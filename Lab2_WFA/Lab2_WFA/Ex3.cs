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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) +
                Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) -
                Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) *
                Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) /
                Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }
    }
}

