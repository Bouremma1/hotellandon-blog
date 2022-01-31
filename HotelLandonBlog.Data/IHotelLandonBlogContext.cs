using HotelLandonBlog.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelLandonBlog.Data
{
    public interface IHotelLandonBlogContext 
    {
        DbSet<BlogPost> Posts { get; set; }
        DbSet<Category> Categories { get; set; }


        public class HotelLandonContext : DbContext, IHotelLandonBlogContext
        {
            public DbSet<BlogPost> Posts { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public DbSet<Category> Categories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
              optionsBuilder.UseSqlServer("Server=tcp:tvitf1a81j.database.windows.net,1433;Initial Catalog=HotelLandon-2022;Persist Security Info=False;User ID=andrestalavera-sql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }

            public void SaveChangesAsync<TEntity>(TEntity entity) where TEntity : EntityBase
            {
                throw new NotImplementedException();
            }
        }

        
    }
}