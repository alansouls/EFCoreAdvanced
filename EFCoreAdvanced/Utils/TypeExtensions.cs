using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAdvanced.Utils
{
    internal static class TypeExtensions
    {
        internal static bool IsPropertyTypeSupported(this Type propertyType)
        {
            return propertyType.IsPrimitive;
        }
    }
}
