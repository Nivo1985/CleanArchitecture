using AutoMapper;
using CleanArchitecture.Application.Features.Categories.Commands.CreateCateogry;
using CleanArchitecture.Application.Features.Categories.Queries.GetCategoriesList;
using CleanArchitecture.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using CleanArchitecture.Application.Features.Events.Commands.CreateEvent;
using CleanArchitecture.Application.Features.Events.Commands.UpdateEvent;
using CleanArchitecture.Application.Features.Events.Queries.GetEventDetail;
using CleanArchitecture.Application.Features.Events.Queries.GetEventsList;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.MapperProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Event, EventListVm>().ReverseMap();
        CreateMap<Event, EventDetailVm>().ReverseMap();
        CreateMap<Category, CategoryDto>();
        CreateMap<Category, CategoryListVm>();
        CreateMap<Category, CategoryEventListVm>();
        
        CreateMap<Event, CreateEventCommand>().ReverseMap();
        CreateMap<Event, UpdateEventCommand>().ReverseMap();
        CreateMap<Event, CategoryEventDto>().ReverseMap();
        
        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
            
    }
}