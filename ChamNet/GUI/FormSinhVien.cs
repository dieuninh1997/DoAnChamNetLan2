using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using ChamNet.BUS;
using ChamNet.DAL;

namespace ChamNet.GUI
{
    public partial class FormSinhVien : Form
    {
        Bus_SinhVien bsv = new Bus_SinhVien();
        Entity_SinhVien et = new Entity_SinhVien();
        bool ktthem;
        public event EventHandler ButtonClick = null;


        public FormSinhVien()
        {
            InitializeComponent();
        }


        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAll.tblLop' table. You can move, or remove it, as needed.
            //this.tblLopTableAdapter.Fill(this.dataSetAll.tblLop);

            HienThi(dGVSinhVien, bdnsv, "");
            btntimttsv.Enabled = true;
            khoanut();
        }
        public void HienThi(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bsv.laydulieu(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public void HienThiComBo(ComboBoxEx cb, string s)
        {
            cb.DataSource = bsv.layttlop(s);
            // cb.DisplayMember = "TenLop";
            //cb.ValueMember = "TenLop";
        }
        private void khoanut()
        {
            txtMasvthem.Enabled = false;
            txthosvthem.Enabled = false;
            txtTensvthem.Enabled = false;
            dtpNgaySinhthem.Enabled = false;
            cmbgtthem.Enabled = false;
            txtquethem.Enabled = false;
            cbotenlop.Enabled = false;
        }
        private void setnull()
        {
            txthosvthem.Text = "";
            txtTensvthem.Text = "";
            cmbgtthem.Text = "Nam";
            txtquethem.Text = "";
            cbomalop.Text = "001";
        }
        private void monut()
        {
            txtMasvthem.Enabled = false;
            txthosvthem.Enabled = true;
            txtTensvthem.Enabled = true;
            dtpNgaySinhthem.Enabled = true;
            cmbgtthem.Enabled = true;
            txtquethem.Enabled = true;
            cbotenlop.Enabled = true;
        }
        private void btnnhapttsv_Click(object sender, EventArgs e)
        {
            monut();
            setnull();
            HienThiComBo(cbotenlop, "");
            cbotenlop.DisplayMember = "TenLop";
            cbotenlop.ValueMember = "TenLop";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtMasvthem.Text = bsv.TaoMa();
            ktthem = true;
        }

        private void btntimttsv_Click(object sender, EventArgs e)
        {
            btnnhapttsv.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }
        private void btnTimKiemsv_Click(object sender, EventArgs e)
        {
            btnnhapttsv.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemttsv.Text;
            if (chkTimTheoMa.Checked)
                HienThi(dGVSinhVien, bdnsv, "where MaSV like N'%" + dieukien + "%'");
            else if (chkTimTheoTensv.Checked)
                HienThi(dGVSinhVien, bdnsv, "where TenSV like N'%" + dieukien + "%'");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimttsv.Enabled = true;
            if (txthosvthem.Text == "" || txtTensvthem.Text == "" || dtpNgaySinhthem.Text == "" || cmbgtthem.Text == "" || txtquethem.Text == "" || cbotenlop.Text == "")
            {
                if (MessageBox.Show("Xin nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    monut();
            }
            else
            {
                et.MaSV = txtMasvthem.Text;
                et.HoSV = txthosvthem.Text;
                et.TenSV = txtTensvthem.Text;
                et.NgaySinh = dtpNgaySinhthem.Value;
                btnnhapttsv.Enabled = true;
                if (cmbgtthem.Text == "Nam")
                    et.GioiTinh = true;
                else if (cmbgtthem.Text == "Nữ")
                    et.GioiTinh = false;
                et.QueQuan = txtquethem.Text;

                et.MaLop = cbomalop.Text;
                if (ktthem == true)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        bsv.themdulieu(et);
                        HienThi(dGVSinhVien, bdnsv, "");
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }
                else if (ktthem == false)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        bsv.suadulieu(et);
                        HienThi(dGVSinhVien, bdnsv, "");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ret == DialogResult.No)
                        return;
                    khoanut();
                }
            }
        }

        //btnThoat
        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            monut();
            HienThiComBo(cbotenlop, "");
            cbotenlop.DisplayMember = "TenLop";
            cbotenlop.ValueMember = "TenLop";
            btnxoa.Enabled = false;
            btnnhapttsv.Checked = true;
            btnnhapttsv.Enabled = false;
            ktthem = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaSV = txtMasvthem.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bsv.xoadulieu(et);
                HienThi(dGVSinhVien, bdnsv, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            HienThi(dGVSinhVien, bdnsv, "");
        }

        private void dGVSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMasvthem.Text = dGVSinhVien.Rows[dong].Cells[0].Value.ToString();
            txthosvthem.Text = dGVSinhVien.Rows[dong].Cells[1].Value.ToString();
            txtTensvthem.Text = dGVSinhVien.Rows[dong].Cells[2].Value.ToString();
            dtpNgaySinhthem.Text = dGVSinhVien.Rows[dong].Cells[3].Value.ToString();

            txtgioitinh.Text = dGVSinhVien.Rows[dong].Cells[4].Value.ToString();
            if (txtgioitinh.Text == "True")
                cmbgtthem.Text = "Nam";
            else if (txtgioitinh.Text == "False")
                cmbgtthem.Text = "Nữ";
            txtquethem.Text = dGVSinhVien.Rows[dong].Cells[5].Value.ToString();
            cbomalop.Text = dGVSinhVien.Rows[dong].Cells[6].Value.ToString();
            HienThiComBo(cbotenlop, "where MaLop=N'" + cbomalop.Text + "'");
            cbotenlop.DisplayMember = "TenLop";
            cbotenlop.ValueMember = "TenLop";
        }

        private void cbomalop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbotenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComBo(cbomalop, " where TenLop=N'" + cbotenlop.Text + "'");
            cbomalop.DisplayMember = "MaLop";
            cbomalop.ValueMember = "MaLop";
        }

        private void txthosvthem_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsNumber(txthosvthem.Text) == true)
            {
                DialogResult ret = MessageBox.Show("Họ đệm phải là ký tự", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ret == DialogResult.OK)
                    txthosvthem.Text = "";
            }
        }
        public bool IsNumber(string s)
        {
            char[] mang;
            mang = s.ToCharArray();
            char s1;

            for (int i = 0; i < s.Length; i++)
            {
                s1 = mang[i];
                if (Char.IsDigit(s1))
                    return true;
            }
            return false;

        }

        private void txtTensvthem_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsNumber(txtTensvthem.Text) == true)
            {
                DialogResult ret = MessageBox.Show("Tên sinh viên phải là ký tự", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ret == DialogResult.OK)
                    txtTensvthem.Text = "";
            }
        }

        private void txthosvthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtTensvthem.Focus();

        }

        private void dtpNgaySinhthem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cmbgtthem.Focus();
        }

        private void txtTensvthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                dtpNgaySinhthem.Focus();
        }

      
        private void cmbgtthem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //gioi tinh
        private void cmbgtthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtquethem.Focus();

        }

        private void txtquethem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cbotenlop.Focus();
        }

        private void cbotenlop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnluu_Click(btnluu, e);
        }

        private void btnTimKiemsv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiemsv_Click(btnTimKiemsv, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
