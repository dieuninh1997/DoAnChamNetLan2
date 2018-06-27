using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_SinhVien
    {
        private string maSV;
        private string hoSV;
        private string tenSV;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string queQuan;
        private string maLop;

        public string MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }

        public string HoSV
        {
            get
            {
                return hoSV;
            }

            set
            {
                hoSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return tenSV;
            }

            set
            {
                tenSV = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return queQuan;
            }

            set
            {
                queQuan = value;
            }
        }

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }
    }
}
