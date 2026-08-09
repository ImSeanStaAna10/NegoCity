namespace NegoCity.Application.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

    }
}
