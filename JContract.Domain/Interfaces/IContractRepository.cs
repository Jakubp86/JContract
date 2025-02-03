using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Domain.Interfaces
{
    public interface IContractRepository
    {
        Task Create(Domain.Entities.Contract contract);
        Task Details(Domain.Entities.Contract contract);
        Task Delete(Domain.Entities.Contract contract);
        Task<IEnumerable<Domain.Entities.Contract>> GetAll();
    }
}
