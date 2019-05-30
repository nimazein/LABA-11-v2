using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class PrintElementsWithThisType : Form
    {
        public PrintElementsWithThisType()
        {
            InitializeComponent();
        }

        Collection сollection = Main.collection;
        private void BTPrint_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            string type = "";
            switch (CBTypes.SelectedIndex)
            {
                case 0:
                    type = "Животные";
                    break;

                case 1:
                    type = "Млекопитающие";
                    break;

                case 2:
                    type = "Птицы";
                    break;

                case 3:
                    type = "Парнокопытные";
                    break;
            }

            FormPrinter printer = new FormPrinter();
            printer.PrintElThisType = this;
            сollection.PrintThisType(type, printer);

        }
        public void Output(KingdomAnimal animal)
        {
            TBOutput.Text += animal.ToString();
        }
        public void Output(ClassMammals animal)
        {
            TBOutput.Text += animal.ToString();
        }
        public void Output(ClassBirds animal)
        {
            TBOutput.Text += animal.ToString();
        }
        public void Output(OrderArtiodactyl animal)
        {
            TBOutput.Text += animal.ToString();
        }

        private void PrintElementsWithThisType_Load(object sender, EventArgs e)
        {

        }
    }
}
