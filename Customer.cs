using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemprograman_UAS_RESPONSI
{
    public class Customer
    {
        // PERINTAH: lengkapi property class customer, sesuai petunjuk soal 
        public string KodeCustomer { get; set; }
        public string NamaCustomer { get; set; }
        public int TotalPiutang { get; set; }
        public void Print()
        {
            Console.WriteLine("{0}, {1}, {2}", KodeCustomer, NamaCustomer, TotalPiutang);
        }
    }
}
