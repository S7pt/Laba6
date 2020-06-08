using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Laba4Task2.manager;
using Laba4Task2.model;

namespace Laba4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoOwnerManager manager=new AutoOwnerManager();
            List<AutoOwner> autoOwners=new List<AutoOwner>();
            autoOwners.Add(new AutoOwner("Oleg",098526987,"BMW","Red","21-801-27"));
            autoOwners.Add(new AutoOwner("Ivan",0961234568,"Porsche","Blue","38-951-39"));
            autoOwners.Add(new AutoOwner("Taras",097254968,"Ford","Green","21-801-27"));
            autoOwners.Add(new AutoOwner("Oleksandr",0983794563,"Audi","Blue","21-801-27"));
            autoOwners.Add(new AutoOwner("Dmytro",097956345,"BMW","Red","21-801-27"));
            autoOwners.Add(new AutoOwner("Mykyta",0986153351,"BMW","Yellow","21-801-27"));
            autoOwners.Add(new AutoOwner("Roman",0991356654,"Chevrolet","Orange","21-801-27"));
            autoOwners.Add(new AutoOwner("Maran",0976866484,"Ford","White","21-801-27"));
            autoOwners.Add(new AutoOwner("Pavlo",0978956454,"Peugeot","Red","21-801-27"));
            Console.WriteLine("Type the colour you need to find");
                string color = Console.ReadLine();
                Regex regex = new Regex("[0-9]");
                MatchCollection matches = regex.Matches(color);
                if (matches.Count > 0)
                {
                    throw new ArgumentException("You typed invalid symbol in color");
                }
                Console.WriteLine("Type the brand you need to find");
                string brand = Console.ReadLine();
                matches = regex.Matches(brand);
                if (matches.Count > 0)
                {
                    throw new ArgumentException("You typed invalid symbol in brand name");
                }
                List<AutoOwner> filteredList = manager.FindByColourAndAutoBrand(color, brand, autoOwners);
            

            if (filteredList.Count!=0)
            {
                foreach (AutoOwner owner in filteredList)
                {
                    Console.WriteLine(owner.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no auto owner matching these parameters");
            }
            
        }
    }
}