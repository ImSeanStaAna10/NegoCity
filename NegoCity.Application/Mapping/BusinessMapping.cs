using NegoCity.Application.DTOs.Business;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Mapping
{
    public static class BusinessMapping
    {
        public static Business ToEntity(
            CreateBusinessRequest request)
        {
            return new Business
            {
                Name = request.Name,
                Description = request.Description,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        public static BusinessResponse ToResponse(
            Business business)
        {
            return new BusinessResponse
            {
                Id = business.Id,
                Name = business.Name,
                Description = business.Description,
                IsActive = business.IsActive,
                CreatedAt = business.CreatedAt,
                UpdatedAt = business.UpdatedAt
            };
        }
    }
}