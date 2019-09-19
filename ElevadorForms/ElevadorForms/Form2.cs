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
    public partial class Form2 : Form
    {
        int direccion;

        public Form2()
        {
            InitializeComponent();
            direccion = 0;
        }       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            direccion = direccion + 1;
            textBox1.Text = direccion.ToString();
            if (direccion == 5)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
                if (direccion == 2)
            {
                button2.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            direccion = direccion - 1;
            textBox1.Text = direccion.ToString();
            if (direccion == 1)
            {

                button2.Enabled = false;
                button1.Enabled = true;
            }
            else
                if (direccion == 5)
            {
                button1.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (direccion == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

                

            }            
                if (direccion == 2)
                {

                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;

                    
                }
                if (direccion == 3)
                {
                    pictureBox3.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;


                    
                }
                if (direccion == 4)
                {

                    pictureBox4.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;

                    
                }
                if (direccion == 5)
                {

                    pictureBox5.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                    
                }

            }
        }
    }


