namespace OfflineJudgeApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtRawSourceCode = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.grbxRunningInfo = new System.Windows.Forms.GroupBox();
            this.lbBeforeRestart = new System.Windows.Forms.Label();
            this.grbxControl = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.lbSource = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbxRunningInfo.SuspendLayout();
            this.grbxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRawSourceCode
            // 
            this.txtRawSourceCode.Location = new System.Drawing.Point(24, 55);
            this.txtRawSourceCode.Name = "txtRawSourceCode";
            this.txtRawSourceCode.Size = new System.Drawing.Size(590, 439);
            this.txtRawSourceCode.TabIndex = 0;
            this.txtRawSourceCode.Text = "";
            this.txtRawSourceCode.WordWrap = false;
            // 
            // btnStart
            // 
            this.btnStart.ImageIndex = 0;
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(22, 509);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Run";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play-6-64.ico");
            this.imageList1.Images.SetKeyName(1, "gear-2-64.ico");
            this.imageList1.Images.SetKeyName(2, "arrow-133-64.ico");
            this.imageList1.Images.SetKeyName(3, "error-3-64.ico");
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(92, 60);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            this.lbMessage.TabIndex = 2;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(92, 34);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 17);
            this.lbState.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result:";
            // 
            // btnSetting
            // 
            this.btnSetting.ImageIndex = 1;
            this.btnSetting.ImageList = this.imageList1;
            this.btnSetting.Location = new System.Drawing.Point(330, 509);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(127, 40);
            this.btnSetting.TabIndex = 13;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // grbxRunningInfo
            // 
            this.grbxRunningInfo.Controls.Add(this.lbBeforeRestart);
            this.grbxRunningInfo.Controls.Add(this.label2);
            this.grbxRunningInfo.Controls.Add(this.lbMessage);
            this.grbxRunningInfo.Controls.Add(this.label3);
            this.grbxRunningInfo.Controls.Add(this.lbState);
            this.grbxRunningInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbxRunningInfo.Location = new System.Drawing.Point(31, 592);
            this.grbxRunningInfo.Name = "grbxRunningInfo";
            this.grbxRunningInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbxRunningInfo.Size = new System.Drawing.Size(638, 143);
            this.grbxRunningInfo.TabIndex = 14;
            this.grbxRunningInfo.TabStop = false;
            this.grbxRunningInfo.Text = "Running Information";
            // 
            // lbBeforeRestart
            // 
            this.lbBeforeRestart.AutoSize = true;
            this.lbBeforeRestart.Location = new System.Drawing.Point(233, 34);
            this.lbBeforeRestart.Name = "lbBeforeRestart";
            this.lbBeforeRestart.Size = new System.Drawing.Size(0, 17);
            this.lbBeforeRestart.TabIndex = 13;
            // 
            // grbxControl
            // 
            this.grbxControl.Controls.Add(this.label1);
            this.grbxControl.Controls.Add(this.cbxLanguage);
            this.grbxControl.Controls.Add(this.btnInstruction);
            this.grbxControl.Controls.Add(this.lbSource);
            this.grbxControl.Controls.Add(this.btnTest);
            this.grbxControl.Controls.Add(this.txtRawSourceCode);
            this.grbxControl.Controls.Add(this.btnStart);
            this.grbxControl.Controls.Add(this.btnSetting);
            this.grbxControl.Location = new System.Drawing.Point(31, 21);
            this.grbxControl.Name = "grbxControl";
            this.grbxControl.Size = new System.Drawing.Size(638, 565);
            this.grbxControl.TabIndex = 15;
            this.grbxControl.TabStop = false;
            this.grbxControl.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Language";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "JAVA",
            "C#"});
            this.cbxLanguage.Location = new System.Drawing.Point(485, 25);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(129, 24);
            this.cbxLanguage.TabIndex = 19;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // btnInstruction
            // 
            this.btnInstruction.ImageIndex = 3;
            this.btnInstruction.ImageList = this.imageList1;
            this.btnInstruction.Location = new System.Drawing.Point(485, 509);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(127, 40);
            this.btnInstruction.TabIndex = 18;
            this.btnInstruction.Text = "Instruction";
            this.btnInstruction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Location = new System.Drawing.Point(21, 35);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(96, 17);
            this.lbSource.TabIndex = 17;
            this.lbSource.Text = "Source code :";
            // 
            // btnTest
            // 
            this.btnTest.ImageIndex = 2;
            this.btnTest.ImageList = this.imageList1;
            this.btnTest.Location = new System.Drawing.Point(176, 509);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(127, 40);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "Test Data";
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(699, 765);
            this.Controls.Add(this.grbxControl);
            this.Controls.Add(this.grbxRunningInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline Judge Test Tool 1.0";
            this.grbxRunningInfo.ResumeLayout(false);
            this.grbxRunningInfo.PerformLayout();
            this.grbxControl.ResumeLayout(false);
            this.grbxControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRawSourceCode;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.GroupBox grbxRunningInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grbxControl;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbBeforeRestart;
    }
}

