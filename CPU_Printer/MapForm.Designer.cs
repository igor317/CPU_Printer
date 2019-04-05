namespace CPU_Printer
{
    partial class MapForm
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
            this.components = new System.ComponentModel.Container();
            this.lblXY = new System.Windows.Forms.Label();
            this.pDraw = new System.Windows.Forms.Panel();
            this.btnStartPos = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.lblXMax = new System.Windows.Forms.Label();
            this.lblYMax = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbxScripts = new System.Windows.Forms.ListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStPos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearLbx = new System.Windows.Forms.Button();
            this.chkBDraw = new System.Windows.Forms.CheckBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbGrid = new System.Windows.Forms.CheckBox();
            this.btnIncGrid = new System.Windows.Forms.Button();
            this.btnRedGrid = new System.Windows.Forms.Button();
            this.ckbEdit = new System.Windows.Forms.CheckBox();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnCalib = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(28, 316);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(60, 13);
            this.lblXY.TabIndex = 0;
            this.lblXY.Text = "X = 0 Y = 0";
            // 
            // pDraw
            // 
            this.pDraw.BackColor = System.Drawing.Color.White;
            this.pDraw.Location = new System.Drawing.Point(12, 13);
            this.pDraw.Name = "pDraw";
            this.pDraw.Size = new System.Drawing.Size(300, 300);
            this.pDraw.TabIndex = 1;
            this.pDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pDraw_MouseDown);
            this.pDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pDraw_MouseMove);
            this.pDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pDraw_MouseUp);
            // 
            // btnStartPos
            // 
            this.btnStartPos.Location = new System.Drawing.Point(93, 395);
            this.btnStartPos.Name = "btnStartPos";
            this.btnStartPos.Size = new System.Drawing.Size(75, 23);
            this.btnStartPos.TabIndex = 2;
            this.btnStartPos.Text = "OnStartPos";
            this.btnStartPos.UseVisualStyleBackColor = true;
            this.btnStartPos.Click += new System.EventHandler(this.btnStartPos_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 395);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(394, 368);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(69, 20);
            this.txtXMax.TabIndex = 9;
            this.txtXMax.Text = "2000";
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(394, 398);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(69, 20);
            this.txtYMax.TabIndex = 10;
            this.txtYMax.Text = "2000";
            // 
            // lblXMax
            // 
            this.lblXMax.AutoSize = true;
            this.lblXMax.Location = new System.Drawing.Point(353, 375);
            this.lblXMax.Name = "lblXMax";
            this.lblXMax.Size = new System.Drawing.Size(36, 13);
            this.lblXMax.TabIndex = 11;
            this.lblXMax.Text = "X max";
            // 
            // lblYMax
            // 
            this.lblYMax.AutoSize = true;
            this.lblYMax.Location = new System.Drawing.Point(353, 401);
            this.lblYMax.Name = "lblYMax";
            this.lblYMax.Size = new System.Drawing.Size(36, 13);
            this.lblYMax.TabIndex = 12;
            this.lblYMax.Text = "Y max";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblinfo.Location = new System.Drawing.Point(346, 254);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(137, 29);
            this.lblinfo.TabIndex = 13;
            this.lblinfo.Text = "ScriptState";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 395);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbxScripts
            // 
            this.lbxScripts.FormattingEnabled = true;
            this.lbxScripts.Location = new System.Drawing.Point(331, 43);
            this.lbxScripts.Name = "lbxScripts";
            this.lbxScripts.Size = new System.Drawing.Size(213, 95);
            this.lbxScripts.TabIndex = 15;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(331, 202);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(213, 23);
            this.btnExecute.TabIndex = 16;
            this.btnExecute.Text = "Execute Script";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add To list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStPos
            // 
            this.btnStPos.Location = new System.Drawing.Point(331, 173);
            this.btnStPos.Name = "btnStPos";
            this.btnStPos.Size = new System.Drawing.Size(213, 23);
            this.btnStPos.TabIndex = 18;
            this.btnStPos.Text = "OnStartPos";
            this.btnStPos.UseVisualStyleBackColor = true;
            this.btnStPos.Click += new System.EventHandler(this.btnStPos_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearLbx
            // 
            this.btnClearLbx.Location = new System.Drawing.Point(331, 14);
            this.btnClearLbx.Name = "btnClearLbx";
            this.btnClearLbx.Size = new System.Drawing.Size(120, 23);
            this.btnClearLbx.TabIndex = 19;
            this.btnClearLbx.Text = "Clear";
            this.btnClearLbx.UseVisualStyleBackColor = true;
            this.btnClearLbx.Click += new System.EventHandler(this.btnClearLbx_Click);
            // 
            // chkBDraw
            // 
            this.chkBDraw.AutoSize = true;
            this.chkBDraw.Location = new System.Drawing.Point(487, 18);
            this.chkBDraw.Name = "chkBDraw";
            this.chkBDraw.Size = new System.Drawing.Size(57, 17);
            this.chkBDraw.TabIndex = 21;
            this.chkBDraw.Text = "Draw?";
            this.chkBDraw.UseVisualStyleBackColor = true;
            this.chkBDraw.CheckedChanged += new System.EventHandler(this.chkBDraw_CheckedChanged);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(469, 401);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 22;
            this.btnLoadFile.Text = "LoadFile";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(469, 369);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 25;
            this.btnSaveFile.Text = "SaveFile";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // ckbGrid
            // 
            this.ckbGrid.AutoSize = true;
            this.ckbGrid.Location = new System.Drawing.Point(191, 319);
            this.ckbGrid.Name = "ckbGrid";
            this.ckbGrid.Size = new System.Drawing.Size(45, 17);
            this.ckbGrid.TabIndex = 27;
            this.ckbGrid.Text = "Grid";
            this.ckbGrid.UseVisualStyleBackColor = true;
            this.ckbGrid.CheckedChanged += new System.EventHandler(this.ckbGrid_CheckedChanged);
            // 
            // btnIncGrid
            // 
            this.btnIncGrid.Enabled = false;
            this.btnIncGrid.Location = new System.Drawing.Point(281, 318);
            this.btnIncGrid.Name = "btnIncGrid";
            this.btnIncGrid.Size = new System.Drawing.Size(33, 23);
            this.btnIncGrid.TabIndex = 29;
            this.btnIncGrid.Text = "→";
            this.btnIncGrid.UseVisualStyleBackColor = true;
            this.btnIncGrid.Click += new System.EventHandler(this.btnIncGrid_Click);
            // 
            // btnRedGrid
            // 
            this.btnRedGrid.Enabled = false;
            this.btnRedGrid.Location = new System.Drawing.Point(242, 318);
            this.btnRedGrid.Name = "btnRedGrid";
            this.btnRedGrid.Size = new System.Drawing.Size(33, 23);
            this.btnRedGrid.TabIndex = 30;
            this.btnRedGrid.Text = "←";
            this.btnRedGrid.UseVisualStyleBackColor = true;
            this.btnRedGrid.Click += new System.EventHandler(this.btnRedGrid_Click);
            // 
            // ckbEdit
            // 
            this.ckbEdit.AutoSize = true;
            this.ckbEdit.Location = new System.Drawing.Point(487, 231);
            this.ckbEdit.Name = "ckbEdit";
            this.ckbEdit.Size = new System.Drawing.Size(44, 17);
            this.ckbEdit.TabIndex = 31;
            this.ckbEdit.Text = "Edit";
            this.ckbEdit.UseVisualStyleBackColor = true;
            this.ckbEdit.CheckedChanged += new System.EventHandler(this.ckbEdit_CheckedChanged);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(13, 347);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 32;
            this.btnTest1.Text = "test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(255, 394);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(69, 20);
            this.txtTest.TabIndex = 33;
            this.txtTest.Text = "0";
            // 
            // btnCalib
            // 
            this.btnCalib.Location = new System.Drawing.Point(394, 339);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(75, 23);
            this.btnCalib.TabIndex = 34;
            this.btnCalib.Text = "Calibration";
            this.btnCalib.UseVisualStyleBackColor = true;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(94, 347);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 35;
            this.btnTest2.Text = "test2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(175, 347);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(75, 23);
            this.btnTest3.TabIndex = 36;
            this.btnTest3.Text = "test3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 436);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnCalib);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.ckbEdit);
            this.Controls.Add(this.btnRedGrid);
            this.Controls.Add(this.btnIncGrid);
            this.Controls.Add(this.ckbGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.chkBDraw);
            this.Controls.Add(this.btnClearLbx);
            this.Controls.Add(this.btnStPos);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lbxScripts);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblYMax);
            this.Controls.Add(this.lblXMax);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnStartPos);
            this.Controls.Add(this.pDraw);
            this.Controls.Add(this.lblXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapForm";
            this.Text = "MapForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Panel pDraw;
        private System.Windows.Forms.Button btnStartPos;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.Label lblXMax;
        private System.Windows.Forms.Label lblYMax;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbxScripts;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStPos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearLbx;
        private System.Windows.Forms.CheckBox chkBDraw;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbGrid;
        private System.Windows.Forms.Button btnIncGrid;
        private System.Windows.Forms.Button btnRedGrid;
        private System.Windows.Forms.CheckBox ckbEdit;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnCalib;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
    }
}