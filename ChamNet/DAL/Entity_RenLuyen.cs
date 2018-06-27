using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
   public class Entity_RenLuyen
    {
        private string maSV;
        private string maNamHoc;
        private string renLuyen;

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

        public string RenLuyen
        {
            get
            {
                return renLuyen;
            }

            set
            {
                renLuyen = value;
            }
        }
    }
}
