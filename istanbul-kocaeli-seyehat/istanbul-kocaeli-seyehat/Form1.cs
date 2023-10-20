using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istanbul_kocaeli_seyehat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text== "yönetici" && textBox2.Text == "1234")
            {
                Form3 seyehat = new Form3();
                seyehat.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Giriş Tekrar Dneyiniz!");
                textBox1.Clear();
                textBox2.Clear();

            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "1234")
            {
                Form3 seyehat = new Form3();
                seyehat.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Giriş Tekrar Dneyiniz!");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "1234")
            {
                Form3 seyehat = new Form3();
                seyehat.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Giriş Tekrar Dneyiniz!");
                textBox1.Clear();
                textBox2.Clear();

            }
        }
    }
}
