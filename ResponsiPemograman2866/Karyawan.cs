using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemograman2866
{
    public class Karyawan
    {
        string Name;
        string Nik;
        string GajiBulanan;
        public Karyawan(string name, string nik, string gaji)
        {
            Name = name;
            Nik = nik;
            GajiBulanan = gaji;
        }
        public void GetInfo()
        {
            Console.WriteLine("Pertama");
            Console.WriteLine("Nama : {0} ", Name);
            Console.WriteLine("Nik  : {0}", Nik);
            Console.WriteLine("Gaji Bulanan  : {0}", GajiBulanan);
            Console.WriteLine("------------------------------");
        }
        public void GetInfo1()
        {
            Console.WriteLine("Kedua");
            Console.WriteLine("Nama : {0} ", Name);
            Console.WriteLine("Nik  : {0}", Nik);
            Console.WriteLine("Gaji Bulanan  : {0}", GajiBulanan);
            Console.WriteLine("------------------------------");
        }
    }
}

