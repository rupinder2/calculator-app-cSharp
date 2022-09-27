using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        private int originalWidth;
        private int originalHeight;
        public Calculator()
        {
            InitializeComponent();
            standard.Checked = true;
            originalWidth = this.Width;
            originalHeight = this.Height;
        }
        

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!darkMode.Checked)
            {
                tabPage1.BackColor = Color.White;
                tabPage2.BackColor = Color.White;
                aboutme.BackColor = Color.White;
                aboutme.ForeColor = Color.Black;
                //radio and checkbox
                calc.TabPages[0].BackColor = Color.White;
                standard.ForeColor = Color.Black;
                scientific.ForeColor = Color.Black;
                darkMode.ForeColor = Color.Black;
                //textbox
                output.BackColor = Color.White;
                output.ForeColor = Color.Black;
                //buttons
                btn0.BackColor = Color.White;
                btn0.ForeColor = Color.Black;
                btn1.BackColor = Color.White;
                btn1.ForeColor = Color.Black;
                btn2.BackColor = Color.White;
                btn2.ForeColor = Color.Black;
                btn3.BackColor = Color.White;
                btn3.ForeColor = Color.Black;
                btn4.BackColor = Color.White;
                btn4.ForeColor = Color.Black;
                btn5.BackColor = Color.White;
                btn5.ForeColor = Color.Black;
                btn6.BackColor = Color.White;
                btn6.ForeColor = Color.Black;
                btn7.BackColor = Color.White;
                btn7.ForeColor = Color.Black;
                btn8.BackColor = Color.White;
                btn8.ForeColor = Color.Black;
                btn9.BackColor = Color.White;
                btn9.ForeColor = Color.Black;
                btnAdd.BackColor = Color.White;
                btnAdd.ForeColor = Color.Black;
                btnClear.BackColor = Color.White;
                btnClear.ForeColor = Color.Black;
                btnCosine.BackColor = Color.White;
                btnCosine.ForeColor = Color.Black;
                btnDivide.BackColor = Color.White;
                btnDivide.ForeColor = Color.Black;
                btnDot.BackColor = Color.White;
                btnDot.ForeColor = Color.Black;
                btnEquall.BackColor = Color.White;
                btnEquall.ForeColor = Color.Black;
                btnLog.BackColor = Color.White;
                btnLog.ForeColor = Color.Black;
                btnMultiply.BackColor = Color.White;
                btnMultiply.ForeColor = Color.Black;
                btnPlusMinus.BackColor = Color.White;
                btnPlusMinus.ForeColor = Color.Black;
                btnSine.BackColor = Color.White;
                btnSine.ForeColor = Color.Black;
                btnSqrRoot.BackColor = Color.White;
                btnSqrRoot.ForeColor = Color.Black;
                btnSubtract.BackColor = Color.White;
                btnSubtract.ForeColor = Color.Black;
                btnX.BackColor = Color.White;
                btnX.ForeColor = Color.Black;
                btnXPower.BackColor = Color.White;
                btnXPower.ForeColor = Color.Black;
            }
            else if (darkMode.Checked)
            {
                tabPage1.BackColor = Color.Black;
                tabPage2.BackColor = Color.Black;
                aboutme.BackColor = Color.Black;
                aboutme.ForeColor = Color.White;
                //radio and checkbox
                calc.TabPages[0].BackColor = Color.Black;
                standard.ForeColor = Color.White;
                scientific.ForeColor = Color.White;
                darkMode.ForeColor = Color.White;
                //Textbox
                output.BackColor = Color.Black;
                output.ForeColor = Color.White;
                //buttons
                btn0.BackColor = Color.Black;
                btn0.ForeColor = Color.White;
                btn1.BackColor = Color.Black;
                btn1.ForeColor = Color.White;
                btn2.BackColor = Color.Black;
                btn2.ForeColor = Color.White;
                btn3.BackColor = Color.Black;
                btn3.ForeColor = Color.White;
                btn4.BackColor = Color.Black;
                btn4.ForeColor = Color.White;
                btn5.BackColor = Color.Black;
                btn5.ForeColor = Color.White;
                btn6.BackColor = Color.Black;
                btn6.ForeColor = Color.White;
                btn7.BackColor = Color.Black;
                btn7.ForeColor = Color.White;
                btn8.BackColor = Color.Black;
                btn8.ForeColor = Color.White;
                btn9.BackColor = Color.Black;
                btn9.ForeColor = Color.White;
                btnAdd.BackColor = Color.Black;
                btnAdd.ForeColor = Color.White;
                btnClear.BackColor = Color.Black;
                btnClear.ForeColor = Color.White;
                btnCosine.BackColor = Color.Black;
                btnCosine.ForeColor = Color.White;
                btnDivide.BackColor = Color.Black;
                btnDivide.ForeColor = Color.White;
                btnDot.BackColor = Color.Black;
                btnDot.ForeColor = Color.White;
                btnEquall.BackColor = Color.Black;
                btnEquall.ForeColor = Color.White;
                btnLog.BackColor = Color.Black;
                btnLog.ForeColor = Color.White;
                btnMultiply.BackColor = Color.Black;
                btnMultiply.ForeColor = Color.White;
                btnPlusMinus.BackColor = Color.Black;
                btnPlusMinus.ForeColor = Color.White;
                btnSine.BackColor = Color.Black;
                btnSine.ForeColor = Color.White;
                btnSqrRoot.BackColor = Color.Black;
                btnSqrRoot.ForeColor= Color.White;
                btnSubtract.BackColor = Color.Black;
                btnSubtract.ForeColor = Color.White;
                btnX.BackColor = Color.Black;
                btnX.ForeColor = Color.White;
                btnXPower.BackColor = Color.Black;
                btnXPower.ForeColor = Color.White;
                


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!output.Text.Contains("."))
            {
                output.Text += ".";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "0";
            }else
            {
                output.Text += "0";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "1";
            }
            else
            {
                output.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "2";
            }
            else
            {
                output.Text += "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "3";
            }
            else
            {
                output.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "4";
            }
            else
            {
                output.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "5";
            }
            else
            {
                output.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "6";
            }
            else
            {
                output.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "7";
            }
            else
            {
                output.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "8";
            }
            else
            {
                output.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (output.Text == "0")
            {
                output.Text = "9";
            }
            else
            {
                output.Text += "9";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("-"))
            {
                output.Text=output.Text.Trim('-');
            }
            else
            {
                output.Text = "-" + output.Text;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(output.Text);
            output.Clear();
            operators = "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(output.Text);
            output.Clear();
            operators = "+";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(output.Text);
            output.Clear();
            operators = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(output.Text);
            output.Clear();
            operators = "/";
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(output.Text);
            result = 1 / firstValue;
            output.Text = result.ToString();
        }
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            output.Text = Math.Sqrt(double.Parse(output.Text)).ToString();

        }

        private void btnXPower_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(output.Text);
            output.Text = Math.Pow(temp, 2).ToString();
        }
        private void btnSine_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(output.Text);
            output.Text = Math.Sin(temp * (Math.PI / 180)).ToString();
        }
        private void btnCosine_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(output.Text);
            output.Text = Math.Cos(temp * (Math.PI / 180)).ToString();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(output.Text);
            output.Text = Math.Log(temp,10).ToString();
        }


        private void btnEquall_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    secondValue = decimal.Parse(output.Text);
                    result = firstValue - secondValue;
                    output.Text = result.ToString();
                    break;
                case "+":
                    secondValue = decimal.Parse(output.Text);
                    result = firstValue + secondValue;
                    output.Text = result.ToString();
                    break;
                case "*":
                    secondValue = decimal.Parse(output.Text);
                    result = firstValue * secondValue;
                    output.Text = result.ToString();
                    break;
                case "/":
                    secondValue = decimal.Parse(output.Text);
                    result = firstValue / secondValue;
                    output.Text = result.ToString();
                    break;

                default:
                    break;
            }
        }

        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            if (standard.Checked)
            {

                
                btnSine.Visible = false;
                btnXPower.Visible = false;
                btnCosine.Visible = false;
                btnLog.Visible = false;
                this.Width = 387;
                this.Height = 400;
                output.Width = 341;
                tabPage1.Width = 367;
                tabPage2.Width = 367;
                calc.Width = 375;
                Size = new Size(377, 400);

            }
            
        }
        private void scientific_CheckedChanged(object sender, EventArgs e)
        {
            if (scientific.Checked)
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
                output.Width = 386;
                tabPage1.Width = 405;
                tabPage2.Width = 405;
                calc.Width = 413;
                btnSine.Visible = true;
                btnXPower.Visible = true;
                btnCosine.Visible = true;
                btnLog.Visible = true;
            }

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        
    }
}
