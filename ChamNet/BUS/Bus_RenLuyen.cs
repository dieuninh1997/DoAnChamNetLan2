using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_RenLuyen
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_RenLuyen et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblRenLuyen (MaSV, MaNamHoc, RenLuyen) VALUES     (N'" + et.MaSV + "',N'" + et.MaNamHoc + "',N'" + et.RenLuyen + "')");
        }
        public void suadulieu(Entity_RenLuyen et)
        {
            cn.ThucthiSQL(@"UPDATE    tblRenLuyen SET  RenLuyen =N'" + et.RenLuyen + "' where MaSV=N'" + et.MaSV + "' and MaNamHoc =N'" + et.MaNamHoc + "'");
        }
        public void xoadulieu(Entity_RenLuyen et)
        {
            cn.ThucthiSQL(@"delete from tblRenLuyen where MaSV=N'" + et.MaSV + "' and MaNamHoc=N'" + et.MaNamHoc + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select * from tblRenLuyen " + dieukien);
        }
        public DataTable layttsinhvien(string dieukien)
        {
            return cn.gettable("select MaSV,TenSV from tblSinhVien " + dieukien);
        }
        public DataTable layttnamhoc(string dieukien)
        {
            return cn.gettable("select * from tblNamHoc " + dieukien);
        }
    }
}
