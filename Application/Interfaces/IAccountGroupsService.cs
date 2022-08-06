using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAccountGroupsService
    {
        Task<IEnumerable<AccountGroupViewModel>> GetAccountGroups();
        Task<AccountGroupViewModel> GetById(int? id);

        void Add(AccountGroupViewModel accountGroup);
        void Update(AccountGroupViewModel accountGroup);
        void Remove(int? id);
    }
}
