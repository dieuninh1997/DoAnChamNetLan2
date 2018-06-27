using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_NamHoc
    {
        private string maNamHoc;
        private string namHoc;

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

        public string NamHoc
        {
            get
            {
                return namHoc;
            }

            set
            {
                namHoc = value;
            }
        }
    }
}
