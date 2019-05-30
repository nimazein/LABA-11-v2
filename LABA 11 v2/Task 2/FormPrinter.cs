using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
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


        private PrintEach printEach;
        public PrintEach PrintEach
        {
            get
            {
                return printEach;
            }
            set
            {
                printEach = value;
            }
        }

        public void PrintElement(object individual)
        {
            string output = "";
            switch (support.IdentifyType(individual))
            {
                case "animal":
                    output = (individual as KingdomAnimal).ToString();
                    break;

                case "birds":
                    output = (individual as ClassBirds).ToString();
                    break;

                case "mammals":
                    output = (individual as ClassMammals).ToString();
                    break;

                case "artyodactyl":
                    output = (individual as OrderArtiodactyl).ToString();
                    break;
            }
            printEach.PrintString(output);
        }
    }
}
