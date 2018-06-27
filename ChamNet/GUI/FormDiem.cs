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
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ChamNet.GUI
{
    public partial class FormDiem : Form
    {
        Bus_Diem bdiem = new Bus_Diem();
        Entity_Diem et = new Entity_Diem();
        bool ktthem;
    //    public event EventHandler ButtonClick = null;


        public FormDiem()
        {
            InitializeComponent();
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            HienThiDSSinhVien(dvgsinhvien, bdndiem, "");
            khoanut();
            btntimkiemds.Visible = false;
        }
        private void monut()
        {
            txtdiemccthem.Enabled = true;
            txtdiemkt1them.Enabled = true;
            txtdiemkt1them.Enabled = true;
            txtdiemkt2.Enabled = true;
            txtdiemghpthem.Enabled = true;
            txtthihethpthem.Enabled = true;
            txtdiemtbthem.Enabled = false;
        }
        private void setnull()
        {
            txtMasvthemdiem.Text = "";
            cbonamhoc.Text = "";
            cbomamon.Text = "";
            cbotinchi.Text = "";

            txtdiemccthem.Text = "";
            txtdiemkt1them.Text = "";
            txtdiemkt1them.Text = "";
            txtdiemkt2.Text = "";
            txtdiemghpthem.Text = "";
            txtthihethpthem.Text = "";
            txtdiemtbthem.Text = "";
        }

        public void khoanut()
        {
            txtMasvthemdiem.Enabled = false;
            cbonamhoc.Enabled = false;
            cbomamon.Enabled = false;
            cbotinchi.Enabled = false;
            txtdiemccthem.Enabled = false;
            txtdiemkt1them.Enabled = false;
            txtdiemkt1them.Enabled = false;
            txtdiemkt2.Enabled = false;
            txtdiemghpthem.Enabled = false;
            txtthihethpthem.Enabled = false;
            txtdiemtbthem.Enabled = false;
        }
        public void HienThiDSSinhVien(DataGridView dGV, BindingNavigator bN, string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bdiem.layttsinhvien(dieukien);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public void hienthicombo(ComboBoxEx cb, string s)
        {
            cb.DataSource = bdiem.layttmonhoc(s);
        }
        private void btnnhapttdiem_Click(object sender, EventArgs e)
        {

            setnull();

            txtMasvthemdiem.Enabled = true;
            cbomamon.Enabled = true;
            cbotinchi.Enabled = false;
            cbonamhoc.Enabled = true;
            monut();
            cbonamhoc.Text = "";
            hienthicombo(cbomamon, "");
            cbomamon.DisplayMember = "MaMH";
            cbomamon.ValueMember = "MaMH";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            ktthem = true;
            cbonamhoc.DataSource = bdiem.layttnamhoc("");
            cbonamhoc.DisplayMember = "NamHoc";
            cbonamhoc.ValueMember = "MaNamHoc";
            txtMasvthemdiem.Text = "DH";
            txtMasvthemdiem.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            monut();
            txtMasvthemdiem.Enabled = false;
            cbomamon.Enabled = false;
            cbotinchi.Enabled = false;
            cbonamhoc.Enabled = false;
            btnxoa.Enabled = false;
            btnnhapttdiem.Checked = true;
            btnnhapttdiem.Enabled = false;
            ktthem = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            HienThiDSSinhVien(dvgsinhvien, bdndiem, "");
        }
        public void hienthidsdiem(string dieukien)
        {
            dgvdiem.DataSource = bdiem.laydulieu(dieukien);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimttsv.Enabled = true;
            btnnhapttdiem.Enabled = true;
            if (cbonamhoc.Text == "" || cbomamon.Text == "" || txtdiemccthem.Text == "" || txtdiemkt1them.Text == "" || txtdiemkt2.Text == "" || txtthihethpthem.Text == "")
            {
                if (MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
                    monut();
            }
            else
            {
                et.MaSV = txtMasvthemdiem.Text;
                et.MaMH = cbomamon.Text;
                et.MaNamHoc = cbomanam.Text;
                et.DiemCC = float.Parse(txtdiemccthem.Text);
                et.DiemKT1 = float.Parse(txtdiemkt1them.Text);
                et.DiemKT2 = float.Parse(txtdiemkt2.Text);
                if (int.Parse(cbotinchi.Text) <= 2)
                    et.DiemGK = 0;
                else if (int.Parse(cbotinchi.Text) >= 3)
                    et.DiemGK = float.Parse(txtdiemghpthem.Text);
                et.DiemThi = float.Parse(txtthihethpthem.Text);
                if (txtdiemccthem.Text == "" || txtdiemkt1them.Text == "" || txtdiemkt2.Text == "" || txtthihethpthem.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    monut();
                }
                else
                {
                    if (ktthem == true)
                    {
                        if (bdiem.laydulieu("where tblDiem.MaSV=N'" + et.MaSV + "' and tblDiem.MaMH=N'" + et.MaMH + "'").Rows.Count != 0)
                        {
                            if (MessageBox.Show("Dữ liệu đã tồn tại trong hệ thống. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                                monut();
                        }
                        else
                        {
                            DialogResult ret = MessageBox.Show("Bạn có muốn lưu thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (ret == DialogResult.Yes)
                            {
                                bdiem.themdulieu(et);
                                hienthidsdiem("where tblDiem.MaSV=N'" + txtMasvthemdiem.Text + "' and tblNamHoc.NamHoc=N'" + cbonamhoc.Text + "'");
                                HienThiDSSinhVien(dvgsinhvien, bdndiem, "");
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
                            bdiem.suadulieu(et);

                            hienthidsdiem("where tblDiem.MaSV=N'" + txtMasvthemdiem.Text + "' and tblNamHoc.NamHoc=N'" + cbonamhoc.Text + "'");
                            HienThiDSSinhVien(dvgsinhvien, bdndiem, "");
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else if (ret == DialogResult.No)
                            return;
                        khoanut();

                    }
                }
            }

        }

        private void btntimttsv_Click(object sender, EventArgs e)
        {
            btnnhapttdiem.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void dstimkiem(string dieukien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = bdiem.timkiem(dieukien);
            bdndiem.BindingSource = bS;
            dvgsinhvien.DataSource = bS;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            et.MaSV = txtMasvthemdiem.Text;
            et.MaMH = cbomamon.Text;
            et.MaNamHoc = cbonamhoc.Text;
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                bdiem.xoadulieu(et);

                hienthidsdiem("where tblDiem.MaSV=N'" + et.MaSV + "' and tblNamHoc.NamHoc=N'" + et.MaNamHoc + "'");
                HienThiDSSinhVien(dvgsinhvien, bdndiem, "");
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ret == DialogResult.No)
                return;

        }

        private void btntkdiem_Click(object sender, EventArgs e)
        {
            btnnhapttdiem.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            string dieukien = txtTimKiemttsv.Text;
            if (chkTimTheoMasv.Checked)
                //HienThiDSSinhVien(dvgsinhvien, bdndiem, " where tblSinhVien.MaSV like N'%" + dieukien + "%'");
                dstimkiem(" where tblSinhVien.MaSV like N'%" + dieukien + "%'");
            else if (chkTimTheomamh.Checked)

                dstimkiem(" where vw_diemht.MaMH like N'%" + dieukien + "%' ");
            //HienThiDSSinhVien(dvgsinhvien, bdndiem, " where MaMH like N'%" + dieukien + "%'");

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                this.Close();
            else if (ret == DialogResult.No)
                return;
        }

        private void dvgsinhvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMasvthemdiem.Text = dvgsinhvien.Rows[dong].Cells[0].Value.ToString();
            cbonamhoc.Text = dvgsinhvien.Rows[dong].Cells[3].Value.ToString();
            hienthidsdiem("where tblDiem.MaSV=N'" + txtMasvthemdiem.Text + "' and tblNamHoc.NamHoc=N'" + cbonamhoc.Text + "'");
            if (dgvdiem.RowCount == 0)
            {
                cbomamon.Text = "";
                cbotinchi.Text = "";
                txtdiemccthem.Text = "";
                txtdiemkt1them.Text = "";
                txtdiemkt2.Text = "";
                txtdiemghpthem.Text = "";
                txtthihethpthem.Text = "";
                txtdiemtbthem.Text = "";
            }

        }

        private void txtdiemccthem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiemccthem.Text != "" && kiemtraso(txtdiemccthem.Text) == true)
            {
                if (float.Parse(txtdiemccthem.Text) > 10 || float.Parse(txtdiemccthem.Text) < 0)
                {
                    {
                        DialogResult ret = MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (ret == DialogResult.OK)
                            txtdiemccthem.Text = "";
                    }

                }
            }
        }
        public bool kiemtraso(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txtdiemccthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtdiemccthem.Text != "" && kiemtraso(txtdiemccthem.Text) == true)
            {
                if (float.Parse(txtdiemccthem.Text) > 10 || float.Parse(txtdiemccthem.Text) < 0)
                {
                    txtdiemccthem.Text = "";
                }
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtdiemkt1them.Focus();
            else if (e.KeyCode == Keys.Up)
                cbomamon.Focus();
        }

        private void dgvdiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cbomamon.Text = dgvdiem.Rows[dong].Cells[0].Value.ToString();
            cbotinchi.Text = dgvdiem.Rows[dong].Cells[2].Value.ToString();
            txtdiemccthem.Text = dgvdiem.Rows[dong].Cells[3].Value.ToString();
            txtdiemkt1them.Text = dgvdiem.Rows[dong].Cells[4].Value.ToString();
            txtdiemkt2.Text = dgvdiem.Rows[dong].Cells[5].Value.ToString();
            txtdiemghpthem.Text = dgvdiem.Rows[dong].Cells[6].Value.ToString();
            txtthihethpthem.Text = dgvdiem.Rows[dong].Cells[7].Value.ToString();
            txtdiemtbthem.Text = dgvdiem.Rows[dong].Cells[8].Value.ToString();

        }

        private void cbomamon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbomamon_TextChanged(object sender, EventArgs e)
        {
            hienthicombo(cbotinchi, "where MaMH=N'" + cbomamon.Text + "'");
            cbotinchi.DisplayMember = "SoTC";
            cbotinchi.ValueMember = "SoTC";
        }

        //diem giưa kỳ
        private void txtdiemghpthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.Parse(cbotinchi.Text) <= 2)
            {
                MessageBox.Show("Không được nhập vì môn này có 2 tín chỉ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiemghpthem.Text = "";
                txtthihethpthem.Focus();
            }
            if (txtdiemghpthem.Text != "" && kiemtraso(txtdiemghpthem.Text) == true)
            {
                if (float.Parse(txtdiemghpthem.Text) > 10 || float.Parse(txtdiemghpthem.Text) < 0)
                    txtdiemghpthem.Text = "";
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtthihethpthem.Focus();
            else if (e.KeyCode == Keys.Up)
                txtdiemkt2.Focus();
        }

        private void txtdiemkt1them_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiemkt1them.Text != "" && kiemtraso(txtdiemkt1them.Text) == true)
            {
                if (float.Parse(txtdiemkt1them.Text) > 10 || float.Parse(txtdiemkt1them.Text) < 0)
                {
                    DialogResult ret = MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ret == DialogResult.OK)
                        txtdiemkt1them.Text = "";
                }

            }
        }

        private void txtdiemkt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiemkt2.Text != "" && kiemtraso(txtdiemkt2.Text) == true)
            {
                if (float.Parse(txtdiemkt2.Text) > 10 || float.Parse(txtdiemkt2.Text) < 0)
                {
                    DialogResult ret = MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ret == DialogResult.OK)
                        txtdiemkt2.Text = "";
                }
            }
        }

        private void txtdiemghpthem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiemghpthem.Text != "" && kiemtraso(txtdiemghpthem.Text) == true)
            {
                if (float.Parse(txtdiemghpthem.Text) > 10 || float.Parse(txtdiemghpthem.Text) < 0)
                {
                    DialogResult ret = MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ret == DialogResult.OK)
                        txtdiemghpthem.Text = "";
                }
            }
        }

        private void txtthihethpthem_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtthihethpthem.Text != "" && kiemtraso(txtthihethpthem.Text) == true)
            {
                if (float.Parse(txtthihethpthem.Text) > 10 || float.Parse(txtthihethpthem.Text) < 0)
                {
                    DialogResult ret = MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ret == DialogResult.OK)
                        txtthihethpthem.Text = "";
                }
            }
        }

        private void txtdiemkt1them_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtdiemkt1them.Text != "" && kiemtraso(txtdiemkt1them.Text) == true)
            {
                if (float.Parse(txtdiemkt1them.Text) > 10 || float.Parse(txtdiemkt1them.Text) < 0)
                {
                    txtdiemkt1them.Text = "";
                }
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtdiemkt2.Focus();
            else if (e.KeyCode == Keys.Up)
                txtdiemccthem.Focus();
        }

        private void txtdiemkt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtdiemkt2.Text != "" && kiemtraso(txtdiemkt2.Text) == true)
            {
                if (float.Parse(txtdiemkt2.Text) > 10 || float.Parse(txtdiemkt2.Text) < 0)
                {
                    txtdiemkt2.Text = "";
                }
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtdiemghpthem.Focus();
            else if (e.KeyCode == Keys.Up)
                txtdiemkt1them.Focus();
        }

        private void txtthihethpthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtthihethpthem.Text != "" && kiemtraso(txtthihethpthem.Text) == true)
            {
                if (float.Parse(txtthihethpthem.Text) > 10 || float.Parse(txtthihethpthem.Text) < 0)
                    txtthihethpthem.Text = "";
            }
            if (e.KeyCode == Keys.Enter)
                btnluu_Click(btnluu, e);
            else if (e.KeyCode == Keys.Up)
                txtdiemghpthem.Focus();
        }

        private void txtdiemccthem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Điểm phải là một số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiemccthem.Clear();

            }
        }

        private void txtdiemkt1them_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Điểm phải là một số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtdiemkt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Điểm phải là một số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtdiemghpthem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Điểm phải là một số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtthihethpthem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Điểm phải là một số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cbomanam_TextChanged(object sender, EventArgs e)
        {
            cbomanam.DataSource = bdiem.layttnamhoc(" where NamHoc=N'" + cbonamhoc.Text + "'");
            cbomanam.DisplayMember = "MaNamHoc";
            cbomanam.ValueMember = "MaNamHoc";
        }

        private void cbomanam_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void cbonamhoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cbomamon.Focus();
            else if (e.KeyCode == Keys.Up)
                txtMasvthemdiem.Focus();
        }

        private void cbomamon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtdiemccthem.Focus();
            else if (e.KeyCode == Keys.Up)
                cbonamhoc.Focus();
        }

        private void txtMasvthemdiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cbonamhoc.Focus();
        }

        private void btntimkiemds_Click(object sender, EventArgs e)
        {
            btnnhapttdiem.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            string dieukien = txtTimKiemttsv.Text;
            if (chkTimTheoMasv.Checked)
                //HienThiDSSinhVien(dvgsinhvien, bdndiem, " where tblSinhVien.MaSV like N'%" + dieukien + "%'");
                dstimkiem(" where tblSinhVien.MaSV like N'%" + dieukien + "%'");
            else if (chkTimTheomamh.Checked)

                dstimkiem(" where vw_diemht.MaMH like N'%" + dieukien + "%' ");
            //HienThiDSSinhVien(dvgsinhvien, bdndiem, " where MaMH like N'%" + dieukien + "%'");

        }

        private void txtTimKiemttsv_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                if (btntkdiem.Visible == true)
                    btntkdiem_Click(btntkdiem, e);
                else if (btntimkiemds.Visible == true)
                    btntimkiemds_Click(btntimkiemds, e);
        }
    }
}
