using Facade.Interfaces;

namespace Facade
{
    public class PizzaSupplier : IPizza
    {
        public void GetNormalPizza()
        {
            GetNonVeganCoverage();
            Console.WriteLine("Getting Common Pizza.");
        }

        public void GetVeganPizza()
        {
            Console.WriteLine("Getting Vegan Pizza.");
        }

        private void GetNonVeganCoverage()
        {
            Console.WriteLine("Getting Non-vegetable Pizza Toppings.");
        }
    }
}