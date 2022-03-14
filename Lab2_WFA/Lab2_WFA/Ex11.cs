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
    public partial class Ex11 : Form

    {
       
        public static string pass = "";
        public static string username = "";
        public Ex11()
        {
            InitializeComponent();

            StreamReader streamReader = new StreamReader(path: "fisier1.txt");
                string line;
                if ((line = streamReader.ReadLine()) != null)
                    username = line;
                if ((line = streamReader.ReadLine()) != null)
                    pass = line;
          
            }

            private void button1_Click(object sender, EventArgs e)
        {
            
            if( (pass == textBox2.Text) && (username == textBox1.Text)) {

                this.Hide();
                Ex12 form2 = new Ex12();
                form2.Show();
                form2.label2.Text = "Hello " + username; 
            }
            else
            {
                MessageBox.Show("Parola sau username gresit!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
