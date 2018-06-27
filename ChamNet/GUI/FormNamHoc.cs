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
    public partial class FormNamHoc : Form
    {

        Bus_NamHoc bnh = new Bus_NamHoc();
        Entity_NamHoc et = new Entity_NamHoc();
        bool ktthem;
        public event EventHandler ButtonClick = null;


        public FormNamHoc()
        {
            InitializeComponent();
        }
        public void monut()
        {
            txtmanh.Enabled = true;
            txtnh.Enabled = true;
        }
        public void khoanut()
        {
            txtmanh.Enabled = false;
            txtnh.Enabled = false;
        }
        public void setnull()
        {
            txtmanh.Text = "";
            txtnh.Text = "";
        }
        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bnh.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        private void FormNamHoc_Load(object sender, EventArgs e)
        {
            HienThi(dGVnamhoc, bdnnh, "");
            btnnhaptt.Checked = true;
            khoanut();
        }

        private void btnnhaptt_Click(object sender, EventArgs e)
        {
            monut();
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            ktthem = true;
            txtmanh.Focus();
        }

        private void btntknh_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemtt.Text;
            if (chkTimTheomanh.Checked)
                HienThi(dGVnamhoc, bdnnh, "where MaNamHoc like N'%" + dieukien + "%'");
            else if (chkTimTheonh.Checked)
                HienThi(dGVnamhoc, bdnnh, "where NamHoc like N'%" + dieukien + "%'");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaNamHoc = txtmanh.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bnh.xoadulieu(et);
                HienThi(dGVnamhoc, bdnnh, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }

        private void dGVnamhoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmanh.Text = dGVnamhoc.Rows[dong].Cells[0].Value.ToString();
            txtnh.Text = dGVnamhoc.Rows[dong].Cells[1].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            monut();
            btnnhaptt.Enabled = false;
            btnnhaptt.Checked = true;
            ktthem = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimtt.Enabled = true;
            btnnhaptt.Enabled = true;

            if (txtnh.Text == "" || txtmanh.Text == "")
            {
                if (MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    monut();
            }
            else
            {
                et.MaNamHoc = txtmanh.Text;
                et.NamHoc = txtnh.Text;
                if (ktthem == true)
                {
                    if (bnh.laydulieu("where MaMH=N'" + txtnh.Text + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Năm học này đã tồn tại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            monut();

                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            bnh.themdulieu(et);
                            HienThi(dGVnamhoc, bdnnh, "");
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
                        bnh.suadulieu(et);
                        HienThi(dGVnamhoc, bdnnh, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }
            }
        }

        private void txtmanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                txtnh.Focus();
        }

        private void txtnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu_Click(btnluu, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }
    }
}
