
namespace TeleBarWdg.MainPanel
{
    partial class LoginPage
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
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.requestCode = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberPanel = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.mainControl = new System.Windows.Forms.Panel();
            this.phoneNumberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(153)))));
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumber.Font = new System.Drawing.Font("Calibri", 14F);
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phoneNumber.Location = new System.Drawing.Point(10, 10);
            this.phoneNumber.Mask = "+000-00-00-00-00";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(180, 23);
            this.phoneNumber.TabIndex = 0;
            this.phoneNumber.Text = "374";
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // requestCode
            // 
            this.requestCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(140)))));
            this.requestCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestCode.Font = new System.Drawing.Font("Calibri", 12F);
            this.requestCode.ForeColor = System.Drawing.Color.White;
            this.requestCode.Location = new System.Drawing.Point(80, 130);
            this.requestCode.Name = "requestCode";
            this.requestCode.Size = new System.Drawing.Size(140, 30);
            this.requestCode.TabIndex = 1;
            this.requestCode.Text = "Request a code";
            this.requestCode.UseVisualStyleBackColor = false;
            this.requestCode.Click += new System.EventHandler(this.requestCode_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.phoneNumberLabel.Location = new System.Drawing.Point(80, 30);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(140, 40);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone number";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberPanel
            // 
            this.phoneNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(153)))));
            this.phoneNumberPanel.Controls.Add(this.phoneNumber);
            this.phoneNumberPanel.Location = new System.Drawing.Point(50, 73);
            this.phoneNumberPanel.Name = "phoneNumberPanel";
            this.phoneNumberPanel.Padding = new System.Windows.Forms.Padding(10);
            this.phoneNumberPanel.Size = new System.Drawing.Size(200, 43);
            this.phoneNumberPanel.TabIndex = 3;
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
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.loadingAnimation);
            this.loadingPanel.Location = new System.Drawing.Point(100, 175);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(100, 100);
            this.loadingPanel.TabIndex = 5;
            this.loadingPanel.Visible = false;
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.phoneNumberLabel);
            this.mainControl.Controls.Add(this.phoneNumberPanel);
            this.mainControl.Controls.Add(this.requestCode);
            this.mainControl.Controls.Add(this.errorMsg);
            this.mainControl.Location = new System.Drawing.Point(0, 100);
            this.mainControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(300, 314);
            this.mainControl.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.mainControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(300, 450);
            this.phoneNumberPanel.ResumeLayout(false);
            this.phoneNumberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.Button requestCode;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Panel phoneNumberPanel;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.PictureBox loadingAnimation;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Panel mainControl;
    }
}
