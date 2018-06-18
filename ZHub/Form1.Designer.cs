namespace ZHub
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
            this.SuspendLayout();
            // 
            // NewTemplate
            // 
            resources.ApplyResources(this.NewTemplate, "NewTemplate");
            this.NewTemplate.BackColor = System.Drawing.Color.Transparent;
            this.NewTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTemplate.ForeColor = System.Drawing.Color.Black;
            this.NewTemplate.Name = "NewTemplate";
            this.NewTemplate.UseVisualStyleBackColor = false;
            this.NewTemplate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Close, "Close");
            this.Close.Name = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NewTemplate);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
<<<<<<< HEAD
=======
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
>>>>>>> cf7ecb0c88b4cad2322816d0ac0442f11912c4f6
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTemplate;
        private System.Windows.Forms.Button Close;
    }
}

