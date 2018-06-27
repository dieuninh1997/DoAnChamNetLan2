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
    public partial class FormNganh : Form
    {
        Bus_ChuyenNganh bcn = new Bus_ChuyenNganh();
        Entity_ChuyenNganh et = new Entity_ChuyenNganh();
        bool ktthem;
        public event EventHandler ButtonClick = null;

        public FormNganh()
        {
            InitializeComponent();
        }
      

        private void monut()
        {
            txtmacn.Enabled = true;
            txttencn.Enabled = true;
        }

        private void khoanut()
        {
            txtmacn.Enabled = false;
            txttencn.Enabled = false;
        }

        private void setnull()
        {
            txtmacn.Text = "";
            txttencn.Text = "";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bcn.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        private void FormNganh_Load(object sender, EventArgs e)
        {
            HienThi(dGVChuyenNganh, bdncn, "");
            khoanut();
        }

        private void btnnhaptt_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            monut();
            setnull();
            ktthem = true;
            txtmacn.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            monut();
            txtmacn.Enabled = false;
            btnxoa.Enabled = false;
            btnnhaptt.Checked = true;
            btntimtt.Enabled = false;
            ktthem = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaChuyenNganh = txtmacn.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bcn.xoadulieu(et);
                HienThi(dGVChuyenNganh, bdncn, "");
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
            et.MaChuyenNganh = txtmacn.Text;
            et.TenChuyenNganh = txttencn.Text;
            if (txtmacn.Text == "" || txttencn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monut();
            }
            else
            {

                if (ktthem == true)
                {
                    if (bcn.laydulieu("where MaChuyenNganh=N'" + et.MaChuyenNganh + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Chuyên ngành này đã tồn tại trong hệ thống. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            monut();
                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            bcn.themdulieu(et);
                            HienThi(dGVChuyenNganh, bdncn, "");
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
                        bcn.suadulieu(et);
                        HienThi(dGVChuyenNganh, bdncn, "");
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
            HienThi(dGVChuyenNganh, bdncn, "");
        }

        private void btntkcn_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemttcn.Text;
            if (chkTimTheoMasv.Checked)
                HienThi(dGVChuyenNganh, bdncn, "where MaChuyenNganh like N'%" + dieukien + "%'");
            else if (chkTimTheomamh.Checked)
                HienThi(dGVChuyenNganh, bdncn, "where TenChuyenNganh like N'%" + dieukien + "%'");

        }

        private void btntimtt_Click(object sender, EventArgs e)
        {
            btnnhaptt.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null)
                    ButtonClick(sender, e);
                else return;
        }

        private void dGVChuyenNganh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmacn.Text = dGVChuyenNganh.Rows[dong].Cells[0].Value.ToString();
            txttencn.Text = dGVChuyenNganh.Rows[dong].Cells[1].Value.ToString();

        }

        private void txtmacn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txttencn.Focus();
        }

        private void txttencn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu_Click(btnluu, e);
            else if (e.KeyCode == Keys.Up)
                txtmacn.Focus();
        }

        private void txtTimKiemttcn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntkcn_Click(btntkcn, e);
        }
    }
}
