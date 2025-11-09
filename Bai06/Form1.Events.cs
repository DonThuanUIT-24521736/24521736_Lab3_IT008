using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1
    {
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            calc.Operand1 = 0;
            calc.PendingOperation = "";
            calc.IsNewNumber = true;
            lblExpression.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            calc.IsNewNumber = true;
            lblExpression.Text = ""; 
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = calc.ChangeSign(val).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(txtDisplay.Text);
                lblExpression.Text = $"sqrt({val})"; 
                txtDisplay.Text = calc.Sqrt(val).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(txtDisplay.Text);
                lblExpression.Text = $"1/{val}"; 
                txtDisplay.Text = calc.Inverse(val).ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            calc.MemoryValue = 0;
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = calc.MemoryValue.ToString();
            calc.IsNewNumber = true;
        }

        private void btnMemoryStore_Click(object sender, EventArgs e)
        {
            calc.MemoryValue = double.Parse(txtDisplay.Text);
            calc.IsNewNumber = true;
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            calc.MemoryValue += double.Parse(txtDisplay.Text);
            calc.IsNewNumber = true;
        }
    }
}
