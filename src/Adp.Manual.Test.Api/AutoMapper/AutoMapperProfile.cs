using Adp.Manual.Test.Api.Models;
using Adp.Manual.Test.Core.Entities;

using AutoMapper;

namespace Adp.Manual.Test.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
