using JContract.Domain.Interfaces;
using JContract.Infrastructure.Persistence;
using JContract.Infrastructure.Repositories;
using JContract.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContractDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("Contract")));

            services.AddScoped<ContractSeeder>();
            services.AddScoped<IContractRepository, ContractRepository>();
        }
    }
}
