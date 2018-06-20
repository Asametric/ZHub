using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZHub;
namespace ZHub
{
    public partial class Box : Form
    {
        public Box()
        {
            InitializeComponent();
        }
        OpenFileDialog file = new OpenFileDialog();
        private void NewTemplate_Click(object sender, EventArgs e)
        {
            file.Multiselect = false;
            if (file.ShowDialog() != DialogResult.OK) return;
            richTextBox1.AppendText(file.FileName+",");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int location = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            File.WriteAllText(@".\" + textBox1.Text+".tmp", richTextBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Box_Load(object sender, EventArgs e)
        {

        }
    }
}
