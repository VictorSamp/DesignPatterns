using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    internal class PlatinumCard : CreditCard
    {
        private readonly string _type;
        private int _creditLimit;
        private int _annualBilling;

        public PlatinumCard(int creditLimit, int annualBilling)
        {
            _type = "Platinum";
            _creditLimit = creditLimit;
            _annualBilling = annualBilling;
        }

        public override string Type
        {
            get { return _type; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualBilling
        {
            get { return _annualBilling; }
            set { _annualBilling = value; }
        }
    }
}