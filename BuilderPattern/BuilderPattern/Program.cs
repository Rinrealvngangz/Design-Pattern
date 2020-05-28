using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nguoi = new SinhVienBuilder().addMa(123)
                .addTen("Nguyen Mau tuan")
                .addsdt(0949238337)
                .diachi(new Diachi("21 Phu Dong thien Vuong"))
                .addMaLop(new LopHoc("CTK42"))
                .Builder();
            Console.WriteLine(nguoi.ToString());

          
        }
    }
}
