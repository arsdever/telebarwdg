
namespace TeleBarWdg.MainPanel
{
    partial class CodeConfirmPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainControl = new System.Windows.Forms.Panel();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codePanel = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.MaskedTextBox();
            this.verifyCode = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.mainControl.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.codeLabel);
            this.mainControl.Controls.Add(this.codePanel);
            this.mainControl.Controls.Add(this.verifyCode);
            this.mainControl.Controls.Add(this.errorMsg);
            this.mainControl.Location = new System.Drawing.Point(0, 100);
            this.mainControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(300, 314);
            this.mainControl.TabIndex = 7;
            // 
            // codeLabel
            // 
            this.codeLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.White;
            this.codeLabel.Location = new System.Drawing.Point(60, 30);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(180, 40);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Text = "Confirmation code";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codePanel
            // 
            this.codePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(153)))));
            this.codePanel.Controls.Add(this.code);
            this.codePanel.Location = new System.Drawing.Point(50, 73);
            this.codePanel.Name = "codePanel";
            this.codePanel.Padding = new System.Windows.Forms.Padding(10);
            this.codePanel.Size = new System.Drawing.Size(200, 43);
            this.codePanel.TabIndex = 3;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(153)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.Font = new System.Drawing.Font("Calibri", 14F);
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code.Location = new System.Drawing.Point(10, 10);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(180, 23);
            this.code.TabIndex = 0;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyCode
            // 
            this.verifyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(140)))));
            this.verifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyCode.Font = new System.Drawing.Font("Calibri", 12F);
            this.verifyCode.ForeColor = System.Drawing.Color.White;
            this.verifyCode.Location = new System.Drawing.Point(80, 130);
            this.verifyCode.Name = "verifyCode";
            this.verifyCode.Size = new System.Drawing.Size(140, 30);
            this.verifyCode.TabIndex = 1;
            this.verifyCode.Text = "Verify";
            this.verifyCode.UseVisualStyleBackColor = false;
            this.verifyCode.Click += new System.EventHandler(this.verifyCode_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(121)))), ((int)(((byte)(136)))));
            this.errorMsg.Location = new System.Drawing.Point(20, 180);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(260, 100);
            this.errorMsg.TabIndex = 2;
            this.errorMsg.Text = "Error message";
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorMsg.Visible = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.loadingAnimation);
            this.loadingPanel.Location = new System.Drawing.Point(100, 175);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(100, 100);
            this.loadingPanel.TabIndex = 6;
            this.loadingPanel.Visible = false;
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.loadingAnimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingAnimation.Location = new System.Drawing.Point(0, 0);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(100, 100);
            this.loadingAnimation.TabIndex = 4;
            this.loadingAnimation.TabStop = false;
            // 
            // CodeConfirmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.mainControl);
            this.Name = "CodeConfirmPage";
            this.Size = new System.Drawing.Size(300, 450);
            this.mainControl.ResumeLayout(false);
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainControl;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.MaskedTextBox code;
        private System.Windows.Forms.Button verifyCode;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox loadingAnimation;
    }
}
