using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class OrderArtiodactyl : ClassMammals, IAnimal
    {
        bool hasHorns;
        string habitat;

        public bool HasHorns
        {
            get
            {
                return hasHorns;
            }
            set
            {
                hasHorns = value;
            }
        }
        public string Habitat
        {
            get
            {
                return habitat;
            }
            set
            {
                habitat = value;
            }
        }
        public OrderArtiodactyl(bool hasHorns, string habitat, int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(incubationPeriod, lifeExpectancy, weight, name)
        {
            HasHorns = hasHorns;
            Habitat = habitat;
        }

        public override string ToString()
        {
            return $"{Name}, {Weight}кг, {IncubationPeriod}месяцев, {LifeExpectancy}лет, есть рога: {HasHorns}, {Habitat}\n";
        }

    }
}
