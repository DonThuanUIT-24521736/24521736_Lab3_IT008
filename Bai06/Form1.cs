using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private CalculatorLogic calc = new CalculatorLogic();

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }

        // Hàm nhận giá trị số. 
        private void btnNumber_Click(object sender, EventArgs e) // 
        {
            var btn = (Button)sender;
            // Xử lý khi người dùng nhấn . nhiều lần 
            if (btn.Text == "." && txtDisplay.Text.Contains(".")) return;
            // Xử lý khi người dùng muốn nhập giá trị 0,...: 
            if (calc.IsNewNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text == "." ? "0." : btn.Text;
            }
            else
                txtDisplay.Text += btn.Text;

            calc.IsNewNumber = false;
        }

        // Hàm nhận toán tử khi người dùng nhấn vào toán tử bất kỳ. 
        private void btnOperator_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
           // txtDisplay.Text += btn.Text; 
            if (!calc.IsNewNumber && calc.PendingOperation != "")
                btnEqual.PerformClick();

            calc.Operand1 = double.Parse(txtDisplay.Text);
            calc.PendingOperation = btn.Text;
            calc.IsNewNumber = true;

            lblExpression.Text = $"{calc.Operand1} {calc.PendingOperation}";
        }

        // Hàm cho nút =
        private void btnEquals_Click(object sender, EventArgs e)
        {
           
            try
            {
                double operand2 = double.Parse(txtDisplay.Text);
                // Cập nhật nhãn biểu thức
                if (calc.PendingOperation == "")
                {
                    lblExpression.Text = $"{operand2} =";
                    txtDisplay.Text = operand2.ToString();
                    calc.Operand1 = operand2;
                    return; 
                }
                else
                    lblExpression.Text = $"{calc.Operand1} {calc.PendingOperation} {operand2} =";


                double result = calc.Calculate(operand2);
                txtDisplay.Text = result.ToString();
                
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText =
                "🧮 HƯỚNG DẪN SỬ DỤNG MÁY TÍNH\n\n" +
                "Các nút bộ nhớ:\n" +
                " - MC: Xóa giá trị trong bộ nhớ.\n" +
                " - MR: Gọi lại giá trị đang lưu trong bộ nhớ.\n" +
                " - MS: Lưu giá trị hiện tại vào bộ nhớ (ghi đè giá trị cũ).\n" +
                " - M+: Cộng giá trị hiện tại vào bộ nhớ.\n" 
               ;
            MessageBox.Show(
                helpText, 
                "Hướng dẫn sử dụng", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            ); 
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không? ",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes) Application.Exit(); 
        }
        
    }
}
