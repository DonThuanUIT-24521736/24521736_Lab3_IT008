using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private readonly AccountService acv = new AccountService();
        public Form1()
        {
            InitializeComponent();

        }
        private bool ValidateInputs(out string message)
        {
            message = "";

            if (string.IsNullOrWhiteSpace(txtSoTK.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                message = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            decimal value;
            if (!decimal.TryParse(txtSoTien.Text.Trim(),
                                  NumberStyles.Number,
                                  CultureInfo.InvariantCulture,
                                  out value) || value < 0)
            {
                message = "Số tiền không hợp lệ!";
                return false;
            }
            return true;
        }
        private Account BuildAccountFromInputs()
        {
            decimal balance = decimal.Parse(txtSoTien.Text.Trim(),
                                            NumberStyles.Number,
                                            CultureInfo.InvariantCulture);

            return new Account(
                txtSoTK.Text.Trim(),
                txtTen.Text.Trim(),
                txtDiaChi.Text.Trim(),
                balance
            );
        }
        private void RenderListView()
        {
            lsvTaiKhoans.BeginUpdate();
            lsvTaiKhoans.Items.Clear();

            int idx = 1;
            foreach (var a in acv.Items)
            {
                var item = new ListViewItem(idx.ToString());
                item.SubItems.Add(a.AccountNumber);
                item.SubItems.Add(a.CustomerName);
                item.SubItems.Add(a.Address);
                item.SubItems.Add(a.Money.ToString("N0"));
                item.Tag = a.AccountNumber; // để tra ngược khi cần
                lsvTaiKhoans.Items.Add(item);
                idx++;
            }

            lsvTaiKhoans.EndUpdate();
        }
        private void UpdateTotalLabel()
        {
            txtTongTien.Text = acv.TotalBalance().ToString("N0");
        }
        private void ClearInputs()
        {
            txtSoTK.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
            txtSoTK.Focus();
        }
        private void FillInputsFromSelectedItem()
        {
            if (lsvTaiKhoans.SelectedItems.Count == 0) return;

            var sel = lsvTaiKhoans.SelectedItems[0];
            txtSoTK.Text = sel.SubItems[1].Text;
            txtTen.Text = sel.SubItems[2].Text;
            txtDiaChi.Text = sel.SubItems[3].Text;

            // Bỏ dấu phẩy ngăn cách nghìn trước khi đưa lại vào textbox
            txtSoTien.Text = sel.SubItems[4].Text.Replace(",", "");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string msg;
            if (!ValidateInputs(out msg))
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var acc = BuildAccountFromInputs();
            bool isNew = acv.AddOrUpdate(acc);

            RenderListView();
            UpdateTotalLabel();
            ClearInputs();
            MessageBox.Show(isNew ? "Thêm mới dữ liệu thành công!"
                                  : "Cập nhật dữ liệu thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string accountNumber = txtSoTK.Text.Trim();
            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var exist = acv.Find(accountNumber);
            if (exist == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ask = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản " + accountNumber + "?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                acv.Remove(accountNumber);
                RenderListView();
                UpdateTotalLabel();
                MessageBox.Show("Xóa tài khoản thành công.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Bạn có chắc muốn thoát?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lsvTaiKhoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInputsFromSelectedItem();
        }
    }
}
