using DesignPatterns.Domain.CommandHandlers.Abstractions;
using DesignPatterns.Domain.Commands.Requests;
using DesignPatterns.Domain.Commands.Responses;
using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.CommandHandlers
{
    public class CreatePersonCommandHandler : ICreatePersonHandler
    {
        public IPersonRepository _personRepository { get; set; }

        public IEmailService _emailService { get; set; }

        public CreatePersonCommandHandler(IPersonRepository personRepository, IEmailService emailService)
        {
            _personRepository = personRepository;
            _emailService = emailService;
        }

        public CreatePersonResponseCommand Handle(CreatePersonRequestCommand command)
        {
            var person = new Person(command);

            _personRepository.Save(person);

            _emailService.Send(person.Name, person.Email);

            return new CreatePersonResponseCommand()
            {
                Id = person.Id,
                Name = person.Name,
                LastName = person.LastName,
                Email = person.Email,
                BirthDate = person.BirthDate,
                Address = person.Address,
                CreateDate = DateTime.Now
            };
        }
    }
}