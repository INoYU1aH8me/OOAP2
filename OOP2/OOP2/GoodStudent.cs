using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class GoodStudent : Student
    {
        public override void EveningActivity()
        {
            Console.WriteLine("Отдохнул");
        }

        public override void MidDayActivity()
        {
            Console.WriteLine("Пошел на занятия");
        }

        public override void MorningActivity()
        {
            Console.WriteLine("Сделал зарядку");
        }
    }
}
