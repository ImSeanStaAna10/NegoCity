using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Application.DTOs.Business;
using NegoCity.Application.Mapping;


namespace NegoCity.Application.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BusinessService(
            IBusinessRepository businessRepository,
            IUnitOfWork unitOfWork)
        {
            _businessRepository = businessRepository;
            _unitOfWork = unitOfWork;
        }

        #region METHODS

        public async Task<BusinessResponse?> GetByIdAsync(Guid id)
        {
            var business = await _businessRepository.GetByIdAsync(id);

            if (business is null)
            {
                return null;
            }

            return BusinessMapping.ToResponse(business);
        }

        public async Task<BusinessResponse> CreateAsync(CreateBusinessRequest request)
        {
            var exist = await _businessRepository.ExistsByNameAsync(request.Name);

            if (exist)
            {
                throw new InvalidOperationException($"Business with name '{request.Name}' already exists.");
            }
             
            var business = BusinessMapping.ToEntity(request);

            await _businessRepository.AddAsync(business);

            await _unitOfWork.SaveChangesAsync();

            return BusinessMapping.ToResponse(business);
        }


        #endregion
    }
}   