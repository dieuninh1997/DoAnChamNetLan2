using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamNet.GUI
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtReNPassword.Text == "" || txtmaxacnhan.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtReNPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtmaxacnhan.Focus();
            else if (e.KeyCode == Keys.Up)
                txtNewPassword.Focus();
        }

        private void txtmaxacnhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDongY_Click(btnDongY, e);
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtReNPassword.Focus();
            else if (e.KeyCode == Keys.Up)
                txtOldPassword.Focus();
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtNewPassword.Focus();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
