using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    public class AccountService
    {
        private readonly List<Account> _items = new List<Account>();
        public IReadOnlyList<Account> Items
        {
            get { return _items; }
        }

        

        // Hàm trả về true nếu thêm , trả về false nếu cập nhật. 
        public bool AddOrUpdate(Account input)
        { 
            if (TryGet(input.AccountNumber, out Account exist))
            {
                // TÌM THẤY -> Cập nhật
                exist.CustomerName = input.CustomerName;
                exist.Address = input.Address;
                exist.Money = input.Money;
                return false; // trả về false (đã cập nhật)
            }
            else
            {
                // KHÔNG TÌM THẤY -> Thêm mới
                _items.Add(input);
                return true; // trả về true (đã thêm mới)
            }
        }

        // Hàm xóa tài khoản ứng với số tài khoản đã nhập. 
        public bool Remove(string accountNumber)
        {
            if (TryGet(accountNumber, out Account exist))
            {
                // TÌM THẤY -> Xóa
                _items.Remove(exist);
                return true;
            }
            else
            {
                // KHÔNG TÌM THẤY -> Không làm gì, trả về false
                return false;
            }
        }

        // Hàm tính tổng số tiền 
        public decimal TotalMoney()
        {
            return _items.Sum(a => a.Money);
        }


        // Các hàm công cụ hỗ trợ tìm tài khoản. 
        // Hàm find viết theo cách LINQ. dùng cú pháp Biểu thức Lambda. 
        public Account Find(string accountNumber)
        {
            return _items.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }
        // Hàm tryGet (tìm thử) đảm bảo an toàn nếu không tìm thấy
        // và hạn chế lập code kiểm tra null. 
        public bool TryGet(string accountNumber, out Account account)
        {
            account = Find(accountNumber);
            return account != null;
        }
    }
}
