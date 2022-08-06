using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAccountGroupsRepository
    {
        Task<IEnumerable<AccountGroups>> GetAccountGroups();
        Task<AccountGroups> GetById(int? id);

        void Add(AccountGroups accountGroup);
        void Remove(AccountGroups accountGroup);
        void Update(AccountGroups accountGroup);
    }
}
