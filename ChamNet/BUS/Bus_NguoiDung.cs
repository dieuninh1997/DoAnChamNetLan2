using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_NguoiDung
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_NguoiDung et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblNguoiDung (TaiKhoan,TenNguoiDung, MatKhau, LoaiNguoiDung, MaXacNhan) VALUES     (N'" + et.TaiKhoan + "',N'" + et.TenNguoiDung + "',N'" + et.MatKhau + "',N'" + et.LoaiNguoiDung + "',N'" + et.MaXacNhan + "')");
        }
        public void suadulieu(Entity_NguoiDung et)
        {
            cn.ThucthiSQL(@"UPDATE    tblNguoiDung SET TenNguoiDung=N'" + et.TenNguoiDung + "',LoaiNguoiDung=N'" + et.LoaiNguoiDung + "',MatKhau =N'" + et.MatKhau + "' where TaiKhoan=N'" + et.TaiKhoan + "' and MaXacNhan=N'" + et.MaXacNhan + "'");
        }
        public void xoadulieu(Entity_NguoiDung et)
        {
            cn.ThucthiSQL(@"DELETE from tblNguoiDung where TaiKhoan=N'" + et.TaiKhoan + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select * from tblNguoiDung " + dieukien);
        }
        public DataTable dangnhap(string dieukien)
        {
            return cn.gettable(dieukien);
        }
        public string quenmk(string dieukien)
        {
            return cn.getvalue(dieukien);
        }
        public void doimk(Entity_NguoiDung et)
        {
            cn.ThucthiSQL(@"update tblNguoiDung set MatKhau=N'" + et.MatKhau + "' where TaiKhoan=N'" + et.TaiKhoan + "' and MaXacNhan=N'" + et.MaXacNhan + "'");
        }
    }
}
