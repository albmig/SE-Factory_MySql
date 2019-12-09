namespace SE_Factory
{
    partial class UC_form_Produzione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_Produzione));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Produzione_Menu_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.pan_SW_Titolo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.aggiornaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gCOrdiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.gC_OrdiniTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_OrdiniTableAdapter();
            this.Produzione_Sel_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Prog_Window = new MetroFramework.Controls.MetroButton();
            this.btn_pdfview = new MetroFramework.Controls.MetroTile();
            this.image_Device = new System.Windows.Forms.PictureBox();
            this.dg_Ordini = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordIdCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordNUMEROORDINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordNUMERORIGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordCODICEKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordCODICESISTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRIZIONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordQTAORDINATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordQTAEVASADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordSOFTWAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRESTKITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRSISTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordMODELLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordSTATOORDINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_dati = new MetroFramework.Controls.MetroPanel();
            this.lab_descrest_kit = new MetroFramework.Controls.MetroLabel();
            this.lab_descr_kit = new MetroFramework.Controls.MetroLabel();
            this.lab_kit = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lab_ragsoc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_numord = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_dati_2 = new MetroFramework.Controls.MetroPanel();
            this.lab_descrest_fw = new MetroFramework.Controls.MetroLabel();
            this.lab_descr_fw = new MetroFramework.Controls.MetroLabel();
            this.lab_fw = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lab_descrest_sist = new MetroFramework.Controls.MetroLabel();
            this.lab_descr_sist = new MetroFramework.Controls.MetroLabel();
            this.lab_sist = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Produzione_Progr_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.dos_box = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.lab_modello = new MetroFramework.Controls.MetroLabel();
            this.Produzione_Menu_Layout.SuspendLayout();
            this.pan_SW_Titolo.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCOrdiniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            this.Produzione_Sel_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordini)).BeginInit();
            this.panel_dati.SuspendLayout();
            this.panel_dati_2.SuspendLayout();
            this.Produzione_Progr_Layout.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Produzione_Menu_Layout
            // 
            this.Produzione_Menu_Layout.ColumnCount = 10;
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Menu_Layout.Controls.Add(this.pan_SW_Titolo, 0, 0);
            this.Produzione_Menu_Layout.Controls.Add(this.pan_Menu_comandi, 0, 1);
            this.Produzione_Menu_Layout.Controls.Add(this.pan_Menu_salva, 6, 1);
            this.Produzione_Menu_Layout.Controls.Add(this.pan_Menu_exit, 9, 1);
            this.Produzione_Menu_Layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.Produzione_Menu_Layout.Location = new System.Drawing.Point(0, 0);
            this.Produzione_Menu_Layout.Name = "Produzione_Menu_Layout";
            this.Produzione_Menu_Layout.RowCount = 2;
            this.Produzione_Menu_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Produzione_Menu_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Produzione_Menu_Layout.Size = new System.Drawing.Size(1200, 45);
            this.Produzione_Menu_Layout.TabIndex = 1;
            // 
            // pan_SW_Titolo
            // 
            this.Produzione_Menu_Layout.SetColumnSpan(this.pan_SW_Titolo, 10);
            this.pan_SW_Titolo.Controls.Add(this.metroLabel21);
            this.pan_SW_Titolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_SW_Titolo.HorizontalScrollbarBarColor = true;
            this.pan_SW_Titolo.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.HorizontalScrollbarSize = 10;
            this.pan_SW_Titolo.Location = new System.Drawing.Point(3, 3);
            this.pan_SW_Titolo.Name = "pan_SW_Titolo";
            this.pan_SW_Titolo.Size = new System.Drawing.Size(1194, 19);
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
            this.metroLabel21.Size = new System.Drawing.Size(185, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Produzione SmartLine";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseStyleColors = true;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.Produzione_Menu_Layout.SetColumnSpan(this.pan_Menu_comandi, 6);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornaDBToolStripMenuItem});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 25);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(720, 20);
            this.pan_Menu_comandi.TabIndex = 21;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // aggiornaDBToolStripMenuItem
            // 
            this.aggiornaDBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aggiornaDBToolStripMenuItem.Image")));
            this.aggiornaDBToolStripMenuItem.Name = "aggiornaDBToolStripMenuItem";
            this.aggiornaDBToolStripMenuItem.Size = new System.Drawing.Size(102, 16);
            this.aggiornaDBToolStripMenuItem.Text = "Aggiorna DB";
            this.aggiornaDBToolStripMenuItem.Click += new System.EventHandler(this.aggiornaDBToolStripMenuItem_Click);
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.Produzione_Menu_Layout.SetColumnSpan(this.pan_Menu_salva, 3);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_salva.Location = new System.Drawing.Point(720, 25);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(360, 20);
            this.pan_Menu_salva.TabIndex = 57;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem1});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1080, 25);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(120, 20);
            this.pan_Menu_exit.TabIndex = 58;
            this.pan_Menu_exit.Text = "menuStrip1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShowShortcutKeys = false;
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 16);
            this.toolStripMenuItem5.Text = "|";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 16);
            this.toolStripMenuItem1.Text = "Uscita";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gCOrdiniBindingSource
            // 
            this.gCOrdiniBindingSource.DataMember = "GC_Ordini";
            this.gCOrdiniBindingSource.DataSource = this.dB_FactoryDataSet;
            this.gCOrdiniBindingSource.CurrentChanged += new System.EventHandler(this.gCOrdiniBindingSource_CurrentChanged);
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gC_OrdiniTableAdapter
            // 
            this.gC_OrdiniTableAdapter.ClearBeforeFill = true;
            // 
            // Produzione_Sel_Layout
            // 
            this.Produzione_Sel_Layout.ColumnCount = 10;
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Sel_Layout.Controls.Add(this.btn_Prog_Window, 9, 4);
            this.Produzione_Sel_Layout.Controls.Add(this.btn_pdfview, 0, 4);
            this.Produzione_Sel_Layout.Controls.Add(this.image_Device, 0, 1);
            this.Produzione_Sel_Layout.Controls.Add(this.dg_Ordini, 0, 0);
            this.Produzione_Sel_Layout.Controls.Add(this.panel_dati, 1, 1);
            this.Produzione_Sel_Layout.Controls.Add(this.panel_dati_2, 5, 1);
            this.Produzione_Sel_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Produzione_Sel_Layout.Location = new System.Drawing.Point(0, 45);
            this.Produzione_Sel_Layout.Name = "Produzione_Sel_Layout";
            this.Produzione_Sel_Layout.RowCount = 8;
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Produzione_Sel_Layout.Size = new System.Drawing.Size(1200, 2355);
            this.Produzione_Sel_Layout.TabIndex = 2;
            this.Produzione_Sel_Layout.Visible = false;
            // 
            // btn_Prog_Window
            // 
            this.btn_Prog_Window.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Prog_Window.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Prog_Window.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Prog_Window.BackgroundImage")));
            this.btn_Prog_Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Prog_Window.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Prog_Window.Location = new System.Drawing.Point(1083, 363);
            this.btn_Prog_Window.Name = "btn_Prog_Window";
            this.btn_Prog_Window.Size = new System.Drawing.Size(114, 23);
            this.btn_Prog_Window.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Prog_Window.TabIndex = 65;
            this.btn_Prog_Window.UseSelectable = true;
            this.btn_Prog_Window.UseStyleColors = true;
            this.btn_Prog_Window.Click += new System.EventHandler(this.btn_Prog_Window_Click);
            // 
            // btn_pdfview
            // 
            this.btn_pdfview.ActiveControl = null;
            this.btn_pdfview.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pdfview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pdfview.Location = new System.Drawing.Point(3, 353);
            this.btn_pdfview.Name = "btn_pdfview";
            this.btn_pdfview.Size = new System.Drawing.Size(114, 44);
            this.btn_pdfview.Style = MetroFramework.MetroColorStyle.White;
            this.btn_pdfview.TabIndex = 62;
            this.btn_pdfview.Text = "     PDF";
            this.btn_pdfview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pdfview.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_pdfview.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_pdfview.TileImage")));
            this.btn_pdfview.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pdfview.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_pdfview.UseCustomBackColor = true;
            this.btn_pdfview.UseCustomForeColor = true;
            this.btn_pdfview.UseSelectable = true;
            this.btn_pdfview.UseTileImage = true;
            this.btn_pdfview.Visible = false;
            this.btn_pdfview.Click += new System.EventHandler(this.btn_pdfview_Click);
            // 
            // image_Device
            // 
            this.image_Device.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.image_Device.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image_Device.Location = new System.Drawing.Point(3, 203);
            this.image_Device.Name = "image_Device";
            this.Produzione_Sel_Layout.SetRowSpan(this.image_Device, 3);
            this.image_Device.Size = new System.Drawing.Size(114, 144);
            this.image_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Device.TabIndex = 61;
            this.image_Device.TabStop = false;
            // 
            // dg_Ordini
            // 
            this.dg_Ordini.AllowUserToAddRows = false;
            this.dg_Ordini.AllowUserToDeleteRows = false;
            this.dg_Ordini.AllowUserToResizeRows = false;
            this.dg_Ordini.AutoGenerateColumns = false;
            this.dg_Ordini.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_Ordini.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Ordini.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_Ordini.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Ordini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Ordini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_Ordini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn,
            this.ordIdCliDataGridViewTextBoxColumn,
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn,
            this.ordNUMEROORDINEDataGridViewTextBoxColumn,
            this.ordNUMERORIGADataGridViewTextBoxColumn,
            this.ordCODICEKITDataGridViewTextBoxColumn,
            this.ordCODICESISTEMADataGridViewTextBoxColumn,
            this.ordDESCRIZIONEDataGridViewTextBoxColumn,
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn,
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn,
            this.ordUMDataGridViewTextBoxColumn,
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn,
            this.ordQTAORDINATADataGridViewTextBoxColumn,
            this.ordQTAEVASADataGridViewTextBoxColumn,
            this.ordSOFTWAREDataGridViewTextBoxColumn,
            this.ordDESCRKITDataGridViewTextBoxColumn,
            this.ordDESCRESTKITDataGridViewTextBoxColumn,
            this.ordDESCRSISTEMADataGridViewTextBoxColumn,
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn,
            this.ordMODELLODataGridViewTextBoxColumn,
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn,
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn,
            this.ordSTATOORDINEDataGridViewTextBoxColumn,
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn});
            this.Produzione_Sel_Layout.SetColumnSpan(this.dg_Ordini, 10);
            this.dg_Ordini.DataSource = this.gCOrdiniBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Ordini.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Ordini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Ordini.EnableHeadersVisualStyles = false;
            this.dg_Ordini.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_Ordini.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_Ordini.Location = new System.Drawing.Point(3, 3);
            this.dg_Ordini.Name = "dg_Ordini";
            this.dg_Ordini.ReadOnly = true;
            this.dg_Ordini.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Ordini.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Ordini.RowHeadersVisible = false;
            this.dg_Ordini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_Ordini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Ordini.Size = new System.Drawing.Size(1194, 194);
            this.dg_Ordini.Style = MetroFramework.MetroColorStyle.Red;
            this.dg_Ordini.TabIndex = 60;
            this.dg_Ordini.UseCustomBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordTIPOORDINECLIENTEDataGridViewTextBoxColumn
            // 
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "Ord_TIPO_ORDINE_CLIENTE";
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn.HeaderText = "Ord_TIPO_ORDINE_CLIENTE";
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn.Name = "ordTIPOORDINECLIENTEDataGridViewTextBoxColumn";
            this.ordTIPOORDINECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordIdCliDataGridViewTextBoxColumn
            // 
            this.ordIdCliDataGridViewTextBoxColumn.DataPropertyName = "Ord_Id_Cli";
            this.ordIdCliDataGridViewTextBoxColumn.HeaderText = "Ord_Id_Cli";
            this.ordIdCliDataGridViewTextBoxColumn.Name = "ordIdCliDataGridViewTextBoxColumn";
            this.ordIdCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordRAGIONESOCIALEDataGridViewTextBoxColumn
            // 
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn.DataPropertyName = "Ord_RAGIONE_SOCIALE";
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn.HeaderText = "Ord_RAGIONE_SOCIALE";
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn.Name = "ordRAGIONESOCIALEDataGridViewTextBoxColumn";
            this.ordRAGIONESOCIALEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordNUMEROORDINEDataGridViewTextBoxColumn
            // 
            this.ordNUMEROORDINEDataGridViewTextBoxColumn.DataPropertyName = "Ord_NUMERO_ORDINE";
            this.ordNUMEROORDINEDataGridViewTextBoxColumn.HeaderText = "Ord_NUMERO_ORDINE";
            this.ordNUMEROORDINEDataGridViewTextBoxColumn.Name = "ordNUMEROORDINEDataGridViewTextBoxColumn";
            this.ordNUMEROORDINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordNUMERORIGADataGridViewTextBoxColumn
            // 
            this.ordNUMERORIGADataGridViewTextBoxColumn.DataPropertyName = "Ord_NUMERO_RIGA";
            this.ordNUMERORIGADataGridViewTextBoxColumn.HeaderText = "Ord_NUMERO_RIGA";
            this.ordNUMERORIGADataGridViewTextBoxColumn.Name = "ordNUMERORIGADataGridViewTextBoxColumn";
            this.ordNUMERORIGADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordCODICEKITDataGridViewTextBoxColumn
            // 
            this.ordCODICEKITDataGridViewTextBoxColumn.DataPropertyName = "Ord_CODICE_KIT";
            this.ordCODICEKITDataGridViewTextBoxColumn.HeaderText = "Ord_CODICE_KIT";
            this.ordCODICEKITDataGridViewTextBoxColumn.Name = "ordCODICEKITDataGridViewTextBoxColumn";
            this.ordCODICEKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordCODICESISTEMADataGridViewTextBoxColumn
            // 
            this.ordCODICESISTEMADataGridViewTextBoxColumn.DataPropertyName = "Ord_CODICE_SISTEMA";
            this.ordCODICESISTEMADataGridViewTextBoxColumn.HeaderText = "Ord_CODICE_SISTEMA";
            this.ordCODICESISTEMADataGridViewTextBoxColumn.Name = "ordCODICESISTEMADataGridViewTextBoxColumn";
            this.ordCODICESISTEMADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRIZIONEDataGridViewTextBoxColumn
            // 
            this.ordDESCRIZIONEDataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCRIZIONE";
            this.ordDESCRIZIONEDataGridViewTextBoxColumn.HeaderText = "Ord_DESCRIZIONE";
            this.ordDESCRIZIONEDataGridViewTextBoxColumn.Name = "ordDESCRIZIONEDataGridViewTextBoxColumn";
            this.ordDESCRIZIONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn
            // 
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn.DataPropertyName = "Ord_DATA_RICHIESTA_CONSEGNA";
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn.HeaderText = "Ord_DATA_RICHIESTA_CONSEGNA";
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn.Name = "ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn";
            this.ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDATACONFERMACONSEGNADataGridViewTextBoxColumn
            // 
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn.DataPropertyName = "Ord_DATA_CONFERMA_CONSEGNA";
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn.HeaderText = "Ord_DATA_CONFERMA_CONSEGNA";
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn.Name = "ordDATACONFERMACONSEGNADataGridViewTextBoxColumn";
            this.ordDATACONFERMACONSEGNADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordUMDataGridViewTextBoxColumn
            // 
            this.ordUMDataGridViewTextBoxColumn.DataPropertyName = "Ord_UM";
            this.ordUMDataGridViewTextBoxColumn.HeaderText = "Ord_UM";
            this.ordUMDataGridViewTextBoxColumn.Name = "ordUMDataGridViewTextBoxColumn";
            this.ordUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordQTAORDINATAKITDataGridViewTextBoxColumn
            // 
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn.DataPropertyName = "Ord_QTA_ORDINATA_KIT";
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn.HeaderText = "Ord_QTA_ORDINATA_KIT";
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn.Name = "ordQTAORDINATAKITDataGridViewTextBoxColumn";
            this.ordQTAORDINATAKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordQTAORDINATADataGridViewTextBoxColumn
            // 
            this.ordQTAORDINATADataGridViewTextBoxColumn.DataPropertyName = "Ord_QTA_ORDINATA";
            this.ordQTAORDINATADataGridViewTextBoxColumn.HeaderText = "Ord_QTA_ORDINATA";
            this.ordQTAORDINATADataGridViewTextBoxColumn.Name = "ordQTAORDINATADataGridViewTextBoxColumn";
            this.ordQTAORDINATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordQTAEVASADataGridViewTextBoxColumn
            // 
            this.ordQTAEVASADataGridViewTextBoxColumn.DataPropertyName = "Ord_QTA_EVASA";
            this.ordQTAEVASADataGridViewTextBoxColumn.HeaderText = "Ord_QTA_EVASA";
            this.ordQTAEVASADataGridViewTextBoxColumn.Name = "ordQTAEVASADataGridViewTextBoxColumn";
            this.ordQTAEVASADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordSOFTWAREDataGridViewTextBoxColumn
            // 
            this.ordSOFTWAREDataGridViewTextBoxColumn.DataPropertyName = "Ord_SOFTWARE";
            this.ordSOFTWAREDataGridViewTextBoxColumn.HeaderText = "Ord_SOFTWARE";
            this.ordSOFTWAREDataGridViewTextBoxColumn.Name = "ordSOFTWAREDataGridViewTextBoxColumn";
            this.ordSOFTWAREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRKITDataGridViewTextBoxColumn
            // 
            this.ordDESCRKITDataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCR_KIT";
            this.ordDESCRKITDataGridViewTextBoxColumn.HeaderText = "Ord_DESCR_KIT";
            this.ordDESCRKITDataGridViewTextBoxColumn.Name = "ordDESCRKITDataGridViewTextBoxColumn";
            this.ordDESCRKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRESTKITDataGridViewTextBoxColumn
            // 
            this.ordDESCRESTKITDataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCREST_KIT";
            this.ordDESCRESTKITDataGridViewTextBoxColumn.HeaderText = "Ord_DESCREST_KIT";
            this.ordDESCRESTKITDataGridViewTextBoxColumn.Name = "ordDESCRESTKITDataGridViewTextBoxColumn";
            this.ordDESCRESTKITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRSISTEMADataGridViewTextBoxColumn
            // 
            this.ordDESCRSISTEMADataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCR_SISTEMA";
            this.ordDESCRSISTEMADataGridViewTextBoxColumn.HeaderText = "Ord_DESCR_SISTEMA";
            this.ordDESCRSISTEMADataGridViewTextBoxColumn.Name = "ordDESCRSISTEMADataGridViewTextBoxColumn";
            this.ordDESCRSISTEMADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRESTSISTEMADataGridViewTextBoxColumn
            // 
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCREST_SISTEMA";
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn.HeaderText = "Ord_DESCREST_SISTEMA";
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn.Name = "ordDESCRESTSISTEMADataGridViewTextBoxColumn";
            this.ordDESCRESTSISTEMADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordMODELLODataGridViewTextBoxColumn
            // 
            this.ordMODELLODataGridViewTextBoxColumn.DataPropertyName = "Ord_MODELLO";
            this.ordMODELLODataGridViewTextBoxColumn.HeaderText = "Ord_MODELLO";
            this.ordMODELLODataGridViewTextBoxColumn.Name = "ordMODELLODataGridViewTextBoxColumn";
            this.ordMODELLODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRSOFTWAREDataGridViewTextBoxColumn
            // 
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCR_SOFTWARE";
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn.HeaderText = "Ord_DESCR_SOFTWARE";
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn.Name = "ordDESCRSOFTWAREDataGridViewTextBoxColumn";
            this.ordDESCRSOFTWAREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordDESCRESTSOFTWAREDataGridViewTextBoxColumn
            // 
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn.DataPropertyName = "Ord_DESCREST_SOFTWARE";
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn.HeaderText = "Ord_DESCREST_SOFTWARE";
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn.Name = "ordDESCRESTSOFTWAREDataGridViewTextBoxColumn";
            this.ordDESCRESTSOFTWAREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordSTATOORDINEDataGridViewTextBoxColumn
            // 
            this.ordSTATOORDINEDataGridViewTextBoxColumn.DataPropertyName = "Ord_STATO_ORDINE";
            this.ordSTATOORDINEDataGridViewTextBoxColumn.HeaderText = "Ord_STATO_ORDINE";
            this.ordSTATOORDINEDataGridViewTextBoxColumn.Name = "ordSTATOORDINEDataGridViewTextBoxColumn";
            this.ordSTATOORDINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn
            // 
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn.DataPropertyName = "Ord_PROG_PROGRAMMAZIONI";
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn.HeaderText = "Ord_PROG_PROGRAMMAZIONI";
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn.Name = "ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn";
            this.ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel_dati
            // 
            this.Produzione_Sel_Layout.SetColumnSpan(this.panel_dati, 4);
            this.panel_dati.Controls.Add(this.lab_descrest_kit);
            this.panel_dati.Controls.Add(this.lab_descr_kit);
            this.panel_dati.Controls.Add(this.lab_kit);
            this.panel_dati.Controls.Add(this.metroLabel3);
            this.panel_dati.Controls.Add(this.lab_ragsoc);
            this.panel_dati.Controls.Add(this.metroLabel2);
            this.panel_dati.Controls.Add(this.lab_numord);
            this.panel_dati.Controls.Add(this.metroLabel1);
            this.panel_dati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dati.HorizontalScrollbarBarColor = true;
            this.panel_dati.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_dati.HorizontalScrollbarSize = 10;
            this.panel_dati.Location = new System.Drawing.Point(123, 203);
            this.panel_dati.Name = "panel_dati";
            this.Produzione_Sel_Layout.SetRowSpan(this.panel_dati, 4);
            this.panel_dati.Size = new System.Drawing.Size(474, 194);
            this.panel_dati.TabIndex = 63;
            this.panel_dati.VerticalScrollbarBarColor = true;
            this.panel_dati.VerticalScrollbarHighlightOnWheel = false;
            this.panel_dati.VerticalScrollbarSize = 10;
            this.panel_dati.Visible = false;
            // 
            // lab_descrest_kit
            // 
            this.lab_descrest_kit.AutoSize = true;
            this.lab_descrest_kit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descrest_kit.Location = new System.Drawing.Point(115, 130);
            this.lab_descrest_kit.Name = "lab_descrest_kit";
            this.lab_descrest_kit.Size = new System.Drawing.Size(114, 19);
            this.lab_descrest_kit.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_descrest_kit.TabIndex = 9;
            this.lab_descrest_kit.Text = "lab_descrest_kit";
            this.lab_descrest_kit.UseStyleColors = true;
            // 
            // lab_descr_kit
            // 
            this.lab_descr_kit.AutoSize = true;
            this.lab_descr_kit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descr_kit.Location = new System.Drawing.Point(115, 111);
            this.lab_descr_kit.Name = "lab_descr_kit";
            this.lab_descr_kit.Size = new System.Drawing.Size(95, 19);
            this.lab_descr_kit.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_descr_kit.TabIndex = 8;
            this.lab_descr_kit.Text = "lab_descr_kit";
            this.lab_descr_kit.UseStyleColors = true;
            // 
            // lab_kit
            // 
            this.lab_kit.AutoSize = true;
            this.lab_kit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_kit.Location = new System.Drawing.Point(115, 92);
            this.lab_kit.Name = "lab_kit";
            this.lab_kit.Size = new System.Drawing.Size(53, 19);
            this.lab_kit.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_kit.TabIndex = 7;
            this.lab_kit.Text = "lab_kit";
            this.lab_kit.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Codice KIT:";
            // 
            // lab_ragsoc
            // 
            this.lab_ragsoc.AutoSize = true;
            this.lab_ragsoc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_ragsoc.Location = new System.Drawing.Point(115, 23);
            this.lab_ragsoc.Name = "lab_ragsoc";
            this.lab_ragsoc.Size = new System.Drawing.Size(73, 19);
            this.lab_ragsoc.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_ragsoc.TabIndex = 5;
            this.lab_ragsoc.Text = "lab_ragsoc";
            this.lab_ragsoc.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Ragione Sociale:";
            // 
            // lab_numord
            // 
            this.lab_numord.AutoSize = true;
            this.lab_numord.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_numord.Location = new System.Drawing.Point(115, 4);
            this.lab_numord.Name = "lab_numord";
            this.lab_numord.Size = new System.Drawing.Size(82, 19);
            this.lab_numord.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_numord.TabIndex = 3;
            this.lab_numord.Text = "lab_numord";
            this.lab_numord.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ordine a cliente:";
            // 
            // panel_dati_2
            // 
            this.Produzione_Sel_Layout.SetColumnSpan(this.panel_dati_2, 4);
            this.panel_dati_2.Controls.Add(this.lab_modello);
            this.panel_dati_2.Controls.Add(this.metroLabel23);
            this.panel_dati_2.Controls.Add(this.lab_descrest_fw);
            this.panel_dati_2.Controls.Add(this.lab_descr_fw);
            this.panel_dati_2.Controls.Add(this.lab_fw);
            this.panel_dati_2.Controls.Add(this.metroLabel8);
            this.panel_dati_2.Controls.Add(this.lab_descrest_sist);
            this.panel_dati_2.Controls.Add(this.lab_descr_sist);
            this.panel_dati_2.Controls.Add(this.lab_sist);
            this.panel_dati_2.Controls.Add(this.metroLabel7);
            this.panel_dati_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dati_2.HorizontalScrollbarBarColor = true;
            this.panel_dati_2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_dati_2.HorizontalScrollbarSize = 10;
            this.panel_dati_2.Location = new System.Drawing.Point(603, 203);
            this.panel_dati_2.Name = "panel_dati_2";
            this.Produzione_Sel_Layout.SetRowSpan(this.panel_dati_2, 4);
            this.panel_dati_2.Size = new System.Drawing.Size(474, 194);
            this.panel_dati_2.TabIndex = 64;
            this.panel_dati_2.VerticalScrollbarBarColor = true;
            this.panel_dati_2.VerticalScrollbarHighlightOnWheel = false;
            this.panel_dati_2.VerticalScrollbarSize = 10;
            this.panel_dati_2.Visible = false;
            // 
            // lab_descrest_fw
            // 
            this.lab_descrest_fw.AutoSize = true;
            this.lab_descrest_fw.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descrest_fw.Location = new System.Drawing.Point(115, 130);
            this.lab_descrest_fw.Name = "lab_descrest_fw";
            this.lab_descrest_fw.Size = new System.Drawing.Size(113, 19);
            this.lab_descrest_fw.Style = MetroFramework.MetroColorStyle.Orange;
            this.lab_descrest_fw.TabIndex = 17;
            this.lab_descrest_fw.Text = "lab_descrest_fw";
            this.lab_descrest_fw.UseStyleColors = true;
            // 
            // lab_descr_fw
            // 
            this.lab_descr_fw.AutoSize = true;
            this.lab_descr_fw.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descr_fw.Location = new System.Drawing.Point(115, 111);
            this.lab_descr_fw.Name = "lab_descr_fw";
            this.lab_descr_fw.Size = new System.Drawing.Size(94, 19);
            this.lab_descr_fw.Style = MetroFramework.MetroColorStyle.Orange;
            this.lab_descr_fw.TabIndex = 16;
            this.lab_descr_fw.Text = "lab_descr_fw";
            this.lab_descr_fw.UseStyleColors = true;
            // 
            // lab_fw
            // 
            this.lab_fw.AutoSize = true;
            this.lab_fw.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_fw.Location = new System.Drawing.Point(115, 92);
            this.lab_fw.Name = "lab_fw";
            this.lab_fw.Size = new System.Drawing.Size(52, 19);
            this.lab_fw.Style = MetroFramework.MetroColorStyle.Orange;
            this.lab_fw.TabIndex = 15;
            this.lab_fw.Text = "lab_fw";
            this.lab_fw.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 92);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Firmware:";
            // 
            // lab_descrest_sist
            // 
            this.lab_descrest_sist.AutoSize = true;
            this.lab_descrest_sist.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descrest_sist.Location = new System.Drawing.Point(115, 42);
            this.lab_descrest_sist.Name = "lab_descrest_sist";
            this.lab_descrest_sist.Size = new System.Drawing.Size(118, 19);
            this.lab_descrest_sist.Style = MetroFramework.MetroColorStyle.Blue;
            this.lab_descrest_sist.TabIndex = 13;
            this.lab_descrest_sist.Text = "lab_descrest_sist";
            this.lab_descrest_sist.UseStyleColors = true;
            // 
            // lab_descr_sist
            // 
            this.lab_descr_sist.AutoSize = true;
            this.lab_descr_sist.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_descr_sist.Location = new System.Drawing.Point(115, 23);
            this.lab_descr_sist.Name = "lab_descr_sist";
            this.lab_descr_sist.Size = new System.Drawing.Size(99, 19);
            this.lab_descr_sist.Style = MetroFramework.MetroColorStyle.Blue;
            this.lab_descr_sist.TabIndex = 12;
            this.lab_descr_sist.Text = "lab_descr_sist";
            this.lab_descr_sist.UseStyleColors = true;
            // 
            // lab_sist
            // 
            this.lab_sist.AutoSize = true;
            this.lab_sist.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_sist.Location = new System.Drawing.Point(115, 4);
            this.lab_sist.Name = "lab_sist";
            this.lab_sist.Size = new System.Drawing.Size(57, 19);
            this.lab_sist.Style = MetroFramework.MetroColorStyle.Blue;
            this.lab_sist.TabIndex = 11;
            this.lab_sist.Text = "lab_sist";
            this.lab_sist.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 4);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(102, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Codice Sistema:";
            // 
            // Produzione_Progr_Layout
            // 
            this.Produzione_Progr_Layout.BackColor = System.Drawing.SystemColors.Control;
            this.Produzione_Progr_Layout.ColumnCount = 10;
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Produzione_Progr_Layout.Controls.Add(this.dos_box, 5, 0);
            this.Produzione_Progr_Layout.Controls.Add(this.metroButton1, 4, 0);
            this.Produzione_Progr_Layout.Controls.Add(this.metroPanel1, 0, 0);
            this.Produzione_Progr_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Produzione_Progr_Layout.Location = new System.Drawing.Point(0, 45);
            this.Produzione_Progr_Layout.Name = "Produzione_Progr_Layout";
            this.Produzione_Progr_Layout.RowCount = 10;
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Produzione_Progr_Layout.Size = new System.Drawing.Size(1200, 2355);
            this.Produzione_Progr_Layout.TabIndex = 3;
            this.Produzione_Progr_Layout.Visible = false;
            // 
            // dos_box
            // 
            this.dos_box.BackColor = System.Drawing.Color.Black;
            this.Produzione_Progr_Layout.SetColumnSpan(this.dos_box, 5);
            this.dos_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dos_box.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dos_box.Location = new System.Drawing.Point(603, 3);
            this.dos_box.Multiline = true;
            this.dos_box.Name = "dos_box";
            this.Produzione_Progr_Layout.SetRowSpan(this.dos_box, 10);
            this.dos_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dos_box.Size = new System.Drawing.Size(594, 2349);
            this.dos_box.TabIndex = 67;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroButton1.BackColor = System.Drawing.Color.LightGreen;
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(483, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 66;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.Produzione_Progr_Layout.SetColumnSpan(this.metroPanel1, 4);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.metroLabel18);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.metroLabel20);
            this.metroPanel1.Controls.Add(this.metroLabel22);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.Produzione_Progr_Layout.SetRowSpan(this.metroPanel1, 10);
            this.metroPanel1.Size = new System.Drawing.Size(474, 2349);
            this.metroPanel1.TabIndex = 68;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(114, 301);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(102, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel14.TabIndex = 25;
            this.metroLabel14.Text = "metroLabel14";
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(114, 282);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(102, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel15.TabIndex = 24;
            this.metroLabel15.Text = "metroLabel15";
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(114, 263);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(102, 19);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel16.TabIndex = 23;
            this.metroLabel16.Text = "metroLabel16";
            this.metroLabel16.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 263);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(67, 19);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel17.TabIndex = 22;
            this.metroLabel17.Text = "Firmware:";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(114, 213);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(102, 19);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel18.TabIndex = 21;
            this.metroLabel18.Text = "metroLabel18";
            this.metroLabel18.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(114, 194);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(102, 19);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel19.TabIndex = 20;
            this.metroLabel19.Text = "metroLabel19";
            this.metroLabel19.UseStyleColors = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(114, 175);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(102, 19);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel20.TabIndex = 19;
            this.metroLabel20.Text = "metroLabel20";
            this.metroLabel20.UseStyleColors = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(3, 175);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(102, 19);
            this.metroLabel22.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel22.TabIndex = 18;
            this.metroLabel22.Text = "Codice Sistema:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(114, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "metroLabel4";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(114, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "metroLabel5";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(114, 92);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "metroLabel6";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 92);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Codice KIT:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(114, 23);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(94, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "metroLabel10";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 23);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(105, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Ragione Sociale:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(114, 4);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(94, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel12.TabIndex = 11;
            this.metroLabel12.Text = "metroLabel12";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 4);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(105, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "Ordine a cliente:";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(284, 4);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(61, 19);
            this.metroLabel23.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel23.TabIndex = 18;
            this.metroLabel23.Text = "Modello:";
            // 
            // lab_modello
            // 
            this.lab_modello.AutoSize = true;
            this.lab_modello.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_modello.Location = new System.Drawing.Point(351, 4);
            this.lab_modello.Name = "lab_modello";
            this.lab_modello.Size = new System.Drawing.Size(102, 19);
            this.lab_modello.Style = MetroFramework.MetroColorStyle.Blue;
            this.lab_modello.TabIndex = 19;
            this.lab_modello.Text = "metroLabel24";
            this.lab_modello.UseStyleColors = true;
            // 
            // UC_form_Produzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Produzione_Sel_Layout);
            this.Controls.Add(this.Produzione_Progr_Layout);
            this.Controls.Add(this.Produzione_Menu_Layout);
            this.Name = "UC_form_Produzione";
            this.Size = new System.Drawing.Size(1200, 2400);
            this.Load += new System.EventHandler(this.UC_form_Produzione_Load);
            this.Produzione_Menu_Layout.ResumeLayout(false);
            this.Produzione_Menu_Layout.PerformLayout();
            this.pan_SW_Titolo.ResumeLayout(false);
            this.pan_SW_Titolo.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCOrdiniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            this.Produzione_Sel_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Ordini)).EndInit();
            this.panel_dati.ResumeLayout(false);
            this.panel_dati.PerformLayout();
            this.panel_dati_2.ResumeLayout(false);
            this.panel_dati_2.PerformLayout();
            this.Produzione_Progr_Layout.ResumeLayout(false);
            this.Produzione_Progr_Layout.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Produzione_Menu_Layout;
        private MetroFramework.Controls.MetroPanel pan_SW_Titolo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.BindingSource gCOrdiniBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_OrdiniTableAdapter gC_OrdiniTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel Produzione_Sel_Layout;
        private MetroFramework.Controls.MetroGrid dg_Ordini;
        private System.Windows.Forms.TableLayoutPanel Produzione_Progr_Layout;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordTIPOORDINECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordIdCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordRAGIONESOCIALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNUMEROORDINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNUMERORIGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordCODICEKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordCODICESISTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRIZIONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDATACONFERMACONSEGNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordQTAORDINATAKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordQTAORDINATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordQTAEVASADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordSOFTWAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRESTKITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRSISTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRESTSISTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordMODELLODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRSOFTWAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDESCRESTSOFTWAREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordSTATOORDINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox image_Device;
        private MetroFramework.Controls.MetroTile btn_pdfview;
        private MetroFramework.Controls.MetroPanel panel_dati;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lab_numord;
        private MetroFramework.Controls.MetroLabel lab_ragsoc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lab_kit;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lab_descr_kit;
        private MetroFramework.Controls.MetroLabel lab_descrest_kit;
        private MetroFramework.Controls.MetroPanel panel_dati_2;
        private MetroFramework.Controls.MetroLabel lab_descrest_sist;
        private MetroFramework.Controls.MetroLabel lab_descr_sist;
        private MetroFramework.Controls.MetroLabel lab_sist;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lab_descrest_fw;
        private MetroFramework.Controls.MetroLabel lab_descr_fw;
        private MetroFramework.Controls.MetroLabel lab_fw;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ToolStripMenuItem aggiornaDBToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_Prog_Window;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox dos_box;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel lab_modello;
        private MetroFramework.Controls.MetroLabel metroLabel23;
    }
}
