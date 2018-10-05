using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.MouseMove += Label1_MouseMove;
            button1.MouseMove += Button1_MouseMove;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button1.Location = new Point(r.Next(0, 200), r.Next(0, 200));
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            label1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.Text = "X:" + e.X + ",Y:" + e.Y;
        }
    }
}
