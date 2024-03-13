using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Features.Events.Queries.GetEventsExport;
using CsvHelper;

namespace CleanArchitecture.Infrastructure.FileExport;

public class CsvExporter : ICsvExporter
{
    public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter);
            csvWriter.WriteRecords(eventExportDtos);
        }

        return memoryStream.ToArray();
    }
}