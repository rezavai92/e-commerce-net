using Application.shared.Extensions;
using Application.UAM.Commands;
using AutoMapper;
using Domain.Entities;

namespace Application.UAM.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserCommand, User>()
                .ForMember(dest => dest.ItemId,
                opt => opt.MapFrom(src => Guid.NewGuid().ToString()));
        }
    }
}
