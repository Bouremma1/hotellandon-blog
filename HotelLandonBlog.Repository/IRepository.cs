using HotelLandonBlog.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelLandonBlog.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicat = null);
        Task<TEntity> GetAsync(int id);
        Task<TEntity> Createsync(TEntity entity);
        Task<TEntity> Updatesync(int id, TEntity entity);
        Task<TEntity> Deletesync(int id);
        Task<TEntity> Undeletesync(int id);
    }
}
