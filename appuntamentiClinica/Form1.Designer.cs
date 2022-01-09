
namespace appuntamentiClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPazienti = new System.Windows.Forms.TabPage();
            this.dgvPazienti = new System.Windows.Forms.DataGridView();
            this.tabMedici = new System.Windows.Forms.TabPage();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.tabPatologie = new System.Windows.Forms.TabPage();
            this.dgvPatologie = new System.Windows.Forms.DataGridView();
            this.tabSpecializzazioni = new System.Windows.Forms.TabPage();
            this.dgvSpec = new System.Windows.Forms.DataGridView();
            this.tabAppuntamenti = new System.Windows.Forms.TabPage();
            this.dgvAppuntamenti = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbMedico = new System.Windows.Forms.CheckBox();
            this.cbPaziente = new System.Windows.Forms.CheckBox();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbPaziente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPazienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazienti)).BeginInit();
            this.tabMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.tabPatologie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatologie)).BeginInit();
            this.tabSpecializzazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpec)).BeginInit();
            this.tabAppuntamenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppuntamenti)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPazienti);
            this.tabControl1.Controls.Add(this.tabMedici);
            this.tabControl1.Controls.Add(this.tabPatologie);
            this.tabControl1.Controls.Add(this.tabSpecializzazioni);
            this.tabControl1.Controls.Add(this.tabAppuntamenti);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPazienti
            // 
            this.tabPazienti.Controls.Add(this.dgvPazienti);
            this.tabPazienti.Location = new System.Drawing.Point(4, 22);
            this.tabPazienti.Name = "tabPazienti";
            this.tabPazienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPazienti.Size = new System.Drawing.Size(792, 424);
            this.tabPazienti.TabIndex = 0;
            this.tabPazienti.Text = "Pazienti";
            this.tabPazienti.UseVisualStyleBackColor = true;
            // 
            // dgvPazienti
            // 
            this.dgvPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPazienti.Location = new System.Drawing.Point(3, 3);
            this.dgvPazienti.Name = "dgvPazienti";
            this.dgvPazienti.Size = new System.Drawing.Size(786, 418);
            this.dgvPazienti.TabIndex = 2;
            // 
            // tabMedici
            // 
            this.tabMedici.Controls.Add(this.dgvMedici);
            this.tabMedici.Location = new System.Drawing.Point(4, 22);
            this.tabMedici.Name = "tabMedici";
            this.tabMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedici.Size = new System.Drawing.Size(792, 424);
            this.tabMedici.TabIndex = 1;
            this.tabMedici.Text = "Medici";
            this.tabMedici.UseVisualStyleBackColor = true;
            // 
            // dgvMedici
            // 
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(3, 3);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.Size = new System.Drawing.Size(786, 418);
            this.dgvMedici.TabIndex = 2;
            // 
            // tabPatologie
            // 
            this.tabPatologie.Controls.Add(this.dgvPatologie);
            this.tabPatologie.Location = new System.Drawing.Point(4, 22);
            this.tabPatologie.Name = "tabPatologie";
            this.tabPatologie.Size = new System.Drawing.Size(792, 424);
            this.tabPatologie.TabIndex = 2;
            this.tabPatologie.Text = "Patologie";
            this.tabPatologie.UseVisualStyleBackColor = true;
            // 
            // dgvPatologie
            // 
            this.dgvPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatologie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatologie.Location = new System.Drawing.Point(0, 0);
            this.dgvPatologie.Name = "dgvPatologie";
            this.dgvPatologie.Size = new System.Drawing.Size(792, 424);
            this.dgvPatologie.TabIndex = 2;
            // 
            // tabSpecializzazioni
            // 
            this.tabSpecializzazioni.Controls.Add(this.dgvSpec);
            this.tabSpecializzazioni.Location = new System.Drawing.Point(4, 22);
            this.tabSpecializzazioni.Name = "tabSpecializzazioni";
            this.tabSpecializzazioni.Size = new System.Drawing.Size(792, 424);
            this.tabSpecializzazioni.TabIndex = 3;
            this.tabSpecializzazioni.Text = "Specializzazioni";
            this.tabSpecializzazioni.UseVisualStyleBackColor = true;
            // 
            // dgvSpec
            // 
            this.dgvSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpec.Location = new System.Drawing.Point(0, 0);
            this.dgvSpec.Name = "dgvSpec";
            this.dgvSpec.Size = new System.Drawing.Size(792, 424);
            this.dgvSpec.TabIndex = 1;
            // 
            // tabAppuntamenti
            // 
            this.tabAppuntamenti.Controls.Add(this.dgvAppuntamenti);
            this.tabAppuntamenti.Controls.Add(this.panel1);
            this.tabAppuntamenti.Location = new System.Drawing.Point(4, 22);
            this.tabAppuntamenti.Name = "tabAppuntamenti";
            this.tabAppuntamenti.Size = new System.Drawing.Size(792, 424);
            this.tabAppuntamenti.TabIndex = 4;
            this.tabAppuntamenti.Text = "Appuntamenti";
            this.tabAppuntamenti.UseVisualStyleBackColor = true;
            // 
            // dgvAppuntamenti
            // 
            this.dgvAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppuntamenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppuntamenti.Location = new System.Drawing.Point(0, 118);
            this.dgvAppuntamenti.Name = "dgvAppuntamenti";
            this.dgvAppuntamenti.Size = new System.Drawing.Size(792, 306);
            this.dgvAppuntamenti.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.cbMedico);
            this.panel1.Controls.Add(this.cbPaziente);
            this.panel1.Controls.Add(this.cbData);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cmbMedico);
            this.panel1.Controls.Add(this.cmbPaziente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 118);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(557, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 71);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(443, 18);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 71);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filtra";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbMedico
            // 
            this.cbMedico.AutoSize = true;
            this.cbMedico.Location = new System.Drawing.Point(311, 76);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(80, 17);
            this.cbMedico.TabIndex = 10;
            this.cbMedico.Text = "checkBox3";
            this.cbMedico.UseVisualStyleBackColor = true;
            this.cbMedico.CheckedChanged += new System.EventHandler(this.cbMedico_CheckedChanged);
            // 
            // cbPaziente
            // 
            this.cbPaziente.AutoSize = true;
            this.cbPaziente.Location = new System.Drawing.Point(311, 48);
            this.cbPaziente.Name = "cbPaziente";
            this.cbPaziente.Size = new System.Drawing.Size(80, 17);
            this.cbPaziente.TabIndex = 9;
            this.cbPaziente.Text = "checkBox2";
            this.cbPaziente.UseVisualStyleBackColor = true;
            this.cbPaziente.CheckedChanged += new System.EventHandler(this.cbPaziente_CheckedChanged);
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(311, 15);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(80, 17);
            this.cbData.TabIndex = 8;
            this.cbData.Text = "checkBox1";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(102, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(193, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(103, 73);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(192, 21);
            this.cmbMedico.TabIndex = 6;
            // 
            // cmbPaziente
            // 
            this.cmbPaziente.FormattingEnabled = true;
            this.cmbPaziente.Location = new System.Drawing.Point(103, 45);
            this.cmbPaziente.Name = "cmbPaziente";
            this.cmbPaziente.Size = new System.Drawing.Size(192, 21);
            this.cmbPaziente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paziente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPazienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazienti)).EndInit();
            this.tabMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.tabPatologie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatologie)).EndInit();
            this.tabSpecializzazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpec)).EndInit();
            this.tabAppuntamenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppuntamenti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPazienti;
        private System.Windows.Forms.TabPage tabMedici;
        private System.Windows.Forms.TabPage tabPatologie;
        private System.Windows.Forms.TabPage tabSpecializzazioni;
        private System.Windows.Forms.TabPage tabAppuntamenti;
        private System.Windows.Forms.DataGridView dgvSpec;
        private System.Windows.Forms.DataGridView dgvPatologie;
        private System.Windows.Forms.DataGridView dgvPazienti;
        private System.Windows.Forms.DataGridView dgvMedici;
        private System.Windows.Forms.DataGridView dgvAppuntamenti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox cbMedico;
        private System.Windows.Forms.CheckBox cbPaziente;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbPaziente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

