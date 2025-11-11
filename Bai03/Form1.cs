using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        // Khai báo đối tượng random. 
        // đối tượng này được tạo 1 lần duy nhất. 
        private Random random = new Random(); 
        public Form1()
        {
            InitializeComponent();
        }


        // Hàm được gọi khi nhấn nút 'btnChangeColor'. 
        private void btnChangeColor_Click(object sender, EventArgs e) 
        {
            // lấy ba màu đỏ, xanh lục, xanh nước biển ngẫu nhiên. 
            int red = random.Next(256); 
            int green = random.Next(256);
            int blue = random.Next(256);

            // Hàm FromArgb giống như việc pha 3 màu đỏ, xanh lá, xanh nước biển để tạo ra màu mới. 
            Color newcolor = Color.FromArgb(red, green, blue); 


            this.BackColor = newcolor; 
        }

        
    }
}
