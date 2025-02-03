using JContract.Domain.Entities;
using JContract.Domain.Interfaces;
using JContract.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ContractDbContext _dbContext;
        public ContractRepository(ContractDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Contract contract)
        {
            _dbContext.Add(contract);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Contract contract)
        {
            _dbContext.Remove(contract);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Details(Contract contract)
        {
            _dbContext.Update(contract);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contract>> GetAll()
       => await _dbContext.Contracts.ToListAsync();
    }
}
