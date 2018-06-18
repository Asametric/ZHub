using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Box box = new Box();
            box.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.FromArgb(99, 96, 101);
        }
        int location = 1;
        public void Form1_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(@".\","*.tmp");
            foreach(string file in files)
            {
                File.ReadAllText(file);
                Template temp = new Template();
                temp.SetName(file.Split('\\').Last().Split('.')[0]);
                temp.Left = location * 28;
                temp.Top = 55;
                location++;
                this.Controls.Add(temp);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.BackColor == Color.FromArgb(55, 55, 55)) { control.Dispose(); }
                location = 1;
            }
            var files = Directory.GetFiles(@".\","*.tmp");
            foreach(string file in files)
            {
       
                File.ReadAllText(file);
                Template temp = new Template();
                temp.SetName(file.Split('\\').Last().Split('.')[0]);
                temp.Left = location * 28;
                temp.Top = 55;
                location++;
                this.Controls.Add(temp);
            }
        }
    }
}
