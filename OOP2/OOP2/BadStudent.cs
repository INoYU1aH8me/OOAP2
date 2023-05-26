using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class BadStudent : Student
    {
        public override void EveningActivity()
        {
            Console.WriteLine("Погулял");
        } 

        public override void MidDayActivity()
        {
            Console.WriteLine("Компьютерные игры");
        }

        public override void MorningActivity()
        {
        }     
    }
}
