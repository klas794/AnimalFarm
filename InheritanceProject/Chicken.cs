using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Chicken : Animal
    {
        public Chicken(string _name, int _age)
        {
            name = _name;
            age = _age;

            ProductionRate = 300;
            ForageNeeded = 10;

            AgeForSlaughter += age;
        }

        /// <summary>
        /// The chicken celebrates it's birthday. Returns true if the chicken survives another year, otherwise false.
        /// </summary>
        public override bool HaveBirthday()
        {
            age++;
            if (age < CalculateAgeOfNaturalDeath())
                return true;
            return false;
        }

        public override bool SlaughterAge()
        {
            if (age == AgeForSlaughter)
            {
                Alive = false;
                return true;
            }

            return false;
        }

        public override int[] ProduceYearsWorth()
        {
            var numberOfProds = Enum.GetNames(typeof(Products)).Length;

            var production = new int[numberOfProds];

            production[(int)Products.Egg] = Alive ? ProductionRate: 0;
            production[(int)Products.Meat] = SlaughterAge() ? 1: 0;

            return production;
        }
    }
}
