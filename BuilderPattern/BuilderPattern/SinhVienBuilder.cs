using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class SinhVienBuilder : InterfaceNguoi
    {
        public int ma { get; set; }
        public string ten { get; set; }
        public int sdt { get; set; }
        public LopHoc LopHoc { get; set; }
        public Diachi Diachi { get; set; }
        public SinhVienBuilder addMa(int ma)
        {
            this.ma = ma;

            return this;
        }

        public SinhVienBuilder addMaLop(LopHoc maLop)
        {
            LopHoc = maLop;
            return this;
        }

        public SinhVienBuilder addsdt(int sdt)
        {
            this.sdt = sdt;
            return this;
        }

        public SinhVienBuilder addTen(string ten)
        {
            this.ten = ten;
            return this;
        }

        public SinhVienBuilder diachi(Diachi diachi)
        {
            Diachi = diachi;
            return this;
        }

        public Nguoi Builder()
        {
            return new Nguoi(ma, ten, sdt, LopHoc, Diachi);
        }

      
    }
}
