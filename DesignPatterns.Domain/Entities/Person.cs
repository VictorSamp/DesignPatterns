namespace DesignPatterns.Domain.Entities
{
    internal class Person
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address Address { get; private set; }

        public Person(string name, string lastName, DateTime birthDate, Address address)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
        }
    }
}
