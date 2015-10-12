namespace DualCount
{
    partial class FrmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCountA = new System.Windows.Forms.TextBox();
            this.txtCountB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCountA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUseLock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result A + B";
            // 
            // txtCountA
            // 
            this.txtCountA.Location = new System.Drawing.Point(81, 33);
            this.txtCountA.Name = "txtCountA";
            this.txtCountA.Size = new System.Drawing.Size(93, 20);
            this.txtCountA.TabIndex = 1;
            // 
            // txtCountB
            // 
            this.txtCountB.Location = new System.Drawing.Point(81, 77);
            this.txtCountB.Name = "txtCountB";
            this.txtCountB.Size = new System.Drawing.Size(93, 20);
            this.txtCountB.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.Location = new System.Drawing.Point(81, 169);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(93, 20);
            this.txtResult.TabIndex = 6;
            // 
            // lblCountA
            // 
            this.lblCountA.AutoSize = true;
            this.lblCountA.Location = new System.Drawing.Point(16, 40);
            this.lblCountA.Name = "lblCountA";
            this.lblCountA.Size = new System.Drawing.Size(45, 13);
            this.lblCountA.TabIndex = 0;
            this.lblCountA.Text = "Count A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count B";
            // 
            // chkUseLock
            // 
            this.chkUseLock.AutoSize = true;
            this.chkUseLock.Location = new System.Drawing.Point(199, 56);
            this.chkUseLock.Name = "chkUseLock";
            this.chkUseLock.Size = new System.Drawing.Size(68, 17);
            this.chkUseLock.TabIndex = 7;
            this.chkUseLock.Text = "Use lock";
            this.chkUseLock.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 221);
            this.Controls.Add(this.chkUseLock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountA);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCountB);
            this.Controls.Add(this.txtCountA);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Dual Thread Count";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCountA;
        private System.Windows.Forms.TextBox txtCountB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCountA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUseLock;
    }
}

