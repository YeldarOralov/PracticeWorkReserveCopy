using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    public class HDD: Storage
    {
        public int Speed { get; set; }
        public int CountOfSections { get; set; }
        public int SizeOfSections { get; set; }

        public override int GetMemory()
        {
            return SizeOfSections * CountOfSections;
        }
        public override void AllInfo()
        {
            Console.WriteLine($"Скорость: {Speed}. Кол-во разделов: {CountOfSections}. Размер одного раздела: {SizeOfSections}")
        }
    }
}
