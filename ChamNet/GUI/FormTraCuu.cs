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
    public partial class FormTraCuu : Form
    {
        Bus_SinhVien bsinhvien = new Bus_SinhVien();
        Entity_SinhVien et = new Entity_SinhVien();
        public event EventHandler ButtonClick = null;

        public FormTraCuu()
        {
            InitializeComponent();
        }
        private void hienthi(DataGridViewX dgv, BindingNavigator bn, string dieukien)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bsinhvien.timkiem(dieukien);
            dgv.DataSource = bs;
            bn.BindingSource = bs;
        }
        private void FormTraCuu_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'dataSetAll.tblChuyenNganh' table. You can move, or remove it, as needed.
        //    this.tblChuyenNganhTableAdapter.Fill(this.dataSetAll.tblChuyenNganh);
            // TODO: This line of code loads data into the 'dataSetAll.tblLop' table. You can move, or remove it, as needed.
         //   this.tblLopTableAdapter.Fill(this.dataSetAll.tblLop);
            hienthi(dgvtimkiem, bdntimkiem, "");

            clear();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            string sql = "where DSSV.HoTen like N'%" + txthoten.Text + "%'";
            if (cbodieukienqq.Text != "NONE")
            {
                sql += cbodieukienqq.Text + " QueQuan like N'%" + txtquequan.Text + "%'";
            }
            if (cbodieukienlop.Text != "NONE")
                sql += cbodieukienlop.Text + " TenLop like N'%" + cbolop.Text + "%'";
            if (cbodieukienchuyennganh.Text != "NONE")
                sql += cbodieukienchuyennganh.Text + " TenChuyenNganh like N'%" + cbochuyennganh.Text + "%'";
            hienthi(dgvtimkiem, bdntimkiem, sql);

        }

        private void clear()
        {
            txthoten.Text = "";
            txtquequan.Text = "";
            cbochuyennganh.Text = "";
            cbodieukienqq.Text = "NONE";
            cbodieukienlop.Text = "NONE";
            cbodieukienchuyennganh.Text = "NONE";
            txthoten.Focus();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            hienthi(dgvtimkiem, bdntimkiem, "");
        }

       /* private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;

        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
