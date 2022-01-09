using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appuntamentiClinica
{
    public partial class Form1 : Form
    {

        Patologie patologie;
        Pazienti pazienti;
        Specializzazioni specializzazioni;
        Medici medici;
        Appuntamenti appuntamenti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creo tutti gli oggetti e li associo alle relative grid view
            patologie = new Patologie();
            pazienti = new Pazienti();
            specializzazioni = new Specializzazioni();
            medici = new Medici();
            appuntamenti = new Appuntamenti();

            dgvPatologie.DataSource = patologie.TablePatologie;
            dgvPazienti.DataSource = pazienti.TablePazienti;
            dgvSpec.DataSource = specializzazioni.TableSpec;
            dgvMedici.DataSource = medici.TableMedici;
            dgvAppuntamenti.DataSource = appuntamenti.TableApp;

            // disabilito le combobox
            cmbMedico.Enabled = false;
            cmbPaziente.Enabled = false;
            dtpDate.Enabled = false;

            cbData.Text = "";
            cbMedico.Text = "";
            cbPaziente.Text = "";

            cmbMedico.DataSource = appuntamenti.NomiMedici;
            cmbPaziente.DataSource = appuntamenti.NomiPazienti;
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            if(cbData.Checked == true)
            {
                dtpDate.Enabled = true;
            }
            else
            {
                dtpDate.Enabled = false;
            }

        }

        private void cbPaziente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPaziente.Checked == true)
            {
                cmbPaziente.Enabled = true;
            }
            else
            {
                cmbPaziente.Enabled = false;
            }
            
        }

        private void cbMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMedico.Checked == true)
            {
                cmbMedico.Enabled = true;
            }
            else
            {
                cmbMedico.Enabled = false;
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        { 
            // eseguo la funzione filter
            dgvAppuntamenti.DataSource = null;
            dgvAppuntamenti.DataSource = appuntamenti.Filter(dtpDate.Value, (string)cmbPaziente.SelectedItem, (string)cmbMedico.SelectedItem, cmbPaziente.Enabled, cmbMedico.Enabled, dtpDate.Enabled);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // resetto la gridview
            dgvAppuntamenti.DataSource = null;
            dgvAppuntamenti.DataSource = appuntamenti.TableApp;
        }
    }
}
