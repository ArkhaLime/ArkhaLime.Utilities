using System;
using System.Collections.Generic;
using System.Text;

namespace ArkhaLime.Utilities.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Function equivalent to substring with trimming of space
        /// Used to cut parts of a fixed lenght file
        /// </summary>
        /// <param name="aString"></param>
        /// <param name="startBase1">Index of the start character in base 1</param>
        /// <param name="length">Number of characters to cut</param>
        /// <returns></returns>
        public static string Cut(this string aString, int startBase1, int length)
        {
            if (aString == null) return "";
            int tempLength = aString.Length - (startBase1 - 1);
            tempLength = Math.Min(tempLength, length);
            return aString.Substring(startBase1 - 1, tempLength).Trim();
        }

    }
}
