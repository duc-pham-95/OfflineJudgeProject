namespace OfflineJudgeApp
{
    partial class TestData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestData));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTestCase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestCase = new System.Windows.Forms.Button();
            this.rbtnNotSp = new System.Windows.Forms.RadioButton();
            this.rbtnSp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(182, 123);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(282, 24);
            this.txtInput.TabIndex = 9;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(28, 126);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(115, 17);
            this.lbInput.TabIndex = 11;
            this.lbInput.Text = "Test Input Folder";
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(470, 123);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(72, 24);
            this.btnInput.TabIndex = 10;
            this.btnInput.Text = "<<";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(182, 166);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(282, 24);
            this.txtOutput.TabIndex = 12;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(28, 169);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(127, 17);
            this.lbOutput.TabIndex = 14;
            this.lbOutput.Text = "Test Output Folder";
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(470, 166);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(72, 24);
            this.btnOutput.TabIndex = 13;
            this.btnOutput.Text = "<<";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTestCase
            // 
            this.txbTestCase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTestCase.Enabled = false;
            this.txbTestCase.Location = new System.Drawing.Point(182, 56);
            this.txbTestCase.Multiline = true;
            this.txbTestCase.Name = "txbTestCase";
            this.txbTestCase.Size = new System.Drawing.Size(282, 24);
            this.txbTestCase.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "TestCases Folder";
            // 
            // btnTestCase
            // 
            this.btnTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCase.Location = new System.Drawing.Point(470, 56);
            this.btnTestCase.Name = "btnTestCase";
            this.btnTestCase.Size = new System.Drawing.Size(72, 24);
            this.btnTestCase.TabIndex = 19;
            this.btnTestCase.Text = "<<";
            this.btnTestCase.UseVisualStyleBackColor = true;
            this.btnTestCase.Click += new System.EventHandler(this.btnTestCase_Click);
            // 
            // rbtnNotSp
            // 
            this.rbtnNotSp.AutoSize = true;
            this.rbtnNotSp.Checked = true;
            this.rbtnNotSp.Location = new System.Drawing.Point(182, 21);
            this.rbtnNotSp.Name = "rbtnNotSp";
            this.rbtnNotSp.Size = new System.Drawing.Size(102, 21);
            this.rbtnNotSp.TabIndex = 21;
            this.rbtnNotSp.TabStop = true;
            this.rbtnNotSp.Text = "Not specific";
            this.rbtnNotSp.UseVisualStyleBackColor = true;
            this.rbtnNotSp.Click += new System.EventHandler(this.rbtnNotSp_Click);
            // 
            // rbtnSp
            // 
            this.rbtnSp.AutoSize = true;
            this.rbtnSp.Location = new System.Drawing.Point(321, 21);
            this.rbtnSp.Name = "rbtnSp";
            this.rbtnSp.Size = new System.Drawing.Size(76, 21);
            this.rbtnSp.TabIndex = 22;
            this.rbtnSp.Text = "specific";
            this.rbtnSp.UseVisualStyleBackColor = true;
            this.rbtnSp.Click += new System.EventHandler(this.rbtnSp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtnNotSp);
            this.groupBox1.Controls.Add(this.txbTestCase);
            this.groupBox1.Controls.Add(this.rbtnSp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTestCase);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Controls.Add(this.lbInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnOutput);
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 218);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Chooser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "(temporarily disable)";
            // 
            // TestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestData";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTestCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestCase;
        private System.Windows.Forms.RadioButton rbtnNotSp;
        private System.Windows.Forms.RadioButton rbtnSp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}