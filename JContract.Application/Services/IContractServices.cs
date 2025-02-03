using JContract.Application.Contract;
using JContract.Domain.Entities;

namespace JContract.Application.Services
{
    public interface IContractServices
    {
        Task Create(ContractDto contract);
        Task Details(ContractDto contract);
        Task Delete(ContractDto contract);
        Task Edit(ContractDto contract);
        Task<IEnumerable<ContractDto>> GetAll();    
        Task<ContractDto?> GetByIdAsync(int id);
    }
}