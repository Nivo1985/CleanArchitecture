using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Features.Categories.Queries.GetCategoriesList;
using CleanArchitecture.Application.MapperProfiles;
using CleanArchitecture.Application.UnitTests.Mocks;
using CleanArchitecture.Domain.Entities;
using Moq;
using Shouldly;

namespace CleanArchitecture.Application.UnitTests.Categories.Queries;

public class GetCategoriesListQueryHandlerTests
{
    private readonly IMapper _mapper;
    private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

    public GetCategoriesListQueryHandlerTests()
    {
        _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
        var configurationProvider = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        _mapper = configurationProvider.CreateMapper();
    }

    [Fact]
    public async Task GetCategoriesListTest()
    {
        var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

        var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

        result.ShouldBeOfType<List<CategoryListVm>>();

        result.Count.ShouldBe(4);
    }
}