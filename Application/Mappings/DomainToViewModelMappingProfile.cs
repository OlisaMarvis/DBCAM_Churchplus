using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;


namespace Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AccountGroups, AccountGroupViewModel>();
        }
    }
}
