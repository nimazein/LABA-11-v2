using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public interface IPrinter
    {
        void PrintElement(object individual);
        void PrintThisType(KingdomAnimal individual);

        void PrintThisType(ClassBirds individual);

        void PrintThisType(ClassMammals individual);

        void PrintThisType(OrderArtiodactyl individual);

    }
}
