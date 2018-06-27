using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_NamHoc
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_NamHoc et)
        {
            cn.ThucthiSQL("INSERT INTO tblNamHoc  (MaNamHoc, NamHoc) VALUES     (N'" + et.MaNamHoc + "',N'" + et.NamHoc + "')");
        }
        public void suadulieu(Entity_NamHoc et)
        {
            cn.ThucthiSQL("UPDATE    tblNamHoc SET NamHoc =N'" + et.NamHoc + "' WHERE MaNH=N'" + et.MaNamHoc + "'");
        }
        public void xoadulieu(Entity_NamHoc et)
        {
            cn.ThucthiSQL("DELETE FROM tblNamHoc WHERE MaNH=N'" + et.MaNamHoc + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select * from tblNamHoc " + dieukien);
        }
    }
}
