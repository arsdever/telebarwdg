using System.Windows.Threading;

namespace TeleBarWdg
{
    partial class TelegramWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelegramWindow));
            this.loginPage = new TeleBarWdg.MainPanel.LoginPage();
            this.SuspendLayout();
            // 
            // loginPage1
            // 
            this.loginPage.BackColor = System.Drawing.Color.Transparent;
            this.loginPage.Location = new System.Drawing.Point(0, 0);
            this.loginPage.Margin = new System.Windows.Forms.Padding(0);
            this.loginPage.Name = "loginPage1";
            this.loginPage.Size = new System.Drawing.Size(300, 450);
            this.loginPage.TabIndex = 0;

            loginPage.OnErrorOccured += msg =>
            {

            };

            var dispatcher = Dispatcher.CurrentDispatcher;
            loginPage.OnCodeRecieved += code =>
            {
                dispatcher.Invoke(() =>
                {
                    this.Controls.Remove(loginPage);
                    this.confirmPage = new TeleBarWdg.MainPanel.CodeConfirmPage();
                    this.confirmPage.Location = new System.Drawing.Point(0, 0);
                    this.confirmPage.Margin = new System.Windows.Forms.Padding(0);
                    this.confirmPage.Name = "loginPage1";
                    this.confirmPage.Size = new System.Drawing.Size(300, 450);
                    this.confirmPage.TabIndex = 0;
                    this.Controls.Add(confirmPage);
                });
            };
            // 
            // TelegramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.loginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelegramWindow";
            this.Text = "TelegramWindow";
            this.MouseEnter += new System.EventHandler(this.TelegramWindow_OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.TelegramWindow_OnMouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private MainPanel.LoginPage loginPage;
        private MainPanel.CodeConfirmPage confirmPage;
    }
}