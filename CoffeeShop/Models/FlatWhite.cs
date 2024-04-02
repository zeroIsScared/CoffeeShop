using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{ 
    public class FlatWhite : CoffeeBeverage
    {          
        public FlatWhite() : base()
        {               
        }
        public override void ShowTheIngredients()
        {
            Console.WriteLine($"This {Name} - {Counter} is made with: {CoffeeDosage} X black coffee, {SugarDosage} X sugar, {MilkType} milk");
        }
        public override bool CheckCoffeeDosage()
        {
            return CoffeeDosage == 2;
        }
    }    
}
