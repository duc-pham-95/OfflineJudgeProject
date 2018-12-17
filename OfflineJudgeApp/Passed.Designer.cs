namespace OfflineJudgeApp
{
    partial class Passed
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
            this.grbxInfo = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnAllOut = new System.Windows.Forms.Button();
            this.grbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxInfo
            // 
            this.grbxInfo.Controls.Add(this.lbResult);
            this.grbxInfo.Location = new System.Drawing.Point(12, 12);
            this.grbxInfo.Name = "grbxInfo";
            this.grbxInfo.Size = new System.Drawing.Size(334, 78);
            this.grbxInfo.TabIndex = 1;
            this.grbxInfo.TabStop = false;
            this.grbxInfo.Text = "Information";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(109, 34);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(124, 17);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Passed all the test";
            // 
            // btnAllOut
            // 
            this.btnAllOut.Location = new System.Drawing.Point(12, 96);
            this.btnAllOut.Name = "btnAllOut";
            this.btnAllOut.Size = new System.Drawing.Size(334, 43);
            this.btnAllOut.TabIndex = 3;
            this.btnAllOut.Text = ">>  See All Your Output Here  <<";
            this.btnAllOut.UseVisualStyleBackColor = true;
            this.btnAllOut.Click += new System.EventHandler(this.btnAllOut_Click);
            // 
            // Passed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 148);
            this.Controls.Add(this.btnAllOut);
            this.Controls.Add(this.grbxInfo);
            this.Name = "Passed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passed";
            this.grbxInfo.ResumeLayout(false);
            this.grbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxInfo;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnAllOut;
    }
}