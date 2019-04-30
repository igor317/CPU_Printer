using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace CPU_Printer
{
    public partial class MainForm : Form
    {
        #region VARIABLES
        public SerialPort serialPort;           // Класс для работы с портом
        private bool readyToExecute = true;     // Готовность выполнить действие
        public string textaccepter = "";       // Массив для данных с порта
        #endregion

        #region FORM METHODS
        public MainForm()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
            InitializeComponent();
            CheckActivePort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PortMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortsForm portsForm = new PortsForm(this);
            Enabled = false;
            portsForm.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool CheckActivePort()
        {
            if (serialPort.IsOpen)
            {
                lblCurPort.Text = "Порт: " + serialPort.PortName;
                btnSend.Enabled = true;
                txtText.Enabled = true;
                ClosePortToolStripMenuItem.Enabled = true;
            }
            else
            {
                lblCurPort.Text = "Порт закрыт!";
                btnSend.Enabled = false;
                txtText.Enabled = false;
                ClosePortToolStripMenuItem.Enabled = false;
                return false;
            }
            //lbxAccepter.Items.Clear();
            return true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (CheckActivePort())
            {
                string txt = CPUGen.startSymbol + txtText.Text + CPUGen.endSymbol;
                serialPort.Write(txt);
                txtText.Text = "";
            }
        }

        private void ClosePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
            CheckActivePort();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(this);
            Enabled = false;
            mapForm.Show();
        }
        #endregion

        #region PRIVATE METHODS
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort obj = (SerialPort)sender;
            string test = obj.ReadExisting();
            textaccepter += test;
            if (textaccepter.Substring(textaccepter.Length - 1, 1) == CPUGen.endSymbol)
            {
                string temp = textaccepter.Substring(1, textaccepter.Length - 2);
                if (lbxAccepter.Items.Count > 6)
                    lbxAccepter.Invoke(new Action(() => lbxAccepter.Items.Clear()));
                lbxAccepter.Invoke(new Action(() => lbxAccepter.Items.Add(temp)));
                textaccepter = "";
                obj.DiscardInBuffer();
                readyToExecute = true;
            }
        }
      
        public void ExecutedAction()
        {
            readyToExecute = false;
        }

        public bool CheckExecute()
        {
            return readyToExecute;
        }
        #endregion
    }
}
