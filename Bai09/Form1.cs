using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu cho ComboBox Chuyên Ngành
            cmbChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cmbChuyenNganh.Items.Add("Kỹ Thuật Phần Mềm");
            cmbChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cmbChuyenNganh.Items.Add("An Toàn Thông Tin");
            cmbChuyenNganh.Items.Add("Kỹ Thuật Máy Tính");
            cmbChuyenNganh.Items.Add("Khoa Học Dữ Liệu"); 
            cmbChuyenNganh.SelectedIndex = 0; // Chọn "Hệ Thống Thông Tin" làm mặc định

            // Tải dữ liệu cho ListBox Môn học gốc
            lstbMonChuaChon.Items.Add("Cơ Sở Dữ Liệu");
            lstbMonChuaChon.Items.Add("Cơ Sở DL Nâng Cao");
            lstbMonChuaChon.Items.Add("PTTK Hệ Thống thông tin");
            lstbMonChuaChon.Items.Add("Lập trình C#");
            lstbMonChuaChon.Items.Add("Mạng Máy Tính");
            lstbMonChuaChon.Items.Add("Nhập môn lập trình");
            lstbMonChuaChon.Items.Add("Xác xuất thống kê");
            lstbMonChuaChon.Items.Add("Cấu trúc rời rạc");
            lstbMonChuaChon.Items.Add("Cấu trúc dữ liệu và giải thuật"); 
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            // Dùng vòng lặp for ngược để tránh lỗi index khi xóa nhiều mục
            for (int i = source.SelectedItems.Count - 1; i >= 0; i--)
            {
                object item = source.SelectedItems[i];
                destination.Items.Add(item); // Thêm qua list bên kia
                source.Items.Remove(item);   // Xóa khỏi list hiện tại
            }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(lstbMonChuaChon, lstbMonDaChon);
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(lstbMonDaChon, lstbMonChuaChon);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào (validation)
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus(); // Di chuyển con trỏ chuột tới ô MSSV
                return; // Dừng hàm
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return; // Dừng hàm
            }

            // 2. Lấy thông tin
            string mssv = txtMSSV.Text;
            string hoTen = txtHoTen.Text;
            string chuyenNganh = cmbChuyenNganh.SelectedItem.ToString();
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ"; // Toán tử 3 ngôi
            int soMon = lstbMonDaChon.Items.Count;

            // 3. Thêm dữ liệu vào DataGridView
            dgvSinhVien.Rows.Add(mssv, hoTen, chuyenNganh, gioiTinh, soMon);

            // 4. Sau khi lưu, xóa các lựa chọn để chuẩn bị nhập mới
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Gọi hàm ClearForm
            ClearForm();
        }

        private void ClearForm()
        {
            // Xóa text
            txtMSSV.Text = "";
            txtHoTen.Text = "";

            // Reset về lựa chọn đầu tiên
            cmbChuyenNganh.SelectedIndex = 0;
            radNam.Checked = true;

            // Chuyển tất cả các môn đã chọn về lại list bên trái
            // (Chúng ta có thể dùng vòng lặp, hoặc gọi lại hàm MoveListBoxItems)

            // Tạm thời chọn tất cả các mục trong list bên phải
            lstbMonDaChon.SelectAll();
            // Gọi hàm di chuyển
            MoveListBoxItems(lstbMonDaChon, lstbMonChuaChon);

            // Đặt con trỏ chuột về ô MSSV để sẵn sàng nhập mới
            txtMSSV.Focus();
        }
    }
}
public static class ListBoxExtensions // hỗ trợ cho hàm chọn tất cả. 
{
    public static void SelectAll(this ListBox listBox)
    {
        for (int i = 0; i < listBox.Items.Count; i++)
        {
            listBox.SetSelected(i, true);
        }
    }
}