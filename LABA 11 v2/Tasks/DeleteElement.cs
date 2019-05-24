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
