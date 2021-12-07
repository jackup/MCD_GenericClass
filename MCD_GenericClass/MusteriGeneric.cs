
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClass
{
    public class MusteriGeneric<T>
    {
        public T id { get; set; }
        public T musteriNumara { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarihi { get; set; }

        public T MusteriNumarasiAl()
        {
            return musteriNumara;
        }
    }
}
