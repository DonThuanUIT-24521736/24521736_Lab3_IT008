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

        public Account Find(string accountNumber)
        {
            return _items.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }

        public bool AddOrUpdate(Account input)
        {
            var exist = Find(input.AccountNumber);
            if (exist == null)
            {
                _items.Add(input);
                return true; // thêm mới
            }

            // Cập nhật
            exist.CustomerName = input.CustomerName;
            exist.Address = input.Address;
            exist.Money += input.Money; 
            return false; // cập nhật
        }

        public bool Remove(string accountNumber)
        {
            var exist = Find(accountNumber);
            if (exist == null) return false;
            _items.Remove(exist);
            return true;
        }

        public decimal TotalBalance()
        {
            return _items.Sum(a => a.Money);
        }

        public bool TryGet(string accountNumber, out Account account)
        {
            account = Find(accountNumber);
            return account != null;
        }
    }
}
