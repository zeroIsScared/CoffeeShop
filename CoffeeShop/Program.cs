// See https://aka.ms/new-console-template for more information
using CoffeeShop.Creators;

CoffeeBeverageCreator coffeeFactory = new CoffeeMaker();

//var coffee1 = coffeeFactory.DeliverCoffee("Espresso", 0, 1, MilkTypes.without);

coffeeFactory.DeliverCoffee("Cappuccino", 1, 1, MilkTypes.Oat);
coffeeFactory.DeliverCoffee("FlatWhite", 2, 2, MilkTypes.Soy);
coffeeFactory.DeliverCoffee("Cappuccino", 1, 0, MilkTypes.without);
