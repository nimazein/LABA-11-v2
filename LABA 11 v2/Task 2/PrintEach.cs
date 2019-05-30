using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class PrintEach : Form
    {
        public PrintEach()
        {
            InitializeComponent();
        }
        Collection collection = Main.collection;
        private void PrintEach_Load(object sender, EventArgs e)
        {

        }
        public void PrintString(string line)
        {
            TBOutput.Text += line;
        }

        private void TBOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void BTOutput_Click(object sender, EventArgs e)
        {
            FormPrinter printer = new FormPrinter();
            printer.PrintEach = this;

            collection.PrintEach(printer);
        }
    }
}
