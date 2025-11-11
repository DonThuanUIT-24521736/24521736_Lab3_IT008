using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1
    {
        // 1. Hàm xóa toàn bộ: 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            calc.Operand1 = 0;
            calc.PendingOperation = "";
            calc.IsNewNumber = true;
            lblExpression.Text = "";
        }

        // 2. Hàm xóa màn hình nhưng không xóa đi Memory. 
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            calc.IsNewNumber = true;
            lblExpression.Text = ""; 
        }
        
        // 3. Hàm của nút đổi dấu: 
        private void btnSign_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = calc.ChangeSign(val).ToString();
        }

        // 4. Hàm của nút căn bậc 2: 
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

        // 5. Hàm của nút 1/x: 
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

        // 6. Hàm cho nút MC : xóa bộ nhớ đệm. 
        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            calc.MemoryValue = 0;
        }

        // 7. Hàm cho nút MR : gọi ra giá trị trong bộ nhớ đệm. 
        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = calc.MemoryValue.ToString();
            calc.IsNewNumber = true;
        }

        // 8. Hàm cho nút MS : cập nhật giá trị trừ txtDisplay vào bộ nhớ đệm. 
        private void btnMemoryStore_Click(object sender, EventArgs e)
        {
            calc.MemoryValue = double.Parse(txtDisplay.Text);
            calc.IsNewNumber = true;
        }

        // 9. Hàm cho nút M+ : cộng dồn giá trị từ txtDisplay vào bộ nhớ đệm. 
        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            calc.MemoryValue += double.Parse(txtDisplay.Text);
            calc.IsNewNumber = true;
        }

        // 10. Hàm cho nút %
        private void btnPerson_Click(object sender, EventArgs e)
        {
            // Logic của nút % là tính giá trị phần trăm của toán hạng 1.
            // Ví dụ: 500 + 10 % (sẽ tính 10% của 500, là 50)
            // Màn hình sẽ hiển thị 50, chờ người dùng nhấn = để thực hiện 500 + 50

            double operand2;
           

            // 1. Dùng TryParse để lấy số trên màn hình một cách an toàn
            if (!double.TryParse(txtDisplay.Text, out operand2))
            {
                MessageBox.Show("Giá trị trên màn hình không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }

            // 2. Nếu không có phép toán nào đang chờ chỉ cần chia cho 100. 
            if (calc.PendingOperation == "")
            {
                txtDisplay.Text = (operand2 / 100.0).ToString();
                lblExpression.Text = $"{operand2}% = "; 
                calc.IsNewNumber = true; // Đây là một kết quả
                
                return;
            }

            // 3. Nếu có phép toán đang chờ
            try
            {
                
                // Tính giá trị phần trăm 
                double percentageValue = calc.Operand1 * (operand2 / 100.0);

                // Cập nhật màn hình với giá trị % này
                txtDisplay.Text = percentageValue.ToString();

                // Cập nhật nhãn biểu thức
                lblExpression.Text = $"{calc.Operand1} {calc.PendingOperation} {percentageValue}";

                // Đặt IsNewNumber = false để người dùng có thể nhấn "=" ngay sau đó
                // để thực hiện phép tính (ví dụ: 500 * 50)
                calc.IsNewNumber = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính phần trăm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
