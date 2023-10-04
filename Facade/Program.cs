using Facade;

var facade = new RestaurantFacade();

Console.WriteLine("----------------------PIZZA ORDERS----------------------------\n");
facade.GetNormalPizza();
facade.GetVeganPizza();

Console.WriteLine("\n----------------------BREAD ORDERS----------------------------\n");
facade.GetGarlicBread();
facade.GetGarlicBreadWithCheese();