using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW16
{
    public partial class CalcForm : Form
    {
        private string _firstVaue = "";
        private string _massAction = "";

        public CalcForm()
        {
            InitializeComponent();
        }


        private void btnNumb_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (textBox1.Text == "0" || textBox1.Text == "Деление на ноль невозможно")
                {
                    textBox1.Text = "";
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                    btn.BackColor = Color.FromArgb(65, 65, 65);
                }
                else
                {
                    Button btn = (Button)sender;
                    textBox1.Text += btn.Text;
                    btn.BackColor = Color.FromArgb(65, 65, 65);
                }
                
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += 0;
            }

            btn0.BackColor = Color.FromArgb(65, 65, 65);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1 && textBox1.Text == "")
            {
                textBox1.Text += "0,";
            }
            else if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";

            }
            btnPoint.BackColor = Color.FromArgb(65, 65, 65);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            btnDelete.BackColor = Color.LightGray;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (_massAction == "")
            {
                _firstVaue = textBox1.Text;
                textBox1.Text = "";
                _massAction = "/";
                btnDivide.BackColor = Color.White;
                btnDivide.ForeColor = Color.Orange;
            }
            else
            {
                _massAction = "/";
                btnDivide.BackColor = Color.White;
                btnDivide.ForeColor = Color.Orange;
                btnMult.BackColor = Color.Orange;
                btnMult.ForeColor = Color.White;
                btnSub.BackColor = Color.Orange;
                btnSub.ForeColor = Color.White;
                btnSum.BackColor = Color.Orange;
                btnSum.ForeColor = Color.White;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (_massAction == "")
            {
                _firstVaue = textBox1.Text;
                textBox1.Text = "";
                _massAction = "*";
                btnMult.BackColor = Color.White;
                btnMult.ForeColor = Color.Orange;
            }
            else
            {
                _massAction = "*";
                btnMult.BackColor = Color.White;
                btnMult.ForeColor = Color.Orange;
                btnDivide.BackColor = Color.Orange;
                btnDivide.ForeColor = Color.White;
                btnSub.BackColor = Color.Orange;
                btnSub.ForeColor = Color.White;
                btnSum.BackColor = Color.Orange;
                btnSum.ForeColor = Color.White;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (_massAction == "")
            {
                _firstVaue = textBox1.Text;
                textBox1.Text = "";
                _massAction = "-";
                btnSub.BackColor = Color.White;
                btnSub.ForeColor = Color.Orange;
            }
            else
            {
                _massAction = "-";
                btnSub.BackColor = Color.White;
                btnSub.ForeColor = Color.Orange;
                btnDivide.BackColor = Color.Orange;
                btnDivide.ForeColor = Color.White;
                btnMult.BackColor = Color.Orange;
                btnMult.ForeColor = Color.White;
                btnSum.BackColor = Color.Orange;
                btnSum.ForeColor = Color.White;
            }

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (_massAction == "")
            {
                _firstVaue = textBox1.Text;
                textBox1.Text = "";
                _massAction = "+";
                btnSum.BackColor = Color.White;
                btnSum.ForeColor = Color.Orange;
            }
            else
            {
                _massAction = "+";
                _massAction = "+";
                btnSum.BackColor = Color.White;
                btnSum.ForeColor = Color.Orange;
                btnDivide.BackColor = Color.Orange;
                btnDivide.ForeColor = Color.White;
                btnMult.BackColor = Color.Orange;
                btnMult.ForeColor = Color.White;
                btnSub.BackColor = Color.Orange;
                btnSub.ForeColor = Color.White;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            switch (_massAction)
            {
                case "+":
                    textBox1.Text = (Convert.ToDouble(_firstVaue) + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Convert.ToDouble(_firstVaue) - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "Деление на ноль невозможно";

                    }
                    else
                    {
                        textBox1.Text = (Convert.ToDouble(_firstVaue) / Convert.ToDouble(textBox1.Text)).ToString();
                    }
                    break;
                case "*":
                    textBox1.Text = (Convert.ToDouble(_firstVaue) * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }

            _massAction = "";
            btnEqual.BackColor = Color.Orange;
            btnEqual.ForeColor = Color.White;
            btnSum.BackColor = Color.Orange;
            btnSum.ForeColor = Color.White;
            btnDivide.BackColor = Color.Orange;
            btnDivide.ForeColor = Color.White;
            btnMult.BackColor = Color.Orange;
            btnMult.ForeColor = Color.White;
            btnSub.BackColor = Color.Orange;
            btnSub.ForeColor = Color.White;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            btnCe.BackColor = Color.LightGray;
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            btn7.BackColor = Color.White;
        }

        private void btnBlack_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(125, 125, 125);
        }

        private void btnGrey_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.WhiteSmoke;
        }

        private void btnEqual_MouseDown(object sender, MouseEventArgs e)
        {
            btnEqual.BackColor = Color.White;
            btnEqual.ForeColor = Color.Orange;
        }
    }
}
