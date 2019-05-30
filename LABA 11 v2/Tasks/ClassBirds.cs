using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class ClassBirds : KingdomAnimal, IAnimal
    {
        bool flying;
        bool domestic;

        public bool Flying
        {
            get
            {
                return flying;
            }
            set
            {
                flying = value;
            }
        }
        public bool Domestic
        {
            get
            {
                return domestic;
            }
            set
            {
                domestic = value;
            }
        }

        public ClassBirds(bool flying, bool domestic, int weight, string name) 
            : base(weight, name)
        {
            Flying = flying;
            Domestic = domestic;
        }
        public override string ToString()
        {            
            return $"{Name}, {Weight} кг, летает: {Flying}, домашняя: {Domestic}";
        }
    }
}
