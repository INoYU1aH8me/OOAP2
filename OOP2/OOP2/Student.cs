using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public abstract class Student
    {
        public string name;
        
        /// <summary>
        /// режим дня
        /// </summary>
        public void SpendDay()
        {
            WakeUp();
            MorningActivity();
            MidDayActivity();
            Lunch();
            EveningActivity();
            GoToBed();
        }
        /// <summary>
        /// проснулся
        /// </summary>
        public virtual void WakeUp()
        {
            Console.WriteLine("Проснулся");
        }

        /// <summary>
        /// утреннее занятие
        /// </summary>
        public abstract void MorningActivity();

        /// <summary>
        /// дневное занятие
        /// </summary>
        public abstract void MidDayActivity();

        /// <summary>
        /// обед
        /// </summary>
        public virtual void Lunch()
        {
            Console.WriteLine("Пообедал");
        }

        /// <summary>
        /// вечернее занятие
        /// </summary>
        public abstract void EveningActivity();

        /// <summary>
        /// лег спать
        /// </summary>
        public virtual void GoToBed()
        {
            Console.WriteLine("Лег спать");
        }      
    }
}
