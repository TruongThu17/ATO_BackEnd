using Data.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ContractSer
{
    public interface IContractService
    {
        Task<List<Contract>> ListContract();
        Task<Contract> GetContract(Guid ContractId);
        Task<bool> AddContract(Contract Contract);
        Task<bool> UpdateContract(Guid ContractId, Contract Contract);
    }
}
