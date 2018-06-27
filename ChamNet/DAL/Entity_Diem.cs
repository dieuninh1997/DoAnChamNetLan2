using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_Diem
    {
        private string maSV;
        private string maMH;
        private string maNamHoc;
        private float diemCC;
        private float diemKT1;
        private float diemKT2;
        private float diemGK;
        private float diemThi;

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

        public string MaMH
        {
            get
            {
                return maMH;
            }

            set
            {
                maMH = value;
            }
        }

        public string MaNamHoc
        {
            get
            {
                return maNamHoc;
            }

            set
            {
                maNamHoc = value;
            }
        }

        public float DiemCC
        {
            get
            {
                return diemCC;
            }

            set
            {
                diemCC = value;
            }
        }

        public float DiemKT1
        {
            get
            {
                return diemKT1;
            }

            set
            {
                diemKT1 = value;
            }
        }

        public float DiemKT2
        {
            get
            {
                return diemKT2;
            }

            set
            {
                diemKT2 = value;
            }
        }

        public float DiemGK
        {
            get
            {
                return diemGK;
            }

            set
            {
                diemGK = value;
            }
        }

        public float DiemThi
        {
            get
            {
                return diemThi;
            }

            set
            {
                diemThi = value;
            }
        }
    }
}
