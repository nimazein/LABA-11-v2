using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    class FormPrinter : IPrinter
    {
        Support support = new Support();

        private PrintElementsWithThisType printElThisType;

        public PrintElementsWithThisType PrintElThisType
        {           
            set
            {
                printElThisType = value;
            }
            get
            {
                return printElThisType;
            }
        }
        public void PrintThisType(KingdomAnimal individual)
        {
            PrintElThisType.Output(individual);
        }
        public void PrintThisType(ClassBirds individual)
        {
            PrintElThisType.Output(individual);
        }
        public void PrintThisType(ClassMammals individual)
        {
            PrintElThisType.Output(individual);
        }
        public void PrintThisType(OrderArtiodactyl individual)
        {
            PrintElThisType.Output(individual);
        }






        public void PrintElement(object individual)
        {

        }

       














        public void PrintElement(object individual, Form form)
        {
            switch (support.IdentifyType(individual))
            {
                case "animal":
                    form.Print(individual as KingdomAnimal);
                    break;

                case "bird":
                    form.Print(individual as ClassBirds);
                    break;

                case "mammal":
                    form.Print(individual as ClassMammals);
                    break;

                case "artyodactyl":
                    form.Print(individual as OrderArtiodactyl);
                    break;
            }
        }
    }
}
