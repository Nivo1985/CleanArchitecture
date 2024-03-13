using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Contracts.Persistence;

public interface ICategoryRepository : IAsyncRepository<Category>
{
    Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
}