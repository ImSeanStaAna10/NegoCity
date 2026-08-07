using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking?> GetByIdAsync(Guid id);
        Task AddAsync(Booking booking); 
    }
}
