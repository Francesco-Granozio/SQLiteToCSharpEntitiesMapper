using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    static class Utils
    {
        // C# 9.0
        /*public static string MapType(string? sqliteType)
        {
            sqliteType = sqliteType?.ToUpper();

            switch (sqliteType)
            {
                case string when sqliteType.Contains("INT"):
                case string when sqliteType.Contains("INTEGER"):
                case string when sqliteType.Contains("BIGINT"):
                case string when sqliteType.Contains("SMALLINT"):
                case string when sqliteType.Contains("TINYINT"):
                    return "int";
                case string when sqliteType.Contains("REAL"):
                case string when sqliteType.Contains("FLOAT"):
                case string when sqliteType.Contains("DOUBLE"):
                    return "double";
                case string when sqliteType.Contains("TEXT"):
                case string when sqliteType.Contains("VARCHAR"):
                case string when sqliteType.Contains("CHAR"):
                case string when sqliteType.Contains("CLOB"):
                case string when sqliteType.Contains("NVARCHAR"):
                case string when sqliteType.Contains("STRING"): // Aggiunto per gestire il tipo string esplicito
                    return "string";
                case string when sqliteType.Contains("BLOB"):
                    return "byte[]";
                case string when sqliteType.Contains("BOOL"):
                case string when sqliteType.Contains("BOOLEAN"):
                    return "bool";
                case string when sqliteType.Contains("NUMERIC"):
                case string when sqliteType.Contains("DECIMAL"):
                    return "decimal";
                case string type when type.Contains("DATE"):
                    return "DateTime";
                case string type when type.Contains("TIME"):
                    return "TimeSpan";
                default:
                    return "unknown_type";
            }
        }*/

        // C# 7.3
        public static string MapType(string sqliteType)
        {
            sqliteType = sqliteType.ToUpper();

            switch (sqliteType)
            {
                case var _ when sqliteType.Contains("INT") ||
                              sqliteType.Contains("INTEGER") ||
                              sqliteType.Contains("BIGINT") ||
                              sqliteType.Contains("SMALLINT") ||
                              sqliteType.Contains("TINYINT"):
                    return "int";
                case var _ when sqliteType.Contains("REAL") ||
                              sqliteType.Contains("FLOAT") ||
                              sqliteType.Contains("DOUBLE"):
                    return "double";
                case var _ when sqliteType.Contains("TEXT") ||
                              sqliteType.Contains("VARCHAR") ||
                              sqliteType.Contains("CHAR") ||
                              sqliteType.Contains("CLOB") ||
                              sqliteType.Contains("NVARCHAR") ||
                              sqliteType.Contains("STRING"):
                    return "string";
                case var _ when sqliteType.Contains("BLOB"):
                    return "byte[]";
                case var _ when sqliteType.Contains("BOOL") ||
                              sqliteType.Contains("BOOLEAN"):
                    return "bool";
                case var _ when sqliteType.Contains("NUMERIC") ||
                              sqliteType.Contains("DECIMAL"):
                    return "decimal";
                case var _ when sqliteType.Contains("DATE"):
                    return "DateTime";
                case var _ when sqliteType.Contains("TIME"):
                    return "TimeSpan";
                default:
                    return "unknown_type";
            }
        }

    }
}
