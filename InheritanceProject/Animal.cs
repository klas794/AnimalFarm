using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        public bool Alive { get; set; } = true;
        protected int ProductionRate { get; set; }
        protected int ForageNeeded;
        public int AgeForSlaughter { get; set; } = 5;
        protected int k = 2;
        public bool TreatedWell { get; set; } = false;

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }

        public abstract bool HaveBirthday();

        public abstract int[] ProduceYearsWorth();

        public abstract bool SlaughterAge();

        public void Feed(ref int forageLeft)
        {
            var increasedSurvivalChance = TreatedWell ? 50 : 0;

            if (!Alive)
            {
                return;
            }
            else if (forageLeft < ForageNeeded)
            {
                forageLeft = 0;

                if(new Random().Next(1,100) > increasedSurvivalChance )
                {
                    Alive = false;
                }
            }
            else
            {
                forageLeft -= ForageNeeded;
            }
        }

        public double CalculateAgeOfNaturalDeath()
        {
            return Math.Pow(AgeForSlaughter, 2) / k;
        }
    }
}
