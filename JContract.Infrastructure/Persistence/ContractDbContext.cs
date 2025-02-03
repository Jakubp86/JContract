using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Infrastructure.Persistence
{
    public class ContractDbContext : DbContext
    {
        public ContractDbContext(DbContextOptions<ContractDbContext>options) : base (options) 
        {
            
        }
        public DbSet<Domain.Entities.Contract> Contracts { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Contract>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}
