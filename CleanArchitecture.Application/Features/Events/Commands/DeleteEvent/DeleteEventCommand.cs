using MediatR;

namespace CleanArchitecture.Application.Features.Events.Commands.DeleteEvent;

public class DeleteEventCommand : IRequest
{
    public Guid EventId { get; set; }
}