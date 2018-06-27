using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
   public class Bus_MonHoc
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_MonHoc et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblMonHoc (MaMH, TenMH, SoTC) VALUES     (N'" + et.MaMH + "',N'" + et.TenMH + "',N'" + et.SoTC + "')");
        }
        public void suadulieu(Entity_MonHoc et)
        {
            cn.ThucthiSQL(@"UPDATE    tblMonHoc SET  TenMH =N'" + et.TenMH + "', SoTC =N'" + et.SoTC + "' where MaMH=N'" + et.MaMH + "'");
        }
        public void xoadulieu(Entity_MonHoc et)
        {
            cn.ThucthiSQL(@"delete from tblMonHoc where MaMH=N'" + et.MaMH + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select * from tblMonHoc " + dieukien);
        }
    }
}
