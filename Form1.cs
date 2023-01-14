using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maycalc
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }

            Button B = (Button)sender;
            if (textBox1.Text=="0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void per1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text; 
            label1.Text = $"{B.Text}";
            N1 = textBox1.Text;
            label2.Text = textBox1.Text;
            N2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2,res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            if (D == "X")
            {
                res = dn1 * dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "%")
            {
                res = (dn1 * dn2 / 100);
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
            label1.Text = "";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = 1/dn;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0"; 
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        private void темнаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Black;
           BackColor = Color.Black;
            ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
            button10.BackColor = Color.Black;
            button10.ForeColor = Color.White;
            button11.BackColor = Color.Black;
            button11.ForeColor = Color.White;
            button12.BackColor = Color.Black;
            button12.ForeColor = Color.White;
            button13.BackColor = Color.Black;
            button13.ForeColor = Color.White;
            button14.BackColor = Color.Black;
            button14.ForeColor = Color.White;
            button15.BackColor = Color.Black;
            button15.ForeColor = Color.White;
            button16.BackColor = Color.Black;
            button16.ForeColor = Color.White;
            button17.BackColor = Color.Black;
            button17.ForeColor = Color.White;
            button18.BackColor = Color.Black;
            button18.ForeColor = Color.White;
            button19.BackColor = Color.Black;
            button19.ForeColor = Color.White;
            button20.BackColor = Color.Black;
            button20.ForeColor = Color.White;
            button21.BackColor = Color.Black;
            button21.ForeColor = Color.White;
            button22.BackColor = Color.Black;
            button22.ForeColor = Color.White;
            button23.BackColor = Color.Black;
            button23.ForeColor = Color.White;
            button24.BackColor = Color.Black;
            button24.ForeColor = Color.White;
        }

        private void светлаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.White;
            BackColor = Color.White;
            ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Blue;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Blue;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Blue;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Blue;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Blue;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Blue;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Blue;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Blue;
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Blue;
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Blue;
            button11.BackColor = Color.White;
            button11.ForeColor = Color.Blue;
            button12.BackColor = Color.White;
            button12.ForeColor = Color.Red;
            button13.BackColor = Color.White;
            button13.ForeColor = Color.Red;
            button14.BackColor = Color.White;
            button14.ForeColor = Color.Red;
            button15.BackColor = Color.White;
            button15.ForeColor = Color.Red;
            button16.BackColor = Color.White;
            button16.ForeColor = Color.Blue;
            button17.BackColor = Color.White;
            button17.ForeColor = Color.Blue;
            button18.BackColor = Color.White;
            button18.ForeColor = Color.Blue;
            button19.BackColor = Color.White;
            button19.ForeColor = Color.Red;
            button20.BackColor = Color.White;
            button20.ForeColor = Color.Red;
            button21.BackColor = Color.White;
            button21.ForeColor = Color.Red;
            button22.BackColor = Color.White;
            button22.ForeColor = Color.Blue;
            button23.BackColor = Color.White;
            button23.ForeColor = Color.Blue;
            button24.BackColor = Color.White;
            button24.ForeColor = Color.Red;
        }
    }
}
