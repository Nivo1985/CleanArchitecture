using MediatR;

namespace CleanArchitecture.Application.Features.Events.Queries.GetEventsExport;

public class GetEventsExportQuery: IRequest<EventExportFileVm>
{
}