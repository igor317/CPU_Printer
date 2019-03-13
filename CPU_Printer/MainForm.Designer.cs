namespace CPU_Printer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurPort = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbxAccepter = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurPort
            // 
            this.lblCurPort.AutoSize = true;
            this.lblCurPort.Location = new System.Drawing.Point(222, 134);
            this.lblCurPort.Name = "lblCurPort";
            this.lblCurPort.Size = new System.Drawing.Size(35, 13);
            this.lblCurPort.TabIndex = 1;
            this.lblCurPort.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.ClosePortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortMenuToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItem.Text = "Меню";
            // 
            // PortMenuToolStripMenuItem
            // 
            this.PortMenuToolStripMenuItem.Name = "PortMenuToolStripMenuItem";
            this.PortMenuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.PortMenuToolStripMenuItem.Text = "Меню портов";
            this.PortMenuToolStripMenuItem.Click += new System.EventHandler(this.PortMenuToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mapToolStripMenuItem.Text = "Карта";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ClosePortToolStripMenuItem
            // 
            this.ClosePortToolStripMenuItem.Name = "ClosePortToolStripMenuItem";
            this.ClosePortToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ClosePortToolStripMenuItem.Text = "Закрыть порт";
            this.ClosePortToolStripMenuItem.Click += new System.EventHandler(this.ClosePortToolStripMenuItem_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(225, 62);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(221, 27);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 10;
            // 
            // lbxAccepter
            // 
            this.lbxAccepter.FormattingEnabled = true;
            this.lbxAccepter.Location = new System.Drawing.Point(12, 27);
            this.lbxAccepter.Name = "lbxAccepter";
            this.lbxAccepter.Size = new System.Drawing.Size(203, 95);
            this.lbxAccepter.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 162);
            this.Controls.Add(this.lbxAccepter);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCurPort);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ЧПУ Принтер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PortMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ListBox lbxAccepter;
        private System.Windows.Forms.ToolStripMenuItem ClosePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
    }
}

