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
    public partial class AddElements : Form
    {
        public AddElements()
        {
            InitializeComponent();
        }
        Support support = new Support();
        Collection sortedList = Main.collection;

        private void BTMammalCreate_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBMammalName.Text)
                && !support.IsStringEmpty(TBMammalWeight.Text)
                && !support.IsStringEmpty(TBMammalMaxAge.Text)
                && !support.IsStringEmpty(TBMammalIncubationPeriod.Text))
            {
                string name = TBMammalName.Text;
                int weight = Convert.ToInt32(TBMammalWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBMammalIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBMammalMaxAge.Text);

                sortedList.AddToList(name, weight, incubationPeriod, lifeExpectancy);
            }
            else
            {
                support.ShowMistake();
            }

            TBMammalWeight.Clear();
            TBMammalName.Clear();
            TBMammalMaxAge.Clear();
            TBMammalIncubationPeriod.Clear();
        }

        private void BTAnimalCreate_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBAnimalName.Text)
                && !support.IsStringEmpty(TBAnimalWeight.Text))
            {
                string name = TBAnimalName.Text;
                int weight = Convert.ToInt32(TBAnimalWeight.Text);

                sortedList.AddToList(name, weight);
            }
            else
            {
                support.ShowMistake();
            }

            TBAnimalName.Clear();
            TBAnimalWeight.Clear();
        }

        private void BTBirdCreate_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBBirdName.Text)
                && !support.IsStringEmpty(TBBirdWeight.Text))
            {
                string name = TBBirdName.Text;
                int weight = Convert.ToInt32(TBBirdWeight.Text);
                bool flying = CBFlying.Checked;
                bool domestic = CBDomestic.Checked;

                sortedList.AddToList(name, weight, flying, domestic);
            }
            else
            {
                support.ShowMistake();
            }

            TBBirdWeight.Clear();
            TBBirdName.Clear();
        }

        private void BTArtiodactylCreate_Click(object sender, EventArgs e)
        {
            if (!support.IsStringEmpty(TBArtiodactylName.Text)
                && !support.IsStringEmpty(TBArtiodactylWeight.Text)
                && !support.IsStringEmpty(TBArtiodactylMaxAge.Text)
                && !support.IsStringEmpty(TBArtiodactylIncubationPeriod.Text)
                && !support.IsStringEmpty(TBArtiodactylHabitat.Text))
            {
                string name = TBArtiodactylName.Text;
                int weight = Convert.ToInt32(TBArtiodactylWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBArtiodactylIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBArtiodactylMaxAge.Text);
                bool hasHorns = CBHorns.Checked;
                string habitat = TBArtiodactylHabitat.Text;

                sortedList.AddToList(name, weight, incubationPeriod, lifeExpectancy, hasHorns, habitat);
            }
            else
            {
                support.ShowMistake();
            }

            TBArtiodactylHabitat.Clear();
            TBArtiodactylIncubationPeriod.Clear();
            TBArtiodactylMaxAge.Clear();
            TBArtiodactylName.Clear();
            TBArtiodactylWeight.Clear();
        }
    }
}
