using EFCoreAdvanced.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EFCoreAdvanced.Providers
{
    public class SqlServerProvider : AbstractSqlProvider
    {
        protected override string GetProviderSqlType(Type type)
        {
            if (type.IsPropertyTypeSupported())
                throw new Exception("Not a primitive type");

            throw new NotImplementedException();
        }

        private string ConstructSqlTableParameter(Type type)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("declare @tableParam as Table");
            stringBuilder.Append("(");
            string columnsString = "";
            foreach (var property in type.GetProperties())
            {
                if (!property.PropertyType.IsPropertyTypeSupported())
                    continue;
                if (Attribute.IsDefined(property, typeof(NotMappedAttribute)))
                    continue;
                var line = $"{property.Name} {GetProviderSqlType(property.PropertyType)} not null, ";
                columnsString += line;
            }
            columnsString = columnsString.Substring(0, columnsString.Length - 2);
            stringBuilder.Append(columnsString);
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        public override string GetSqlForUpsert(Type tEntityType)
        {
            throw new NotImplementedException();
        }

        public override string GetSqlForUpsert<TEntity>() where TEntity : class
        {
            return GetSqlForUpsert(typeof(TEntity));
        }
    }
}
