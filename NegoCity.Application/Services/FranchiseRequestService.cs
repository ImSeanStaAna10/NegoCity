using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Services
{
    public class FranchiseRequestService : IFranchiseRequestService
    {
        private readonly IFranchiseRequestRepository _franchiseRequestRepository;

        public FranchiseRequestService(
            IFranchiseRequestRepository franchiseRequestRepository)
        {
            _franchiseRequestRepository = franchiseRequestRepository;
        }

        #region METHODS

        public async Task<FranchiseRequest?> GetByIdAsync(Guid id)
        {
            return await _franchiseRequestRepository.GetByIdAsync(id);
        }

        public async Task<FranchiseRequest> CreateAsync(
            FranchiseRequest franchiseRequest)
        {
            await _franchiseRequestRepository.AddAsync(franchiseRequest);

            return franchiseRequest;
        }

        #endregion
    }
}