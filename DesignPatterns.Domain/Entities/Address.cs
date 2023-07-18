namespace DesignPatterns.Domain.Entities
{
    internal class Address
    {
        public Guid Id { get; init; }
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string Number { get; private set; }
        public string City { get; private set; }
        public string State { get; set; }

        public Address(string street, string neighborhood, string number,
            string city, string state)
        {
            Street = street;
            Neighborhood = neighborhood;
            Number = number;
            City = city;
            State = state;
        }
    }
}
