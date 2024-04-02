using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Creators
{
    public class CoffeeMaker : CoffeeBeverageCreator
    {
        public override  CoffeeBeverage CreateBeverage(string name, int sugarDosage, int coffeeDosage, MilkTypes milkType)
        {
            switch (name)
            {
                case "Espresso":
                    return new Espresso
                    {
                        Name = name,
                        SugarDosage = sugarDosage,
                        CoffeeDosage = coffeeDosage,
                        MilkType = milkType
                    };

                case "Cappuccino":
                    return new Cappuccino
                    {
                        Name = name,
                        SugarDosage = sugarDosage,
                        CoffeeDosage = coffeeDosage,
                        MilkType = milkType
                    };

                case "FlatWhite":
                    return new FlatWhite
                    {
                        Name = name,
                        SugarDosage = sugarDosage,
                        CoffeeDosage = coffeeDosage,
                        MilkType = milkType
                    };

                default:
                    throw new NotSupportedException(
                        $"{name} is not currently supported"
                        );
            }    
            
        }
    }
}
