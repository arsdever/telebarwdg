﻿
using TeleBarWdg;

namespace test
{
    partial class DummyPage
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
            this.telegramTaskbarWidget1 = new TeleBarWdg.TelegramTaskbarWidget();
            this.loginManager1 = new TeleBarWdg.LoginManager();
            this.SuspendLayout();
            // 
            // telegramTaskbarWidget1
            // 
            this.telegramTaskbarWidget1.Location = new System.Drawing.Point(168, 12);
            this.telegramTaskbarWidget1.Name = "telegramTaskbarWidget1";
            this.telegramTaskbarWidget1.Size = new System.Drawing.Size(100, 100);
            this.telegramTaskbarWidget1.TabIndex = 1;
            // 
            // loginManager1
            // 
            this.loginManager1.AutoSize = true;
            this.loginManager1.Location = new System.Drawing.Point(12, 12);
            this.loginManager1.Name = "loginManager1";
            this.loginManager1.Size = new System.Drawing.Size(150, 81);
            this.loginManager1.TabIndex = 0;
            // 
            // DummyPage
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(351, 236);
            this.Controls.Add(this.telegramTaskbarWidget1);
            this.Controls.Add(this.loginManager1);
            this.Name = "DummyPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginManager loginManager1;
        private TelegramTaskbarWidget telegramTaskbarWidget1;
    }
}

