using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    internal class BlackFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualBilling;

        public BlackFactory(int creditLimit, int annualBilling)
        {
            _creditLimit = creditLimit;
            _annualBilling = annualBilling;
        }

        internal override CreditCard GetCreditCard()
        {
            return new BlackCard(_creditLimit, _annualBilling);
        }
    }
}