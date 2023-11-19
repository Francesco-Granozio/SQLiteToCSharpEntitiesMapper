using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteToEntitiesMapper
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private string filePath;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_sel_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Database SQLite (*.db *.sdb *.sqlite *.db3 *.s3db *.sqlite3 *sl3)|*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File aperto correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filePath = openFileDialog1.FileName;
            }
        }

        private void button_sel_cartella_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog
            {
                Description = "Seleziona la cartella dove salvare i file"
            };
            
            

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cartella selezionata correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                folderPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_genera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Selezionare prima il file e la cartella", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> tableNames = DatabaseInfo.GetInstance(filePath).GetTableNames();

                foreach (var tableName in tableNames)
                {
                    TableInfo tableInfo = DatabaseInfo.GetInstance(filePath).GetTableInfo(tableName);
                    ClassBuilder classBuilder = new ClassBuilder(tableInfo, textBox_namespace.Text);
                    File.WriteAllText($"{folderPath}\\{tableName.Capitalize()}.cs", classBuilder.BuildClass());
                }

                MessageBox.Show("File generati correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Errore durante la generazione delle classi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }
    }
}
