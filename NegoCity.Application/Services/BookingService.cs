using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        #region METHODS

        public async Task<Booking?> GetByIdAsync(Guid id)
        {
            return await _bookingRepository.GetByIdAsync(id);
        }

        public async Task<Booking> CreateAsync(Booking booking)
        {
            await _bookingRepository.AddAsync(booking);

            return booking;
        }

        #endregion
    }
}