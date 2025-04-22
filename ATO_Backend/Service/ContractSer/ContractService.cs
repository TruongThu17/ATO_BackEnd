using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ContractSer
{
    public class ContractService : IContractService
    {
        private readonly IRepository<Contract> _contractRepository;
        public ContractService(IRepository<Contract> contractRepository)
        {
            _contractRepository = contractRepository;
        }

        public async Task<bool> AddContract(Contract Contract)
        {
            try
            {
                Contract.ContractId = Guid.NewGuid();
                Contract.CreateDate = DateTime.Now;
                await _contractRepository.AddAsync(Contract);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Contract> GetContract(Guid ContractId)
        {
            try
            {
                return await _contractRepository.Query()
                    .Include(x => x.TourCompany)
                    .Include(x => x.TouristFacility)
                    .SingleOrDefaultAsync(x=>x.ContractId==ContractId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Contract>> ListContract()
        {
            try
            {
                return await _contractRepository.Query()
                    .Include(x=>x.TourCompany)
                    .Include(x=>x.TouristFacility)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateContract(Guid ContractId, Contract Contract)
        {
            try
            {
                var exist = await _contractRepository.GetByIdAsync(ContractId);
                exist.Status = Contract.Status;
                exist.ContractContent = Contract.ContractContent;
                exist.StartDate = Contract.StartDate;
                exist.EndDate = Contract.EndDate;
                exist.SignedDate = Contract.SignedDate;
                exist.RequestReSignContract = Contract.RequestReSignContract;
                exist.UpdateDate = DateTime.UtcNow;
                await _contractRepository.UpdateAsync(Contract);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
