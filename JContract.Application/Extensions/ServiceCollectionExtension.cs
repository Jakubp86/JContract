using FluentValidation;
using FluentValidation.AspNetCore;
using JContract.Application.Contract;
using JContract.Application.Mappings;
using JContract.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IContractServices, ContractServices>();

            services.AddAutoMapper(typeof(ContractMappingProfile));

            services.AddValidatorsFromAssemblyContaining<ContractDtoValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

        }
    }
}
