using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tasks
{
    public class Collection
    {      
        public SortedList animals = new SortedList();

        Support support = new Support();
        int animalNumber = 1;
        int mammalNumber = 1;
        int artyodactylNumber = 1;
        int birdNumber = 1;

        public void AddToList(string name, int weight)
        {
            animals.Add($"Животное {animalNumber}", new KingdomAnimal
                (weight, name));
            animalNumber++;
        }
        public void AddToList(string name, int weight, int incubationPeriod, int lifeExpectancy)
        {
            animals.Add($"Млекопитающее {mammalNumber}", new ClassMammals
                (incubationPeriod, lifeExpectancy, weight, name));
            mammalNumber++;
        }
        public void AddToList(string name, int weight, int incubationPeriod, int lifeExpectancy, bool hasHorns, string habitat)
        {
            animals.Add($"Парнокопытное {artyodactylNumber}", new OrderArtiodactyl
                (hasHorns, habitat, incubationPeriod, lifeExpectancy, weight, name));
            artyodactylNumber++;
        }
        public void AddToList(string name, int weight, bool flying, bool domestic)
        {
            animals.Add($"Птица {birdNumber}", new ClassBirds
                (flying, domestic, weight, name));
            birdNumber++;

        }
        public void DeleteByKey(string key)
        {
            if (animals.ContainsKey(key))
            {
                animals.Remove(key);
            }
            else
            {
                support.ShowMistake(content:"Элемента с таким ключом нет");
            }
        }
        public object FindByKey(string key)
        {
            if (animals.ContainsKey(key))
            {
                return animals[key];
            }
            else
            {
                support.ShowMistake(content: "Элемента с таким ключом нет");
                return null;
            }
        }
        public int GetAnimalNumber()
        {
            return animalNumber;
        }
        public int GetBirdNumber()
        {
            return birdNumber;
        }
        public int GetMammalNumber()
        {
            return mammalNumber;
        }
        public int GetArtiodactylNumber()
        {
            return artyodactylNumber;
        }
        public void PrintThisType(string type, IPrinter printer)
        {
            foreach (object animal in animals)
            {
                switch (type)
                {
                    case "Животное":
                        if (animal is KingdomAnimal)
                        {
                            printer.PrintThisType(animal as KingdomAnimal);
                        }
                        break;
                    case "Млекопитающее":
                        if (animal is ClassMammals) 
                        {
                            printer.PrintThisType(animal as ClassMammals);
                        }
                        break;
                    case "Птица":
                        if (animal is ClassBirds)
                        {
                            printer.PrintThisType(animal as ClassBirds);
                        }
                        break;
                    case "Парнокопытное":
                        if (animal is OrderArtiodactyl)
                        {
                            printer.PrintThisType(animal as OrderArtiodactyl);
                        }
                        break;
                }
            }
            
        }
        public void PrintEach(IPrinter printer)
        {
            foreach (object animal in animals)
            {
                printer.PrintElement(animal);
            }
        }
    }
}
