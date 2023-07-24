using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.Commands.Responses
{
    public class CreatePersonResponseCommand
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public DateTime CreateDate { get; set; }
    }
}