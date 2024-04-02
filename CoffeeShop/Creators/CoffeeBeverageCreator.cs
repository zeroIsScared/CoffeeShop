using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Creators
{
    public abstract class CoffeeBeverageCreator
    {
        public abstract CoffeeBeverage CreateBeverage(string name, int sugarDosage, int coffeeDosage, MilkTypes milkType);       
        
        public void DeliverCoffee(string name, int sugarDosage, int coffeeDosage, MilkTypes milkType)
        {
            CoffeeBeverage coffeeBeverage = CreateBeverage(name, sugarDosage, coffeeDosage, milkType);

            if (!coffeeBeverage.CheckCoffeeDosage())
            {
                Console.WriteLine($"Sorry, this coffee dosage do not corespond to the type {name} of coffee beverage");
            }

            coffeeBeverage.ShowTheIngredients();
        }
    }
}
