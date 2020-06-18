using System;
namespace VOLUME_KERUCUT
{
    class Program
    {
        static void Main()
        {
            double VOLUME, TINGGI, JARI, DIAMETER, S, KELILING, LUAS_ALAS;
            Console.Write("\n Menghitung Volume Kerucut \n");
            Console.Write("\n Tinggi        = ");
            TINGGI = double.Parse(Console.ReadLine());
            Console.Write("\n Jari-Jari     = ");
            JARI = double.Parse(Console.ReadLine());
            LUAS_ALAS = 3.14 * JARI * JARI;
            DIAMETER = JARI * 2;
            KELILING = DIAMETER * 22 / 7;
            S = Math.Sqrt(JARI * JARI + TINGGI * TINGGI);
            VOLUME = 1/3 * 3.14 * JARI * JARI * TINGGI;
            Console.WriteLine("\n Luas Alas     = " + LUAS_ALAS);
            Console.WriteLine("\n Diameter      = " + DIAMETER);
            Console.WriteLine("\n Keliling      = " + KELILING);
            Console.WriteLine("\n Garis Pelukis = " + S);
            Console.WriteLine("\n Volume        = " + VOLUME);
            Console.ReadKey();
        }
    }
}
