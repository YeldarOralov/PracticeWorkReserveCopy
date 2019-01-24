using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{   
    enum TypesOfSide : int
    {
        OneSide=4700, TwoSide=9000
    }
    class DVD: Storage
    {
        public int SpeedOfRead { get; set; }
        public int SpeedOfWrite { get; set; }
        public TypesOfSide Side { get; set; }

        public override int GetMemory()
        {
            return (int)Side;
        }
        public override void AllInfo()
        {
            Console.WriteLine($"Скорость чтения: {SpeedOfRead}. Скорость записи: {SpeedOfWrite}. Тип: {Side}.")
        }
    }
}
