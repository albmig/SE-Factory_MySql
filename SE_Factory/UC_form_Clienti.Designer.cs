namespace SE_Factory
{
    partial class UC_form_Clienti
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_Clienti));
            this.Ordini_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.pan_SW_Titolo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.menu_ord_aggiorna = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div01 = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_Ordini_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.dg_Ordini = new System.Windows.Forms.DataGridView();
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAGIONESOCIALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROORDINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERORIGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODICEKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODICESISTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIZIONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREZZOUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTAORDINATAKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTAORDINATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTASPEDITAKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTASPEDITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTOKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTOEVASODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATORIGAORDINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOFTWAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jLabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.dg_Clienti_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numOrdineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOrdineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAnagraficoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partitaIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ricercaBreveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioValiditaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineValiditaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAnagraficoOldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentoStoricoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ragSocCognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ragSocNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ragSocCompletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toponimoFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCivicoFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frazioneFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codComuneFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneAggiuntivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regioneFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casiPartAddRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazioneFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefissoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefissoAggiuntivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoAggiuntivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroVerdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefissoFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codConcessioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLinguaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flCancellatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flRiservatezzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flCodFiscNonRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltModificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTerminaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flSoggettoEsteroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValiditaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAnagraficoNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omocodiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flPIVAChiusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flAllineaIndirizziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flEmailPECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailPECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailPECCommDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdAllegatiEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jLabelJLabelClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLabelTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.JLabelTableAdapter();
            this.jLabel_ClientiTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.JLabel_ClientiTableAdapter();
            this.gCCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gC_CustomersTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter();
            this.Ordini_Layout.SuspendLayout();
            this.pan_SW_Titolo.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.dg_Ordini_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            this.dg_Clienti_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelJLabelClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ordini_Layout
            // 
            this.Ordini_Layout.ColumnCount = 10;
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Ordini_Layout.Controls.Add(this.pan_SW_Titolo, 0, 0);
            this.Ordini_Layout.Controls.Add(this.pan_Menu_comandi, 0, 1);
            this.Ordini_Layout.Controls.Add(this.pan_Menu_salva, 6, 1);
            this.Ordini_Layout.Controls.Add(this.pan_Menu_exit, 9, 1);
            this.Ordini_Layout.Controls.Add(this.dg_Ordini_Layout, 0, 2);
            this.Ordini_Layout.Controls.Add(this.dg_Clienti_Layout, 0, 3);
            this.Ordini_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ordini_Layout.Location = new System.Drawing.Point(0, 0);
            this.Ordini_Layout.Name = "Ordini_Layout";
            this.Ordini_Layout.RowCount = 10;
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Ordini_Layout.Size = new System.Drawing.Size(1200, 1200);
            this.Ordini_Layout.TabIndex = 0;
            // 
            // pan_SW_Titolo
            // 
            this.Ordini_Layout.SetColumnSpan(this.pan_SW_Titolo, 10);
            this.pan_SW_Titolo.Controls.Add(this.metroLabel21);
            this.pan_SW_Titolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_SW_Titolo.HorizontalScrollbarBarColor = true;
            this.pan_SW_Titolo.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.HorizontalScrollbarSize = 10;
            this.pan_SW_Titolo.Location = new System.Drawing.Point(3, 3);
            this.pan_SW_Titolo.Name = "pan_SW_Titolo";
            this.pan_SW_Titolo.Size = new System.Drawing.Size(1194, 22);
            this.pan_SW_Titolo.TabIndex = 20;
            this.pan_SW_Titolo.UseCustomBackColor = true;
            this.pan_SW_Titolo.VerticalScrollbarBarColor = true;
            this.pan_SW_Titolo.VerticalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.VerticalScrollbarSize = 10;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(0, 0);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(159, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Inserimento Clienti";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseStyleColors = true;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.Ordini_Layout.SetColumnSpan(this.pan_Menu_comandi, 6);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ord_aggiorna,
            this.menu_sw_div01,
            this.conversionToolStripMenuItem});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 28);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(720, 24);
            this.pan_Menu_comandi.TabIndex = 21;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // menu_ord_aggiorna
            // 
            this.menu_ord_aggiorna.Image = ((System.Drawing.Image)(resources.GetObject("menu_ord_aggiorna.Image")));
            this.menu_ord_aggiorna.Name = "menu_ord_aggiorna";
            this.menu_ord_aggiorna.Size = new System.Drawing.Size(110, 20);
            this.menu_ord_aggiorna.Text = "Refresh Ordini";
            this.menu_ord_aggiorna.Click += new System.EventHandler(this.UC_form_Clienti_Load);
            // 
            // menu_sw_div01
            // 
            this.menu_sw_div01.Enabled = false;
            this.menu_sw_div01.Name = "menu_sw_div01";
            this.menu_sw_div01.Size = new System.Drawing.Size(22, 20);
            this.menu_sw_div01.Text = "|";
            // 
            // conversionToolStripMenuItem
            // 
            this.conversionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conversionToolStripMenuItem.Image")));
            this.conversionToolStripMenuItem.Name = "conversionToolStripMenuItem";
            this.conversionToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.conversionToolStripMenuItem.Text = "Conversione";
            this.conversionToolStripMenuItem.Click += new System.EventHandler(this.conversionToolStripMenuItem_Click);
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.Ordini_Layout.SetColumnSpan(this.pan_Menu_salva, 3);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_salva.Location = new System.Drawing.Point(720, 28);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(360, 24);
            this.pan_Menu_salva.TabIndex = 57;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1080, 28);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(120, 24);
            this.pan_Menu_exit.TabIndex = 58;
            this.pan_Menu_exit.Text = "menuStrip1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShowShortcutKeys = false;
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem5.Text = "|";
            // 
            // menu_sw_exit
            // 
            this.menu_sw_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_exit.Image")));
            this.menu_sw_exit.Name = "menu_sw_exit";
            this.menu_sw_exit.Size = new System.Drawing.Size(67, 20);
            this.menu_sw_exit.Text = "Uscita";
            this.menu_sw_exit.Click += new System.EventHandler(this.menu_sw_exit_Click);
            // 
            // dg_Ordini_Layout
            // 
            this.dg_Ordini_Layout.ColumnCount = 1;
            this.Ordini_Layout.SetColumnSpan(this.dg_Ordini_Layout, 10);
            this.dg_Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dg_Ordini_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dg_Ordini_Layout.Controls.Add(this.dg_Ordini, 0, 0);
            this.dg_Ordini_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Ordini_Layout.Location = new System.Drawing.Point(3, 55);
            this.dg_Ordini_Layout.Name = "dg_Ordini_Layout";
            this.dg_Ordini_Layout.RowCount = 1;
            this.dg_Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dg_Ordini_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.dg_Ordini_Layout.Size = new System.Drawing.Size(1194, 300);
            this.dg_Ordini_Layout.TabIndex = 60;
            // 
            // dg_Ordini
            // 
            this.dg_Ordini.AllowUserToAddRows = false;
            this.dg_Ordini.AllowUserToDeleteRows = false;
            this.dg_Ordini.AllowUserToOrderColumns = true;
            this.dg_Ordini.AllowUserToResizeRows = false;
            this.dg_Ordini.AutoGenerateColumns = false;
            this.dg_Ordini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Ordini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Ordini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn,
            this.rAGIONESOCIALEDataGridViewTextBoxColumn,
            this.nUMEROORDINEDataGridViewTextBoxColumn,
            this.nUMERORIGADataGridViewTextBoxColumn,
            this.tIPODBDataGridViewTextBoxColumn,
            this.cODICEKITDataGridViewTextBoxColumn,
            this.cODICESISTEMADataGridViewTextBoxColumn,
            this.dESCRIZIONEDataGridViewTextBoxColumn,
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn,
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn,
            this.pREZZOUNITARIODataGridViewTextBoxColumn,
            this.qTAORDINATAKITDataGridViewTextBoxColumn,
            this.qTAORDINATADataGridViewTextBoxColumn,
            this.qTASPEDITAKITDataGridViewTextBoxColumn,
            this.qTASPEDITADataGridViewTextBoxColumn,
            this.iMPORTOKITDataGridViewTextBoxColumn,
            this.iMPORTODataGridViewTextBoxColumn,
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn,
            this.iMPORTOEVASODataGridViewTextBoxColumn,
            this.sTATORIGAORDINEDataGridViewTextBoxColumn,
            this.sOFTWAREDataGridViewTextBoxColumn});
            this.dg_Ordini.DataSource = this.jLabelBindingSource;
            this.dg_Ordini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Ordini.Location = new System.Drawing.Point(3, 3);
            this.dg_Ordini.Name = "dg_Ordini";
            this.dg_Ordini.ReadOnly = true;
            this.dg_Ordini.RowHeadersVisible = false;
            this.dg_Ordini.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Ordini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Ordini.Size = new System.Drawing.Size(1188, 294);
            this.dg_Ordini.TabIndex = 59;
            // 
            // tIPOORDINECLIENTEDataGridViewTextBoxColumn
            // 
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "TIPO_ORDINE_CLIENTE";
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn.HeaderText = "TIPO_ORDINE_CLIENTE";
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn.Name = "tIPOORDINECLIENTEDataGridViewTextBoxColumn";
            this.tIPOORDINECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAGIONESOCIALEDataGridViewTextBoxColumn
            // 
            this.rAGIONESOCIALEDataGridViewTextBoxColumn.DataPropertyName = "RAGIONE_SOCIALE";
            this.rAGIONESOCIALEDataGridViewTextBoxColumn.HeaderText = "RAGIONE_SOCIALE";
            this.rAGIONESOCIALEDataGridViewTextBoxColumn.Name = "rAGIONESOCIALEDataGridViewTextBoxColumn";
            this.rAGIONESOCIALEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROORDINEDataGridViewTextBoxColumn
            // 
            this.nUMEROORDINEDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_ORDINE";
            this.nUMEROORDINEDataGridViewTextBoxColumn.HeaderText = "NUMERO_ORDINE";
            this.nUMEROORDINEDataGridViewTextBoxColumn.Name = "nUMEROORDINEDataGridViewTextBoxColumn";
            this.nUMEROORDINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMERORIGADataGridViewTextBoxColumn
            // 
            this.nUMERORIGADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_RIGA";
            this.nUMERORIGADataGridViewTextBoxColumn.HeaderText = "NUMERO_RIGA";
            this.nUMERORIGADataGridViewTextBoxColumn.Name = "nUMERORIGADataGridViewTextBoxColumn";
            this.nUMERORIGADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODBDataGridViewTextBoxColumn
            // 
            this.tIPODBDataGridViewTextBoxColumn.DataPropertyName = "TIPO_DB";
            this.tIPODBDataGridViewTextBoxColumn.HeaderText = "TIPO_DB";
            this.tIPODBDataGridViewTextBoxColumn.Name = "tIPODBDataGridViewTextBoxColumn";
            this.tIPODBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODICEKITDataGridViewTextBoxColumn
            // 
            this.cODICEKITDataGridViewTextBoxColumn.DataPropertyName = "CODICE_KIT";
            this.cODICEKITDataGridViewTextBoxColumn.HeaderText = "CODICE_KIT";
            this.cODICEKITDataGridViewTextBoxColumn.Name = "cODICEKITDataGridViewTextBoxColumn";
            this.cODICEKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODICESISTEMADataGridViewTextBoxColumn
            // 
            this.cODICESISTEMADataGridViewTextBoxColumn.DataPropertyName = "CODICE_SISTEMA";
            this.cODICESISTEMADataGridViewTextBoxColumn.HeaderText = "CODICE_SISTEMA";
            this.cODICESISTEMADataGridViewTextBoxColumn.Name = "cODICESISTEMADataGridViewTextBoxColumn";
            this.cODICESISTEMADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIZIONEDataGridViewTextBoxColumn
            // 
            this.dESCRIZIONEDataGridViewTextBoxColumn.DataPropertyName = "DESCRIZIONE";
            this.dESCRIZIONEDataGridViewTextBoxColumn.HeaderText = "DESCRIZIONE";
            this.dESCRIZIONEDataGridViewTextBoxColumn.Name = "dESCRIZIONEDataGridViewTextBoxColumn";
            this.dESCRIZIONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATARICHIESTACONSEGNADataGridViewTextBoxColumn
            // 
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn.DataPropertyName = "DATA_RICHIESTA_CONSEGNA";
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn.HeaderText = "DATA_RICHIESTA_CONSEGNA";
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn.Name = "dATARICHIESTACONSEGNADataGridViewTextBoxColumn";
            this.dATARICHIESTACONSEGNADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATACONFERMACONSEGNADataGridViewTextBoxColumn
            // 
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn.DataPropertyName = "DATA_CONFERMA_CONSEGNA";
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn.HeaderText = "DATA_CONFERMA_CONSEGNA";
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn.Name = "dATACONFERMACONSEGNADataGridViewTextBoxColumn";
            this.dATACONFERMACONSEGNADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREZZOUNITARIOKITDataGridViewTextBoxColumn
            // 
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn.DataPropertyName = "PREZZO_UNITARIO_KIT";
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn.HeaderText = "PREZZO_UNITARIO_KIT";
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn.Name = "pREZZOUNITARIOKITDataGridViewTextBoxColumn";
            this.pREZZOUNITARIOKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREZZOUNITARIODataGridViewTextBoxColumn
            // 
            this.pREZZOUNITARIODataGridViewTextBoxColumn.DataPropertyName = "PREZZO_UNITARIO";
            this.pREZZOUNITARIODataGridViewTextBoxColumn.HeaderText = "PREZZO_UNITARIO";
            this.pREZZOUNITARIODataGridViewTextBoxColumn.Name = "pREZZOUNITARIODataGridViewTextBoxColumn";
            this.pREZZOUNITARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTAORDINATAKITDataGridViewTextBoxColumn
            // 
            this.qTAORDINATAKITDataGridViewTextBoxColumn.DataPropertyName = "QTA_ORDINATA_KIT";
            this.qTAORDINATAKITDataGridViewTextBoxColumn.HeaderText = "QTA_ORDINATA_KIT";
            this.qTAORDINATAKITDataGridViewTextBoxColumn.Name = "qTAORDINATAKITDataGridViewTextBoxColumn";
            this.qTAORDINATAKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTAORDINATADataGridViewTextBoxColumn
            // 
            this.qTAORDINATADataGridViewTextBoxColumn.DataPropertyName = "QTA_ORDINATA";
            this.qTAORDINATADataGridViewTextBoxColumn.HeaderText = "QTA_ORDINATA";
            this.qTAORDINATADataGridViewTextBoxColumn.Name = "qTAORDINATADataGridViewTextBoxColumn";
            this.qTAORDINATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTASPEDITAKITDataGridViewTextBoxColumn
            // 
            this.qTASPEDITAKITDataGridViewTextBoxColumn.DataPropertyName = "QTA_SPEDITA_KIT";
            this.qTASPEDITAKITDataGridViewTextBoxColumn.HeaderText = "QTA_SPEDITA_KIT";
            this.qTASPEDITAKITDataGridViewTextBoxColumn.Name = "qTASPEDITAKITDataGridViewTextBoxColumn";
            this.qTASPEDITAKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTASPEDITADataGridViewTextBoxColumn
            // 
            this.qTASPEDITADataGridViewTextBoxColumn.DataPropertyName = "QTA_SPEDITA";
            this.qTASPEDITADataGridViewTextBoxColumn.HeaderText = "QTA_SPEDITA";
            this.qTASPEDITADataGridViewTextBoxColumn.Name = "qTASPEDITADataGridViewTextBoxColumn";
            this.qTASPEDITADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMPORTOKITDataGridViewTextBoxColumn
            // 
            this.iMPORTOKITDataGridViewTextBoxColumn.DataPropertyName = "IMPORTO_KIT";
            this.iMPORTOKITDataGridViewTextBoxColumn.HeaderText = "IMPORTO_KIT";
            this.iMPORTOKITDataGridViewTextBoxColumn.Name = "iMPORTOKITDataGridViewTextBoxColumn";
            this.iMPORTOKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMPORTODataGridViewTextBoxColumn
            // 
            this.iMPORTODataGridViewTextBoxColumn.DataPropertyName = "IMPORTO";
            this.iMPORTODataGridViewTextBoxColumn.HeaderText = "IMPORTO";
            this.iMPORTODataGridViewTextBoxColumn.Name = "iMPORTODataGridViewTextBoxColumn";
            this.iMPORTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMPORTOEVASOKITDataGridViewTextBoxColumn
            // 
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn.DataPropertyName = "IMPORTO_EVASO_KIT";
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn.HeaderText = "IMPORTO_EVASO_KIT";
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn.Name = "iMPORTOEVASOKITDataGridViewTextBoxColumn";
            this.iMPORTOEVASOKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMPORTOEVASODataGridViewTextBoxColumn
            // 
            this.iMPORTOEVASODataGridViewTextBoxColumn.DataPropertyName = "IMPORTO_EVASO";
            this.iMPORTOEVASODataGridViewTextBoxColumn.HeaderText = "IMPORTO_EVASO";
            this.iMPORTOEVASODataGridViewTextBoxColumn.Name = "iMPORTOEVASODataGridViewTextBoxColumn";
            this.iMPORTOEVASODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATORIGAORDINEDataGridViewTextBoxColumn
            // 
            this.sTATORIGAORDINEDataGridViewTextBoxColumn.DataPropertyName = "STATO_RIGA_ORDINE";
            this.sTATORIGAORDINEDataGridViewTextBoxColumn.HeaderText = "STATO_RIGA_ORDINE";
            this.sTATORIGAORDINEDataGridViewTextBoxColumn.Name = "sTATORIGAORDINEDataGridViewTextBoxColumn";
            this.sTATORIGAORDINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOFTWAREDataGridViewTextBoxColumn
            // 
            this.sOFTWAREDataGridViewTextBoxColumn.DataPropertyName = "SOFTWARE";
            this.sOFTWAREDataGridViewTextBoxColumn.HeaderText = "SOFTWARE";
            this.sOFTWAREDataGridViewTextBoxColumn.Name = "sOFTWAREDataGridViewTextBoxColumn";
            this.sOFTWAREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jLabelBindingSource
            // 
            this.jLabelBindingSource.DataMember = "JLabel";
            this.jLabelBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg_Clienti_Layout
            // 
            this.dg_Clienti_Layout.ColumnCount = 1;
            this.Ordini_Layout.SetColumnSpan(this.dg_Clienti_Layout, 10);
            this.dg_Clienti_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dg_Clienti_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dg_Clienti_Layout.Controls.Add(this.dataGridView1, 0, 0);
            this.dg_Clienti_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Clienti_Layout.Location = new System.Drawing.Point(3, 361);
            this.dg_Clienti_Layout.Name = "dg_Clienti_Layout";
            this.dg_Clienti_Layout.RowCount = 1;
            this.dg_Clienti_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dg_Clienti_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.dg_Clienti_Layout.Size = new System.Drawing.Size(1194, 300);
            this.dg_Clienti_Layout.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numOrdineDataGridViewTextBoxColumn,
            this.tipoOrdineDataGridViewTextBoxColumn,
            this.codAnagraficoDataGridViewTextBoxColumn,
            this.partitaIvaDataGridViewTextBoxColumn,
            this.codiceFiscaleDataGridViewTextBoxColumn,
            this.ricercaBreveDataGridViewTextBoxColumn,
            this.dataInizioValiditaDataGridViewTextBoxColumn,
            this.dataFineValiditaDataGridViewTextBoxColumn,
            this.codAnagraficoOldDataGridViewTextBoxColumn,
            this.commentoStoricoDataGridViewTextBoxColumn,
            this.tipoPersonaDataGridViewTextBoxColumn,
            this.ragSocCognomeDataGridViewTextBoxColumn,
            this.ragSocNomeDataGridViewTextBoxColumn,
            this.ragSocCompletaDataGridViewTextBoxColumn,
            this.indirizzoFiscaleDataGridViewTextBoxColumn,
            this.toponimoFiscaleDataGridViewTextBoxColumn,
            this.indFiscaleDataGridViewTextBoxColumn,
            this.numCivicoFiscaleDataGridViewTextBoxColumn,
            this.frazioneFiscaleDataGridViewTextBoxColumn,
            this.capFiscaleDataGridViewTextBoxColumn,
            this.comuneFiscaleDataGridViewTextBoxColumn,
            this.codComuneFiscaleDataGridViewTextBoxColumn,
            this.comuneAggiuntivoDataGridViewTextBoxColumn,
            this.provinciaFiscaleDataGridViewTextBoxColumn,
            this.regioneFiscaleDataGridViewTextBoxColumn,
            this.casiPartAddRegDataGridViewTextBoxColumn,
            this.nazioneFiscaleDataGridViewTextBoxColumn,
            this.prefissoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.prefissoAggiuntivoDataGridViewTextBoxColumn,
            this.telefonoAggiuntivoDataGridViewTextBoxColumn,
            this.numeroVerdeDataGridViewTextBoxColumn,
            this.prefissoFaxDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.telexDataGridViewTextBoxColumn,
            this.httpDataGridViewTextBoxColumn,
            this.titoloDataGridViewTextBoxColumn,
            this.codConcessioneDataGridViewTextBoxColumn,
            this.codLinguaDataGridViewTextBoxColumn,
            this.flCancellatoDataGridViewTextBoxColumn,
            this.flRiservatezzaDataGridViewTextBoxColumn,
            this.flCodFiscNonRegDataGridViewTextBoxColumn,
            this.dataUltModificaDataGridViewTextBoxColumn,
            this.iDUtenteDataGridViewTextBoxColumn,
            this.iDTerminaleDataGridViewTextBoxColumn,
            this.flSoggettoEsteroDataGridViewTextBoxColumn,
            this.dataValiditaDataGridViewTextBoxColumn,
            this.codAnagraficoNewDataGridViewTextBoxColumn,
            this.omocodiceDataGridViewTextBoxColumn,
            this.flPIVAChiusaDataGridViewTextBoxColumn,
            this.flAllineaIndirizziDataGridViewTextBoxColumn,
            this.flEmailPECDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.eMailPECDataGridViewTextBoxColumn,
            this.eMailPECCommDataGridViewTextBoxColumn,
            this.pwdAllegatiEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jLabelJLabelClientiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 294);
            this.dataGridView1.TabIndex = 59;
            // 
            // numOrdineDataGridViewTextBoxColumn
            // 
            this.numOrdineDataGridViewTextBoxColumn.DataPropertyName = "NumOrdine";
            this.numOrdineDataGridViewTextBoxColumn.HeaderText = "NumOrdine";
            this.numOrdineDataGridViewTextBoxColumn.Name = "numOrdineDataGridViewTextBoxColumn";
            this.numOrdineDataGridViewTextBoxColumn.ReadOnly = true;
            this.numOrdineDataGridViewTextBoxColumn.Width = 85;
            // 
            // tipoOrdineDataGridViewTextBoxColumn
            // 
            this.tipoOrdineDataGridViewTextBoxColumn.DataPropertyName = "TipoOrdine";
            this.tipoOrdineDataGridViewTextBoxColumn.HeaderText = "TipoOrdine";
            this.tipoOrdineDataGridViewTextBoxColumn.Name = "tipoOrdineDataGridViewTextBoxColumn";
            this.tipoOrdineDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoOrdineDataGridViewTextBoxColumn.Width = 84;
            // 
            // codAnagraficoDataGridViewTextBoxColumn
            // 
            this.codAnagraficoDataGridViewTextBoxColumn.DataPropertyName = "CodAnagrafico";
            this.codAnagraficoDataGridViewTextBoxColumn.HeaderText = "CodAnagrafico";
            this.codAnagraficoDataGridViewTextBoxColumn.Name = "codAnagraficoDataGridViewTextBoxColumn";
            this.codAnagraficoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAnagraficoDataGridViewTextBoxColumn.Width = 102;
            // 
            // partitaIvaDataGridViewTextBoxColumn
            // 
            this.partitaIvaDataGridViewTextBoxColumn.DataPropertyName = "PartitaIva";
            this.partitaIvaDataGridViewTextBoxColumn.HeaderText = "PartitaIva";
            this.partitaIvaDataGridViewTextBoxColumn.Name = "partitaIvaDataGridViewTextBoxColumn";
            this.partitaIvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.partitaIvaDataGridViewTextBoxColumn.Width = 77;
            // 
            // codiceFiscaleDataGridViewTextBoxColumn
            // 
            this.codiceFiscaleDataGridViewTextBoxColumn.DataPropertyName = "CodiceFiscale";
            this.codiceFiscaleDataGridViewTextBoxColumn.HeaderText = "CodiceFiscale";
            this.codiceFiscaleDataGridViewTextBoxColumn.Name = "codiceFiscaleDataGridViewTextBoxColumn";
            this.codiceFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceFiscaleDataGridViewTextBoxColumn.Width = 98;
            // 
            // ricercaBreveDataGridViewTextBoxColumn
            // 
            this.ricercaBreveDataGridViewTextBoxColumn.DataPropertyName = "RicercaBreve";
            this.ricercaBreveDataGridViewTextBoxColumn.HeaderText = "RicercaBreve";
            this.ricercaBreveDataGridViewTextBoxColumn.Name = "ricercaBreveDataGridViewTextBoxColumn";
            this.ricercaBreveDataGridViewTextBoxColumn.ReadOnly = true;
            this.ricercaBreveDataGridViewTextBoxColumn.Width = 97;
            // 
            // dataInizioValiditaDataGridViewTextBoxColumn
            // 
            this.dataInizioValiditaDataGridViewTextBoxColumn.DataPropertyName = "DataInizioValidita";
            this.dataInizioValiditaDataGridViewTextBoxColumn.HeaderText = "DataInizioValidita";
            this.dataInizioValiditaDataGridViewTextBoxColumn.Name = "dataInizioValiditaDataGridViewTextBoxColumn";
            this.dataInizioValiditaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataInizioValiditaDataGridViewTextBoxColumn.Width = 113;
            // 
            // dataFineValiditaDataGridViewTextBoxColumn
            // 
            this.dataFineValiditaDataGridViewTextBoxColumn.DataPropertyName = "DataFineValidita";
            this.dataFineValiditaDataGridViewTextBoxColumn.HeaderText = "DataFineValidita";
            this.dataFineValiditaDataGridViewTextBoxColumn.Name = "dataFineValiditaDataGridViewTextBoxColumn";
            this.dataFineValiditaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataFineValiditaDataGridViewTextBoxColumn.Width = 109;
            // 
            // codAnagraficoOldDataGridViewTextBoxColumn
            // 
            this.codAnagraficoOldDataGridViewTextBoxColumn.DataPropertyName = "CodAnagraficoOld";
            this.codAnagraficoOldDataGridViewTextBoxColumn.HeaderText = "CodAnagraficoOld";
            this.codAnagraficoOldDataGridViewTextBoxColumn.Name = "codAnagraficoOldDataGridViewTextBoxColumn";
            this.codAnagraficoOldDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAnagraficoOldDataGridViewTextBoxColumn.Width = 118;
            // 
            // commentoStoricoDataGridViewTextBoxColumn
            // 
            this.commentoStoricoDataGridViewTextBoxColumn.DataPropertyName = "CommentoStorico";
            this.commentoStoricoDataGridViewTextBoxColumn.HeaderText = "CommentoStorico";
            this.commentoStoricoDataGridViewTextBoxColumn.Name = "commentoStoricoDataGridViewTextBoxColumn";
            this.commentoStoricoDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentoStoricoDataGridViewTextBoxColumn.Width = 115;
            // 
            // tipoPersonaDataGridViewTextBoxColumn
            // 
            this.tipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.HeaderText = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.Name = "tipoPersonaDataGridViewTextBoxColumn";
            this.tipoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPersonaDataGridViewTextBoxColumn.Width = 92;
            // 
            // ragSocCognomeDataGridViewTextBoxColumn
            // 
            this.ragSocCognomeDataGridViewTextBoxColumn.DataPropertyName = "RagSocCognome";
            this.ragSocCognomeDataGridViewTextBoxColumn.HeaderText = "RagSocCognome";
            this.ragSocCognomeDataGridViewTextBoxColumn.Name = "ragSocCognomeDataGridViewTextBoxColumn";
            this.ragSocCognomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ragSocCognomeDataGridViewTextBoxColumn.Width = 116;
            // 
            // ragSocNomeDataGridViewTextBoxColumn
            // 
            this.ragSocNomeDataGridViewTextBoxColumn.DataPropertyName = "RagSocNome";
            this.ragSocNomeDataGridViewTextBoxColumn.HeaderText = "RagSocNome";
            this.ragSocNomeDataGridViewTextBoxColumn.Name = "ragSocNomeDataGridViewTextBoxColumn";
            this.ragSocNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ragSocNomeDataGridViewTextBoxColumn.Width = 99;
            // 
            // ragSocCompletaDataGridViewTextBoxColumn
            // 
            this.ragSocCompletaDataGridViewTextBoxColumn.DataPropertyName = "RagSocCompleta";
            this.ragSocCompletaDataGridViewTextBoxColumn.HeaderText = "RagSocCompleta";
            this.ragSocCompletaDataGridViewTextBoxColumn.Name = "ragSocCompletaDataGridViewTextBoxColumn";
            this.ragSocCompletaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ragSocCompletaDataGridViewTextBoxColumn.Width = 115;
            // 
            // indirizzoFiscaleDataGridViewTextBoxColumn
            // 
            this.indirizzoFiscaleDataGridViewTextBoxColumn.DataPropertyName = "IndirizzoFiscale";
            this.indirizzoFiscaleDataGridViewTextBoxColumn.HeaderText = "IndirizzoFiscale";
            this.indirizzoFiscaleDataGridViewTextBoxColumn.Name = "indirizzoFiscaleDataGridViewTextBoxColumn";
            this.indirizzoFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.indirizzoFiscaleDataGridViewTextBoxColumn.Width = 103;
            // 
            // toponimoFiscaleDataGridViewTextBoxColumn
            // 
            this.toponimoFiscaleDataGridViewTextBoxColumn.DataPropertyName = "ToponimoFiscale";
            this.toponimoFiscaleDataGridViewTextBoxColumn.HeaderText = "ToponimoFiscale";
            this.toponimoFiscaleDataGridViewTextBoxColumn.Name = "toponimoFiscaleDataGridViewTextBoxColumn";
            this.toponimoFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.toponimoFiscaleDataGridViewTextBoxColumn.Width = 112;
            // 
            // indFiscaleDataGridViewTextBoxColumn
            // 
            this.indFiscaleDataGridViewTextBoxColumn.DataPropertyName = "IndFiscale";
            this.indFiscaleDataGridViewTextBoxColumn.HeaderText = "IndFiscale";
            this.indFiscaleDataGridViewTextBoxColumn.Name = "indFiscaleDataGridViewTextBoxColumn";
            this.indFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.indFiscaleDataGridViewTextBoxColumn.Width = 80;
            // 
            // numCivicoFiscaleDataGridViewTextBoxColumn
            // 
            this.numCivicoFiscaleDataGridViewTextBoxColumn.DataPropertyName = "NumCivicoFiscale";
            this.numCivicoFiscaleDataGridViewTextBoxColumn.HeaderText = "NumCivicoFiscale";
            this.numCivicoFiscaleDataGridViewTextBoxColumn.Name = "numCivicoFiscaleDataGridViewTextBoxColumn";
            this.numCivicoFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.numCivicoFiscaleDataGridViewTextBoxColumn.Width = 116;
            // 
            // frazioneFiscaleDataGridViewTextBoxColumn
            // 
            this.frazioneFiscaleDataGridViewTextBoxColumn.DataPropertyName = "FrazioneFiscale";
            this.frazioneFiscaleDataGridViewTextBoxColumn.HeaderText = "FrazioneFiscale";
            this.frazioneFiscaleDataGridViewTextBoxColumn.Name = "frazioneFiscaleDataGridViewTextBoxColumn";
            this.frazioneFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.frazioneFiscaleDataGridViewTextBoxColumn.Width = 105;
            // 
            // capFiscaleDataGridViewTextBoxColumn
            // 
            this.capFiscaleDataGridViewTextBoxColumn.DataPropertyName = "CapFiscale";
            this.capFiscaleDataGridViewTextBoxColumn.HeaderText = "CapFiscale";
            this.capFiscaleDataGridViewTextBoxColumn.Name = "capFiscaleDataGridViewTextBoxColumn";
            this.capFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.capFiscaleDataGridViewTextBoxColumn.Width = 84;
            // 
            // comuneFiscaleDataGridViewTextBoxColumn
            // 
            this.comuneFiscaleDataGridViewTextBoxColumn.DataPropertyName = "ComuneFiscale";
            this.comuneFiscaleDataGridViewTextBoxColumn.HeaderText = "ComuneFiscale";
            this.comuneFiscaleDataGridViewTextBoxColumn.Name = "comuneFiscaleDataGridViewTextBoxColumn";
            this.comuneFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.comuneFiscaleDataGridViewTextBoxColumn.Width = 104;
            // 
            // codComuneFiscaleDataGridViewTextBoxColumn
            // 
            this.codComuneFiscaleDataGridViewTextBoxColumn.DataPropertyName = "CodComuneFiscale";
            this.codComuneFiscaleDataGridViewTextBoxColumn.HeaderText = "CodComuneFiscale";
            this.codComuneFiscaleDataGridViewTextBoxColumn.Name = "codComuneFiscaleDataGridViewTextBoxColumn";
            this.codComuneFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.codComuneFiscaleDataGridViewTextBoxColumn.Width = 123;
            // 
            // comuneAggiuntivoDataGridViewTextBoxColumn
            // 
            this.comuneAggiuntivoDataGridViewTextBoxColumn.DataPropertyName = "ComuneAggiuntivo";
            this.comuneAggiuntivoDataGridViewTextBoxColumn.HeaderText = "ComuneAggiuntivo";
            this.comuneAggiuntivoDataGridViewTextBoxColumn.Name = "comuneAggiuntivoDataGridViewTextBoxColumn";
            this.comuneAggiuntivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.comuneAggiuntivoDataGridViewTextBoxColumn.Width = 121;
            // 
            // provinciaFiscaleDataGridViewTextBoxColumn
            // 
            this.provinciaFiscaleDataGridViewTextBoxColumn.DataPropertyName = "ProvinciaFiscale";
            this.provinciaFiscaleDataGridViewTextBoxColumn.HeaderText = "ProvinciaFiscale";
            this.provinciaFiscaleDataGridViewTextBoxColumn.Name = "provinciaFiscaleDataGridViewTextBoxColumn";
            this.provinciaFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinciaFiscaleDataGridViewTextBoxColumn.Width = 109;
            // 
            // regioneFiscaleDataGridViewTextBoxColumn
            // 
            this.regioneFiscaleDataGridViewTextBoxColumn.DataPropertyName = "RegioneFiscale";
            this.regioneFiscaleDataGridViewTextBoxColumn.HeaderText = "RegioneFiscale";
            this.regioneFiscaleDataGridViewTextBoxColumn.Name = "regioneFiscaleDataGridViewTextBoxColumn";
            this.regioneFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.regioneFiscaleDataGridViewTextBoxColumn.Width = 105;
            // 
            // casiPartAddRegDataGridViewTextBoxColumn
            // 
            this.casiPartAddRegDataGridViewTextBoxColumn.DataPropertyName = "CasiPartAddReg";
            this.casiPartAddRegDataGridViewTextBoxColumn.HeaderText = "CasiPartAddReg";
            this.casiPartAddRegDataGridViewTextBoxColumn.Name = "casiPartAddRegDataGridViewTextBoxColumn";
            this.casiPartAddRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.casiPartAddRegDataGridViewTextBoxColumn.Width = 110;
            // 
            // nazioneFiscaleDataGridViewTextBoxColumn
            // 
            this.nazioneFiscaleDataGridViewTextBoxColumn.DataPropertyName = "NazioneFiscale";
            this.nazioneFiscaleDataGridViewTextBoxColumn.HeaderText = "NazioneFiscale";
            this.nazioneFiscaleDataGridViewTextBoxColumn.Name = "nazioneFiscaleDataGridViewTextBoxColumn";
            this.nazioneFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazioneFiscaleDataGridViewTextBoxColumn.Width = 104;
            // 
            // prefissoDataGridViewTextBoxColumn
            // 
            this.prefissoDataGridViewTextBoxColumn.DataPropertyName = "Prefisso";
            this.prefissoDataGridViewTextBoxColumn.HeaderText = "Prefisso";
            this.prefissoDataGridViewTextBoxColumn.Name = "prefissoDataGridViewTextBoxColumn";
            this.prefissoDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefissoDataGridViewTextBoxColumn.Width = 69;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 74;
            // 
            // prefissoAggiuntivoDataGridViewTextBoxColumn
            // 
            this.prefissoAggiuntivoDataGridViewTextBoxColumn.DataPropertyName = "PrefissoAggiuntivo";
            this.prefissoAggiuntivoDataGridViewTextBoxColumn.HeaderText = "PrefissoAggiuntivo";
            this.prefissoAggiuntivoDataGridViewTextBoxColumn.Name = "prefissoAggiuntivoDataGridViewTextBoxColumn";
            this.prefissoAggiuntivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefissoAggiuntivoDataGridViewTextBoxColumn.Width = 119;
            // 
            // telefonoAggiuntivoDataGridViewTextBoxColumn
            // 
            this.telefonoAggiuntivoDataGridViewTextBoxColumn.DataPropertyName = "TelefonoAggiuntivo";
            this.telefonoAggiuntivoDataGridViewTextBoxColumn.HeaderText = "TelefonoAggiuntivo";
            this.telefonoAggiuntivoDataGridViewTextBoxColumn.Name = "telefonoAggiuntivoDataGridViewTextBoxColumn";
            this.telefonoAggiuntivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoAggiuntivoDataGridViewTextBoxColumn.Width = 124;
            // 
            // numeroVerdeDataGridViewTextBoxColumn
            // 
            this.numeroVerdeDataGridViewTextBoxColumn.DataPropertyName = "NumeroVerde";
            this.numeroVerdeDataGridViewTextBoxColumn.HeaderText = "NumeroVerde";
            this.numeroVerdeDataGridViewTextBoxColumn.Name = "numeroVerdeDataGridViewTextBoxColumn";
            this.numeroVerdeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroVerdeDataGridViewTextBoxColumn.Width = 97;
            // 
            // prefissoFaxDataGridViewTextBoxColumn
            // 
            this.prefissoFaxDataGridViewTextBoxColumn.DataPropertyName = "PrefissoFax";
            this.prefissoFaxDataGridViewTextBoxColumn.HeaderText = "PrefissoFax";
            this.prefissoFaxDataGridViewTextBoxColumn.Name = "prefissoFaxDataGridViewTextBoxColumn";
            this.prefissoFaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefissoFaxDataGridViewTextBoxColumn.Width = 86;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            this.faxDataGridViewTextBoxColumn.Width = 49;
            // 
            // telexDataGridViewTextBoxColumn
            // 
            this.telexDataGridViewTextBoxColumn.DataPropertyName = "Telex";
            this.telexDataGridViewTextBoxColumn.HeaderText = "Telex";
            this.telexDataGridViewTextBoxColumn.Name = "telexDataGridViewTextBoxColumn";
            this.telexDataGridViewTextBoxColumn.ReadOnly = true;
            this.telexDataGridViewTextBoxColumn.Width = 58;
            // 
            // httpDataGridViewTextBoxColumn
            // 
            this.httpDataGridViewTextBoxColumn.DataPropertyName = "Http";
            this.httpDataGridViewTextBoxColumn.HeaderText = "Http";
            this.httpDataGridViewTextBoxColumn.Name = "httpDataGridViewTextBoxColumn";
            this.httpDataGridViewTextBoxColumn.ReadOnly = true;
            this.httpDataGridViewTextBoxColumn.Width = 52;
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            this.titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            this.titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            this.titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            this.titoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.titoloDataGridViewTextBoxColumn.Width = 58;
            // 
            // codConcessioneDataGridViewTextBoxColumn
            // 
            this.codConcessioneDataGridViewTextBoxColumn.DataPropertyName = "CodConcessione";
            this.codConcessioneDataGridViewTextBoxColumn.HeaderText = "CodConcessione";
            this.codConcessioneDataGridViewTextBoxColumn.Name = "codConcessioneDataGridViewTextBoxColumn";
            this.codConcessioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.codConcessioneDataGridViewTextBoxColumn.Width = 112;
            // 
            // codLinguaDataGridViewTextBoxColumn
            // 
            this.codLinguaDataGridViewTextBoxColumn.DataPropertyName = "CodLingua";
            this.codLinguaDataGridViewTextBoxColumn.HeaderText = "CodLingua";
            this.codLinguaDataGridViewTextBoxColumn.Name = "codLinguaDataGridViewTextBoxColumn";
            this.codLinguaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLinguaDataGridViewTextBoxColumn.Width = 83;
            // 
            // flCancellatoDataGridViewTextBoxColumn
            // 
            this.flCancellatoDataGridViewTextBoxColumn.DataPropertyName = "FlCancellato";
            this.flCancellatoDataGridViewTextBoxColumn.HeaderText = "FlCancellato";
            this.flCancellatoDataGridViewTextBoxColumn.Name = "flCancellatoDataGridViewTextBoxColumn";
            this.flCancellatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.flCancellatoDataGridViewTextBoxColumn.Width = 90;
            // 
            // flRiservatezzaDataGridViewTextBoxColumn
            // 
            this.flRiservatezzaDataGridViewTextBoxColumn.DataPropertyName = "FlRiservatezza";
            this.flRiservatezzaDataGridViewTextBoxColumn.HeaderText = "FlRiservatezza";
            this.flRiservatezzaDataGridViewTextBoxColumn.Name = "flRiservatezzaDataGridViewTextBoxColumn";
            this.flRiservatezzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.flRiservatezzaDataGridViewTextBoxColumn.Width = 101;
            // 
            // flCodFiscNonRegDataGridViewTextBoxColumn
            // 
            this.flCodFiscNonRegDataGridViewTextBoxColumn.DataPropertyName = "FlCodFiscNonReg";
            this.flCodFiscNonRegDataGridViewTextBoxColumn.HeaderText = "FlCodFiscNonReg";
            this.flCodFiscNonRegDataGridViewTextBoxColumn.Name = "flCodFiscNonRegDataGridViewTextBoxColumn";
            this.flCodFiscNonRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.flCodFiscNonRegDataGridViewTextBoxColumn.Width = 118;
            // 
            // dataUltModificaDataGridViewTextBoxColumn
            // 
            this.dataUltModificaDataGridViewTextBoxColumn.DataPropertyName = "DataUltModifica";
            this.dataUltModificaDataGridViewTextBoxColumn.HeaderText = "DataUltModifica";
            this.dataUltModificaDataGridViewTextBoxColumn.Name = "dataUltModificaDataGridViewTextBoxColumn";
            this.dataUltModificaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataUltModificaDataGridViewTextBoxColumn.Width = 108;
            // 
            // iDUtenteDataGridViewTextBoxColumn
            // 
            this.iDUtenteDataGridViewTextBoxColumn.DataPropertyName = "IDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.HeaderText = "IDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.Name = "iDUtenteDataGridViewTextBoxColumn";
            this.iDUtenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUtenteDataGridViewTextBoxColumn.Width = 75;
            // 
            // iDTerminaleDataGridViewTextBoxColumn
            // 
            this.iDTerminaleDataGridViewTextBoxColumn.DataPropertyName = "IDTerminale";
            this.iDTerminaleDataGridViewTextBoxColumn.HeaderText = "IDTerminale";
            this.iDTerminaleDataGridViewTextBoxColumn.Name = "iDTerminaleDataGridViewTextBoxColumn";
            this.iDTerminaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTerminaleDataGridViewTextBoxColumn.Width = 89;
            // 
            // flSoggettoEsteroDataGridViewTextBoxColumn
            // 
            this.flSoggettoEsteroDataGridViewTextBoxColumn.DataPropertyName = "FlSoggettoEstero";
            this.flSoggettoEsteroDataGridViewTextBoxColumn.HeaderText = "FlSoggettoEstero";
            this.flSoggettoEsteroDataGridViewTextBoxColumn.Name = "flSoggettoEsteroDataGridViewTextBoxColumn";
            this.flSoggettoEsteroDataGridViewTextBoxColumn.ReadOnly = true;
            this.flSoggettoEsteroDataGridViewTextBoxColumn.Width = 113;
            // 
            // dataValiditaDataGridViewTextBoxColumn
            // 
            this.dataValiditaDataGridViewTextBoxColumn.DataPropertyName = "DataValidita";
            this.dataValiditaDataGridViewTextBoxColumn.HeaderText = "DataValidita";
            this.dataValiditaDataGridViewTextBoxColumn.Name = "dataValiditaDataGridViewTextBoxColumn";
            this.dataValiditaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataValiditaDataGridViewTextBoxColumn.Width = 89;
            // 
            // codAnagraficoNewDataGridViewTextBoxColumn
            // 
            this.codAnagraficoNewDataGridViewTextBoxColumn.DataPropertyName = "CodAnagraficoNew";
            this.codAnagraficoNewDataGridViewTextBoxColumn.HeaderText = "CodAnagraficoNew";
            this.codAnagraficoNewDataGridViewTextBoxColumn.Name = "codAnagraficoNewDataGridViewTextBoxColumn";
            this.codAnagraficoNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAnagraficoNewDataGridViewTextBoxColumn.Width = 124;
            // 
            // omocodiceDataGridViewTextBoxColumn
            // 
            this.omocodiceDataGridViewTextBoxColumn.DataPropertyName = "Omocodice";
            this.omocodiceDataGridViewTextBoxColumn.HeaderText = "Omocodice";
            this.omocodiceDataGridViewTextBoxColumn.Name = "omocodiceDataGridViewTextBoxColumn";
            this.omocodiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.omocodiceDataGridViewTextBoxColumn.Width = 86;
            // 
            // flPIVAChiusaDataGridViewTextBoxColumn
            // 
            this.flPIVAChiusaDataGridViewTextBoxColumn.DataPropertyName = "FlPIVAChiusa";
            this.flPIVAChiusaDataGridViewTextBoxColumn.HeaderText = "FlPIVAChiusa";
            this.flPIVAChiusaDataGridViewTextBoxColumn.Name = "flPIVAChiusaDataGridViewTextBoxColumn";
            this.flPIVAChiusaDataGridViewTextBoxColumn.ReadOnly = true;
            this.flPIVAChiusaDataGridViewTextBoxColumn.Width = 96;
            // 
            // flAllineaIndirizziDataGridViewTextBoxColumn
            // 
            this.flAllineaIndirizziDataGridViewTextBoxColumn.DataPropertyName = "FlAllineaIndirizzi";
            this.flAllineaIndirizziDataGridViewTextBoxColumn.HeaderText = "FlAllineaIndirizzi";
            this.flAllineaIndirizziDataGridViewTextBoxColumn.Name = "flAllineaIndirizziDataGridViewTextBoxColumn";
            this.flAllineaIndirizziDataGridViewTextBoxColumn.ReadOnly = true;
            this.flAllineaIndirizziDataGridViewTextBoxColumn.Width = 105;
            // 
            // flEmailPECDataGridViewTextBoxColumn
            // 
            this.flEmailPECDataGridViewTextBoxColumn.DataPropertyName = "FlEmailPEC";
            this.flEmailPECDataGridViewTextBoxColumn.HeaderText = "FlEmailPEC";
            this.flEmailPECDataGridViewTextBoxColumn.Name = "flEmailPECDataGridViewTextBoxColumn";
            this.flEmailPECDataGridViewTextBoxColumn.ReadOnly = true;
            this.flEmailPECDataGridViewTextBoxColumn.Width = 86;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailDataGridViewTextBoxColumn.Width = 58;
            // 
            // eMailPECDataGridViewTextBoxColumn
            // 
            this.eMailPECDataGridViewTextBoxColumn.DataPropertyName = "EMailPEC";
            this.eMailPECDataGridViewTextBoxColumn.HeaderText = "EMailPEC";
            this.eMailPECDataGridViewTextBoxColumn.Name = "eMailPECDataGridViewTextBoxColumn";
            this.eMailPECDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailPECDataGridViewTextBoxColumn.Width = 79;
            // 
            // eMailPECCommDataGridViewTextBoxColumn
            // 
            this.eMailPECCommDataGridViewTextBoxColumn.DataPropertyName = "EMailPECComm";
            this.eMailPECCommDataGridViewTextBoxColumn.HeaderText = "EMailPECComm";
            this.eMailPECCommDataGridViewTextBoxColumn.Name = "eMailPECCommDataGridViewTextBoxColumn";
            this.eMailPECCommDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailPECCommDataGridViewTextBoxColumn.Width = 108;
            // 
            // pwdAllegatiEmailDataGridViewTextBoxColumn
            // 
            this.pwdAllegatiEmailDataGridViewTextBoxColumn.DataPropertyName = "PwdAllegatiEmail";
            this.pwdAllegatiEmailDataGridViewTextBoxColumn.HeaderText = "PwdAllegatiEmail";
            this.pwdAllegatiEmailDataGridViewTextBoxColumn.Name = "pwdAllegatiEmailDataGridViewTextBoxColumn";
            this.pwdAllegatiEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.pwdAllegatiEmailDataGridViewTextBoxColumn.Width = 112;
            // 
            // jLabelJLabelClientiBindingSource
            // 
            this.jLabelJLabelClientiBindingSource.DataMember = "JLabel_JLabel_Clienti";
            this.jLabelJLabelClientiBindingSource.DataSource = this.jLabelBindingSource;
            // 
            // jLabelTableAdapter
            // 
            this.jLabelTableAdapter.ClearBeforeFill = true;
            // 
            // jLabel_ClientiTableAdapter
            // 
            this.jLabel_ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // gCCustomersBindingSource
            // 
            this.gCCustomersBindingSource.DataSource = this.dB_FactoryDataSet;
            this.gCCustomersBindingSource.Position = 0;
            // 
            // gC_CustomersTableAdapter
            // 
            this.gC_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // UC_form_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ordini_Layout);
            this.Name = "UC_form_Clienti";
            this.Size = new System.Drawing.Size(1200, 1200);
            this.Load += new System.EventHandler(this.UC_form_Clienti_Load);
            this.Ordini_Layout.ResumeLayout(false);
            this.Ordini_Layout.PerformLayout();
            this.pan_SW_Titolo.ResumeLayout(false);
            this.pan_SW_Titolo.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.dg_Ordini_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            this.dg_Clienti_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelJLabelClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Ordini_Layout;
        private MetroFramework.Controls.MetroPanel pan_SW_Titolo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel dg_Ordini_Layout;
        private System.Windows.Forms.DataGridView dg_Ordini;
        private System.Windows.Forms.TableLayoutPanel dg_Clienti_Layout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOORDINECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAGIONESOCIALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROORDINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERORIGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODICEKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODICESISTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIZIONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATARICHIESTACONSEGNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACONFERMACONSEGNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREZZOUNITARIOKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREZZOUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTAORDINATAKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTAORDINATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTASPEDITAKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTASPEDITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTOKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTOEVASOKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTOEVASODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATORIGAORDINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOFTWAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jLabelBindingSource;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOrdineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOrdineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAnagraficoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partitaIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ricercaBreveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioValiditaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineValiditaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAnagraficoOldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentoStoricoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ragSocCognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ragSocNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ragSocCompletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toponimoFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCivicoFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frazioneFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComuneFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneAggiuntivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regioneFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casiPartAddRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazioneFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefissoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefissoAggiuntivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoAggiuntivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroVerdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefissoFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn httpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codConcessioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLinguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flCancellatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flRiservatezzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flCodFiscNonRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltModificaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTerminaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flSoggettoEsteroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValiditaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAnagraficoNewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omocodiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flPIVAChiusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flAllineaIndirizziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flEmailPECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailPECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailPECCommDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwdAllegatiEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jLabelJLabelClientiBindingSource;
        private DB_FactoryDataSetTableAdapters.JLabelTableAdapter jLabelTableAdapter;
        private DB_FactoryDataSetTableAdapters.JLabel_ClientiTableAdapter jLabel_ClientiTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem menu_ord_aggiorna;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div01;
        private System.Windows.Forms.ToolStripMenuItem conversionToolStripMenuItem;
        private System.Windows.Forms.BindingSource gCCustomersBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter gC_CustomersTableAdapter;
    }
}
