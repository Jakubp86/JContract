using JContract.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Infrastructure.Seeders
{
    public class ContractSeeder
    {
        private readonly ContractDbContext _dbContext;
        public ContractSeeder(ContractDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Contracts.Any())
                {
                    var umowa = new Domain.Entities.Contract()
                    {

                        FullName = "Adam",
                        NrUmowy = "B/1/2025",
                        ContactDetails = new()
                        {
                            City = "Kraków",
                            Street = "Szewska 2",
                            PostalCode = "09-410",
                            PhoneNumber = "507704861"

                        }
                    };
                    _dbContext.Contracts.Add(umowa);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
