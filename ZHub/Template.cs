using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ZHub
{
    public partial class Template : UserControl
    {
        public Template()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetName(string name)
        {
            textBox1.Text = name;
        }

        private void Template_MouseHover(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void Template_MouseLeave(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void Template_Load(object sender, EventArgs e)
        {

        }

        private void Template_Click(object sender, EventArgs e)
        {
            string Text = File.ReadAllText(@".\" + textBox1.Text+".tmp");
            string[] files = Text.Remove(Text.Length - 1).Split(',');
            foreach(string file in files)
            {
                Process.Start(file);
            }
        }
        int location = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            File.Delete(@".\" + textBox1.Text + ".tmp");
            var files = Directory.GetFiles(@".\", "*.tmp");
            foreach (string file in files)
            {
                File.ReadAllText(file);
                Template temp = new Template();
                temp.SetName(file.Split('\\').Last().Split('.')[0]);
                temp.Left = location * 28;
                temp.Top = 55;
                location++;
                this.Controls.Add(temp);
            }

            this.Dispose();
        }
    }
}
