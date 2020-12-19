using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAdvanced.Utils
{
    internal static class StringExtensions
    {
        internal static string InsertArround(this string str, string leftSide, string rightSide)
        {
            return leftSide + str + rightSide;
        }
    }
}
