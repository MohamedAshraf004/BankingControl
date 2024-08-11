using Application.Client.Commands.Create;
using Application.Client.Queries.GetClients;
using Application.Features.Client.Queries.CachedParametersQuery;
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

            CreateMap<ClientDto, Domain.Entities.Client>()
                .ReverseMap();
            CreateMap<AddressDto, Address>()
                .ReverseMap();
            CreateMap<AccountDto, Domain.Entities.Account>()
                .ReverseMap();

            CreateMap<GetClientsQuery, GetCachedParametersQueryResponse>();


        }
    }
}