using DesignPatterns.Domain.Commands.Requests;
using DesignPatterns.Domain.Commands.Responses;

namespace DesignPatterns.Domain.CommandHandlers.Abstractions
{
    public interface ICreatePersonHandler
    {
        CreatePersonResponseCommand Handle(CreatePersonRequestCommand command);
    }
}
