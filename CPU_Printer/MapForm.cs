using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CPU_Printer
{
    public partial class MapForm : Form
    {
        #region VARIABLES
        OpenFileDialog openFileDialog;                                // Окно для открытия файла
        SaveFileDialog saveFileDialog;                                // Окно для сохранения файла
        ColorDialog colorDialog;                                      // Окно для выбора цвета

        VectorPicture vectorPicture;                                  // Класс для работы с векторными файлами
        CPUGen cpuGen;                                                // Класс для работы с принтером

        Color colorLine = Color.Green;                                // Цвет рисунка
        const int maxPoints = 100;                                    // Максимальное количество точек
        private int[] x1,x2,y1,y2;                                    // Массив точек
        private int counter = 0;                                      // Счетчик точек

        private Graphics graph;                                       // Первичный буфер
        private MainForm mainForm;                                    // Форма с портом
        Bitmap bm;                                                    // Картинка для рисования
        Graphics g;                                                   // Вторичный буфер
        private float xCoeff, yCoeff;                                 // Коеффициент масштаба
        private int xMax, yMax;                                       // Границы принтера
        private int xDraw, yDraw;                                     // Позиция мыши в поле для рисования
        private int xPos = 0, yPos = 0;                               // Текущая позиция каретки
        private int xSelect = 0, ySelect = 0;                         // Выбранная позиция каретки

        private int a = 0;                                            // Счетчик для скрипта

        bool selectPos = false;                                       // Проверка зажатой клавиши мыши
        bool editMode = false;

        int countGridLines = 2;                                       // Количесво линий в сетке
        int minCountGridLines = 2;                                    // Минимальное количество линий в сетке
        int maxCountGridLines = 50;                                   // Максимальное количество линий в сетке

        int timerState = 0;
        #endregion

        #region FORM METHODS
        public MapForm(MainForm mainForm)
        {
            vectorPicture = new VectorPicture();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();
            openFileDialog.Filter = "Векторный рисунок|*.svg;*.cpi";
            saveFileDialog.Filter = "Векторный рисунок|*.cpi";
            x1 = new int[maxPoints];
            y1 = new int[maxPoints];
            x2 = new int[maxPoints];
            y2 = new int[maxPoints];
            this.mainForm = mainForm;
            InitializeComponent();
            CheckPorts();
            graph = pDraw.CreateGraphics();
            cpuGen = new CPUGen();
            CalculateCoefficients();

            // СОЗДАЕМ БУФЕР ДЛЯ РИСОВАНИЯ
            bm = new Bitmap(pDraw.Width, pDraw.Height, graph);
            g = Graphics.FromImage(bm);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void MapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.CheckActivePort();
            mainForm.Show();
        }

        private void pDraw_MouseMove(object sender, MouseEventArgs e)
        {
            xDraw = Convert.ToInt16(e.X * xCoeff);
            yDraw = Convert.ToInt16(e.Y * yCoeff);
            if (selectPos && e.Button == MouseButtons.Left)
            {
                CalcSelectPosition();
                if (xSelect < 0)
                    xSelect = 0;
                if (ySelect < 0)
                    ySelect = 0;
                if (xSelect > xMax)
                    xSelect = xMax;
                if (ySelect > yMax)
                    ySelect = yMax;

                DrawInPanel();
                lblXY.Text = "X = " + Convert.ToString(xSelect) + " Y = " + Convert.ToString(ySelect);
            }
        }

        private void pDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                selectPos = false;
        }

        private void pDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CalcSelectPosition();
                DrawInPanel();
                selectPos = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (chkBDraw.Checked)
            {
                lbxScripts.Items.Add(GetWay());
                counter++;

            }
            xPos = xSelect;
            yPos = ySelect;

            DrawInPanel();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void chkBDraw_CheckedChanged(object sender, EventArgs e)
        {
            DrawInPanel();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string path = "";
            saveFileDialog.ShowDialog();
            path = saveFileDialog.FileName;

        }

        private void btnStPos_Click(object sender, EventArgs e)
        {
            lbxScripts.Items.Add(cpuGen.GetStartPosCommand());
            xPos = 0;
            yPos = 0;
            if (chkBDraw.Checked)
                counter++;
            DrawInPanel();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorLine = colorDialog.Color;
            DrawInPanel();
        }

        private void btnStartPos_Click(object sender, EventArgs e)
        {
            if (mainForm.CheckExecute())
            {
                mainForm.serialPort.Write(cpuGen.GetStartPosCommand());
                mainForm.ExecutedAction();
                xPos = 0;
                yPos = 0;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (mainForm.serialPort.IsOpen && mainForm.CheckExecute())
            {
                mainForm.serialPort.Write(GetWay());
                mainForm.ExecutedAction();
                xPos = xSelect;
                yPos = ySelect;
                DrawInPanel();
            }
        }

        private void ckbGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGrid.Checked)
            {
                btnIncGrid.Enabled = true;
                btnRedGrid.Enabled = true;
            }
            else
            {
                btnIncGrid.Enabled = false;
                btnRedGrid.Enabled = false;
            }
            DrawInPanel();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (mainForm.serialPort.IsOpen)
            {
                a = 0;
                timerState = 0;
                timer1.Start();
                lblinfo.Text = "Processing execution!";
            }
        }

        private void btnIncGrid_Click(object sender, EventArgs e)
        {
            if (countGridLines >= maxCountGridLines)
                return;
            int countG = countGridLines+1;
            while (pDraw.Width%countG != 0 || countG%2 != 0)
            {
                countG++;
            }
            countGridLines = countG;
            DrawInPanel();
        }

        private void btnRedGrid_Click(object sender, EventArgs e)
        {
            if (countGridLines <= minCountGridLines)
                return;
            int countG = countGridLines-1;
            while (pDraw.Width % countG != 0 || countG % 2 != 0)
            {
                countG--;
            }
            countGridLines = countG;
            DrawInPanel();
        }

        private void ckbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEdit.Checked)
                editMode = true;
            else
                editMode = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (mainForm.serialPort.IsOpen)
            {
                mainForm.serialPort.Write(cpuGen.GetStopCommand());
                timer1.Stop();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (mainForm.serialPort.IsOpen)
            {
                mainForm.serialPort.Write(cpuGen.GetTest1Command() + Convert.ToString(txtTest.Text));
            }
        }

        private void btnCalib_Click(object sender, EventArgs e)
        {
            a = 0;
            timerState = 1;
            timer1.Start();
            lblinfo.Text = "Processing execution!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (timerState)
            {
                case 0:
                    ExecuteScript();
                    break;
                case 1:
                    CalibrationAxes();
                    break;
            }

        }

        private void CalibrationAxes()
        {
            if (a > 1)
            {
                if (mainForm.CheckExecute())
                {
                    lblinfo.Text = "Script executed!";
                    timer1.Stop();
                }
            }
            else
            {
                if (mainForm.CheckExecute())
                {
                    if (a == 0)
                        mainForm.serialPort.Write(cpuGen.GetCalibYCommand());
                    else
                    {
                        mainForm.serialPort.Write(cpuGen.GetCalibXCommand());
                    }
                    mainForm.ExecutedAction();
                    a++;
                }
            }
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            if (mainForm.serialPort.IsOpen)
            {
                mainForm.serialPort.Write(cpuGen.GetTest2Command() + Convert.ToString(txtTest.Text));
            }
        }

        private void ExecuteScript()
        {
            if (a > lbxScripts.Items.Count - 1)
            {
                if (mainForm.CheckExecute())
                {
                    lblinfo.Text = "Script executed!";
                    timer1.Stop();
                }
            }
            else
            {
                if (mainForm.CheckExecute())
                {
                    mainForm.serialPort.Write(lbxScripts.Items[a].ToString());
                    mainForm.ExecutedAction();
                    a++;
                }
            }
        }

        private void btnClearLbx_Click(object sender, EventArgs e)
        {
            lbxScripts.Items.Clear();
            xPos = 0;
            yPos = 0;
            counter = 0;
            x1 = new int[maxPoints];
            y1 = new int[maxPoints];
            x2 = new int[maxPoints];
            y2 = new int[maxPoints];
            DrawInPanel();
        }
        #endregion

        #region PRIVATE METHODS
        private void CheckPorts()
        {
            if (mainForm.serialPort.IsOpen)
            {
                btnGo.Enabled = true;
                btnStartPos.Enabled = true;
                btnStop.Enabled = true;
                btnExecute.Enabled = true;
            }
            else
            {
                btnGo.Enabled = false;
                btnStartPos.Enabled = false;
                btnStop.Enabled = false;
                btnExecute.Enabled = false;
            }
        }

        private void CalculateCoefficients()
        {
            xCoeff = Convert.ToSingle(txtXMax.Text) / pDraw.Width;
            yCoeff = Convert.ToSingle(txtYMax.Text) / pDraw.Height;
            xMax = Convert.ToInt16(txtXMax.Text);
            yMax = Convert.ToInt16(txtYMax.Text);
        }

        private void DrawInPanel()
        {

            int xFixedSelected = Convert.ToInt16(xSelect / xCoeff);
            int yFixedSelected = Convert.ToInt16(ySelect / yCoeff);
            int xFixedPos = Convert.ToInt16(xPos / xCoeff);
            int yFixedPos = Convert.ToInt16(yPos / yCoeff);

            x1[counter] = xFixedPos;
            y1[counter] = yFixedPos;
            x2[counter] = xFixedSelected;
            y2[counter] = yFixedSelected;


            // КРАСИМ ВСЕ В БЕЛЫЙ ЦВЕТ
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pDraw.Width, pDraw.Height);

            // РИСУЕМ СЕТКУ, ЕСЛИ НУЖНО
            if (ckbGrid.Checked)
            {
                Color gridColor;
                for (int i = 0; i < countGridLines; ++i)
                {
                    gridColor = Color.LightGray;
                    if (i == countGridLines / 2)
                        gridColor = Color.DarkGray;
                    int curx = pDraw.Width / countGridLines * i;
                    int cury = pDraw.Height / countGridLines * i;
                    g.DrawLine(new Pen(gridColor), curx, 0, curx, pDraw.Height);
                    g.DrawLine(new Pen(gridColor), 0, cury, pDraw.Width, cury);
                }
            }

            int j = counter;
            if (chkBDraw.Checked)
                j++;

            // ЛИНИИ РИСУНКА
            for (int i = 0; i < j; ++i)
            {
                g.DrawLine(new Pen(colorLine), x1[i], y1[i], x2[i], y2[i]);
            }
            // ВЫЬРАННАЯ ТОЧКА
            g.DrawLine(new Pen(Color.Blue), xFixedSelected, yFixedSelected, xFixedSelected + 5, yFixedSelected);
            g.DrawLine(new Pen(Color.Blue), xFixedSelected, yFixedSelected, xFixedSelected - 5, yFixedSelected);
            g.DrawLine(new Pen(Color.Blue), xFixedSelected, yFixedSelected, xFixedSelected, yFixedSelected + 5);
            g.DrawLine(new Pen(Color.Blue), xFixedSelected, yFixedSelected, xFixedSelected, yFixedSelected - 5);

            // ТОЧКА, ГДЕ НАХОДИТСЯ КАРЕТКА
            g.DrawLine(new Pen(Color.Red), xFixedPos, yFixedPos, xFixedPos + 5, yFixedPos);
            g.DrawLine(new Pen(Color.Red), xFixedPos, yFixedPos, xFixedPos - 5, yFixedPos);
            g.DrawLine(new Pen(Color.Red), xFixedPos, yFixedPos, xFixedPos, yFixedPos + 5);
            g.DrawLine(new Pen(Color.Red), xFixedPos, yFixedPos, xFixedPos, yFixedPos - 5);

            // ПЕРЕНОСИМ ВСЕ НА ЭКРАН
            graph.DrawImageUnscaled(bm, 0, 0);
        }
      
        private string GetWay()
        {
            int xMove = Convert.ToInt16(Math.Abs(xPos - xSelect));
            int yMove = Convert.ToInt16(Math.Abs(yPos - ySelect));
            bool xL, yL;

            if (xSelect >= xPos)
                xL = false;
            else
                xL = true;
            if (ySelect >= yPos)
                yL = false;
            else
                yL = true;

            return cpuGen.GetMoveCommand(xMove, xL, yMove, yL);
        }

        private void LoadFile()
        {
            string path = "";
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            if (path == "")
                return;
            vectorPicture.LoadPicture(path);
            lbxScripts.Items.Clear();
            lbxScripts.Items.Add(cpuGen.GetStartPosCommand());
            counter = 0;
            x1 = new int[vectorPicture.Counter+1];
            y1 = new int[vectorPicture.Counter + 1];
            x2 = new int[vectorPicture.Counter + 1];
            y2 = new int[vectorPicture.Counter + 1];
            float xC = pDraw.Width / vectorPicture.OriginX;
            float yC = pDraw.Height / vectorPicture.OriginY;
            xPos = 0;
            yPos = 0;
            for (int i = 0; i < vectorPicture.Counter; ++i)
            {
                x1[i] = Convert.ToInt16(vectorPicture.GetX1(i) * xC);
                y1[i] = Convert.ToInt16(vectorPicture.GetY1(i) * yC);
                x2[i] = Convert.ToInt16(vectorPicture.GetX2(i) * xC);
                y2[i] = Convert.ToInt16(vectorPicture.GetY2(i) * yC);

                int x11 = Convert.ToInt16(x1[i] * xCoeff);
                int y11 = Convert.ToInt16(y1[i] * yCoeff);
                int x22 = Convert.ToInt16(x2[i] * xCoeff);
                int y22 = Convert.ToInt16(y2[i] * yCoeff);

                xSelect = x11;
                ySelect = y11;
                if ((xSelect - xPos) != 0 || (ySelect - yPos) != 0)
                    lbxScripts.Items.Add(GetWay());
                xPos = xSelect;
                yPos = ySelect;
                xSelect = x22;
                ySelect = y22;
                if ((xSelect - xPos) != 0 || (ySelect - yPos) != 0)
                    lbxScripts.Items.Add(GetWay());
                xPos = xSelect;
                yPos = ySelect;
                counter++;
            }
            DrawInPanel();
            lblinfo.Text = "File Loaded!";
        }

        private void CalcSelectPosition()
        {
            if (ckbGrid.Checked)
            {
                int LenghtLinesX = Convert.ToInt16(pDraw.Width / countGridLines * xCoeff);
                int LenghtLinesY = Convert.ToInt16(pDraw.Height / countGridLines * yCoeff);
                float xR = (float)xDraw / LenghtLinesX - xDraw / LenghtLinesX;
                float yR = (float)yDraw / LenghtLinesY - yDraw / LenghtLinesY;
                if (xR >= 0.5f)
                    xSelect = LenghtLinesX * ((xDraw / LenghtLinesX) + 1);
                else
                    xSelect = LenghtLinesX * (xDraw / LenghtLinesX);
                if (yR >= 0.5f)
                    ySelect = LenghtLinesY * ((yDraw / LenghtLinesY) + 1);
                else
                    ySelect = LenghtLinesY * (yDraw / LenghtLinesY);
            }
            else
            {
                xSelect = xDraw;
                ySelect = yDraw;
            }
        }

        #endregion
    }
}
