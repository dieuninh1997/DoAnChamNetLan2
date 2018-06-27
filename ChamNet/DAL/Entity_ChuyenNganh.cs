using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.DAL
{
    public class Entity_ChuyenNganh
    {
        private string maChuyenNganh;
        private string tenChuyenNganh;

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

        public string TenChuyenNganh
        {
            get
            {
                return tenChuyenNganh;
            }

            set
            {
                tenChuyenNganh = value;
            }
        }
    }
}
