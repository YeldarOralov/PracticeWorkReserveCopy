using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    public class Flash: Storage
    {
        public int Speed { get; set; }
        public int Memory { get; set; }

        public override int GetMemory()
        {
            return Memory;
        }
        public override void AllInfo()
        {
            Console.WriteLine($"Скорость: {Speed}. Память: {Memory}");
        }
    }
}
