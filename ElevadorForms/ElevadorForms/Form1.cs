using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevadorForms
{
    public partial class Form1 : Form
    {
        int X;
        int Y;
        int Subir = 1;
        int Bajar = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Subir = 1;
            X = pictureBox1.Location.X;
            Y = pictureBox1.Location.Y;
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bajar = 1;
            X = pictureBox1.Location.X;
            Y = pictureBox1.Location.Y;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(X, Y - Subir);
            Subir++;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(X, Y + Bajar);
            Bajar++;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
