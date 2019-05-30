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

            animals = new MyQueue<IAnimal>(InputCapacity.capacity);

            BTFill.Enabled = true;
        }

        private void BTCtorCollection_Click(object sender, EventArgs e)
        {
            MyQueue<IAnimal> zoo = new MyQueue<IAnimal>(5);

            zoo.Enqueue(new KingdomAnimal(150000, "Кит"));
            zoo.Enqueue(new ClassBirds(true, true, 1, "Попугай"));
            zoo.Enqueue(new ClassMammals(9, 100, 80, "Человек"));
            zoo.Enqueue(new OrderArtiodactyl(true, "Степи", 12, 35, 500, "Корова"));

            animals = new MyQueue<IAnimal>(zoo);

            BTClear.Enabled = true;
            BTClone.Enabled = true;
            BTContains.Enabled = true;
            BTCopyTo.Enabled = true;
            BTCount.Enabled = true;
            BTDequeue.Enabled = true;
            BTEnqueue.Enabled = true;
            BTPeek.Enabled = true;
            BTToArray.Enabled = true;
            BTCapacity.Enabled = true;
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

        private void BTFill_Click(object sender, EventArgs e)
        {
            FillCollection form = new FillCollection();
            form.ShowDialog();

            BTClear.Enabled = true;
            BTClone.Enabled = true;
            BTContains.Enabled = true;
            BTCopyTo.Enabled = true;
            BTCount.Enabled = true;
            BTDequeue.Enabled = true;
            BTEnqueue.Enabled = true;
            BTPeek.Enabled = true;
            BTToArray.Enabled = true;
            BTCapacity.Enabled = true;
        }

        private void BTCount_Click(object sender, EventArgs e)
        {
            string content = $"Объектов в коллекции: {Main.animals.Count}";
            support.ShowInfo(content);
        }

        private void BTCapacity_Click(object sender, EventArgs e)
        {
            string content = $"Вместимость коллекции: {Main.animals.Capacity}";
            support.ShowInfo(content);
        }

        private void BTContains_Click(object sender, EventArgs e)
        {
            ContainObj form = new ContainObj();
            form.ShowDialog();
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            Main.animals.Clear();
            support.ShowInfo("Коллекция очищена");
        }

        private void BTEnqueue_Click(object sender, EventArgs e)
        {
            AddElement form = new AddElement();
            form.ShowDialog();
        }

        private void BTPeek_Click(object sender, EventArgs e)
        {
            support.ShowInfo(Main.animals.Peek().ToString());
        }

        private void BTDequeue_Click(object sender, EventArgs e)
        {
            support.ShowInfo(Main.animals.Dequeue().ToString());         
        }

        private void BTToArray_Click(object sender, EventArgs e)
        {
            Array array = Main.animals.ToArray();
            support.ShowInfo("Коллекция преобразована в массив");
        }

        private void BTClone_Click(object sender, EventArgs e)
        {
            List<IAnimal> newZoo = Main.animals.Clone();
            support.ShowInfo("Колекция клонирована");
        }

        private void BTCopyTo_Click(object sender, EventArgs e)
        {
            IAnimal[] array = new IAnimal[animals.Count];
            animals.CopyTo(array, 0);
            support.ShowInfo("Колекция скопирована в массив");
        }
    }


}
