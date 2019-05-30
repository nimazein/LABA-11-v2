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
    public partial class ContainObj : Form
    {
        public ContainObj()
        {
            InitializeComponent();
        }
        Support support = new Support();
        private void BTFindObject_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBName.Text)
               && !support.IsStringEmpty(TBWeight.Text))
            {
                string name = TBName.Text;
                int weight = Convert.ToInt32(TBWeight.Text);

               if (!support.IsStringEmpty(TBIncubationPeriod.Text)
                  && !support.IsStringEmpty(TBLifeExpectancy.Text))
                {
                    int lifeExpectancy = Convert.ToInt32(TBLifeExpectancy.Text);
                    int incubationPeriod = Convert.ToInt32(TBIncubationPeriod.Text);

                    if (!support.IsStringEmpty(TBHabitat.Text))
                    {
                        string habitat = TBHabitat.Text;

                        OrderArtiodactyl artiodactyl = new OrderArtiodactyl(CBHorns.Checked, habitat, incubationPeriod, lifeExpectancy, weight, name);
                        Contain(artiodactyl);
                    }
                    else
                    {
                        ClassMammals mammal = new ClassMammals(incubationPeriod, lifeExpectancy, weight, name);
                        Contain(mammal);
                    }
                }
                else
                {
                    if (CBBird.Checked)
                    {
                        ClassBirds bird = new ClassBirds(CBFlying.Checked, CBDomestic.Checked, weight, name);
                        Contain(bird);
                    }
                    else
                    {
                        KingdomAnimal animal = new KingdomAnimal(weight, name);
                        Contain(animal);
                    }
                }
            }
            else
            {
                support.ShowMistake();
            }
        }
        private void Contain(KingdomAnimal animal)
        {
            if (Main.animals.Contains(animal))
            {
                support.ShowInfo("Объект найден");
            }
            else
            {
                support.ShowInfo("Объект не найден");
            }
        }
        private void Contain(ClassMammals animal)
        {
            if (Main.animals.Contains(animal))
            {
                support.ShowInfo("Объект найден");
            }
            else
            {
                support.ShowInfo("Объект не найден");
            }
        }
        private void Contain(ClassBirds animal)
        {
            if (Main.animals.Contains(animal))
            {
                support.ShowInfo("Объект найден");
            }
            else
            {
                support.ShowInfo("Объект не найден");
            }
        }
        private void Contain(OrderArtiodactyl animal)
        {
            if (Main.animals.Contains(animal))
            {
                support.ShowInfo("Объект найден");
            }
            else
            {
                support.ShowInfo("Объект не найден");
            }
        }
    }
}
