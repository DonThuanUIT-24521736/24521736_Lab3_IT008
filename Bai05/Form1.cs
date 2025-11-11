using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PerformCalculation(string operation)
        {
            double num1, num2;
            // sử dụng double.TryParse() để chuyển đổi văn bản từ TextBox sang số. 
            // TryParse() sẽ trả về true nếu thành công và false nếu thất bại (ví dụ: người dùng nhập chữ "abc").
            bool isNum1Valid = double.TryParse(txtNumber1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtNumber2.Text, out num2);

            // Kiểm tra if (!isNum1Valid || !isNum2Valid) để đảm bảo cả hai ô đều là số hợp lệ.
            // Nếu không, một MessageBox lỗi sẽ hiện ra và hàm sẽ dừng lại.
            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô!", "Lỗi đầu vào",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dựa trên chuỗi operation("+", "-", "x", "/") được truyền vào,
            // chương trình thực hiện phép toán tương ứng và gán kết quả cho biến result.
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi Phép Tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                    result = num1 / num2;
                    break;     
            }
            txtAnswer.Text = result.ToString(); 
        }

        // Các hàm này nhận lệnh từ người dùng click vào button tương ứng. 
        // Chúng sẽ gọi Hàm PerformCalculation với tham số truyền vào là toán tử tương ứng. 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            PerformCalculation("+"); 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            PerformCalculation("-"); 
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation("x"); 
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation("/"); 
        }   
    }
}
