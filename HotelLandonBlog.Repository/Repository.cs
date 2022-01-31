using HotelLandonBlog.Data;
using HotelLandonBlog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static HotelLandonBlog.Data.IHotelLandonBlogContext;

namespace HotelLandonBlog.Repository
{
    public partial class Repository<TEntity> : IRepository<TEntity>
         where TEntity : EntityBase
    {
        private HotelLandonContext context;
        public Repository() => context = new HotelLandonContext();


        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicat=null) => context.Set<TEntity>().ToListAsync();
        public async Task<TEntity> GetAsync(int id) => await context.Set<TEntity>().FindAsync(id);


        public async Task<bool> Createsync(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            return await context.SaveChangesAsync() == 1;
            
        }


        public async Task<bool> Deletesync(int id)
        {
            TEntity entity = await GetAsync(id); 
            if (entity is not null)
            {
                context.SaveChangesAsync(entity);
                return await context.SaveChangesAsync() == 1;
            }
            return false;
        }

        Task<TEntity> IRepository<TEntity>.Updatesync(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Updatesync(int id, TEntity entity)
        {
            var local = context.Set<TEntity>()
            .Local
            .FirstOrDefault(entry => entry.Id.Equals(id));
            if (local != null)
            {
                context.Entry(local).State= EntityState.Modified;
            }
            context.Entry(entity).State= EntityState.Modified;

            return await context.SaveChangesAsync() == 1;
        }

       
    }
}
