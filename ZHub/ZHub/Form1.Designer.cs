﻿namespace ZHub
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewTemplate = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewTemplate
            // 
            resources.ApplyResources(this.NewTemplate, "NewTemplate");
            this.NewTemplate.BackColor = System.Drawing.Color.White;
            this.NewTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTemplate.ForeColor = System.Drawing.Color.Black;
            this.NewTemplate.Name = "NewTemplate";
            this.NewTemplate.UseVisualStyleBackColor = false;
            this.NewTemplate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Close, "Close");
            this.Close.Name = "Close";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(252)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.Close);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewTemplate);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTemplate;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
    }
}
