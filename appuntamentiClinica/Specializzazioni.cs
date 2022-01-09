using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace appuntamentiClinica
{
    class Specializzazioni
    {
        private DataTable _table;
        public DataTable TableSpec { get => _table; }

        public Specializzazioni()
        {
            this._table = tableGenerator();
        }

        private DataTable tableGenerator()
        {
            DataTable dataTable = new DataTable();
            DataColumn column;
            DataRow row;

            List<string> lines = System.IO.File.ReadLines(@"..\data\specializzazioni.csv").ToList<string>();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] lineSplitted = lines[i].Split(';');

                if (i == 0)
                {
                    for (int c = 1; c >= 0; c--)
                    {
                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = lineSplitted[c];
                        column.AutoIncrement = false;
                        column.ReadOnly = true;
                        column.Unique = false;
                        dataTable.Columns.Add(column);
                    }
                }
                else
                {
                    row = dataTable.NewRow();
                    row[dataTable.Columns[0]] = lineSplitted[1];
                    row[dataTable.Columns[1]] = lineSplitted[0];
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }
    }

        
    
}
