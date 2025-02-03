using AutoMapper;
using JContract.Application.Contract;
using JContract.Domain.Entities;
using JContract.Domain.Interfaces;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Application.Services
{
    public class ContractServices : IContractServices
    {
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;
        public ContractServices(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }
        public async Task Create(ContractDto contractDto)
        {
           var contract = _mapper.Map<Domain.Entities.Contract>(contractDto);
            await _contractRepository.Create(contract);
        }

      

        public Task Delete(ContractDto contract)
        {
            throw new NotImplementedException();
        }

        public async Task Details(ContractDto contractDto)
        {
            var contract = _mapper.Map<Domain.Entities.Contract>(contractDto);
            await _contractRepository.Details(contract);
        }

        public Task Edit(ContractDto contract)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContractDto>> GetAll()
        {
            var contract = await _contractRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<ContractDto>>(contract);
            return dtos;
        }

        public Task<ContractDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
