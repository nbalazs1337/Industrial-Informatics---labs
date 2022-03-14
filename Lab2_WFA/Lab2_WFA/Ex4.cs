using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_WFA
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
            listBox1.Items.Add("Arduino Uno");
            listBox1.Items.Add("Arduino Leonardo");
            listBox1.Items.Add("Raspberry Pi 3");
            listBox1.Items.Add("Raspberry Pi 4");
            string t1 = "";
            string t2 = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == "Arduino Uno")
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\negre\\Documents\\Lab2_WFA\\Lab2_WFA\\Lab2_WFA\\bin\\Debug\\uno.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (listBox1.SelectedItem == "Arduino Leonardo")
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\negre\\Documents\\Lab2_WFA\\Lab2_WFA\\Lab2_WFA\\bin\\Debug\\leonardo.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (listBox1.SelectedItem == "Raspberry Pi 4")
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\negre\\Documents\\Lab2_WFA\\Lab2_WFA\\Lab2_WFA\\bin\\Debug\\pi4.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (listBox1.SelectedItem == "Raspberry Pi 3")
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\negre\\Documents\\Lab2_WFA\\Lab2_WFA\\Lab2_WFA\\bin\\Debug\\pi3.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked)
            {
                MessageBox.Show("1 0 1 0");
            }
            else
                   if (radioButton1.Checked && radioButton4.Checked)
            {
                MessageBox.Show("1 0 0 1");
            }
            else
                   if (radioButton2.Checked && radioButton3.Checked)
            {
                MessageBox.Show("0 1 1 0");
            }
            else
                MessageBox.Show(" 0 1 0 1");

          
        }
    }
    }

