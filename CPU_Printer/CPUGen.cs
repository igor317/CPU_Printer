using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Printer
{

    class CPUGen
    {
        static public string startSymbol = "#";
        static public string endSymbol = "$";
        #region PRIVATE METHODS

        string ConvertNumber(int number)
        {
            string numb = "";
            if (number < 10)
                numb = "000" + Convert.ToString(number);
            if (number < 100 && number >= 10)
                numb = "00" + Convert.ToString(number);
            if (number < 1000 && number >= 100)
                numb = "0" + Convert.ToString(number);
            if (number >= 1000)
                numb = Convert.ToString(number);
            return numb;
        }

        #endregion

        #region PUBLIC METHODS
        public string GetMoveCommand(int xStep,bool leftX,int yStep,bool leftY)
        {
            string X;
            string Y;

            if (leftX)
                X = "-" + ConvertNumber(xStep);
            else
                X = "+" + ConvertNumber(xStep);
            if (leftY)
                Y = "-" + ConvertNumber(yStep);
            else
                Y = "+" + ConvertNumber(yStep);
            return startSymbol + "mv" + X + Y + endSymbol;
        }

        public string GetStartPosCommand()
        {
            return startSymbol + "stpos" + endSymbol;
        }

        public string GetStopCommand()
        {
            return startSymbol + "stop" + endSymbol;
        }
        public string GetCalibYCommand()
        {
            return startSymbol + "caliby" + endSymbol;
        }
        public string GetCalibXCommand()
        {
            return startSymbol + "calibx" + endSymbol;
        }

        public string GetTest1Command()
        {
            return startSymbol + "test1" + endSymbol;
        }
        public string GetTest2Command()
        {
            return startSymbol + "elp+0500+050001000100" + endSymbol;
        }
        public string GetTest3Command()
        {
            return startSymbol + "test3" + endSymbol;
        }
        public string GetPenUpCommand()
        {
            return startSymbol + "penup" + endSymbol;
        }
        public string GetPenDownCommand()
        {
            return startSymbol + "pendown" + endSymbol;
        }
        #endregion
    }
}