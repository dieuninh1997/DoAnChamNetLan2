using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
   public class Bus_ChuyenNganh
    {

        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_ChuyenNganh et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblChuyenNganh (MaChuyenNganh, TenChuyenNganh)  VALUES     (N'" + et.MaChuyenNganh + "',N'" + et.TenChuyenNganh + "')");
        }
        public void suadulieu(Entity_ChuyenNganh et)
        {
            cn.ThucthiSQL(@"UPDATE    tblChuyenNganh SET TenChuyenNganh =N'" + et.TenChuyenNganh + "' where MaChuyenNganh=N'" + et.MaChuyenNganh + "'");
        }
        public void xoadulieu(Entity_ChuyenNganh et)
        {
            cn.ThucthiSQL(@"delete from tblChuyenNganh where MaChuyenNganh=N'" + et.MaChuyenNganh + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select * from tblChuyenNganh " + dieukien);
        }
    }
}
