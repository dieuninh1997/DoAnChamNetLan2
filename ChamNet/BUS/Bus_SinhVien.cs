using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_SinhVien
    {
        KetNoiCSDL cn = new KetNoiCSDL();

        public void themdulieu(Entity_SinhVien et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblSinhVien  (MaSV, HoSV, TenSV, NgaySinh, GioiTinh, QueQuan, MaLop)
                            VALUES     (N'" + et.MaSV + "',N'" + et.HoSV + "',N'" + et.TenSV + "',N'" + et.NgaySinh + "',N'" + et.GioiTinh + "',N'" + et.QueQuan + "',N'" + et.MaLop + "')");
        }
        public void suadulieu(Entity_SinhVien et)
        {
            cn.ThucthiSQL(@"UPDATE tblSinhVien SET  HoSV =N'" + et.HoSV + "', TenSV =N'" + et.TenSV + "', NgaySinh =N'" + et.NgaySinh + "', GioiTinh =N'" + et.GioiTinh + "', QueQuan =N'" + et.QueQuan + "', MaLop =N'" + et.MaLop + "' where MaSV=N'" + et.MaSV + "'");
        }
        public void xoadulieu(Entity_SinhVien et)
        {
            cn.ThucthiSQL(@"DELETE FROM tblSinhVien where MaSV=N'" + et.MaSV + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("Select * from tblSinhVien " + dieukien);
        }
        public DataTable layttlop(string dieukien)
        {
            return cn.gettable("select MaLop,TenLop from tblLop " + dieukien);
        }
        public string TaoMa()
        {
            TangMa a = new TangMa();
            return a.MaTiepTheo(cn.laymacuoi("tblSinhVien", "MaSV"), "DH");
        }
        public DataTable timkiem(string dieukien)
        {
            return cn.gettable("select DSSV.MaSV,DSSV.HoTen,DSSV.NgaySinh,DSSV.GioiTinh,DSSV.QueQuan,DSSV.TenLop,DSSV.TenChuyenNganh from DSSV " + dieukien);
        }
    }
}
