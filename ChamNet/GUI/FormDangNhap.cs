using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChamNet.BUS;
using ChamNet.DAL;

namespace ChamNet.GUI
{
    public partial class FormDangNhap : Form
    {
        Bus_NguoiDung bsngdung = new Bus_NguoiDung();
        Entity_NguoiDung et = new Entity_NguoiDung();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtMatKhau.Focus();
        }
        private void setnull()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            et.TaiKhoan = txtTaiKhoan.Text;
            et.MatKhau = txtMatKhau.Text;
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Xin moi nhap day du", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setnull();
                txtTaiKhoan.Focus();
            }
            else
            {
                if (bsngdung.laydulieu("where TaiKhoan=N'" + et.TaiKhoan + "' and MatKhau=N'" + et.MatKhau + "'").Rows.Count == 1)
                {
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Tài khoản,mật khẩu không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setnull();
                    txtTaiKhoan.Focus();
                }
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(btnDangNhap, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
