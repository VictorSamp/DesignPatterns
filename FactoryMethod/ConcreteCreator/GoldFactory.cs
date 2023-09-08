using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    internal class GoldFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualBilling;

        public GoldFactory(int creditLimit, int annualBilling)
        {
            _creditLimit = creditLimit;
            _annualBilling = annualBilling;
        }

        internal override CreditCard GetCreditCard()
        {
            return new GoldCard(_creditLimit, _annualBilling);
        }
    }
}