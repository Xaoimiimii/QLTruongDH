using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongDH
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string Phai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public decimal? Luong { get; set; }
        public decimal? PhuCap { get; set; }
        public string DienThoai { get; set; }
        public string VaiTro { get; set; }
        public string MaDV { get; set; }

        public NhanVien() { }
    }

    public class MoMon
    {
        public string MaMM { get; set; }      // Mã môn mở (khóa chính)
        public string MaHP { get; set; }      // Mã học phần
        public string MaGV { get; set; }      // Mã giảng viên
        public int HK { get; set; }           // Học kỳ (1, 2 hoặc 3)
        public int Nam { get; set; }          // Năm

        public MoMon() { }

        public MoMon(string maMM, string maHP, string maGV, int hk, int nam)
        {
            MaMM = maMM;
            MaHP = maHP;
            MaGV = maGV;
            HK = hk;
            Nam = nam;
        }
    }

}
