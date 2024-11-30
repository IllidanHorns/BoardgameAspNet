/*using BoardgameShopASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardgameShop.WEBUI.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() 
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id) 
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task AddAsync(T entity) 
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity) 
        {
            var existingEntity = _dbSet.FindAsync(entity.Id);
        }
    }
}
*/