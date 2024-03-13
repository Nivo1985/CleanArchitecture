using CleanArchitecture.Application.Features.Events.Queries.GetEventsExport;

namespace CleanArchitecture.Application.Contracts.Infrastructure;

public interface ICsvExporter
{
    byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
}