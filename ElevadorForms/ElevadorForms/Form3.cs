using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevadorForms
{
    public partial class Form3 : Form
    {
        int x = 100;

        public enum Piso
        {
            Uno = 332,
            Dos = 178,
            Tres = 31
        }
        private readonly List<Piso> LiftQueue;

        public Form3()
        {
            InitializeComponent();
            LiftQueue = new List<Piso>();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            x = x + 1;
            pictureBox1.Location = new Point(64, 331 - x);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
