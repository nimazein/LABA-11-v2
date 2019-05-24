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
            foreach (object animal in collection.animals)
            {
                newCollection.animals.Add(collection.animals.GetKey(collection.animals.IndexOfValue(animal)), animal);
            }
            
        }
    }
}
