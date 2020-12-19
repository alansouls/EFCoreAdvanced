using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAdvanced.Providers
{
    public interface ISqlProvider
    {
        string GetSqlForUpsert(Type tEntityType);
        string GetSqlForUpsert<TEntity>() where TEntity : class;
    }
}
