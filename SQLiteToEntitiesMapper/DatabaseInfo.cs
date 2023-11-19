using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    class DatabaseInfo
    {
        private static volatile DatabaseInfo instance = null;
        private static readonly object @lock = new object();
        private static string dbPath;
        private static string ConnectionString { get { return $"Data Source={dbPath};Version=3;"; } }

        private DatabaseInfo(string path)
        {
            dbPath = path;
        }

        public TableInfo GetTableInfo(string tableName)
        {
            List<ColumnInfo> columns = GetColumns(ConnectionString, tableName);

            List<string> primaryKeys = columns.Where(c => c.IsPrimaryKey).Select(c => c.ColumnName).ToList();

            List<string> foreignKeys = GetForeignKeys(tableName);

            TableInfo tableInfo = new TableInfo(tableName, columns, primaryKeys, foreignKeys);

            return tableInfo;
        }

        public static DatabaseInfo GetInstance(string path)
        {

            if (instance == null)
            {
                lock (@lock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseInfo(path);
                    }
                }
            }
            return instance;

        }

        public List<ColumnInfo> GetColumns(string connectionString, string tableName)
        {
            List<ColumnInfo> columns = new List<ColumnInfo>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand($"PRAGMA table_info({tableName})", connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColumnInfo columnInfo = new ColumnInfo
                        {
                            ColumnName = reader["name"].ToString(),
                            DataType = reader["type"].ToString(),
                            MappedDataType = Utils.MapType(reader["type"].ToString()),
                            IsNotNull = Convert.ToBoolean(reader["notnull"]),
                            IsPrimaryKey = Convert.ToBoolean(reader["pk"]),
                        };
                        columns.Add(columnInfo);
                    }
                }

                // Ottieni le chiavi esterne
                List<string> foreignKeys = GetForeignKeys(tableName);

                // Aggiungi le informazioni sulle chiavi esterne all'elenco delle colonne
                foreach (var column in columns)
                {
                    column.IsForeignKey = foreignKeys.Contains(column.ColumnName);
                }

                connection.Close();
            }
            return columns;
        }

        public List<string> GetTableNames()
        {
            List<string> tables = new List<string>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var tableNames = connection.GetSchema("Tables");
                foreach (DataRow row in tableNames.Rows)
                {
                    tables.Add(row["TABLE_NAME"].ToString());
                }
                connection.Close();
            }
            return tables;
        }
        
        public List<string> GetForeignKeys(string tableName)
        {
            List<string> foreignKeys = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var foreignKeyCommand = new SQLiteCommand($"PRAGMA foreign_key_list({tableName})", connection);
                using (SQLiteDataReader fkReader = foreignKeyCommand.ExecuteReader())
                {
                    while (fkReader.Read())
                    {
                        string columnName = fkReader["from"].ToString(); // Nome della colonna con la chiave esterna
                        foreignKeys.Add(columnName);
                    }
                }
                    connection.Close();
            }
            return foreignKeys;
        }
    }
}
