
using System.Windows.Forms;

namespace TeleBarWdg
{
    partial class TelegramTaskbarWidget
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
            this.taskbarButton1 = new TeleBarWdg.TaskbarButton();
            this.SuspendLayout();
            // 
            // taskbarButton1
            // 
            this.taskbarButton1.BackColorDefault = System.Drawing.Color.Transparent;
            this.taskbarButton1.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.taskbarButton1.BackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskbarButton1.BackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskbarButton1.Icon = global::TeleBarWdg.Properties.Resources.icon;
            this.taskbarButton1.Location = new System.Drawing.Point(0, 0);
            this.taskbarButton1.Margin = new System.Windows.Forms.Padding(0);
            this.taskbarButton1.Name = "taskbarButton1";
            this.taskbarButton1.Size = new System.Drawing.Size(30, 30);
            this.taskbarButton1.TabIndex = 0;
            this.taskbarButton1.Click += new System.EventHandler(this.taskbarButton1_Click);
            // 
            // TelegramTaskbarWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskbarButton1);
            this.Name = "TelegramTaskbarWidget";
            this.Size = new System.Drawing.Size(30, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskbarButton taskbarButton1;
    }
}
