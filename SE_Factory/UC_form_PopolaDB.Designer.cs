namespace SE_Factory
{
    partial class UC_form_PopolaDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_PopolaDB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Popola_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.pan_SW_Titolo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.verificaArchiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_tile = new MetroFramework.Controls.MetroTile();
            this.lab_clienti = new MetroFramework.Controls.MetroLabel();
            this.update_Clienti = new Syncfusion.WinForms.Controls.SfButton();
            this.art_tile = new MetroFramework.Controls.MetroTile();
            this.lab_articoli = new MetroFramework.Controls.MetroLabel();
            this.update_Articoli = new Syncfusion.WinForms.Controls.SfButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devFamProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devCodiceItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devDescItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devFirmwareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devStartDateFWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devEndDateFWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.jLabelJLabelClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLabelTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.JLabelTableAdapter();
            this.jLabel_ClientiTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.JLabel_ClientiTableAdapter();
            this.gC_CustomersTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter();
            this.gCCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLabelfullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLabel_fullTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.JLabel_fullTableAdapter();
            this.gC_DevicesTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_DevicesTableAdapter();
            this.Popola_Layout.SuspendLayout();
            this.pan_SW_Titolo.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelJLabelClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelfullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Popola_Layout
            // 
            this.Popola_Layout.ColumnCount = 10;
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.09174F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.841538F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00834F));
            this.Popola_Layout.Controls.Add(this.pan_SW_Titolo, 0, 0);
            this.Popola_Layout.Controls.Add(this.pan_Menu_comandi, 0, 1);
            this.Popola_Layout.Controls.Add(this.pan_Menu_salva, 6, 1);
            this.Popola_Layout.Controls.Add(this.pan_Menu_exit, 9, 1);
            this.Popola_Layout.Controls.Add(this.cli_tile, 0, 2);
            this.Popola_Layout.Controls.Add(this.lab_clienti, 1, 2);
            this.Popola_Layout.Controls.Add(this.update_Clienti, 3, 2);
            this.Popola_Layout.Controls.Add(this.art_tile, 0, 3);
            this.Popola_Layout.Controls.Add(this.lab_articoli, 1, 3);
            this.Popola_Layout.Controls.Add(this.update_Articoli, 3, 3);
            this.Popola_Layout.Controls.Add(this.dataGridView1, 0, 4);
            this.Popola_Layout.Controls.Add(this.dataGridView2, 0, 9);
            this.Popola_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Popola_Layout.Location = new System.Drawing.Point(0, 0);
            this.Popola_Layout.Name = "Popola_Layout";
            this.Popola_Layout.RowCount = 10;
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Popola_Layout.Size = new System.Drawing.Size(1200, 1200);
            this.Popola_Layout.TabIndex = 0;
            // 
            // pan_SW_Titolo
            // 
            this.Popola_Layout.SetColumnSpan(this.pan_SW_Titolo, 10);
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
            this.metroLabel21.Size = new System.Drawing.Size(197, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Popolamento DataBase";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseStyleColors = true;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.Popola_Layout.SetColumnSpan(this.pan_Menu_comandi, 6);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificaArchiviToolStripMenuItem});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 28);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(719, 24);
            this.pan_Menu_comandi.TabIndex = 21;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // verificaArchiviToolStripMenuItem
            // 
            this.verificaArchiviToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verificaArchiviToolStripMenuItem.Image")));
            this.verificaArchiviToolStripMenuItem.Name = "verificaArchiviToolStripMenuItem";
            this.verificaArchiviToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.verificaArchiviToolStripMenuItem.Text = "Verifica Archivi";
            this.verificaArchiviToolStripMenuItem.Click += new System.EventHandler(this.verificaArchiviToolStripMenuItem_Click);
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.Popola_Layout.SetColumnSpan(this.pan_Menu_salva, 3);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_salva.Location = new System.Drawing.Point(719, 28);
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
            this.pan_Menu_exit.Location = new System.Drawing.Point(1079, 28);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(121, 24);
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
            // cli_tile
            // 
            this.cli_tile.ActiveControl = null;
            this.cli_tile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cli_tile.Enabled = false;
            this.cli_tile.Location = new System.Drawing.Point(3, 55);
            this.cli_tile.Name = "cli_tile";
            this.cli_tile.Size = new System.Drawing.Size(100, 35);
            this.cli_tile.Style = MetroFramework.MetroColorStyle.Red;
            this.cli_tile.TabIndex = 59;
            this.cli_tile.Text = "Clienti";
            this.cli_tile.UseSelectable = true;
            // 
            // lab_clienti
            // 
            this.lab_clienti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_clienti.AutoSize = true;
            this.lab_clienti.BackColor = System.Drawing.Color.Transparent;
            this.Popola_Layout.SetColumnSpan(this.lab_clienti, 2);
            this.lab_clienti.Location = new System.Drawing.Point(123, 63);
            this.lab_clienti.Name = "lab_clienti";
            this.lab_clienti.Size = new System.Drawing.Size(66, 19);
            this.lab_clienti.TabIndex = 61;
            this.lab_clienti.Text = "lab_clienti";
            // 
            // update_Clienti
            // 
            this.update_Clienti.AccessibleName = "Button";
            this.update_Clienti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.update_Clienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Popola_Layout.SetColumnSpan(this.update_Clienti, 2);
            this.update_Clienti.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.update_Clienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_Clienti.Location = new System.Drawing.Point(363, 55);
            this.update_Clienti.Name = "update_Clienti";
            this.update_Clienti.Size = new System.Drawing.Size(150, 35);
            this.update_Clienti.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.update_Clienti.TabIndex = 63;
            this.update_Clienti.Text = "Aggiorna Clienti";
            this.update_Clienti.Click += new System.EventHandler(this.update_Clienti_Click);
            // 
            // art_tile
            // 
            this.art_tile.ActiveControl = null;
            this.art_tile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.art_tile.Enabled = false;
            this.art_tile.Location = new System.Drawing.Point(3, 96);
            this.art_tile.Name = "art_tile";
            this.art_tile.Size = new System.Drawing.Size(100, 35);
            this.art_tile.Style = MetroFramework.MetroColorStyle.Red;
            this.art_tile.TabIndex = 64;
            this.art_tile.Text = "Articoli";
            this.art_tile.UseSelectable = true;
            // 
            // lab_articoli
            // 
            this.lab_articoli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_articoli.AutoSize = true;
            this.lab_articoli.BackColor = System.Drawing.Color.Transparent;
            this.Popola_Layout.SetColumnSpan(this.lab_articoli, 2);
            this.lab_articoli.Location = new System.Drawing.Point(123, 104);
            this.lab_articoli.Name = "lab_articoli";
            this.lab_articoli.Size = new System.Drawing.Size(73, 19);
            this.lab_articoli.TabIndex = 65;
            this.lab_articoli.Text = "lab_articoli";
            // 
            // update_Articoli
            // 
            this.update_Articoli.AccessibleName = "Button";
            this.update_Articoli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.update_Articoli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Popola_Layout.SetColumnSpan(this.update_Articoli, 3);
            this.update_Articoli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.update_Articoli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_Articoli.Location = new System.Drawing.Point(363, 96);
            this.update_Articoli.Name = "update_Articoli";
            this.update_Articoli.Size = new System.Drawing.Size(150, 35);
            this.update_Articoli.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.update_Articoli.TabIndex = 66;
            this.update_Articoli.Text = "Aggiorna Articoli";
            this.update_Articoli.Click += new System.EventHandler(this.update_Articoli_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Popola_Layout.SetColumnSpan(this.dataGridView1, 10);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1194, 150);
            this.dataGridView1.TabIndex = 67;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.devFamProdDataGridViewTextBoxColumn,
            this.devCodiceItemDataGridViewTextBoxColumn,
            this.devDescItemDataGridViewTextBoxColumn,
            this.devFirmwareDataGridViewTextBoxColumn,
            this.devStartDateFWDataGridViewTextBoxColumn,
            this.devEndDateFWDataGridViewTextBoxColumn});
            this.Popola_Layout.SetColumnSpan(this.dataGridView2, 10);
            this.dataGridView2.DataSource = this.gCDevicesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1194, 904);
            this.dataGridView2.TabIndex = 68;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // devFamProdDataGridViewTextBoxColumn
            // 
            this.devFamProdDataGridViewTextBoxColumn.DataPropertyName = "Dev_FamProd";
            this.devFamProdDataGridViewTextBoxColumn.HeaderText = "Dev_FamProd";
            this.devFamProdDataGridViewTextBoxColumn.Name = "devFamProdDataGridViewTextBoxColumn";
            // 
            // devCodiceItemDataGridViewTextBoxColumn
            // 
            this.devCodiceItemDataGridViewTextBoxColumn.DataPropertyName = "Dev_CodiceItem";
            this.devCodiceItemDataGridViewTextBoxColumn.HeaderText = "Dev_CodiceItem";
            this.devCodiceItemDataGridViewTextBoxColumn.Name = "devCodiceItemDataGridViewTextBoxColumn";
            // 
            // devDescItemDataGridViewTextBoxColumn
            // 
            this.devDescItemDataGridViewTextBoxColumn.DataPropertyName = "Dev_DescItem";
            this.devDescItemDataGridViewTextBoxColumn.HeaderText = "Dev_DescItem";
            this.devDescItemDataGridViewTextBoxColumn.Name = "devDescItemDataGridViewTextBoxColumn";
            // 
            // devFirmwareDataGridViewTextBoxColumn
            // 
            this.devFirmwareDataGridViewTextBoxColumn.DataPropertyName = "Dev_Firmware";
            this.devFirmwareDataGridViewTextBoxColumn.HeaderText = "Dev_Firmware";
            this.devFirmwareDataGridViewTextBoxColumn.Name = "devFirmwareDataGridViewTextBoxColumn";
            // 
            // devStartDateFWDataGridViewTextBoxColumn
            // 
            this.devStartDateFWDataGridViewTextBoxColumn.DataPropertyName = "Dev_StartDateFW";
            this.devStartDateFWDataGridViewTextBoxColumn.HeaderText = "Dev_StartDateFW";
            this.devStartDateFWDataGridViewTextBoxColumn.Name = "devStartDateFWDataGridViewTextBoxColumn";
            // 
            // devEndDateFWDataGridViewTextBoxColumn
            // 
            this.devEndDateFWDataGridViewTextBoxColumn.DataPropertyName = "Dev_EndDateFW";
            this.devEndDateFWDataGridViewTextBoxColumn.HeaderText = "Dev_EndDateFW";
            this.devEndDateFWDataGridViewTextBoxColumn.Name = "devEndDateFWDataGridViewTextBoxColumn";
            // 
            // gCDevicesBindingSource
            // 
            this.gCDevicesBindingSource.DataMember = "GC_Devices";
            this.gCDevicesBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jLabelJLabelClientiBindingSource
            // 
            this.jLabelJLabelClientiBindingSource.DataMember = "JLabel_JLabel_Clienti";
            this.jLabelJLabelClientiBindingSource.DataSource = this.jLabelBindingSource;
            // 
            // jLabelBindingSource
            // 
            this.jLabelBindingSource.DataMember = "JLabel";
            this.jLabelBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // jLabelTableAdapter
            // 
            this.jLabelTableAdapter.ClearBeforeFill = true;
            // 
            // jLabel_ClientiTableAdapter
            // 
            this.jLabel_ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // gC_CustomersTableAdapter
            // 
            this.gC_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // gCCustomersBindingSource
            // 
            this.gCCustomersBindingSource.DataSource = this.dB_FactoryDataSet;
            this.gCCustomersBindingSource.Position = 0;
            // 
            // jLabelfullBindingSource
            // 
            this.jLabelfullBindingSource.DataMember = "JLabel_full";
            this.jLabelfullBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // jLabel_fullTableAdapter
            // 
            this.jLabel_fullTableAdapter.ClearBeforeFill = true;
            // 
            // gC_DevicesTableAdapter
            // 
            this.gC_DevicesTableAdapter.ClearBeforeFill = true;
            // 
            // UC_form_PopolaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Popola_Layout);
            this.Name = "UC_form_PopolaDB";
            this.Size = new System.Drawing.Size(1200, 1200);
            this.Load += new System.EventHandler(this.UC_form_PopolaDB_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.UC_form_PopolaDB_Layout);
            this.Popola_Layout.ResumeLayout(false);
            this.Popola_Layout.PerformLayout();
            this.pan_SW_Titolo.ResumeLayout(false);
            this.pan_SW_Titolo.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelJLabelClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLabelfullBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Popola_Layout;
        private MetroFramework.Controls.MetroPanel pan_SW_Titolo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.BindingSource jLabelBindingSource;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.BindingSource jLabelJLabelClientiBindingSource;
        private DB_FactoryDataSetTableAdapters.JLabelTableAdapter jLabelTableAdapter;
        private DB_FactoryDataSetTableAdapters.JLabel_ClientiTableAdapter jLabel_ClientiTableAdapter;
        private System.Windows.Forms.BindingSource gCCustomersBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter gC_CustomersTableAdapter;
        private MetroFramework.Controls.MetroTile cli_tile;
        private MetroFramework.Controls.MetroLabel lab_clienti;
        private Syncfusion.WinForms.Controls.SfButton update_Clienti;
        private MetroFramework.Controls.MetroTile art_tile;
        private MetroFramework.Controls.MetroLabel lab_articoli;
        private Syncfusion.WinForms.Controls.SfButton update_Articoli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verificaArchiviToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource jLabelfullBindingSource;
        private DB_FactoryDataSetTableAdapters.JLabel_fullTableAdapter jLabel_fullTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devFamProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devCodiceItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devDescItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devFirmwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devStartDateFWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devEndDateFWDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gCDevicesBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_DevicesTableAdapter gC_DevicesTableAdapter;
    }
}
