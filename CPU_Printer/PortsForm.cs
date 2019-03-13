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
    public partial class PortsForm : Form
    {
        #region VARIABLES
        private MainForm mainForm;     // Главная форма
        private string _activePort;    // Активный порт
        private int _baudRate;         // БОДРЕЙТ
        private string[] _allports;    // Массив доступных портов
        #endregion

        #region FormMethods

        public PortsForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            FindPorts();
            CheckOpenPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindPorts_Click(object sender, EventArgs e)
        {
            FindPorts();
        }

        private void btnConnectToPort_Click(object sender, EventArgs e)
        {
            _activePort = lbxPorts.Items[lbxPorts.SelectedIndex].ToString();
            _baudRate = Convert.ToInt16(txtBaudRate.Text);
            InitPort(_baudRate);
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (ClosePort())
            {
                btnClosePort.Visible = false;
                btnConnectToPort.Visible = true;
                btnFindPorts.Enabled = true;
                lbxPorts.Enabled = true;
                txtBaudRate.Enabled = true;
                lblCurPort.Text = "Порт закрыт!";
            }
            else
            {
                lblCurPort.Text = "Ошибка закрытия порта!";
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PortsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.CheckActivePort();
            mainForm.Show();
        }
        #endregion

        #region PortMethods
        public void CheckOpenPort()
        {
            if (mainForm.serialPort.IsOpen)
            {
                lblCurPort.Text = "Открыт порт " + mainForm.serialPort.PortName;
                btnClosePort.Visible = true;
                btnConnectToPort.Visible = false;
                btnFindPorts.Enabled = false;
                lbxPorts.Enabled = false;
                txtBaudRate.Enabled = false;
            }
            else
            {
                lblCurPort.Text = "Порт закрыт";
                btnClosePort.Visible = false;
                btnConnectToPort.Visible = true;
                btnFindPorts.Enabled = true;
                lbxPorts.Enabled = true;
                txtBaudRate.Enabled = true;
            }
        }
        private void InitPort(int baudRate)
        {
            try
            {
                mainForm.serialPort.BaudRate = baudRate;
                mainForm.serialPort.PortName = _activePort;
                mainForm.serialPort.Open();
                CheckOpenPort();
            }
            catch (Exception)
            {
                lblCurPort.Text = "Не удалось открыть порт " + _activePort;
            }
        }

        private void FindPorts()
        {
            lbxPorts.Items.Clear();
            _allports = SerialPort.GetPortNames();
            foreach (string port in _allports)
            {
                lbxPorts.Items.Add(port);
            }
            if (lbxPorts.Items.Count == 0)
            {
                lbxPorts.Text = "Порты не найдены!";
                btnConnectToPort.Enabled = false;
            }
            else
            {
                btnConnectToPort.Enabled = true;
                lbxPorts.SelectedIndex = 0;
            }
        }

        private bool ClosePort()
        {
            if (mainForm.serialPort.IsOpen)
            {
                mainForm.serialPort.Close();
                return true;
            }
            return false;
        }

        #endregion
    }
}
