using System;

namespace ResponsiPemograman2866
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("Grizzly", "16253", "3000000");
            karyawan.GetInfo();

            Karyawan karyawan1 = new Karyawan("Panda", "16253", "3300000");
            karyawan1.GetInfo1();
        }
    }
}
