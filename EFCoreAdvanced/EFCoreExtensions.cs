using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace EFCoreAdvanced
{
    public static class EFCoreExtensions
    {
        //TODO: Get that from DI
        private static DbContext GetContext() => new DbContext(new DbContextOptionsBuilder().Options);

        public static void Upsert<TEntity>(this DbSet<TEntity> entities) where TEntity : class
        {
            var context = GetContext();
            var providerName = context.Database.ProviderName;

        }
    }
}
