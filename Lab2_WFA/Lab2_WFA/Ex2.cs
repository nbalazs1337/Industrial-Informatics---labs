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

namespace Lab2_WFA
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "fisier1.txt");

            string line;
            while ((line = streamReader.ReadLine()) != null)
                listBox2.Items.Add(line);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           



            
        }

            private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
