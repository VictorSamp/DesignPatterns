using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    internal abstract class CardFactory
    {
        internal abstract CreditCard GetCreditCard();
    }
}