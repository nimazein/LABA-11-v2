using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class DeleteElement : Form
    {
        public DeleteElement()
        {
            InitializeComponent();
        }

        Support support = new Support();
        Collection collection = Main.collection;

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBKey.Text))
            {
                string key = TBKey.Text;
                collection.DeleteByKey(key);
                MessageBox.Show("Объект удален");
            }
            else
            {
                support.ShowMistake();
            }
        }
    }
}
