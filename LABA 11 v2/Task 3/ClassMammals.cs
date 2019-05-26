using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ClassMammals : KingdomAnimal, IAnimal
    {
        int incubationPeriod;
        int lifeExpectancy;

        public int IncubationPeriod
        {
            get
            {
                return incubationPeriod;
            }
            set
            {
                incubationPeriod = value;
            }
        }
        public int LifeExpectancy
        {
            get
            {
                return lifeExpectancy;
            }
            set
            {
                lifeExpectancy = value;
            }
        }
        
        public ClassMammals(int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(weight, name)
        {
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight}кг, {IncubationPeriod}месяцев, {LifeExpectancy}лет\n";
        }
    }
    
}
