using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistance.Repositories;

public class EventRepository : BaseRepository<Event>, IEventRepository
{
    public EventRepository(CleanArchitectureDbContext dbContext) : base(dbContext)
    {
    }

    public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
    {
        var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
        return Task.FromResult(matches);
    }
}