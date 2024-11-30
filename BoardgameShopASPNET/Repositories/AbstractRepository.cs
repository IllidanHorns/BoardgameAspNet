/*using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace BoardgameShop.WEBUI.Repositories
{
    public class AbstractRepository<T>(AppDbContext _context)
    : IAbstractRepository<T> where T : class, IModelId, IInclude<T>
    {
        public async Task<T?> GetById(int id)
        {
            IQueryable<T> query = _context.Set<T>();
            var includes = T.GetIncludes();
            foreach (var include in includes) query = query.Include(include);
            var list = await query.ToListAsync();
            return list.FirstOrDefault(t => t.GetId() == id);
        }

        public async Task<List<T>> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            var includes = T.GetIncludes();
            foreach (var include in includes) query = query.Include(include);
            return await query.ToListAsync();
        }

        public async Task<T> Create(T model)
        {
            _context.Set<T>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<T> Update(T oldModel, T newModel)
        {
            _context.Entry(oldModel).CurrentValues.SetValues(newModel);
            await _context.SaveChangesAsync();
            return newModel;
        }

        public async Task Delete(T model)
        {
            _context.Set<T>().Remove(model);
            await _context.SaveChangesAsync();
        }
    }
*/