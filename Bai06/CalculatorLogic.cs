using System;

namespace Bai06
{
    public class CalculatorLogic
    {
        public double Operand1 { get; set; } = 0; // lưu số hạng đầu tiên. 
        public string PendingOperation { get; set; } = ""; // phép toán. 
        public bool IsNewNumber { get; set; } = true; // flag để biết người dùng có đang nhập số mới hay không. 
        public double MemoryValue { get; set; } = 0; // biến lưu giá trị trong bộ nhớ. 

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
            Operand1 = result;
            PendingOperation = "";
            IsNewNumber = true;
            return result;
        }

        public double ChangeSign(double val) => val * -1; // đổi dấu. 
        public double Sqrt(double val)
        {
            if (val < 0) throw new ArgumentException("Số âm không có căn bậc hai thực.");
            return Math.Sqrt(val);
        }
        public double Inverse(double val) // 1 / x; 
        {
            if (val == 0) throw new DivideByZeroException();
            return 1 / val;
        }
    }
}
