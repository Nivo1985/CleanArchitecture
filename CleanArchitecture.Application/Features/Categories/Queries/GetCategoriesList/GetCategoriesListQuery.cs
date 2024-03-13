using MediatR;

namespace CleanArchitecture.Application.Features.Categories.Queries.GetCategoriesList;

public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
{
}