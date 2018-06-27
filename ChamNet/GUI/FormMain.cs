using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChamNet.DAL;
using ChamNet.GUI;
using ChamNet.BUS;
//using DevComponents;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ChamNet
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FormDangNhap frmdn;
        FormDoiMatKhau frmdoimk;

        Bus_NguoiDung bnguoidung = new Bus_NguoiDung();
        Entity_NguoiDung et = new Entity_NguoiDung();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            showDefaultViews();

            FormKetNoi kn = new FormKetNoi();
            kn.ShowDialog();
            if (kn.kt == true)
            {
                dangnhap();
            }
            else
            {
                btnDangNhap.Enabled = false;
            }

        }
        public void dangnhap()
        {
            frmdn = new FormDangNhap();
            frmdn.ShowDialog();
            if (bnguoidung.laydulieu("where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and MatKhau=N'" + frmdn.txtMatKhau.Text + "'").Rows.Count == 1)
            {
                if (bnguoidung.dangnhap("select LoaiNguoiDung from tblNguoiDung where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and LoaiNguoiDung='Admin' ").Rows.Count == 1)
                {
                    admin();

                }
                else if (bnguoidung.dangnhap("select LoaiNguoiDung from tblNguoiDung where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and LoaiNguoiDung='qldt' ").Rows.Count == 1)
                {
                    qldt();

                }
                else if (bnguoidung.dangnhap("select LoaiNguoiDung from tblNguoiDung where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and LoaiNguoiDung='qlsv' ").Rows.Count == 1)
                {
                    qlsv();

                }
            }
        }
        public void showDefaultViews()
        {
            //false
            btnDangXuat.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnQlnd.Enabled = false;

            btnSV.Enabled = false;
            btnLop.Enabled = false;
            btnMon.Enabled = false;
            btnDiem.Enabled = false;
            btnNganh.Enabled = false;
            btnRenLuyen.Enabled = false;
            btnNamHoc.Enabled = false;
            btnDSSV.Enabled = false;
            btnKqDiem.Enabled = false;
            btnTraCuuSV.Enabled = false;
            //true
            btnHelp.Enabled = true;
            btnDangNhap.Enabled = true;
        }
        public void admin()
        {
            //false
            btnDangNhap.Enabled = false;
            //true
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnQlnd.Enabled = true;

            btnSV.Enabled = true;
            btnLop.Enabled = true;
            btnMon.Enabled = true;
            btnDiem.Enabled = true;
            btnNganh.Enabled = true;
            btnRenLuyen.Enabled = true;
            btnNamHoc.Enabled = true;
            btnDSSV.Enabled = true;
            btnKqDiem.Enabled = true;
            btnTraCuuSV.Enabled = true;
            btnHelp.Enabled = true;
            btnDangNhap.Enabled = true;
        }
        public void qldt()
        {
            //false
            btnDangNhap.Enabled = false;
            btnQlnd.Enabled = false;
            btnRenLuyen.Enabled = false;
            //true
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnSV.Enabled = true;
            btnLop.Enabled = true;
            btnMon.Enabled = true;
            btnDiem.Enabled = true;
            btnNganh.Enabled = true;
            btnRenLuyen.Enabled = true;
            btnNamHoc.Enabled = true;
            btnDSSV.Enabled = true;
            btnKqDiem.Enabled = true;
            btnTraCuuSV.Enabled = true;
            btnHelp.Enabled = true;
            btnDangNhap.Enabled = true;
        }
        public void qlsv()
        {
            //false
            btnDangNhap.Enabled = false;
            btnQlnd.Enabled = false;
            btnDiem.Enabled = false;

            //true
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;

            btnSV.Enabled = true;
            btnLop.Enabled = true;
            btnMon.Enabled = true;
            btnNganh.Enabled = true;
            btnRenLuyen.Enabled = true;
            btnNamHoc.Enabled = true;
            btnDSSV.Enabled = true;
            btnKqDiem.Enabled = true;
            btnTraCuuSV.Enabled = true;
            btnHelp.Enabled = true;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnDangNhap.Enabled = true;
            tabControl1.Tabs.Clear();
            showDefaultViews();
            if (frmdn == null || frmdn.IsDisposed)
                frmdn = new FormDangNhap();
            frmdn.txtTaiKhoan.Text = "";
            frmdn.txtMatKhau.Text = "";
            dangnhap();
        }

        private void btnQlnd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Quản lý người dùng"))
            {
                TabItem t = tabControl1.CreateTab("Quản lý người dùng");
                FormQlnd f = new FormQlnd();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
                //  f.ButtonClick += new EventHandler(btnThoatCt_ItemClick);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }
        private bool checkOpenTabs(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text == name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;

                }
            }
            return false;
        }

        private void btnThoatCt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
            //in He thong
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmdoimk == null || frmdoimk.IsDisposed)
                frmdoimk = new FormDoiMatKhau();
            frmdoimk.txtOldPassword.Text = "";
            frmdoimk.txtNewPassword.Text = "";
            frmdoimk.txtReNPassword.Text = "";
            frmdoimk.txtmaxacnhan.Text = "";
            DoiMatKhau();

        }
        public void DoiMatKhau()
        {
            Cont:
            if (frmdoimk.ShowDialog() == DialogResult.OK)
            {


                String m_Username = frmdn.txtTaiKhoan.Text;
                String m_Password = frmdn.txtMatKhau.Text;

                String m_OldPassword = frmdoimk.txtOldPassword.Text;
                String m_NewPassword = frmdoimk.txtNewPassword.Text;
                String m_ReNPassword = frmdoimk.txtReNPassword.Text;
                String m_maxacnhan = frmdoimk.txtmaxacnhan.Text;

                if (bnguoidung.laydulieu("where MatKhau=N'" + frmdoimk.txtOldPassword.Text + "' and TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "'").Rows.Count == 0)
                {
                    frmdoimk.lblmkcu.Text = "Nhập sai mật khẩu cũ!";
                    goto Cont;
                }
                else
                {
                    frmdoimk.lblmkcu.Text = "";
                    //DoiMatKhau();
                }
                if (frmdoimk.txtNewPassword.Text == frmdoimk.txtOldPassword.Text)
                {
                    frmdoimk.lblmkmoi.Text = "Mật khẩu trùng với mật khẩu cũ!";
                    goto Cont;
                }
                else
                {
                    frmdoimk.lblmkmoi.Text = "";
                }
                if (m_NewPassword != m_ReNPassword)
                {
                    frmdoimk.lblnhapmklai.Text = "Nhập xác nhận không khớp!";
                    goto Cont;
                }
                else
                {
                    frmdoimk.lblnhapmklai.Text = "";
                }
                if (bnguoidung.laydulieu("where MaXacNhan=N'" + frmdoimk.txtmaxacnhan.Text + "' and TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "'").Rows.Count == 0)
                {
                    frmdoimk.lblmaxn.Text = "Mã xác nhận không chính xác";
                    goto Cont;
                }
                else
                {
                    frmdoimk.lblmaxn.Text = "";
                }
                if (frmdoimk.txtNewPassword.Text == frmdoimk.txtReNPassword.Text && frmdoimk.txtNewPassword.Text != frmdoimk.txtOldPassword.Text && frmdoimk.txtOldPassword.Text == frmdn.txtTaiKhoan.Text && bnguoidung.laydulieu("where MaXacNhan=N'" + frmdoimk.txtmaxacnhan.Text + "' and TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "'").Rows.Count == 1)
                {
                    et.MatKhau = frmdoimk.txtNewPassword.Text;
                    et.TaiKhoan = frmdn.txtTaiKhoan.Text;
                    et.MaXacNhan = frmdoimk.txtmaxacnhan.Text;
                    bnguoidung.doimk(et);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
                return;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                e.Cancel = false;
            //Application.Exit();
            else if (ret == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //in Quan lý
            TabItem t = tabControl1.SelectedTab;
            tabControl1.Tabs.Remove(t);
        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Sinh viên"))
            {
                TabItem t = tabControl1.CreateTab("Sinh viên");
                FormSinhVien f = new FormSinhVien();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
              //  f.ButtonClick += new EventHandler(button1_Click);
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Lớp học"))
            {
                TabItem t = tabControl1.CreateTab("Lớp học");
                FormLopHoc f = new FormLopHoc();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
               // f.ButtonClick += new EventHandler(btnThoat1_ItemClick);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;

            }
        }

        private void btnMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Môn học"))
            {
                TabItem t = tabControl1.CreateTab("Môn học");
                FormMonHoc f = new FormMonHoc();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
              //  f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                if (bnguoidung.dangnhap("select LoaiNguoiDung from tblNguoiDung where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and LoaiNguoiDung='qlsv' ").Rows.Count == 1)
                {
                    f.btnluumon.Enabled = false;
                    f.btnsuamon.Enabled = false;
                    f.btnxoamon.Enabled = false;
                    f.buttonItemNhapDuLieumon.Enabled = false;
                    f.btntimkiemds.Visible = true;
                    f.btnTimKiemmon.Visible = false;
                    f.buttonItemTimKiemmon.Checked = true;
                }
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Điểm"))
            {
                TabItem t = tabControl1.CreateTab("Điểm");
                FormDiem f = new FormDiem();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
            //    f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                if (bnguoidung.dangnhap("select LoaiNguoiDung from tblNguoiDung where TaiKhoan=N'" + frmdn.txtTaiKhoan.Text + "' and LoaiNguoiDung='qlsv' ").Rows.Count == 1)
                {
                    f.btnnhapttdiem.Enabled = false;
                    f.btnluu.Enabled = false;
                    f.btnsua.Enabled = false;
                    f.btnxoa.Enabled = false;
                    f.btntimttsv.Enabled = true;
                    f.btnrefresh.Enabled = true;
                    f.khoanut();
                    f.btntimkiemds.Visible = true;
                    f.btntkdiem.Visible = false;
                    f.btntimttsv.Checked = true;
                }
            }
        }

        private void btnRenLuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Rèn luyện"))
            {
                TabItem t = tabControl1.CreateTab("Rèn luyện");
                FormRenLuyen f = new FormRenLuyen();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
              //  f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Ngành"))
            {
                TabItem t = tabControl1.CreateTab("Ngành");
                FormNganh f = new FormNganh();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
              //  f.ButtonClick += new EventHandler(button1_Click);
                f.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Năm học"))
            {
                TabItem t = tabControl1.CreateTab("Năm học");
                FormNamHoc f = new FormNamHoc();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
             //   f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Danh sách sinh viên"))
            {
                TabItem t = tabControl1.CreateTab("Danh sách sinh viên");
                FormBaoCaoDSSV f = new FormBaoCaoDSSV();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
              //  f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnKqDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Kết quả điểm theo năm học"))
            {
                TabItem t = tabControl1.CreateTab("Kết quả điểm theo năm học");
                FormBaoCaoDiem f = new FormBaoCaoDiem();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
               // f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnTraCuuSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Tìm kiếm sinh viên"))
            {
                TabItem t = tabControl1.CreateTab("Tìm kiếm sinh viên");
                FormTraCuu f = new FormTraCuu();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(f);
                f.Show();
             //   f.ButtonClick += new EventHandler(button1_Click);
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThongTinPM f = new FormThongTinPM();
            f.Show();
        }
    }
}
