namespace SaanapayForm.Web.GenericRepository.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync(int pageNumber = 1, int pageSize = 10);
        Task<T> AddAsync(T entity);
		Task AddRangeAsync(List<T> entities);
		Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
    }
}
