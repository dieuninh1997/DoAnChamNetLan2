using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_Lop
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_Lop et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblLop  (MaLop, TenLop, MaChuyenNganh,SiSo) VALUES     (N'" + et.MaLop + "',N'" + et.TenLop + "',N'" + et.MaChuyenNganh + "',N'" + et.SiSo + "')");
        }
        public void suadulieu(Entity_Lop et)
        {
            cn.ThucthiSQL(@"UPDATE    tblLop SET TenLop =N'" + et.TenLop + "', MaChuyenNganh =N'" + et.MaChuyenNganh + "',SiSo=N'" + et.SiSo + "' WHERE MaLop=N'" + et.MaLop + "'");
        }
        public void xoadulieu(Entity_Lop et)
        {
            cn.ThucthiSQL(@"Delete from tblLop where MaLop=N'" + et.MaLop + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("Select * from tblLop " + dieukien);
        }
        public DataTable layttchuyennganh(string dieukien)
        {
            return cn.gettable("Select MaChuyenNganh,TenChuyenNganh from tblChuyenNganh " + dieukien);
        }
    }
}
