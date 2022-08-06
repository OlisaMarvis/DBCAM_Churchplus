using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class AccountGroupsRepository : IAccountGroupsRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountGroupsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AccountGroups>> GetAccountGroups()
        {
            return await _context.accountGroups.ToListAsync();
        }

        public async Task<AccountGroups> GetById(int? id)
        {
            return await _context.accountGroups.FindAsync(id);
        }
        public void Add(AccountGroups accountGroup)
        {
            _context.Add(accountGroup);
            _context.SaveChanges();
        }

        public void Remove(AccountGroups accountGroup)
        {
            _context.Remove(accountGroup);
            _context.SaveChanges();
        }

        public void Update(AccountGroups accountGroup)
        {
            _context.Update(accountGroup);
            _context.SaveChanges();
        }
    }
}
