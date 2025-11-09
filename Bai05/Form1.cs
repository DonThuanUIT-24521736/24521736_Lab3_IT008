using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bool isNum1Valid = double.TryParse(txtNumber1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtNumber2.Text, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô!", "Lỗi đầu vào",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
        private void btnPlus_Click(object sender, EventArgs e)
        {
            PerformCalculation("+"); 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            PerformCalculation("-"); 
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            PerformCalculation("x"); 
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation("/"); 
        }   
    }
}
