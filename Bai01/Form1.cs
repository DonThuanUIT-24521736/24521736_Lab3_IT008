using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LogEvent("1. Constructor: Hàm dựng được gọi"); 
        }
        private void LogEvent(string eventName) // Hàm nhận tên event và đưa nó lên listBox. 
        {
            if(lstbEvents != null) // Kiểm tra xem listBox tên lsbtEvents đã tồn tại chưa. 
            {
                lstbEvents.Items.Add(eventName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("2. Load: Form đang được tải");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("3. Activated: Form được kích hoạt/focus");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("4. Shown: Form đã hiển thị");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            LogEvent("*. Deactivate: Form bị mất focus"); 
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("5. FormClosing: Form chuẩn bị đóng");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("6. FormClosed: Form đã đóng hoàn toàn!");
        }
        private void btnCreateChildForm_Click(object sender, EventArgs e)
        {
            LogEvent("=> Nhấn nút 'Tạo nút con' ");

            Form childForm = new Form();

            childForm.Text = "Đây là form con";
            childForm.Size = new System.Drawing.Size(400, 300);
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.ShowInTaskbar = false;

            childForm.Show(this); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        
    }
}
