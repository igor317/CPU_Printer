namespace CPU_Printer
{
    partial class PortsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnConnectToPort = new System.Windows.Forms.Button();
            this.btnFindPorts = new System.Windows.Forms.Button();
            this.lbxPorts = new System.Windows.Forms.ListBox();
            this.lblCurPort = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(110, 25);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(55, 13);
            this.lblInfo1.TabIndex = 15;
            this.lblInfo1.Text = "BaudRate";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(171, 22);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(62, 20);
            this.txtBaudRate.TabIndex = 14;
            this.txtBaudRate.Text = "9600";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(12, 126);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(91, 23);
            this.btnClosePort.TabIndex = 13;
            this.btnClosePort.Text = "Отключить";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnConnectToPort
            // 
            this.btnConnectToPort.Location = new System.Drawing.Point(12, 126);
            this.btnConnectToPort.Name = "btnConnectToPort";
            this.btnConnectToPort.Size = new System.Drawing.Size(91, 23);
            this.btnConnectToPort.TabIndex = 12;
            this.btnConnectToPort.Text = "Подключиться";
            this.btnConnectToPort.UseVisualStyleBackColor = true;
            this.btnConnectToPort.Click += new System.EventHandler(this.btnConnectToPort_Click);
            // 
            // btnFindPorts
            // 
            this.btnFindPorts.Location = new System.Drawing.Point(12, 97);
            this.btnFindPorts.Name = "btnFindPorts";
            this.btnFindPorts.Size = new System.Drawing.Size(91, 23);
            this.btnFindPorts.TabIndex = 11;
            this.btnFindPorts.Text = "Найти порты";
            this.btnFindPorts.UseVisualStyleBackColor = true;
            this.btnFindPorts.Click += new System.EventHandler(this.btnFindPorts_Click);
            // 
            // lbxPorts
            // 
            this.lbxPorts.FormattingEnabled = true;
            this.lbxPorts.Location = new System.Drawing.Point(12, 22);
            this.lbxPorts.Name = "lbxPorts";
            this.lbxPorts.Size = new System.Drawing.Size(91, 69);
            this.lbxPorts.TabIndex = 10;
            // 
            // lblCurPort
            // 
            this.lblCurPort.AutoSize = true;
            this.lblCurPort.Location = new System.Drawing.Point(110, 68);
            this.lblCurPort.Name = "lblCurPort";
            this.lblCurPort.Size = new System.Drawing.Size(35, 13);
            this.lblCurPort.TabIndex = 9;
            this.lblCurPort.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 167);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnConnectToPort);
            this.Controls.Add(this.btnFindPorts);
            this.Controls.Add(this.lbxPorts);
            this.Controls.Add(this.lblCurPort);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortsForm";
            this.Text = "Меню портов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnConnectToPort;
        private System.Windows.Forms.Button btnFindPorts;
        private System.Windows.Forms.ListBox lbxPorts;
        private System.Windows.Forms.Label lblCurPort;
        private System.Windows.Forms.Button btnClose;
    }
}