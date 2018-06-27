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
using Microsoft.Reporting.WinForms;

namespace ChamNet.GUI
{
    public partial class FormBaoCaoDiem : Form
    {
        Bus_Diem bdiem = new Bus_Diem();
        public event EventHandler ButtonClick = null;

        public FormBaoCaoDiem()
        {
            InitializeComponent();
        }
        private void hienthicbonamhoc()
        {
            cbonamhoc.DataSource = bdiem.layttnamhoc("");
            cbonamhoc.DisplayMember = "NamHoc";
            cbonamhoc.ValueMember = "MaNamHoc";
        }
        private void hienthicbo()
        {
            cbolop.DataSource = bdiem.layttlop("");//.laydulieu("");
            cbolop.DisplayMember = "TenLop";
            cbolop.ValueMember = "MaLop";
            // cbolop.SelectedIndex = 0;
        }
        private void laythamso(string namhoc, string lop, string namht, string lopht)
        {
            ReportParameter[] rp = new ReportParameter[5];
            rp[0] = new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            rp[1] = new ReportParameter("NamHoc");
            rp[1].Values.Add("*" + namhoc + "*");
            rp[2] = new ReportParameter("Lop");
            rp[2].Values.Add("*" + lop + "*");
            rp[3] = new ReportParameter("NamHocHT", namht);
            rp[4] = new ReportParameter("LopHT", lopht);
            this.rptdsdiem.LocalReport.SetParameters(rp);
        }

        private void FormBaoCaoDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAll.vw_DSDiem' table. You can move, or remove it, as needed.
            this.vw_DSDiemTableAdapter.Fill(this.dataSetAll.vw_DSDiem);

            this.rptdsdiem.RefreshReport();
            hienthicbo();
            cbolop.Text = "";
            hienthicbonamhoc();
            //cbolop.Text = "";
            cbonamhoc.Text = "";
            laythamso("", "", "Tất cả", "Tất cả");
            this.rptdsdiem.RefreshReport();
        }

        private void tblLopBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
          //  if (cbonamhoc.SelectedIndex >= 0 && cbolop.SelectedIndex >= 0)
            {
                laythamso(cbonamhoc.SelectedValue.ToString(), cbolop.SelectedValue.ToString(), cbonamhoc.Text, cbolop.Text);
                this.rptdsdiem.RefreshReport();
            }
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            laythamso("", "", "Tất cả", "Tất cả");
            this.rptdsdiem.RefreshReport();
        }

       /* private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }*/
    }
}
