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
using Microsoft.Reporting.WinForms;

namespace ChamNet.GUI
{
    public partial class FormBaoCaoDSSV : Form
    {
        Bus_Lop blop = new Bus_Lop();
        public event EventHandler ButtonClick = null;
        private void btnthoat_Click(object sender, EventArgs e)
        {
           
        }
        public FormBaoCaoDSSV()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            laythamso(cbolop.SelectedValue.ToString(), cbolop.Text);
            this.rpt_dssv.RefreshReport();
        }
        private void hienthicbo()
        {
            cbolop.DataSource = blop.laydulieu("");
            cbolop.DisplayMember = "TenLop";
            cbolop.ValueMember = "MaLop";
           // cbolop.SelectedIndex = 0;
        }
        private void laythamso(string malop, string lophoc)
        {
            this.rpt_dssv.ProcessingMode = ProcessingMode.Local;
            this.rpt_dssv.LocalReport.ReportPath = "F:\\Nam3\\chamNetProj\\DoAnChamNet\\ChamNet\\ChamNet\\Reports\\rptDSSV.rdlc";
            ReportParameter[] rp = new ReportParameter[3];
            rp[0] = new ReportParameter("NgayLap");
            rp[0].Values.Add(DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            rp[1] = new ReportParameter("MaLop");
            rp[1].Values.Add("*" + malop + "*");
            rp[2] = new ReportParameter("LopHoc");
            rp[2].Values.Add(lophoc);
            this.rpt_dssv.LocalReport.SetParameters(rp);
            this.rpt_dssv.RefreshReport();
        }
        private void FormBaoCaoDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBCDSSV.DSSV' table. You can move, or remove it, as needed.
            this.dSSVTableAdapter.Fill(this.dataSetBCDSSV.DSSV);
            this.rpt_dssv.RefreshReport();
            hienthicbo();
            cbolop.Text = "";
            laythamso("", "Tất cả");
            this.rpt_dssv.RefreshReport();
        }

        private void btnxemtatca_Click(object sender, EventArgs e)
        {
            laythamso("", "Tất cả");
            this.rpt_dssv.RefreshReport();
            cbolop.Text = "";
        }

       /* private void btnthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                if (ButtonClick != null) ButtonClick(sender, e);
                else return;
        }*/
    }
}
