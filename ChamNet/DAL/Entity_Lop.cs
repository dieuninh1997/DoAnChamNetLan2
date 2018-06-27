using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_Lop
    {
        private string maLop;
        private string tenLop;
        private string maChuyenNganh;
        private int siSo;

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

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        public string MaChuyenNganh
        {
            get
            {
                return maChuyenNganh;
            }

            set
            {
                maChuyenNganh = value;
            }
        }

        public int SiSo
        {
            get
            {
                return siSo;
            }

            set
            {
                siSo = value;
            }
        }
    }
}
