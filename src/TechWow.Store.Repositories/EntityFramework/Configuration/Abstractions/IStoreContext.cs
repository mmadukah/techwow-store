using System;
using Microsoft.EntityFrameworkCore;

namespace TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions
{
    public interface IStoreContext : IDisposable
    {
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>(string name) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
