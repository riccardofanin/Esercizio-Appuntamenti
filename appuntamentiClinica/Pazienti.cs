using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace appuntamentiClinica
{
    class Pazienti : Patologie
    {
        private DataTable _table;
        public DataTable TablePazienti { get => _table; }

        public Pazienti()
        {
            this._table = tableGenerator();
        }

        private DataTable tableGenerator()
        {
            DataTable dataTable = new DataTable(); // genero la tabella

            DataRow row;

            List<string> lines = System.IO.File.ReadLines(@"..\data\pazienti.csv").ToList<string>();
            // creo le colonne
            dataTable.Columns.Add(columnGenerator("Id"));
            dataTable.Columns.Add(columnGenerator("Nome"));
            dataTable.Columns.Add(columnGenerator("Cognome"));
            dataTable.Columns.Add(columnGenerator("Patologia"));
            // per ogni colonna creo le relative righe
            for (int i = 1; i < lines.Count; i++)
            {
                string[] lineSplitted = lines[i].Split(';');

                row = dataTable.NewRow();
                row[dataTable.Columns[0]] = lineSplitted[lineSplitted.Length-1];
                row[dataTable.Columns[1]] = lineSplitted[0];
                row[dataTable.Columns[2]] = lineSplitted[1];
                row[dataTable.Columns[3]] = getPatologia(lineSplitted[lineSplitted.Length-2]);
                dataTable.Rows.Add(row);
            }


            return dataTable;
        }

        private DataColumn columnGenerator(string name)
        {
            DataColumn column = new DataColumn();

            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = name;
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;

            return column;
        }

        private string getPatologia(string id)
        {
            List<string> nomiPatologie = new List<string>();
            List<string> idPatologie = new List<string>();

            foreach (DataRow item in TablePatologie.Rows)
            {
                nomiPatologie.Add((string)item[0]);
                idPatologie.Add((string)item[1]);
            }


            for (int i = 0; i < idPatologie.Count; i++)
            {
                if(idPatologie[i] == id)
                {
                    return nomiPatologie[i];
                }
            }

            return id;
        }

    }       
    
}
