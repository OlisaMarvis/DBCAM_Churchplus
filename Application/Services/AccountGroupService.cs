using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AccountGroupService : IAccountGroupsService
    {
        private readonly IAccountGroupsRepository _repository;
        private readonly IMapper _mapper;

        public AccountGroupService(IAccountGroupsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Add(AccountGroupViewModel accountGroup)
        {
            var mapAccountGroup = _mapper.Map<AccountGroups>(accountGroup);
            _repository.Add(mapAccountGroup);
        }

        public async Task<IEnumerable<AccountGroupViewModel>> GetAccountGroups()
        {
            var result = await _repository.GetAccountGroups();
            return _mapper.Map<IEnumerable<AccountGroupViewModel>>(result); 
        }

        public async Task<AccountGroupViewModel> GetById(int? id)
        {
            var result = await _repository.GetById(id);
            return _mapper.Map<AccountGroupViewModel>(result);
        }

        public void Remove(int? id)
        {
            var accountGroup = _repository.GetById(id).Result;
            _repository.Remove(accountGroup);
        }

        public void Update(AccountGroupViewModel accountGroup)
        {
            var mapAccountGroup = _mapper.Map<AccountGroups>(accountGroup);
            _repository.Update(mapAccountGroup);
        }
    }
}
