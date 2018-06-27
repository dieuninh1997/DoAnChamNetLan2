using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_MonHoc
    {
        private string maMH;
        private string tenMH;
        private int soTC;

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

        public string TenMH
        {
            get
            {
                return tenMH;
            }

            set
            {
                tenMH = value;
            }
        }

        public int SoTC
        {
            get
            {
                return soTC;
            }

            set
            {
                soTC = value;
            }
        }
    }
}
