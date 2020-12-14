using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMak
{
    public partial class KullanıcıGirisi : Form
    {
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Admin" || textBox1.Text == "admin" ) && textBox2.Text == "00000")
            {
                MessageBox.Show("Login Successful!");

                Form frm1 = new Form1();
                frm1.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Wrong password or username try again.");
                
            }
            
        }

        private void KullanıcıGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
