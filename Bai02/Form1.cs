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
        private Point textPosition;
        private bool _Draw = false;
        private string textToDraw = "Paint Event";
        private Font myFont = new Font("Snap ITC", 20, FontStyle.Bold);
        private Color textColor; 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Nhấn nút để vẽ tại ví trí bất kỳ";
            this.DoubleBuffered = true;
            textColor = Color.Black; 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPaint_Click(object sender, EventArgs e)
        {
            _Draw = true;

            int x = rd.Next(this.ClientSize.Width);
            int y = rd.Next(this.ClientSize.Height);

            textPosition = new Point(x, y);

            int r = rd.Next(256); 
            int g = rd.Next(256); 
            int b = rd.Next(256); 
            textColor = Color.FromArgb(r, g, b); 

            pnlCanvas.Invalidate(); 
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            if (_Draw)
            {
                using (Brush myBrush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(textToDraw, myFont, myBrush, textPosition);
                }
            }
        }
    }
}
