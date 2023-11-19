using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{



    class ClassBuilder
    {
        public string ClassName { get; set; }
        public TableInfo TableInfos { get; set; }
        public string Namespace { get; set; }
        private Tab tabs;
        

        public ClassBuilder(TableInfo tableInfos, string @namespace = "")
        {
            ClassName = tableInfos.TableName.Capitalize();
            TableInfos = tableInfos;
            Namespace = @namespace;
            tabs = new Tab();
 
        }

        public string BuildClass()
        {
            StringBuilder sb = new StringBuilder("using System;\nusing System.Collections.Generic;\n\n");

            if (!Namespace.Equals(string.Empty))
            {
                sb.AppendLine($"{tabs}namespace {Namespace}");
                sb.AppendLine($"{tabs}{{");
                tabs++;
            }


            sb.AppendLine($"\n{tabs}class {ClassName}");
            sb.AppendLine($"{tabs}{{");
            tabs++;

            foreach (var columnInfo in TableInfos.ColumnInfos)
            {
                if (columnInfo.IsPrimaryKey)
                {
                    sb.AppendLine($"{tabs}//Primary key");
                }
                if (columnInfo.IsForeignKey)
                {
                    sb.AppendLine($"{tabs}//Foreign Key");
                }
                
                sb.AppendLine($"{tabs}public {columnInfo.MappedDataType} {columnInfo.ColumnName.Capitalize().ToCSharpNamingConvention()} {{ get; set; }}");
                
            }

            sb.AppendLine();
            sb.AppendLine($"{tabs}public {ClassName} ()");
            sb.AppendLine($"{tabs}{{");

            sb.AppendLine($"{tabs}}}");

            sb.AppendLine();
            sb.AppendLine($"{tabs}public {ClassName} ({string.Join(", ", TableInfos.ColumnInfos.Select(column => column.MappedDataType + " " + column.ColumnName.ToCSharpNamingConvention()))})");
            sb.AppendLine($"{tabs}{{");
            tabs++;

            for (int i = 0; i < TableInfos.ColumnInfos.Count; i++)
            {
                sb.AppendLine($"{tabs}{TableInfos.ColumnInfos[i].ColumnName.Capitalize().ToCSharpNamingConvention()} = {TableInfos.ColumnInfos[i].ColumnName.ToCSharpNamingConvention()};");
            }

            tabs--;
            sb.AppendLine($"{tabs}}}");

            sb.AppendLine();
            sb.AppendLine($"{tabs}public override string ToString()");
            sb.AppendLine($"{tabs}{{");
            tabs++;
            sb.AppendLine($"{tabs}return $\"{ClassName}: [ {string.Join(", ", TableInfos.ColumnInfos.Select(column => $"{column.ColumnName.ToCSharpNamingConvention()}: {{{column.ColumnName.Capitalize().ToCSharpNamingConvention()}}}"))} ]\";");
            tabs--;
            sb.AppendLine($"{tabs}}}");


            tabs--;
            sb.AppendLine($"{tabs}}}");

            if (!Namespace.Equals(string.Empty))
            {
                tabs--;
                sb.Append($"\n}}");
            }

            return sb.ToString();
        }
    }
}
