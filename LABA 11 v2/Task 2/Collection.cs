using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_2
{
    public class Collection
    {
        public SortedDictionary<string, IAnimal> animals = new SortedDictionary<string, IAnimal>();
        
        Support support = new Support();
        int animalNumber = 1;
        int mammalNumber = 1;
        int artyodactylNumber = 1;
        int birdNumber = 1;

        public void AddToList(string name, int weight)
        {
            string key = $"Животное {animalNumber}";
            KingdomAnimal animal = new KingdomAnimal(weight, name);  

            animals.Add(key, animal);
                     
           
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
                ChangeNumber(key);
            }
            else
            {
                support.ShowMistake(content:"Элемента с таким ключом нет");
            }
        }
        private void ChangeNumber(string key)
        {
            if (key.Contains("Животное"))
            {
                animalNumber--;
            }
            if (key.Contains("Птица"))
            {
                birdNumber--;
            }
            if (key.Contains("Млекопитающее"))
            {
                mammalNumber--;
            }
            if (key.Contains("Парнокопытное"))
            {
                artyodactylNumber--;
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
            return animalNumber - 1;
        }
        public int GetBirdNumber()
        {
            return birdNumber - 1;
        }
        public int GetMammalNumber()
        {
            return mammalNumber - 1;
        }
        public int GetArtiodactylNumber()
        {
            return artyodactylNumber - 1;
        }
        public void PrintThisType(string type, IPrinter printer)
        {
            foreach (var element in animals)
            {
                if (element.Value is KingdomAnimal)
                {
                    if (element.Value is ClassMammals)
                    {
                        if (element.Value is OrderArtiodactyl)
                        {
                            if (type == "Парнокопытные")
                            {
                                printer.PrintThisType(element.Value as OrderArtiodactyl);
                                continue;
                            }
                        }
                        if (type == "Млекопитающие")
                        {
                            printer.PrintThisType(element.Value as ClassMammals);
                            continue;
                        }                
                    }
                    if (element.Value is ClassBirds)
                    {
                        if (type == "Птицы")
                        {
                            printer.PrintThisType(element.Value as ClassBirds);
                            continue;
                        }
                    }
                    if (type == "Животные")
                    {
                        printer.PrintThisType(element.Value as KingdomAnimal);
                        continue;
                    }                    
                    
                }
                
                
            }           
        }
        public void PrintEach(IPrinter printer)
        {
            int i = 0;
            foreach (var element in animals)
            {
                printer.PrintElement(element.Value);
                i++;
            }
        }
    }
}
