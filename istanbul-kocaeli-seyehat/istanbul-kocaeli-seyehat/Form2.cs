using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace istanbul_kocaeli_seyehat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("1");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1 .Checked = false;
            radioButton2.Checked = false;
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("2");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3 .Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("3");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4 .Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("4");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button5 .Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("5");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button6.Enabled = false;

        
        }


        private void button7_Click(object sender, EventArgs e)
        {
            listkoltuk.Items.Add("6");
            listad.Items.Add(textBox1.Text);
            listtel.Items.Add(textBox2.Text);
            listilce.Items.Add(comboBox1.Text);
            listsaat.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listcinsiyet.Items.Add("Bay");
            }
            if (radioButton2.Checked == true)
            {
                listcinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button7.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listsofor.Items.Add(textBox1.Text);


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 geri= new Form3();
            geri.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
    }
}
