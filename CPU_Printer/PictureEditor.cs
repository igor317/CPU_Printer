using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CPU_Printer
{
    class PictureEditor
    {
        #region VARIABLES
        private int countGridLines = 2;                                       // Количесво линий в сетке
        private int minCountGridLines = 2;                                    // Минимальное количество линий в сетке
        private int maxCountGridLines = 50;                                   // Максимальное количество линий в сетке
        private int sizeX, sizeY;                                         // Размеры холста

        private Graphics graph;                                               // Первичный буфер
        private Graphics gBuff;                                               // Вторичный буфер
        private Bitmap bmp;                                                   // Изображения для буфера
        
        #endregion

        #region SET&GET METHODS
        int CountLines
        {
            get { return countGridLines; }
        }
        int MinGridLines
        {
            set { minCountGridLines = value; }
            get { return minCountGridLines; }
        }
        int MaxGridLines
        {
            set { maxCountGridLines = value; }
            get { return maxCountGridLines; }
        }
        #endregion

        #region PRIVATE METHODS
        #endregion

        #region PUBLIC METHODS
        PictureEditor(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            bmp = new Bitmap(sizeX, sizeY, graph);
            gBuff = Graphics.FromImage(bmp);
            gBuff.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        /// <summary>
        /// Увеличить количество линий сетки
        /// </summary>
        public void IncreaseGridLines()
        {
            if (countGridLines >= maxCountGridLines)
                return;
            int countG = countGridLines + 1;
            while (sizeX % countG != 0 || countG % 2 != 0)
            {
                countG++;
            }
            countGridLines = countG;
        }

        /// <summary>
        /// Уменьшить количество линий сетки
        /// </summary>
        public void ReduceGridLines()
        {
            if (countGridLines <= minCountGridLines)
                return;
            int countG = countGridLines - 1;
            while (sizeX % countG != 0 || countG % 2 != 0)
            {
                countG--;
            }
            countGridLines = countG;
        }

        //public void Draw
        #endregion
    }
}
