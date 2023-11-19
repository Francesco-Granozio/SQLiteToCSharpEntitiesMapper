using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    public static class StringExtensions
    {
        /*public static string Capitalize(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };*/

        public static string Capitalize(this string input)
        {
            switch (input)
            {
                case null:
                    throw new ArgumentNullException(nameof(input));
                case "":
                    throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default:
                    return string.Concat(input[0].ToString().ToUpper(), input.Substring(1));
            }
        }


        public static string ToCSharpNamingConvention(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder(input);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '_')
                {
                    if (i + 1 < result.Length)
                    {
                        result[i + 1] = char.ToUpper(result[i + 1]);
                    }
                    result.Remove(i, 1);
                }
            }

            return result.ToString();
        }

    }
}
