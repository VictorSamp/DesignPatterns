using DesignPatterns.Domain.Commands.Requests;

namespace DesignPatterns.Domain.Entities
{
    internal class Person
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address Address { get; private set; }

        public Person(string name, string lastName, string email, DateTime birthDate, Address address)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            Address = address;
        }

        public Person(CreatePersonRequestCommand command)
        {
            Id = Guid.NewGuid();
            Name = command.Name;
            LastName = command.LastName;
            Email = command.Email;
            BirthDate = command.BirthDate;
            Address = command.Address;
        }
    }
}
