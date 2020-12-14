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
    public partial class Form1 : Form
    {
        private bool optDurum = false;
        private double sonuc = 0;
        private string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();
            
            optDurum = false;
            
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;

            button17.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button12.Enabled = true;
            bool islem = true;

           }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;

            switch (opt)
            {
                case "+":

                  txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                    
                    break;

                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();

                    break;

                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();

                    break;

                case "/":



                    if (txtSonuc.Text == "0")
                    {
                        txtSonuc.Text = "ERROR";

                        button17.Enabled = false;
                        button4.Enabled = false;
                        button7.Enabled = false;
                        button12.Enabled = false;


                    }

                    else if (sonuc == 0)
                    {
                        if (txtSonuc.Text == " 0")
                        {
                            txtSonuc.Text = "ERROR";
                            button17.Enabled = false;
                            button4.Enabled = false;
                            button7.Enabled = false;
                            button12.Enabled = false;

                        }
                        else
                        {
                            txtSonuc.Text = "0";
                        }


                    }

                    else
                    {
                        txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                        sonuc = double.Parse(txtSonuc.Text);
                        txtSonuc.Text = sonuc.ToString();

                    }
                    break;

                   

            }

            if (txtSonuc.Text == "ERROR")
            {
                txtSonuc.Text = "ERROR";
            }
            else
            {
                sonuc = double.Parse(txtSonuc.Text);
                txtSonuc.Text = sonuc.ToString();
                opt = yeniOpt;
            }
            txtSonuc.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            button17.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button12.Enabled = true;
            txtSonuc.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
            button17.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button12.Enabled = true;
            txtSonuc.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    try
                    {
                        txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                        sonuc = double.Parse(txtSonuc.Text);
                        txtSonuc.Text = sonuc.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Hata");
                        throw;
                    }

                    

                    break;

                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();
                    sonuc = double.Parse(txtSonuc.Text);
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();
                    sonuc = double.Parse(txtSonuc.Text);
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "/":
                    

                    if (txtSonuc.Text == "0")
                    {
                        txtSonuc.Text = "ERROR";
                        
                        button17.Enabled = false;
                        button4.Enabled = false;
                        button7.Enabled = false;
                        button12.Enabled = false;
                        

                    }

                    else if (sonuc == 0)
                    {
                        if (txtSonuc.Text ==" 0")
                        {
                            txtSonuc.Text = "ERROR";
                            button17.Enabled = false;
                            button4.Enabled = false;
                            button7.Enabled = false;
                            button12.Enabled = false;
                            
                        }
                        else
                        {
                            txtSonuc.Text = "0";
                        }
                        

                    }

                    else
                    {
                        if (txtSonuc.Text == "ERROR")
                        {
                            txtSonuc.Text = "0";
                            button17.Enabled = true;
                            button4.Enabled = true;
                            button7.Enabled = true;
                            button12.Enabled = true;
                        }

                        else
                        {
                            txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                            sonuc = double.Parse(txtSonuc.Text);
                            txtSonuc.Text = sonuc.ToString();
                        }
                        

                    }
                    
                    break;

            }


            txtSonuc.Focus();
            opt = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }

            optDurum = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            
        }

        private void txtSonuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
    }
}
