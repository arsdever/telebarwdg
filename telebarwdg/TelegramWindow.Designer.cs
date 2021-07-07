
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
            this.loginManager1 = new TeleBarWdg.LoginManager();
            this.SuspendLayout();
            // 
            // loginManager1
            // 
            this.loginManager1.AutoSize = true;
            this.loginManager1.Location = new System.Drawing.Point(83, 180);
            this.loginManager1.Name = "loginManager1";
            this.loginManager1.Size = new System.Drawing.Size(150, 81);
            this.loginManager1.TabIndex = 0;
            // 
            // TelegramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(169)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.loginManager1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelegramWindow";
            this.Text = "TelegramWindow";
            this.MouseEnter += new System.EventHandler(this.TelegramWindow_OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.TelegramWindow_OnMouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginManager loginManager1;
    }
}