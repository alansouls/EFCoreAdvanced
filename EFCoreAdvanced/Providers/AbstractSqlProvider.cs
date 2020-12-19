using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAdvanced.Providers
{
    public abstract class AbstractSqlProvider : ISqlProvider
    {
        public abstract string GetSqlForUpsert(Type tEntityType);
        public abstract string GetSqlForUpsert<TEntity>() where TEntity : class;
        protected abstract string GetProviderSqlType(Type type);
    }
}
