using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.Commands.Responses
{
    public class CreatePersonResponseCommand
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address Address { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
