namespace FactoryMethod.Product
{
    internal abstract class CreditCard
    {
        public abstract string Type { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualBilling { get; set; }
    }
}