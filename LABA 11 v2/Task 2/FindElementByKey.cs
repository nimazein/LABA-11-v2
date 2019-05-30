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
    public partial class FindElementByKey : Form
    {
        public FindElementByKey()
        {
            InitializeComponent();
        }

        Support support = new Support();
        Collection collection = Main.collection;
        private void BTFind_Click(object sender, EventArgs e)
        {
            string output = "";
            if (!support.IsStringEmpty(TBKey.Text))
            {
                string key = TBKey.Text;
                object soughtForAnimal = collection.FindByKey(key);

                if (soughtForAnimal != null)
                {
                    if (key.Contains("Животное"))
                    {
                        KingdomAnimal animal = soughtForAnimal as KingdomAnimal;
                        output = animal.ToString();
                    }
                    if (key.Contains("Млекопитающее"))
                    {
                        ClassMammals mammal = soughtForAnimal as ClassMammals;
                        output = mammal.ToString();
                    }
                    if (key.Contains("Птица"))
                    {
                        ClassBirds bird = soughtForAnimal as ClassBirds;
                        output = bird.ToString();
                    }
                    if (key.Contains("Парнокопытное"))
                    {
                        OrderArtiodactyl artiodactyl = soughtForAnimal as OrderArtiodactyl;
                        output = artiodactyl.ToString();
                    }
                    TBOutput.Text += output;

                }
            }
            else
            {
                support.ShowMistake();
            }
        }
    }
}
