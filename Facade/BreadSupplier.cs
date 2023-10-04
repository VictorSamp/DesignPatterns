using Facade.Interfaces;

namespace Facade
{
    public class BreadSupplier : IBread
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }

        public void GetGarlicBreadWithCheese()
        {
            GetCheese();
            Console.WriteLine("Getting Garlic Bread With Cheese.");
        }

        public void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}