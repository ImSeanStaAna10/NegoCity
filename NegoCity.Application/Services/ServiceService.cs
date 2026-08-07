using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        #region METHODS

        public async Task<Service?> GetByIdAsync(Guid id)
        {
            return await _serviceRepository.GetByIdAsync(id);
        }

        public async Task<Service> CreateAsync(Service service)
        {
            await _serviceRepository.AddAsync(service);

            return service;
        }

        #endregion
    }
}