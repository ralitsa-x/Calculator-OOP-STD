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
        Calculations cc = new Calculations();

        private double MemoryStore;
        public Calculator()
        {
            InitializeComponent();
            cc.Operation = true;
            cc.IsDecimalPoint = true;

            btnMC.Enabled = false;
            btnM_Plus.Enabled = false;
            btnMR.Enabled = false;
            btnM_Minus.Enabled = false;
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" || (cc.Operation))
            {
                lblResult.ResetText();
                cc.Operation = false;
            }
            Button btn = (Button)sender;
            //----------------- DEALING WITH THE DECIMAL POINT --------------------
            if (btn.Text == ".")
            {
                if (cc.IsDecimalPoint)
                {
                    lblResult.Text = lblResult.Text + btn.Text;
                    cc.IsDecimalPoint = false;
                }
            }
            else
            {
                lblResult.Text = lblResult.Text + btn.Text;
            }
            //---------------------------------------------------------------------
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.ResetText();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }
        private void Calculation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cc.Calculation = btn.Text;
            cc.Value = double.Parse(lblResult.Text);
            cc.Operation = true;
            cc.IsDecimalPoint = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cc.Calculation)
                {
                    case "+":
                        lblResult.Text = Calculations.Addition(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "-":
                        lblResult.Text = Calculations.Substraction(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "×":
                        lblResult.Text = Calculations.Multiplication(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "÷":
                        lblResult.Text = Calculations.Division(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "√":
                        if(cc.Value >=0) lblResult.Text = Calculations.SquareRoot(cc.Value).ToString();
                        else MessageBox.Show("You cannot find the square root of a negative number!");
                        break;
                    case "1/x":
                        if (cc.Value != 0) lblResult.Text = Calculations.Reciprocal(cc.Value).ToString();
                        else MessageBox.Show("The devisor cannot be 0!");
                        break;
                    case "x²":
                        lblResult.Text = Calculations.MathPow(cc.Value, 2).ToString();
                        break;
                    case "x³":
                        lblResult.Text = Calculations.MathPow(cc.Value, 3).ToString();
                        break;
                    case "±":
                        if (cc.Value != 0) lblResult.Text = Calculations.Opposite(cc.Value).ToString();
                        else MessageBox.Show("Try again!");
                        break;
                    case "%":
                        lblResult.Text = Calculations.Percent(cc.Value).ToString();
                        break;
                    default: 
                        break;
                }
                cc.Operation = true;
                cc.IsDecimalPoint = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn01.PerformClick();
                    break;
                case "2":
                    btn02.PerformClick();
                    break;
                case "3":
                    btn03.PerformClick();
                    break;
                case "4":
                    btn04.PerformClick();
                    break;
                case "5":
                    btn05.PerformClick();
                    break;
                case "6":
                    btn06.PerformClick();
                    break;
                case "7":
                    btn07.PerformClick();
                    break;
                case "8":
                    btn08.PerformClick();
                    break;
                case "9":
                    btn09.PerformClick();
                    break;
                case ",":
                    btnPoint.PerformClick();
                    break;
                case "-":
                    btnMin.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "*":
                    btnMulti.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case " ":
                    btnResult.PerformClick();
                    break;
                case "\r":
                    btnResult.PerformClick();
                    break;
                default:
                    break;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                lblResult.Text = "0";
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            // (Memory Clear)

            MemoryStore = 0;
            btnMC.Enabled = false;
            btnM_Plus.Enabled = false;
            btnMR.Enabled = false;
            btnM_Minus.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            // (Memory Read)

            lblResult.Text = MemoryStore.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            // (Memory Save)

            MemoryStore = double.Parse(lblResult.Text);
            btnMC.Enabled = true;
            btnM_Plus.Enabled = true;
            btnMR.Enabled = true;
            btnM_Minus.Enabled = true;
        }

        private void btnM_Plus_Click(object sender, EventArgs e)
        {
            // add the current number to the memorized number and save

            MemoryStore += double.Parse(lblResult.Text);
        }

        private void btnM_Minus_Click(object sender, EventArgs e)
        {
            // the memorized number minus the current number and save

            MemoryStore -= double.Parse(lblResult.Text);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MemoryStore.ToString(), "Memory");
        }
    }
}
