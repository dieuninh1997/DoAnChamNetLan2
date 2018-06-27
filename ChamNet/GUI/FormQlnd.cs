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
using ChamNet.GUI;

namespace ChamNet.GUI
{
    public partial class FormQlnd : Form
    {

        Bus_NguoiDung bndung = new Bus_NguoiDung();
        Entity_NguoiDung et = new Entity_NguoiDung();
        bool ktthem;
        public event EventHandler ButtonClick = null;

        public FormQlnd()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimtt.Enabled = true;
            btnNhaptt.Enabled = true;

            if (txtTaiKhoan.Text == "" || txtMk.Text == "" || cboloaind.Text == "")
            {
                if (MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    moNut();
            }
            else
            {
                et.TaiKhoan = txtTaiKhoan.Text;
                et.TenNguoiDung = txtTennd.Text;
                et.MatKhau = txtMk.Text;
                et.LoaiNguoiDung = cboloaind.Text;
                et.MaXacNhan = txtmaxn.Text;
                if (ktthem == true)
                {
                    if (bndung.laydulieu("where TaiKhoan=N'" + txtTaiKhoan + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            moNut();

                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            bndung.themdulieu(et);
                            hienThi(dgvNguoidung, bdnnd, "");
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (ret == DialogResult.No)
                            return;
                        khoaNut();
                    }

                }
                else if (ktthem == false)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        bndung.suadulieu(et);
                        hienThi(dgvNguoidung, bdnnd, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoaNut();
                }

            }
        }
        private void FormQlnd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAll.tblChuyenNganh' table. 
            //You can move, or remove it, as needed.
            // this.tblChuyenNganhTableAdapter.Fill(this.dataSetAll.tblChuyenNganh);
            hienThi(dgvNguoidung, bdnnd, "");
            khoaNut();
        }
        private void khoaNut()
        {
            txtTaiKhoan.Enabled = false;
            txtMk.Enabled = false;
            txtTennd.Enabled = false;
            cboloaind.Enabled = false;
            txtmaxn.Enabled = false;
        }
        public void hienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bndung.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        private void moNut()
        {
            txtTaiKhoan.Enabled = true;
            txtMk.Enabled = true;
            txtTennd.Enabled = true;
            cboloaind.Enabled = true;
            txtmaxn.Enabled = true;
        }
        private void setNull()
        {
            txtTaiKhoan.Text = "";
            txtMk.Text = "";
            txtTennd.Text = "";
            cboloaind.Text = "";
            txtmaxn.Text = "";
        }
        private void btnNhaptt_Click(object sender, EventArgs e)
        {
            btnTimtt.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            moNut();
            setNull();
            txtTaiKhoan.Focus();
            ktthem = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi(dgvNguoidung, bdnnd, "");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            et.TaiKhoan = txtTaiKhoan.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bndung.xoadulieu(et);
                hienThi(dgvNguoidung, bdnnd, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            ktthem = false;
            moNut();
            btnNhaptt.Enabled = false;
            btnTimtt.Enabled = false;
            btnXoa.Enabled = false;
            txtmaxn.Enabled = false;
            txtTaiKhoan.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimtt_Click(object sender, EventArgs e)
        {
            btnNhaptt.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTknd_Click(object sender, EventArgs e)
        {
            btnNhaptt.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            string dieukien = txtTimKiemtt.Text;
            if (chkTimTheotk.Checked)
                hienThi(dgvNguoidung, bdnnd, "where TaiKhoan like N'%" + dieukien + "%'");
            else if (chkTimTheoloaind.Checked)
                hienThi(dgvNguoidung, bdnnd, "where LoaiNguoiDung like N'%" + dieukien + "%'");

        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtTennd.Focus();
        }

        private void txtTennd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtMk.Focus();
            else if (e.KeyCode == Keys.Up)
                txtTaiKhoan.Focus();
        }

        private void txtMk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cboloaind.Focus();
            else if (e.KeyCode == Keys.Up)
                txtMk.Focus();
        }

        private void cboloaind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtmaxn.Focus();
            else if (e.KeyCode == Keys.Up)
                txtMk.Focus();
        }

        private void txtmaxn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu_Click(btnLuu, e);
        }

        private void dgvNguoidung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTaiKhoan.Text = dgvNguoidung.Rows[dong].Cells[0].Value.ToString();
            txtTennd.Text = dgvNguoidung.Rows[dong].Cells[4].Value.ToString();
            txtMk.Text = dgvNguoidung.Rows[dong].Cells[1].Value.ToString();
            cboloaind.Text = dgvNguoidung.Rows[dong].Cells[2].Value.ToString();
            txtmaxn.Text = dgvNguoidung.Rows[dong].Cells[3].Value.ToString();

        }
    }
}
