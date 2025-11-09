using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai07.Seat;

namespace Bai07
{
    public partial class Form1 : Form
    {

        const int Rows = 3, Cols = 5;
        List<Seat> seats = new List<Seat>();
        bool isPaid = true; 

        public Form1()
        {
            InitializeComponent();
            BuildSeats(); 
        }

        void BuildSeats()
        {
            int num = 1;
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    int price = 0; 
                    switch (r)
                    {
                        case 0: price = 5000; break;
                        case 1: price = 6500; break;
                        case 2: price = 8000; break;
                        default: price = 0; break; 
                    }

                    var seat = new Seat(num, r, price);
                    seats.Add(seat);

                    var btn = new Button()
                    {
                        Text = num.ToString(),
                        AutoSize = false,
                        BackColor = Color.White,
                        Tag = seat,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Dock = DockStyle.Fill,
                    };
                    btn.Click += Seat_Click;
                    tbSeats.Controls.Add(btn);
                    num++; 
                }
            }
        }

        void Seat_Click(object sender, EventArgs e)
        {

            // Nếu chưa thanh toán thì không cho chọn nữa
            if (!isPaid)
            {
                MessageBox.Show("Bạn chưa thanh toán, không thể chọn thêm ghế!");
                return;
            }


            Button b = (Button)sender;
            var s = (Seat)b.Tag;

            switch (s.State)
            {
                case SeatState.Available:
                    s.State = SeatState.Selected;
                    b.BackColor = Color.LightBlue;
                    break;
                case SeatState.Selected:
                    s.State = SeatState.Available;
                    b.BackColor = Color.White;
                    break;
                case SeatState.Sold:
                    MessageBox.Show($"Ghế {s.Number} đã bán!");
                    break;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            isPaid = false;
            int total = CalculateTotal(seats);
            foreach (var seat in seats)
            {
                if(seat.State == SeatState.Selected)
                {
                    seat.State = SeatState.Sold; 
                }
                
            }
            DoiMau();
            txtThanhTien.Text = total.ToString("N0") + " đ";
        }
        public int CalculateTotal(IEnumerable<Seat> seats)
        {
            int sum = 0;

            foreach (var seat in seats)
            {
                if (seat.State == SeatState.Selected )
                {
                    sum += seat.Price;
                }
            }

            return sum;
        }
        void DoiMau()
        {
            foreach (Control c in tbSeats.Controls)
            {
                Button btn = c as Button;
                if (btn == null)
                    continue;

                Seat seat = btn.Tag as Seat;
                if (seat == null)
                    continue;

                // Kiểm tra trạng thái ghế và đổi màu
                if (seat.State == SeatState.Available)
                {
                    btn.BackColor = Color.White;      // ghế trống
                }
                else if (seat.State == SeatState.Selected)
                {
                    btn.BackColor = Color.LightBlue;  // đang chọn
                }
                else if (seat.State == SeatState.Sold)
                {
                    btn.BackColor = Color.Gold;       // đã bán
                }
                else
                {
                    btn.BackColor = Color.White;
                }
            }
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            
            // Trả lại tất cả ghế đang chọn (Selected) về trạng thái trống (Available)
            foreach (var seat in seats)
            {
                if (seat.State == SeatState.Selected)
                {
                    seat.State = SeatState.Available;
                }
            }

            // Cập nhật lại màu sắc
            DoiMau();

            // Đặt lại tổng tiền
            txtThanhTien.Text = "0";

            // Cho phép chọn lại ghế (trường hợp trước đó đã nhấn chọn)
            isPaid = true;
        }

        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận với người dùng
            var result = MessageBox.Show("Bạn có chắc muốn thanh toán không?",
                                         "Xác nhận",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đặt trạng thái đã thanh toán
                isPaid = true;

                // Reset tổng tiền
                txtThanhTien.Text = "0";

                // Cập nhật lại giao diện nếu cần
                MessageBox.Show("Thanh toán thành công! Vé của bạn đã được xác nhận.");
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát
            var result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc và thoát chương trình không?",
                                         "Xác nhận thoát",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng
            }
        }
    }
}
