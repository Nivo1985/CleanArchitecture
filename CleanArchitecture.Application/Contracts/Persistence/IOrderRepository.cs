using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Contracts.Persistence;

public interface IOrderRepository : IAsyncRepository<Order>
{
}