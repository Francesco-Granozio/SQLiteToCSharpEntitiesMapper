using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    class ColumnInfo
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public bool IsNotNull { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        //public string DefaultValue { get; set; }
        public string MappedDataType { get; set; }


        public ColumnInfo()
        {

        }

        public ColumnInfo(string columnName, string dataType, bool isNotNull, bool isPrimaryKey, bool isForeignKey, string mappedDataType)
        {
            ColumnName = columnName;
            DataType = dataType;
            IsNotNull = isNotNull;
            IsPrimaryKey = isPrimaryKey;
            IsForeignKey = isForeignKey;
            MappedDataType = mappedDataType;
        }
    }
}
