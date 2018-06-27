using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChamNet.DAL;

namespace ChamNet.BUS
{
    public class Bus_Diem
    {
        KetNoiCSDL cn = new KetNoiCSDL();
        public void themdulieu(Entity_Diem et)
        {
            cn.ThucthiSQL(@"INSERT INTO tblDiem (MaSV, MaMH,MaNamHoc, DiemCC,DiemKT1,DiemKT2,DiemGK,DiemThi) VALUES     (N'" + et.MaSV + "',N'" + et.MaMH + "',N'" + et.MaNamHoc + "',N'" + et.DiemCC + "',N'" + et.DiemKT1 + "',N'" + et.DiemKT2 + "',N'" + et.DiemGK + "',N'" + et.DiemThi + "')");
        }
        public void suadulieu(Entity_Diem et)
        {
            cn.ThucthiSQL(@"UPDATE tblDiem SET  DiemCC =N'" + et.DiemCC + "',DiemKT1=N'" + et.DiemKT1 + "',DiemKT2=N'" + et.DiemKT2 + "',DiemGK=N'" + et.DiemGK + "',DiemThi=N'" + et.DiemThi + "' where MaMH=N'" + et.MaMH + "' and MaSV=N'" + et.MaSV + "'");
        }
        public void xoadulieu(Entity_Diem et)
        {
            cn.ThucthiSQL(@"delete from tblDiem where MaSV=N'" + et.MaSV + "' and MaMH=N'" + et.MaMH + "'");
        }
        public DataTable laydulieu(string dieukien)
        {
            return cn.gettable("select tblMonHoc.*,tblDiem.DiemCC,tblDiem.DiemKT1,tblDiem.DiemKT2,tblDiem.DiemGK,tblDiem.DiemThi,case when (SoTC<=2) then convert(decimal(3,2),(DiemCC+DiemKT1+DiemKT2)/3*0.3+DiemThi*0.7) else convert(decimal(3,2),(DiemCC+DiemKT1+DiemKT2+DiemGK*2)/5*0.3+DiemThi*0.7)end as [DiemTB] from tblDiem inner join tblMonHoc on tblDiem.MaMH=tblMonHoc.MaMH inner join tblNamHoc on tblDiem.MaNamHoc=tblNamHoc.MaNamHoc " + dieukien);
        }

        public DataTable layttsinhvien(string dieukien)
        {

            return cn.gettable("select tblSinhVien.MaSV,[HoTen]=tblSinhVien.HoSV+' '+tblSinhVien.TenSV,tblSinhVien.MaLop,vw_diemht.NamHoc,[DiemTBHT]=convert(decimal(3,2),sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)),case when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=9 then N'Xuất sắc' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=8 then N'Giỏi' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=7 then N'Khá' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=6.5 then N'Trung Bình Khá' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=5 then N'Trung bình' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=0 then N'Yếu' else N'Chưa phân loại' end as [PhanLoai] from tblSinhVien left outer join vw_diemht on tblSinhVien.MaSV=vw_diemht.MaSV left outer join tblDiem on tblDiem.MaSV=tblSinhVien.MaSV left outer join tblNamHoc on tblDiem.MaNamHoc=tblNamHoc.MaNamHoc group by tblSinhVien.MaSV,tblSinhVien.TenSV,tblSinhVien.HoSV,tblSinhVien.MaLop,vw_diemht.NamHoc order by tblSinhVien.MaSV " + dieukien);
        }
        public DataTable layttlop(string dieukien)
        {
            return cn.gettable("Select * from tblLop " + dieukien);
        }
        public DataTable layttmonhoc(string dieukien)
        {
            return cn.gettable("select MaMH,TenMH,SoTC from tblMonHoc " + dieukien);
        }
        public DataTable layttnamhoc(string dieukien)
        {
            return cn.gettable("select * from tblNamHoc " + dieukien);
        }
        public DataTable timkiem(string dieukien)
        {
            return cn.gettable("select tblSinhVien.MaSV,[HoTen]=tblSinhVien.HoSV+' '+tblSinhVien.TenSV,tblSinhVien.MaLop,vw_diemht.NamHoc,[DiemTBHT]=convert(decimal(3,2),sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)),case when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=9 then N'Xuất sắc' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=8 then N'Giỏi' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=7 then N'Khá' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=6.5 then N'Trung Bình Khá' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=5 then N'Trung bình' when sum((vw_diemht.DiemTB)*vw_diemht.SoTC)/SUM(vw_diemht.SoTC)>=0 then N'Yếu' else N'Chưa phân loại' end as [PhanLoai] from tblSinhVien left outer join vw_diemht on tblSinhVien.MaSV=vw_diemht.MaSV left outer join tblDiem on tblDiem.MaSV=tblSinhVien.MaSV left outer join tblNamHoc on tblDiem.MaNamHoc=tblNamHoc.MaNamHoc " + dieukien + " group by tblSinhVien.MaSV,tblSinhVien.TenSV,tblSinhVien.HoSV,tblSinhVien.MaLop,vw_diemht.NamHoc order by tblSinhVien.MaSV ");
        }
    }
}
