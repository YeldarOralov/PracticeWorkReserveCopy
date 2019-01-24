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
                Name = "Диск",
                Model = "Sony",
                SpeedOfRead = 21,
                SpeedOfWrite = 20,
                Side = TypesOfSide.OneSide
            };
            Storage flash = new Flash
            {
                Name="Флэшка",
                Model="Transcend",
                Speed = 480,
                Memory = 4096
            };
            Storage hdd = new HDD
            {
                Name = "Жестяк",
                Model = "Kingston",
                Speed = 120,
                CountOfSections = 2,
                SizeOfSections = 25000
            };
            Storage[] storages = new Storage[]
            {
                dvd, flash, hdd
            };

            foreach(var obj in storages)
            {
                obj.AllInfo();
                Console.WriteLine(obj.GetMemory());
            }
            Console.ReadLine();
        }
    }
}
