using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmPrincipal : Form
    {
        public double valueExpression;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private double convert(string vl)
        {
            return Convert.ToDouble(new DataTable().Compute(vl, null));
        }

        private void calcExpression(object sender, EventArgs e)
        {
            string expression = this.textBox1.Text;
            double total = this.convert(this.textBox1.Text);
            string totalCalc = "" + total;
            this.textBox1.Text = totalCalc;
            this.label1.Text = expression;
            this.textBox1.Text = this.textBox1.Text.Replace(",", ".");
        }
        
        private void calcSobreX()
        {
            double value = this.convert(this.textBox1.Text);
            string valueLabel = "" + value; 
            double totalCalc = 1 / value;
            string total = "" + totalCalc;
            this.textBox1.Text = total;
            this.label1.Text = "1/" + value;
            this.textBox1.Text = this.textBox1.Text.Replace(",", ".");
        }

        private void calcSquare()
        {
            double value = this.convert(this.textBox1.Text);
            string valueLabel = "" + value;
            double totalCalc = value * value;
            string total = "" + totalCalc;
            this.textBox1.Text = total;
            this.label1.Text = valueLabel + " * " + valueLabel;
            this.textBox1.Text = this.textBox1.Text.Replace(",", ".");
        }
        private void calcSource()
        {
            double value = this.convert(this.textBox1.Text);
            string valueLabel = "" + value;
            double totalCalc = Math.Sqrt(value);
            string total = "" + totalCalc;
            this.textBox1.Text = total;
            this.label1.Text = "√" + valueLabel;
            this.textBox1.Text = this.textBox1.Text.Replace(",", ".");
        }
        private void plusLess()
        {
            string value = this.textBox1.Text; 
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnSobreX_Click(object sender, EventArgs e)
        {
            calcSobreX();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            calcSquare();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            calcSource();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " / ";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " * ";
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " - ";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " + ";
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1);
        }

        private void btnParenthesesOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnParenthesesClosed_Click(object sender, EventArgs e)
        {

        }
    }
}
