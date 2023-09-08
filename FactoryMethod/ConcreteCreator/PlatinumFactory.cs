using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    internal class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualBilling;

        public PlatinumFactory(int creditLimit, int annualBilling)
        {
            _creditLimit = creditLimit;
            _annualBilling = annualBilling;
        }

        internal override CreditCard GetCreditCard()
        {
            return new PlatinumCard(_creditLimit, _annualBilling);
        }
    }
}