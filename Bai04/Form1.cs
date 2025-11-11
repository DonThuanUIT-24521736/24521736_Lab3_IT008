using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lấy kết quả màu mà người dùng chọn từ colorDialog. 
            DialogResult result = colorDialog1.ShowDialog(); 

            // chỉ thực hiện đổi màu khi người dùng nhấn OK. 
            if (result == DialogResult.OK)
            {
                Color selectColor = colorDialog1.Color;
                this.BackColor = selectColor; 
            }
        }
    }
}
