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
using DevComponents.DotNetBar.Controls;

namespace ChamNet.GUI
{
    public partial class FormLopHoc : Form
    {
        Bus_Lop blop = new Bus_Lop();
        Entity_Lop et = new Entity_Lop();
        bool ktthem;
        public event EventHandler ButtonClick = null;

        public FormLopHoc()
        {
            InitializeComponent();
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAll.tblChuyenNganh' table. You can move, or remove it, as needed.
            //this.tblChuyenNganhTableAdapter.Fill(this.dataSetAll.tblChuyenNganh);
            // TODO: This line of code loads data into the 'dataSetAll.tblLop' table. You can move, or remove it, as needed.
            //this.tblLopTableAdapter.Fill(this.dataSetAll.tblLop);
            //btnTimKiemlop.Enabled = false;
            HienThi(dGVLop, bdnlop, "");
            khoanut();
        }
        private void monut()
        {
            txtMalopthem.Enabled = true;
            txtTenlopthem.Enabled = true;
            cbochuyennganh.Enabled = true;
            txtsiso.Enabled = true;
        }

        private void khoanut()
        {
            txtMalopthem.Enabled = false;
            txtTenlopthem.Enabled = false;
            cbochuyennganh.Enabled = false;
            txtsiso.Enabled = false;
        }

        private void setnull()
        {
            txtMalopthem.Text = "";
            txtTenlopthem.Text = "";
            cbochuyennganh.Text = "Công nghệ thông tin";
            txtsiso.Text = "";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = blop.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        private void hienthicombo(ComboBoxEx cb, string s)
        {
            cb.DataSource = blop.layttchuyennganh(s);
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            monut();
            txtMalopthem.Enabled = false;
            btnxoa.Enabled = false;
            buttonItemNhapDuLieulop.Checked = true;
            buttonItemNhapDuLieulop.Enabled = false;
            ktthem = false;
        }

        private void dGVLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMalopthem.Text = dGVLop.Rows[dong].Cells[0].Value.ToString();
            txtTenlopthem.Text = dGVLop.Rows[dong].Cells[1].Value.ToString();
            cbomacn.Text = dGVLop.Rows[dong].Cells[2].Value.ToString();
            txtsiso.Text = dGVLop.Rows[dong].Cells[3].Value.ToString();
            hienthicombo(cbochuyennganh, "where MaChuyenNganh=N'" + cbomacn.Text + "'");
            cbochuyennganh.DisplayMember = "TenChuyenNganh";
            cbochuyennganh.ValueMember = "TenChuyenNganh";

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            HienThi(dGVLop, bdnlop, "");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaLop = txtMalopthem.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                blop.xoadulieu(et);
                HienThi(dGVLop, bdnlop, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }

        private void buttonItemTimKiemlop_Click(object sender, EventArgs e)
        {
            buttonItemNhapDuLieulop.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnTimKiemlop_Click(object sender, EventArgs e)
        {
            buttonItemNhapDuLieulop.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemlop.Text;
            if (chkTimTheoMalop.Checked)
                HienThi(dGVLop, bdnlop, "where MaLop like N'%" + dieukien + "%'");
            else if (chkTimTheoTenlop.Checked)
                HienThi(dGVLop, bdnlop, "where TenLop like N'%" + dieukien + "%'");

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            buttonItemNhapDuLieulop.Enabled = true;
            if (txtMalopthem.Text == "" || txtTenlopthem.Text == "" || cbochuyennganh.Text == "" || txtsiso.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monut();
            }
            else
            {

                et.MaLop = txtMalopthem.Text;
                et.TenLop = txtTenlopthem.Text;
                et.SiSo = int.Parse(txtsiso.Text);
                et.MaChuyenNganh = cbomacn.Text;
                if (ktthem == true)
                {
                    if (blop.laydulieu("where MaLop=N'" + et.MaLop + "'").Rows.Count != 0)
                    {
                        if (MessageBox.Show("Mã lớp đã tồn tại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            monut();
                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret == DialogResult.Yes)
                        {
                            blop.themdulieu(et);
                            HienThi(dGVLop, bdnlop, "");
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
                        blop.suadulieu(et);
                        HienThi(dGVLop, bdnlop, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }
            }


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }

        private void cbochuyennganh_TextChanged(object sender, EventArgs e)
        {
            hienthicombo(cbomacn, "where TenChuyenNganh=N'" + cbochuyennganh.Text + "'");
            cbomacn.DisplayMember = "MaChuyenNganh";
            cbomacn.ValueMember = "MaChuyenNganh";
        }

        private void buttonItemNhapDuLieulop_Click(object sender, EventArgs e)
        {
            monut();
            //txtMalopthem.Enabled = true;
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            ktthem = true;
            hienthicombo(cbochuyennganh, "");
            cbochuyennganh.DisplayMember = "TenChuyenNganh";
            cbochuyennganh.ValueMember = "MaChuyenNganh";
        }

        private void txtMalopthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtTenlopthem.Focus();
        }

        private void txtTenlopthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cbochuyennganh.Focus();
        }

        private void cbochuyennganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// && IsNumber(txtsiso.Text)==true ||txtsiso.Text !="")
                btnluu_Click(btnluu, e);
        }

        private void btnTimKiemlop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiemlop_Click(btnTimKiemlop, e);
        }

        private void txtsiso_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtsiso.Text != "" && IsNumber(txtsiso.Text) == false)
            {
                if (MessageBox.Show("Sĩ số phải là số tự nhiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    txtsiso.Text = "";
            }
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
    }
}
