using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using ChamNet.BUS;
using ChamNet.DAL;

namespace ChamNet.GUI
{
    public partial class FormRenLuyen : Form
    {
        Bus_RenLuyen brl = new Bus_RenLuyen();
        Entity_RenLuyen et = new Entity_RenLuyen();
        bool ktthem;
        public event EventHandler ButtonClick = null;

        public FormRenLuyen()
        {
            InitializeComponent();
        }
        public void monut()
        {
            txtmasv.Enabled = true;
            cbonamhoc.Enabled = true;
            cborl.Enabled = true;
        }
        public void khoanut()
        {
            txtmasv.Enabled = false;
            cbonamhoc.Enabled = false;
            cborl.Enabled = false;
        }
        public void setnull()
        {
            txtmasv.Text = "";
            cbonamhoc.Text = "";
            cborl.Text = "Tốt";
        }
        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = brl.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        private void FormRenLuyen_Load(object sender, EventArgs e)
        {

            HienThi(dGVrenluyen, bdnrl, "");
            btnnhaptt.Checked = true;
            khoanut();
        }

        private void btnnhaptt_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            monut();
            setnull();
            ktthem = true;
            hienthicombo(cbonamhoc, "");
            cbonamhoc.DisplayMember = "NamHoc";
            cbonamhoc.ValueMember = "NamHoc";
            txtmasv.Text = "DH";
            txtmasv.Focus();
        }
        public void hienthicombo(ComboBoxEx cb, string s)
        {
            cb.DataSource = brl.layttnamhoc(s);
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            monut();
            txtmasv.Enabled = false;
            cbonamhoc.Enabled = false;
            btnxoa.Enabled = false;
            btnnhaptt.Checked = true;
            btntimtt.Enabled = false;
            ktthem = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaSV = txtmasv.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                brl.xoadulieu(et);
                HienThi(dGVrenluyen, bdnrl, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimtt.Enabled = true;
            btnnhaptt.Enabled = true;
            et.MaSV = txtmasv.Text;
            et.MaNamHoc = cbomanamhoc.Text;
            et.RenLuyen = cborl.Text;
            if (txtmasv.Text == "" || cbonamhoc.Text == "" || cborl.Text == "")
            {
                if (MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    monut();
            }
            else
            {
                if (ktthem == true)
                {
                    if (brl.laydulieu("where tblRenLuyen.MaSV=N'" + txtmasv.Text + "' and MaNamHoc=N'" + cbomanamhoc.Text + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Dữ liệu đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            monut();
                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            brl.themdulieu(et);
                            HienThi(dGVrenluyen, bdnrl, "");
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (ret == DialogResult.No)
                            return;
                        khoanut();
                    }

                }
                else if (ktthem == false)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        brl.suadulieu(et);
                        HienThi(dGVrenluyen, bdnrl, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            HienThi(dGVrenluyen, bdnrl, "");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }
        //tim kiem
        private void btntkrl_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemttrl.Text;
            if (chkTimTheomasv.Checked)
                HienThi(dGVrenluyen, bdnrl, "where MaSV like N'%" + dieukien + "%'");
            else if (chkTimTheonam.Checked)
                HienThi(dGVrenluyen, bdnrl, "where NamHoc like N'%" + dieukien + "%'");

        }

        private void btntimtt_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void dGVrenluyen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmasv.Text = dGVrenluyen.Rows[dong].Cells[0].Value.ToString();
            cbomanamhoc.Text = dGVrenluyen.Rows[dong].Cells[1].Value.ToString();
            hienthicombo(cbonamhoc, "where MaNamHoc=N'" + cbomanamhoc.Text + "'");
            cbonamhoc.DisplayMember = "NamHoc";
            cbonamhoc.ValueMember = "NamHoc";
            cborl.Text = dGVrenluyen.Rows[dong].Cells[2].Value.ToString();

        }

        private void txtmasv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cbonamhoc.Focus();
        }

        private void cbonamhoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cborl.Focus();
            else if (e.KeyCode == Keys.Up)
                txtmasv.Focus();
        }

        private void cbonamhoc_TextChanged(object sender, EventArgs e)
        {
            hienthicombo(cbomanamhoc, "where NamHoc=N'" + cbonamhoc.Text + "'");
            cbomanamhoc.DisplayMember = "MaNamHoc";
            cbomanamhoc.ValueMember = "MaNamHoc";
        }

        private void cborl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu_Click(btnluu, e);
        }

        private void txtTimKiemttrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntkrl_Click(btntkrl, e);
        }
    }

}
