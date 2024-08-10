using Application.Client.Commands.Create;
using AutoMapper;
using Domain.ValueObjects;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateClientCommand, Domain.Entities.Client>();
            CreateMap<AddressInput, Address>();
            CreateMap<AccountInput, Domain.Entities.Account>();


        }
    }
}