using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Support support = new Support();
        public static MyQueue<IAnimal> animals;
        private void BTCtorEmpty_Click(object sender, EventArgs e)
        {
            support.ShowInfo("Коллекция размерностью 32 создана");
            animals = new MyQueue<IAnimal>();

            BTFill.Enabled = true;
        }

        private void BTCtorCapacity_Click(object sender, EventArgs e)
        {
            InputCapacity form = new InputCapacity();
            form.ShowDialog();

            animals = new MyQueue<IAnimal>(capacity:InputCapacity.capacity);

            BTFill.Enabled = false;
        }

        private void BTCtorCollection_Click(object sender, EventArgs e)
        {
            MyQueue<IAnimal> zoo = new MyQueue<IAnimal>(5);

            zoo.Enqueue(new KingdomAnimal(150000, "Кит"));
            zoo.Enqueue(new ClassBirds(true, true, 1, "Попугай"));
            zoo.Enqueue(new ClassMammals(9, 100, 80, "Человек"));
            zoo.Enqueue(new OrderArtiodactyl(true, "Степи", 12, 35, 500, "Корова"));

            animals = new MyQueue<IAnimal>(zoo);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            BTClear.Enabled = false;
            BTClone.Enabled = false;
            BTContains.Enabled = false;
            BTCopyTo.Enabled = false;
            BTCount.Enabled = false;
            BTDequeue.Enabled = false;
            BTEnqueue.Enabled = false;
            BTFill.Enabled = false;
            BTPeek.Enabled = false;
            BTToArray.Enabled = false;
            BTCapacity.Enabled = false;
        }
    }
}
