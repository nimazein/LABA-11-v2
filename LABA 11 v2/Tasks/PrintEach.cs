using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
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
            FormPrinter printer = new FormPrinter();
            printer.PrintEach = this;

            collection.PrintEach(printer);            
        }
        public void PrintString(string line)
        {
            TBOutput.Text += line + "\n";
        }
    }
}
