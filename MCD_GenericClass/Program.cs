using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.tcKimlikNumarasi = "12125212422";
            m1.musteriNumara = "MS123";
            m1.isim = "Faik";
            m1.soyisim = "Turan";
            m1.dogumTarihi = DateTime.Parse("20.07.1978");

            MusteriGeneric<int> mGeneric1 = new MusteriGeneric<int>();
            mGeneric1.id = 1;
            mGeneric1.MusteriNumarasiAl();

            MusteriGeneric<Guid> mGeneric2 = new MusteriGeneric<Guid>();
            Console.WriteLine(mGeneric2.MusteriNumarasiAl());
        }
    }
}
