using CoffeeShop.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public abstract class CoffeeBeverage
    {
        public string Name { get; set; }         
        public int CoffeeDosage { get; set; }
        public int SugarDosage { get; set; }
        public static int Counter { get; private set; }
        public MilkTypes MilkType { get; set; }
        public CoffeeBeverage() 
        {
            Counter++;
        }        
        public abstract void ShowTheIngredients();
        public abstract bool CheckCoffeeDosage();        
    }
}
