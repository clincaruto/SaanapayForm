using Microsoft.EntityFrameworkCore;
using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;

namespace SaanapayForm.Web.GenericRepository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

		public async Task AddRangeAsync(List<T> entities)
		{
			await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync(int pageNumber = 1, int pageSize = 10)
        {
            var leave = context.Set<T>().AsQueryable();

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            return await leave.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            // context.Entry(entity).State = EntityState.Modified;
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
