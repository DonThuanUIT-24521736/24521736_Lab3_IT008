using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Minh họa sự kiện Paint";

            // Bật DoubleBuffered để giảm hiện tượng nhấp nháy
            this.DoubleBuffered = true;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Graphics từ sự kiện
            Graphics g = e.Graphics; 


            // 1. Tạo chuỗi và font
            string textToDraw = "Paint Event";
            Font myFont = new Font("Snap ITC", 20, FontStyle.Bold);

            // 2. Tạo màu ngẫu nhiên
            int r = rd.Next(256);
            int g_color = rd.Next(256); 
            int b = rd.Next(256);
            Color textColor = Color.FromArgb(r, g_color, b);

            // 3. Tạo vị trí ngẫu nhiên
            // Tính toán kích thước chữ để đảm bảo không vẽ ra ngoài
            SizeF textSize = g.MeasureString(textToDraw, myFont);
            int x = rd.Next(this.ClientSize.Width - (int)textSize.Width);
            int y = rd.Next(this.ClientSize.Height - (int)textSize.Height);
            Point textPosition = new Point(x, y);

            // 4. Vẽ chuỗi
            using (Brush myBrush = new SolidBrush(textColor))
            {
                g.DrawString(textToDraw, myFont, myBrush, textPosition);
            }
        }
        
    }
}
