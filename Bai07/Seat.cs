using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    public class Seat
    {
        public int Number { get; set; }
        public int Row { get; set; }
        public int Price {  get; set; }
        public enum SeatState
        {
            Available,   // Ghế trống
            Selected,    // Đang chọn
            Sold         // Đã bán
        }
        public SeatState State { get; set; } = SeatState.Available;

        public Seat(int number, int row, int price)
        {
            Number = number;
            Row = row;
            Price = price;
        }
    }
}
