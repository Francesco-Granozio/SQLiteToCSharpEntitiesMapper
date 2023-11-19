using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    class TableInfo
    {

        public string TableName { get; set; }
        public List<ColumnInfo> ColumnInfos { get; set; }
        public List<string> PrimaryKeys { get; set; } = new List<string>();
        public List<string> ForeignKeys { get; set; } = new List<string>();

        public TableInfo(string tableName)
        {
            TableName = tableName;
        }

        public TableInfo(string tableName, List<ColumnInfo> columnInfos, List<string> primaryKeys, List<string> foreignKeys)
        {
            TableName = tableName;
            ColumnInfos = columnInfos;
            PrimaryKeys = primaryKeys;
            ForeignKeys = foreignKeys;
        }

    }
}
