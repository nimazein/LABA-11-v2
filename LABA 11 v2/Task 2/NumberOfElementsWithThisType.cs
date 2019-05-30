using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class NumberOfElementsWithThisType : Form
    {
        public NumberOfElementsWithThisType()
        {
            InitializeComponent();
        }

        Collection collection = Main.collection;
        private void BTShow_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            int output = -1;
            switch (CBTypes.SelectedIndex)
            {
                case 0:
                    TBOutput.Text += "Животных: ";
                    output = collection.GetAnimalNumber();
                    break;
                case 1:
                    TBOutput.Text += "Млекопитающих: ";
                    output = collection.GetMammalNumber();
                    break;
                case 2:
                    TBOutput.Text += "Птиц: ";
                    output = collection.GetBirdNumber();
                    break;
                case 3:
                    TBOutput.Text += "Парнокопытных: ";
                    output = collection.GetArtiodactylNumber();
                    break;
            }
            TBOutput.Text += output.ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
