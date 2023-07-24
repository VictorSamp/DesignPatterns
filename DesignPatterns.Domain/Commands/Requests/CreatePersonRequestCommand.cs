using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.Commands.Requests
{
    public class CreatePersonRequestCommand
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address Address { get; private set; }
    }
}
