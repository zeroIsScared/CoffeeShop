using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeShop.Models
{
    public class Cappuccino : CoffeeBeverage
    {    
        
        public Cappuccino() : base()
        {            
        }
        public override void ShowTheIngredients()
        {
            Console.WriteLine($"This {Name} - {Counter} is made with: {CoffeeDosage} X black coffee, {SugarDosage} X sugar, {MilkType} milk");
        }

        public override bool CheckCoffeeDosage ()
        {
            return CoffeeDosage == 1;
        }
    }
}
