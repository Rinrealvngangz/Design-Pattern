using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Nguoi
    {
        public int ma { get; set; }
        public string ten { get; set; }
          public int sdt { get; set; }
        public LopHoc LopHoc { get; set; }
        public Diachi Diachi { get; set; }

        public Nguoi(int Ma,string Ten,int Sdt, LopHoc lh,Diachi dc)
        {
            ma = Ma;
            ten = Ten;
            sdt = Sdt;
            LopHoc = lh;
            Diachi = dc;
        }

        public override string ToString()
        {
            var sinhvien = "";
            sinhvien += $" Ma:            \t{ma}\n";
            sinhvien += $" Ten:           \t{ten}\n";
            sinhvien += $" So dien thoai: \t{sdt}\n";
            sinhvien += $" Dia chi:       \t{Diachi.DiaChi}\n";
            sinhvien += $" Ma Lop:        \t{LopHoc.MaLop}\n";

            return sinhvien;
        }
    }
}
