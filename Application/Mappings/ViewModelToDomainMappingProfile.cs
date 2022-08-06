using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;

namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AccountGroupViewModel, AccountGroups>();
        }
    }
}
