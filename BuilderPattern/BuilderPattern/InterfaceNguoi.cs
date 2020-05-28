using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    interface InterfaceNguoi
    {
        SinhVienBuilder addMa(int ma);
        SinhVienBuilder addTen(string ten);
        SinhVienBuilder addsdt(int sdt);
        SinhVienBuilder diachi(Diachi diachi);
        SinhVienBuilder addMaLop(LopHoc maLop);

        Nguoi Builder();

       
       
    }
}
