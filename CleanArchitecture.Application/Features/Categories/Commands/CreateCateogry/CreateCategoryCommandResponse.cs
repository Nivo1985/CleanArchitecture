using CleanArchitecture.Application.Responses;

namespace CleanArchitecture.Application.Features.Categories.Commands.CreateCateogry;

public class CreateCategoryCommandResponse: BaseResponse
{
    public CreateCategoryCommandResponse(): base()
    {

    }

    public CreateCategoryDto Category { get; set; } = default!;
}