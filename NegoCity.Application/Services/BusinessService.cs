using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Services
{
    public class BusinessService : IBusinessService
    {

        private readonly IBusinessRepository _businessRepository;

        public BusinessService(IBusinessRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }

        
        
        // GetByIdAsync
        public async Task<Business?> GetByIdAsync(Guid id)
        {
            return await _businessRepository.GetByIdAsync(id);
        
        }

        // Create
        public async Task<Business> CreateAsync(Business business)
        {
            await _businessRepository.AddAsync(business);

            return business; ;
        }


  

    }
}
