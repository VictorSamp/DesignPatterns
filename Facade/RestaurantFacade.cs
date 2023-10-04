using Facade.Interfaces;

namespace Facade
{
    public class RestaurantFacade
    {
        private IPizza _pizzaSupplier;
        private IBread _breadSupplier;

        public RestaurantFacade()
        {
            _pizzaSupplier = new PizzaSupplier();
            _breadSupplier = new BreadSupplier();
        }

        public void GetNormalPizza()
        {
            _pizzaSupplier.GetNormalPizza();
        }

        public void GetVeganPizza()
        {
            _pizzaSupplier.GetVeganPizza();
        }

        public void GetGarlicBread()
        {
            _breadSupplier.GetGarlicBread();
        }

        public void GetGarlicBreadWithCheese()
        {
            _breadSupplier.GetGarlicBreadWithCheese();
        }
    }
}