using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage dvd = new DVD
            {
                
            };
            Storage flash = new Flash
            {

            };
            Storage hdd = new HDD
            {

            };
            Storage[] storages = new Storage[]
            {
                dvd, flash, hdd
            };
        }
    }
}
