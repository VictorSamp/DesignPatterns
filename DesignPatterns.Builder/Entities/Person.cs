namespace DesignPatterns.Builder.Entities
{
    internal class Person
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }

        public Person(string name, string lastName, string document, string phone, Address address)
        {
            Name = name;
            LastName = lastName;
            Document = document;
            Phone = phone;
            Address = address;
        }
    }
}