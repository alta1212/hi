using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlysinhvien
{
    public class Class1
    {
        class NhapDiemView
        {
            public void YeuCauNhapDiem()
            {

            }
            public void NhapHocKy_NamHoc()
            {

            }
            public void NhapMaLop()
            {

            }
            public void NhapMaSinhVien()
            {

            }
            public void NhapMaMonHoc()
            {

            }
        }
        class Diem
        {
            public DiemDAL LayThongTinDiem (string maMonHoc)
            {

            }
            public void CapNhat(List<DiemDAL> ds)
            {

            }

        }
        class Lop
        {
            public List<Lop> getLop(string NamHoc)
            {

            }
            public void CapNhat()
            {

            }
        }
        class MonHoc
        {
            public List<MonHoc> getMonHoc(string maLop)
            {

            }
            public void CapNhat()
            {

            }
        }
        class SinhVien
        {

        }
        class NhapDiemControl
        {
            DiemDAL diem = new DiemDAL();
            SinhVienDAL sinhVien = new SinhVienDAL();
            MonHocDAL monHocDAL = new MonHocDAL();
            SinhVienDAL sinhVien = new SinhVienDAL();

            public List<DiemDAL> danhsachdiem(string maMonHoc)
            {

            }
            public List<Lop> danhSachLop(string maLop)
            {

            }
            public List<SinhVien> danhSachSinhVien(string maSinhVien)
            {

            }
            public List<MonHoc> danhSachMonHoc(string maMonHoc)
            {

            }
        }
    }
}