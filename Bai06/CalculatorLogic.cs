using System;

namespace Bai06
{
    public class CalculatorLogic
    {
        public double Operand1 { get; set; } = 0; // lưu số hạng đầu tiên. 
        public string PendingOperation { get; set; } = ""; // phép toán đang chờ. 
        public bool IsNewNumber { get; set; } = true; // flag để biết người dùng có đang nhập số mới hay không. 
        public double MemoryValue { get; set; } = 0; // biến lưu giá trị trong bộ nhớ. 
      
        // 1. Hàm tính toán. (+,-,*,/). 
        public double Calculate(double operand2)
        {
            double result = 0;
            switch (PendingOperation)
            {
                case "+": result = Operand1 + operand2; break;
                case "-": result = Operand1 - operand2; break;
                case "*": result = Operand1 * operand2; break;
                case "/":
                    if (operand2 == 0) throw new DivideByZeroException();
                    result = Operand1 / operand2;
                    break;
            }
            // Sau khi tính ra kết quả: 
            Operand1 = result; // cập nhật toán hạng đầu tiên là kết quả để tiếp tục tính toán. 
            PendingOperation = ""; // cập nhật phép toán đang chờ là không có. 
            IsNewNumber = true; // chuyển cờ để biết người dùng sẽ nhập số mới.  
            // Trả về kết quả. 
            return result;
        }
        // 2. Hàm đổi dấu. 
        public double ChangeSign(double val) => val * -1; 

        // 3. Hàm căn bậc 2. 
        public double Sqrt(double val)
        {
            if (val < 0) throw new ArgumentException("Số âm không có căn bậc hai thực.");
            return Math.Sqrt(val);
        }
        // 4. Hàm lấy 1 / x.
        public double Inverse(double val) 
        {
            if (val == 0) throw new DivideByZeroException();
            return 1 / val;
        }
    }
}
