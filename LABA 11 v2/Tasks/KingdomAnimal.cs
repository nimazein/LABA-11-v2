using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class KingdomAnimal : IAnimal
    {
        string name;
        int weight;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }         
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public KingdomAnimal(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight}кг\n";
        }
    }
}
