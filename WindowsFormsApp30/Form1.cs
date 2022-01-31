using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double obsah(double a) { return a * a; }
        public double obsah(double a, double b) { return a * b; }
        public double objem(double a) { return a * a * a; }
        public double objem(double a, double b, double c) { return a * b * c; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Text == "") { numericUpDown1.Text = "0"; }
            if (numericUpDown2.Text == "") { numericUpDown2.Text = "0"; }
            if (numericUpDown3.Text == "") { numericUpDown3.Text = "0"; }
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;
            if (double.IsNaN(a)) { a = 0; }
            if (double.IsNaN(b)) { b = 0; }
            if (double.IsNaN(c)) { c = 0; }
           //MessageBox.Show(a.ToString() + b.ToString() + c.ToString());
            if (a>0&&b==0&c==0) { label1.Text = obsah(a).ToString(); label2.Text = objem(a).ToString(); }
            else if (a>0&&b>0&&c==0) { label1.Text = obsah(a, b).ToString(); label2.Text = ""; }
            else { label2.Text = objem(a, b, c).ToString(); label1.Text = obsah(a, b).ToString(); }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown2.Controls[0].Visible = false;
            numericUpDown3.Controls[0].Visible = false;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
