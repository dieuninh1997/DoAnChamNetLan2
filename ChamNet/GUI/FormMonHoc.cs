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
    public partial class FormMonHoc : Form
    {
        Bus_MonHoc bmhoc = new Bus_MonHoc();
        Entity_MonHoc et = new Entity_MonHoc();
        bool ktthem;
        public event EventHandler ButtonClick = null;


        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            HienThi(dGVmonhoc, bdnmonhoc, "");
            khoanut();
            buttonItemNhapDuLieumon.Enabled = true;
            btntimkiemds.Visible = false;
        }
        private void monut()
        {
            txtmamonthem.Enabled = true;
            txttenmonthem.Enabled = true;
            txtsotcthem.Enabled = true;
        }
        private void khoanut()
        {
            txtmamonthem.Enabled = false;
            txttenmonthem.Enabled = false;
            txtsotcthem.Enabled = false;
        }

        private void setnull()
        {
            txtmamonthem.Text = "";
            txttenmonthem.Text = "";
            txtsotcthem.Text = "";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bmhoc.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        private void buttonItemNhapDuLieumon_Click(object sender, EventArgs e)
        {
            monut();
            setnull();
            btnsuamon.Enabled = false;
            btnxoamon.Enabled = false;
            ktthem = true;
        }

        private void btnsuamon_Click(object sender, EventArgs e)
        {
            monut();
            btnxoa.Enabled = false;
            buttonItemNhapDuLieumon.Checked = true;
            buttonItemNhapDuLieumon.Enabled = false;
            ktthem = false;
        }

        private void btnrefreshmon_Click(object sender, EventArgs e)
        {
            HienThi(dGVmonhoc, bdnmonhoc, "");
        }

        private void btnluumon_Click(object sender, EventArgs e)
        {
            btnsuamon.Enabled = true;
            btnxoamon.Enabled = true;
            buttonItemNhapDuLieumon.Enabled = true;
            if (txtmamonthem.Text == "" || txttenmonthem.Text == "" || txtsotcthem.Text == "")
            {
                if (MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    monut();
            }
            else
            {
                et.MaMH = txtmamonthem.Text;
                et.TenMH = txttenmonthem.Text;
                et.SoTC = Convert.ToInt32(txtsotcthem.Text);
                if (ktthem == true)
                {
                    if (bmhoc.laydulieu("where MaMH=N'" + et.MaMH + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Mã môn học này đã tồn tại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            monut();

                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            bmhoc.themdulieu(et);
                            HienThi(dGVmonhoc, bdnmonhoc, "");
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
                        bmhoc.suadulieu(et);
                        HienThi(dGVmonhoc, bdnmonhoc, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }

            }

        }

        private void btnxoamon_Click(object sender, EventArgs e)
        {
            et.MaMH = txtmamonthem.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bmhoc.xoadulieu(et);
                HienThi(dGVmonhoc, bdnmonhoc, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }

        private void buttonItemTimKiemmon_Click(object sender, EventArgs e)
        {
            buttonItemNhapDuLieumon.Enabled = false;
            btnsuamon.Enabled = false;
            btnluumon.Enabled = false;
            btnxoamon.Enabled = false;
        }

        private void btnTimKiemmon_Click(object sender, EventArgs e)
        {
            buttonItemNhapDuLieumon.Enabled = true;
            btnsuamon.Enabled = true;
            btnluumon.Enabled = true;
            btnxoamon.Enabled = true;
            string dieukien = txtTimKiemmon.Text;
            if (chkTimTheoMamon.Checked)
                HienThi(dGVmonhoc, bdnmonhoc, "where MaMH like N'%" + dieukien + "%'");
            else if (chkTimTheoTenmon.Checked)
                HienThi(dGVmonhoc, bdnmonhoc, "where TenMH like N'%" + dieukien + "%'");


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }

        private void dGVmonhoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmamonthem.Text = dGVmonhoc.Rows[dong].Cells[0].Value.ToString();
            txttenmonthem.Text = dGVmonhoc.Rows[dong].Cells[1].Value.ToString();
            txtsotcthem.Text = dGVmonhoc.Rows[dong].Cells[2].Value.ToString();

        }

        private void txtmamonthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txttenmonthem.Focus();
        }

        private void txttenmonthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtsotcthem.Focus();
        }

        private void txtsotcthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluumon_Click(btnluumon, e);
        }
        public bool IsNumber(string s)
        {
            char[] mang;
            mang = s.ToCharArray();
            char s1;
            bool kt = true;
            for (int i = 0; i < s.Length; i++)
            {
                s1 = mang[i];
                if (Char.IsDigit(s1))
                    kt = true;
                else kt = false;
            }
            return kt;

        }
        private void txtsotcthem_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsNumber(txtsotcthem.Text) == false && txtsotcthem.Text != "")
            {
                if (MessageBox.Show("Số tín chỉ phải là số tự nhiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    txtsotcthem.Text = "";
            }
        }

        private void btnTimKiemmon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiemmon_Click(btnTimKiemmon, e);
        }

        private void btntimkiemds_Click(object sender, EventArgs e)
        {
            buttonItemNhapDuLieumon.Enabled = false;
            btnsuamon.Enabled = false;
            btnluumon.Enabled = false;
            btnxoamon.Enabled = false;
            string dieukien = txtTimKiemmon.Text;
            if (chkTimTheoMamon.Checked)
                HienThi(dGVmonhoc, bdnmonhoc, "where MaMH like N'%" + dieukien + "%'");
            else if (chkTimTheoTenmon.Checked)
                HienThi(dGVmonhoc, bdnmonhoc, "where TenMH like N'%" + dieukien + "%'");

        }
    }
}
