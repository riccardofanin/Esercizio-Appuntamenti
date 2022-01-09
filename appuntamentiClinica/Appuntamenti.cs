using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace appuntamentiClinica
{
    class Appuntamenti
    {
        private DataTable _table;

        Pazienti pazienti = new Pazienti();
        Medici medici = new Medici();

        public List<string> nomiPazienti = new List<string>();
        public List<string> nomiMedici = new List<string>();

        public DataTable TableApp { get => _table; }
        public List<string> NomiPazienti { get => nomiPazienti; }
        public List<string> NomiMedici { get => nomiMedici; }

        public Appuntamenti()
        {
            this._table = tableGenerator();
        }

        private DataTable tableGenerator()
        {
            pazientiGen();
            mediciGen();

            DataTable dataTable = new DataTable(); // genero la tabella

            DataRow row;

            List<string> lines = System.IO.File.ReadLines(@"..\data\appuntamenti.csv").ToList<string>();
            // creo le colonne
            dataTable.Columns.Add(columnGenerator("Data"));
            dataTable.Columns.Add(columnGenerator("Paziente"));
            dataTable.Columns.Add(columnGenerator("Dottore"));

            // per ogni colonna creo le relative righe
            for (int i = 1; i < lines.Count; i++)
            {
                string[] lineSplitted = lines[i].Split(';');

                row = dataTable.NewRow();
                row[dataTable.Columns[0]] = lineSplitted[0];
                row[dataTable.Columns[1]] = getPazienti(lineSplitted[lineSplitted.Length - 2]);
                row[dataTable.Columns[2]] = getMedici(lineSplitted[lineSplitted.Length - 1]);
                dataTable.Rows.Add(row);
            }


            return dataTable;
        }

        private DataColumn columnGenerator(string name)
        {
            DataColumn column = new DataColumn();

            if(name == "Data")// creo la colonna con il tipo di dato richiesto
            {
                column.DataType = System.Type.GetType("System.DateTime");
            }
            else
            {
                column.DataType = System.Type.GetType("System.String");
            }
 
            column.ColumnName = name;
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;

            return column;
        }


        private void pazientiGen()
        {
            foreach (DataRow item in pazienti.TablePazienti.Rows)// creo la lista dei nomi dei pazienti in base a quelli inseriti nella classe Pazienti
            {
                nomiPazienti.Add((string)item[1] + " " + (string)item[2]);
            }
        }

        private void mediciGen()
        {
            foreach (DataRow item in medici.TableMedici.Rows) // creo la lista dei nomi dei medici in base a quelli inseriti nella classe Medici
            {
                nomiMedici.Add((string)item[1] + " " + (string)item[2]);
            }
        }



        private string getPazienti(string id)
        {                     
            List<string> idPaziente = new List<string>();

            foreach (DataRow item in pazienti.TablePazienti.Rows) 
            {
                idPaziente.Add((string)item[0]);
            }

            for (int i = 0; i < idPaziente.Count; i++) // associo gli id ai nomi
            {
                if (idPaziente[i] == id)
                {
                    return nomiPazienti[i];
                }
            }

            return id;
        }

        private string getMedici(string id)
        {
            List<string> idMedici = new List<string>();

            foreach (DataRow item in medici.TableMedici.Rows) // associo gli id ai nomi
            {
                idMedici.Add((string)item[0]);
            }


            for (int i = 0; i < idMedici.Count; i++)
            {
                if (idMedici[i] == id)
                {
                    return nomiMedici[i];
                }
            }

            return id;
        }


        public DataTable Filter(DateTime data, string nomePaziente, string nomeMedico, bool pazientiStatus, bool mediciStatus, bool dateStatus)
        {
            DataTable tableFiltered = new DataTable();


            tableFiltered.Columns.Add(columnGenerator("Data"));
            tableFiltered.Columns.Add(columnGenerator("Paziente"));
            tableFiltered.Columns.Add(columnGenerator("Dottore"));


            if(dateStatus == true && pazientiStatus == true && mediciStatus == true) // a seconda dei dati da filtrare richiamo la funzione con parametri diversi
            {
                tableFiltered = FilterAll(tableFiltered, nomePaziente, nomeMedico, data);
            }
            else if(pazientiStatus == true && mediciStatus == true)
            {
                tableFiltered = FilterBoth(tableFiltered, nomePaziente, nomeMedico);
            }
            else if(mediciStatus == true)
            {
                tableFiltered = FilterMedico(tableFiltered, nomeMedico);
            }
            else if(pazientiStatus == true)
            {
                tableFiltered = FilterPaziente(tableFiltered, nomePaziente);
            }
            else if(dateStatus == true)
            {
                tableFiltered = FilterDate(tableFiltered, data);
            }
            

            return tableFiltered;
        }

        private DataTable FilterBoth(DataTable tableFiltered, string nomePaziente, string nomeMedico)
        {
            DataRow dataRow;

            foreach (DataRow item in TableApp.Rows)// confronto solamente i nomi dei medici e dei pazienti in base alla linea della tabella
            {
                if ((string)item[1] == nomePaziente && (string)item[2] == nomeMedico)
                {
                    dataRow = tableFiltered.NewRow();
                    dataRow[tableFiltered.Columns[0]] = item[0];
                    dataRow[tableFiltered.Columns[1]] = item[1];
                    dataRow[tableFiltered.Columns[2]] = item[2];
                    tableFiltered.Rows.Add(dataRow);
                }
            }

            return tableFiltered;
        }

        private DataTable FilterAll(DataTable tableFiltered, string nomePaziente, string nomeMedico, DateTime date)
        {
            DataRow dataRow;

            foreach (DataRow item in TableApp.Rows)// confronto filtro tutti le tipologie di dato in base alla linea della tabella
            {
                if (Convert.ToDateTime(item[0]).Date == date.Date && (string)item[1] == nomePaziente && (string)item[2] == nomeMedico)
                {
                    dataRow = tableFiltered.NewRow();
                    dataRow[tableFiltered.Columns[0]] = item[0];
                    dataRow[tableFiltered.Columns[1]] = item[1];
                    dataRow[tableFiltered.Columns[2]] = item[2];
                    tableFiltered.Rows.Add(dataRow);
                }
            }

            return tableFiltered;
        }

        private DataTable FilterPaziente(DataTable tableFiltered, string nomePaziente)
        {
            DataRow dataRow;

            foreach (DataRow item in TableApp.Rows)// confronto i nomi dei pazienti in base alla linea della tabella
            {
                if ((string)item[1] == nomePaziente)
                {
                    dataRow = tableFiltered.NewRow();
                    dataRow[tableFiltered.Columns[0]] = item[0];
                    dataRow[tableFiltered.Columns[1]] = item[1];
                    dataRow[tableFiltered.Columns[2]] = item[2];
                    tableFiltered.Rows.Add(dataRow);
                }
            }

            return tableFiltered;
        }


        private DataTable FilterMedico(DataTable tableFiltered, string nomeMedico)
        {
            DataRow dataRow;

            foreach (DataRow item in TableApp.Rows) // confronto i nomi dei medici in base alla linea della tabella
            {
                if ((string)item[2] == nomeMedico)
                {
                    dataRow = tableFiltered.NewRow();
                    dataRow[tableFiltered.Columns[0]] = item[0];
                    dataRow[tableFiltered.Columns[1]] = item[1];
                    dataRow[tableFiltered.Columns[2]] = item[2];
                    tableFiltered.Rows.Add(dataRow);
                }
            }

            return tableFiltered;
        }

        private DataTable FilterDate(DataTable tableFiltered, DateTime date)
        {
            DataRow dataRow;

            foreach (DataRow item in TableApp.Rows) // confronto le date in base alla linea della tabella
            {
                if (Convert.ToDateTime(item[0]).Date == date.Date)
                {
                    dataRow = tableFiltered.NewRow();
                    dataRow[tableFiltered.Columns[0]] = item[0];
                    dataRow[tableFiltered.Columns[1]] = item[1];
                    dataRow[tableFiltered.Columns[2]] = item[2];
                    tableFiltered.Rows.Add(dataRow);
                }
            }

            return tableFiltered;
        }
    }
    
}
