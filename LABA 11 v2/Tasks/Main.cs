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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static Collection collection;
        private void BTAddElements_Click(object sender, EventArgs e)
        {
            EnableButtons();
            AddElements form = new AddElements();
            form.ShowDialog();
        }

        private void BTDeleteElements_Click(object sender, EventArgs e)
        {
            DeleteElement form = new DeleteElement();
            form.ShowDialog();
        }

        private void BTNumOfElementsWithThisType_Click(object sender, EventArgs e)
        {
            NumberOfElementsWithThisType form = new NumberOfElementsWithThisType();
            form.ShowDialog();
        }

        private void BTCreate_Click(object sender, EventArgs e)
        {
            collection = new Collection();
            BTAddElements.Enabled = true;
        }

        private void BTFindElementByKey_Click(object sender, EventArgs e)
        {
            FindElementByKey form = new FindElementByKey();
            form.ShowDialog();

        }

        private void BTPrintElementsWithThisType_Click(object sender, EventArgs e)
        {
            PrintElementsWithThisType form = new PrintElementsWithThisType();
            form.ShowDialog();
        }

        private void BTPrintEach_Click(object sender, EventArgs e)
        {
            PrintEach form = new PrintEach();
            form.ShowDialog();
        }

        private void BTClone_Click(object sender, EventArgs e)
        {
            Collection newCollection = new Collection();
            
            for (int i = 0; i < collection.animals.Count; i++)
            {
                object key = collection.animals.GetKey(i);
                object value = collection.animals.GetByIndex(i);

                newCollection.animals.Add(key, value);
            }
            
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            BTAddElements.Enabled = false;
            BTClone.Enabled = false;
            BTDeleteElements.Enabled = false;
            BTFindElementByKey.Enabled = false;
            BTNumOfElementsWithThisType.Enabled = false;
            BTPrintEach.Enabled = false;
            BTPrintElementsWithThisType.Enabled = false;
        }
        private void EnableButtons()
        {           
            BTClone.Enabled = true;
            BTDeleteElements.Enabled = true;
            BTFindElementByKey.Enabled = true;
            BTNumOfElementsWithThisType.Enabled = true;
            BTPrintEach.Enabled = true;
            BTPrintElementsWithThisType.Enabled = true;
        }
    }
}
