using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_NguoiDung
    {
        private string taiKhoan;
        private string matKhau;
        private string tenNguoiDung;
        private string maXacNhan;
        private string loaiNguoiDung;

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string TenNguoiDung
        {
            get
            {
                return tenNguoiDung;
            }

            set
            {
                tenNguoiDung = value;
            }
        }

        public string MaXacNhan
        {
            get
            {
                return maXacNhan;
            }

            set
            {
                maXacNhan = value;
            }
        }

        public string LoaiNguoiDung
        {
            get
            {
                return loaiNguoiDung;
            }

            set
            {
                loaiNguoiDung = value;
            }
        }
    }
}
