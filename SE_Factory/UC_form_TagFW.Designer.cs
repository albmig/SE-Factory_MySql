namespace SE_Factory
{
    partial class UC_form_TagFW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_TagFW));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_sw_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_SW_Titolo = new MetroFramework.Controls.MetroPanel();
            this.titolo_ID = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Tag_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Tag_Lab_field_des_FW = new MetroFramework.Controls.MetroLabel();
            this.Tag_lab_FW_Orig = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Tag_lab_Cliente = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.gCCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dg_CustomerFW = new MetroFramework.Controls.MetroGrid();
            this.dg_CustomerFW_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_CustomerFW_IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_CustomerFW_Id_CustomerFW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_CustomerFW_DisplayTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCCustomersFWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gC_CustomersFWTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_CustomersFWTableAdapter();
            this.gC_CustomersTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter();
            this.gCSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gC_SoftwareTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.GC_SoftwareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.pan_SW_Titolo.SuspendLayout();
            this.Tag_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CustomerFW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersFWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSoftwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.Tag_Layout.SetColumnSpan(this.pan_Menu_salva, 18);
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_salva,
            this.menu_sw_div12,
            this.menu_sw_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(0, 25);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(1224, 20);
            this.pan_Menu_salva.TabIndex = 55;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // menu_sw_salva
            // 
            this.menu_sw_salva.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_salva.Image")));
            this.menu_sw_salva.Name = "menu_sw_salva";
            this.menu_sw_salva.Size = new System.Drawing.Size(62, 16);
            this.menu_sw_salva.Text = "Salva";
            this.menu_sw_salva.Click += new System.EventHandler(this.menu_sw_salva_Click);
            // 
            // menu_sw_div12
            // 
            this.menu_sw_div12.Enabled = false;
            this.menu_sw_div12.Name = "menu_sw_div12";
            this.menu_sw_div12.ShowShortcutKeys = false;
            this.menu_sw_div12.Size = new System.Drawing.Size(22, 16);
            this.menu_sw_div12.Text = "|";
            // 
            // menu_sw_annulla
            // 
            this.menu_sw_annulla.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_annulla.Image")));
            this.menu_sw_annulla.Name = "menu_sw_annulla";
            this.menu_sw_annulla.Size = new System.Drawing.Size(76, 16);
            this.menu_sw_annulla.Text = "Annulla";
            this.menu_sw_annulla.Click += new System.EventHandler(this.menu_sw_annulla_Click);
            // 
            // menu_sw_exit
            // 
            this.menu_sw_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_exit.Image")));
            this.menu_sw_exit.Name = "menu_sw_exit";
            this.menu_sw_exit.Size = new System.Drawing.Size(67, 16);
            this.menu_sw_exit.Text = "Uscita";
            this.menu_sw_exit.Click += new System.EventHandler(this.menu_sw_exit_Click);
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.Tag_Layout.SetColumnSpan(this.pan_Menu_exit, 2);
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1224, 25);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(142, 20);
            this.pan_Menu_exit.TabIndex = 19;
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
            // pan_SW_Titolo
            // 
            this.Tag_Layout.SetColumnSpan(this.pan_SW_Titolo, 20);
            this.pan_SW_Titolo.Controls.Add(this.titolo_ID);
            this.pan_SW_Titolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_SW_Titolo.HorizontalScrollbarBarColor = true;
            this.pan_SW_Titolo.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.HorizontalScrollbarSize = 10;
            this.pan_SW_Titolo.Location = new System.Drawing.Point(3, 3);
            this.pan_SW_Titolo.Name = "pan_SW_Titolo";
            this.pan_SW_Titolo.Size = new System.Drawing.Size(1360, 19);
            this.pan_SW_Titolo.TabIndex = 18;
            this.pan_SW_Titolo.UseCustomBackColor = true;
            this.pan_SW_Titolo.VerticalScrollbarBarColor = true;
            this.pan_SW_Titolo.VerticalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.VerticalScrollbarSize = 10;
            // 
            // titolo_ID
            // 
            this.titolo_ID.AutoSize = true;
            this.titolo_ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titolo_ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.titolo_ID.Location = new System.Drawing.Point(0, 0);
            this.titolo_ID.Name = "titolo_ID";
            this.titolo_ID.Size = new System.Drawing.Size(219, 25);
            this.titolo_ID.Style = MetroFramework.MetroColorStyle.Red;
            this.titolo_ID.TabIndex = 2;
            this.titolo_ID.Text = "Modifica Tag del Firmware";
            this.titolo_ID.UseCustomBackColor = true;
            this.titolo_ID.UseStyleColors = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // Tag_Layout
            // 
            this.Tag_Layout.ColumnCount = 20;
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Tag_Layout.Controls.Add(this.Tag_Lab_field_des_FW, 3, 3);
            this.Tag_Layout.Controls.Add(this.Tag_lab_FW_Orig, 0, 3);
            this.Tag_Layout.Controls.Add(this.metroLabel2, 14, 2);
            this.Tag_Layout.Controls.Add(this.Tag_lab_Cliente, 0, 2);
            this.Tag_Layout.Controls.Add(this.pan_SW_Titolo, 0, 0);
            this.Tag_Layout.Controls.Add(this.pan_Menu_salva, 0, 1);
            this.Tag_Layout.Controls.Add(this.pan_Menu_exit, 18, 1);
            this.Tag_Layout.Controls.Add(this.metroComboBox1, 3, 2);
            this.Tag_Layout.Controls.Add(this.metroLabel1, 13, 2);
            this.Tag_Layout.Controls.Add(this.dg_CustomerFW, 0, 4);
            this.Tag_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tag_Layout.Location = new System.Drawing.Point(0, 0);
            this.Tag_Layout.Name = "Tag_Layout";
            this.Tag_Layout.RowCount = 5;
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tag_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tag_Layout.Size = new System.Drawing.Size(1366, 768);
            this.Tag_Layout.TabIndex = 17;
            // 
            // Tag_Lab_field_des_FW
            // 
            this.Tag_Lab_field_des_FW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tag_Lab_field_des_FW.AutoSize = true;
            this.Tag_Layout.SetColumnSpan(this.Tag_Lab_field_des_FW, 3);
            this.Tag_Lab_field_des_FW.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Tag_Lab_field_des_FW.ForeColor = System.Drawing.Color.Red;
            this.Tag_Lab_field_des_FW.Location = new System.Drawing.Point(207, 73);
            this.Tag_Lab_field_des_FW.Name = "Tag_Lab_field_des_FW";
            this.Tag_Lab_field_des_FW.Size = new System.Drawing.Size(12, 19);
            this.Tag_Lab_field_des_FW.TabIndex = 63;
            this.Tag_Lab_field_des_FW.Text = ".";
            this.Tag_Lab_field_des_FW.UseCustomBackColor = true;
            this.Tag_Lab_field_des_FW.UseCustomForeColor = true;
            // 
            // Tag_lab_FW_Orig
            // 
            this.Tag_lab_FW_Orig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tag_lab_FW_Orig.AutoSize = true;
            this.Tag_Layout.SetColumnSpan(this.Tag_lab_FW_Orig, 3);
            this.Tag_lab_FW_Orig.Location = new System.Drawing.Point(3, 73);
            this.Tag_lab_FW_Orig.Name = "Tag_lab_FW_Orig";
            this.Tag_lab_FW_Orig.Size = new System.Drawing.Size(192, 19);
            this.Tag_lab_FW_Orig.TabIndex = 62;
            this.Tag_lab_FW_Orig.Text = "Descrizione Firmware originale:";
            this.Tag_lab_FW_Orig.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.Tag_Layout.SetColumnSpan(this.metroLabel2, 4);
            this.metroLabel2.Location = new System.Drawing.Point(955, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // Tag_lab_Cliente
            // 
            this.Tag_lab_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tag_lab_Cliente.AutoSize = true;
            this.Tag_Layout.SetColumnSpan(this.Tag_lab_Cliente, 3);
            this.Tag_lab_Cliente.Location = new System.Drawing.Point(3, 48);
            this.Tag_lab_Cliente.Name = "Tag_lab_Cliente";
            this.Tag_lab_Cliente.Size = new System.Drawing.Size(52, 19);
            this.Tag_lab_Cliente.TabIndex = 57;
            this.Tag_lab_Cliente.Text = "Cliente:";
            this.Tag_lab_Cliente.UseCustomBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroComboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.Tag_Layout.SetColumnSpan(this.metroComboBox1, 10);
            this.metroComboBox1.DataSource = this.gCCustomersBindingSource;
            this.metroComboBox1.DisplayMember = "Cli_RagSoc";
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(207, 48);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(674, 25);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroComboBox1.TabIndex = 58;
            this.metroComboBox1.UseSelectable = true;
            // 
            // gCCustomersBindingSource
            // 
            this.gCCustomersBindingSource.DataMember = "GC_Customers";
            this.gCCustomersBindingSource.DataSource = this.dB_FactoryDataSet;
            this.gCCustomersBindingSource.CurrentChanged += new System.EventHandler(this.gCCustomersBindingSource_CurrentChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(887, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // dg_CustomerFW
            // 
            this.dg_CustomerFW.AllowUserToAddRows = false;
            this.dg_CustomerFW.AllowUserToDeleteRows = false;
            this.dg_CustomerFW.AllowUserToResizeRows = false;
            this.dg_CustomerFW.AutoGenerateColumns = false;
            this.dg_CustomerFW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_CustomerFW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_CustomerFW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_CustomerFW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_CustomerFW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_CustomerFW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CustomerFW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_CustomerFW_Id,
            this.dg_CustomerFW_IdCustomer,
            this.dg_CustomerFW_Id_CustomerFW,
            this.dg_CustomerFW_DisplayTitle});
            this.Tag_Layout.SetColumnSpan(this.dg_CustomerFW, 20);
            this.dg_CustomerFW.DataSource = this.gCCustomersFWBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_CustomerFW.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_CustomerFW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_CustomerFW.EnableHeadersVisualStyles = false;
            this.dg_CustomerFW.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_CustomerFW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_CustomerFW.Location = new System.Drawing.Point(3, 98);
            this.dg_CustomerFW.Name = "dg_CustomerFW";
            this.dg_CustomerFW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_CustomerFW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_CustomerFW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_CustomerFW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_CustomerFW.Size = new System.Drawing.Size(1360, 692);
            this.dg_CustomerFW.Style = MetroFramework.MetroColorStyle.Red;
            this.dg_CustomerFW.TabIndex = 60;
            // 
            // dg_CustomerFW_Id
            // 
            this.dg_CustomerFW_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dg_CustomerFW_Id.DataPropertyName = "Id";
            this.dg_CustomerFW_Id.HeaderText = "Id";
            this.dg_CustomerFW_Id.Name = "dg_CustomerFW_Id";
            this.dg_CustomerFW_Id.Width = 40;
            // 
            // dg_CustomerFW_IdCustomer
            // 
            this.dg_CustomerFW_IdCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dg_CustomerFW_IdCustomer.DataPropertyName = "CFW_IdCustomer";
            this.dg_CustomerFW_IdCustomer.HeaderText = "CFW_IdCustomer";
            this.dg_CustomerFW_IdCustomer.Name = "dg_CustomerFW_IdCustomer";
            this.dg_CustomerFW_IdCustomer.Width = 118;
            // 
            // dg_CustomerFW_Id_CustomerFW
            // 
            this.dg_CustomerFW_Id_CustomerFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dg_CustomerFW_Id_CustomerFW.DataPropertyName = "CFW_SW_Code";
            this.dg_CustomerFW_Id_CustomerFW.HeaderText = "CFW_SW_Code";
            this.dg_CustomerFW_Id_CustomerFW.Name = "dg_CustomerFW_Id_CustomerFW";
            this.dg_CustomerFW_Id_CustomerFW.Width = 108;
            // 
            // dg_CustomerFW_DisplayTitle
            // 
            this.dg_CustomerFW_DisplayTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dg_CustomerFW_DisplayTitle.DataPropertyName = "CFW_DisplayTitle";
            this.dg_CustomerFW_DisplayTitle.HeaderText = "CFW_DisplayTitle";
            this.dg_CustomerFW_DisplayTitle.Name = "dg_CustomerFW_DisplayTitle";
            this.dg_CustomerFW_DisplayTitle.Width = 117;
            // 
            // gCCustomersFWBindingSource
            // 
            this.gCCustomersFWBindingSource.AllowNew = false;
            this.gCCustomersFWBindingSource.DataMember = "GC_CustomersFW";
            this.gCCustomersFWBindingSource.DataSource = this.dB_FactoryDataSet;
            this.gCCustomersFWBindingSource.CurrentChanged += new System.EventHandler(this.gCCustomersFWBindingSource_CurrentChanged);
            // 
            // gC_CustomersFWTableAdapter
            // 
            this.gC_CustomersFWTableAdapter.ClearBeforeFill = true;
            // 
            // gC_CustomersTableAdapter
            // 
            this.gC_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // gCSoftwareBindingSource
            // 
            this.gCSoftwareBindingSource.DataMember = "GC_Software";
            this.gCSoftwareBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // gC_SoftwareTableAdapter
            // 
            this.gC_SoftwareTableAdapter.ClearBeforeFill = true;
            // 
            // UC_form_TagFW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tag_Layout);
            this.Name = "UC_form_TagFW";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.UC_form_TagFW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.pan_SW_Titolo.ResumeLayout(false);
            this.pan_SW_Titolo.PerformLayout();
            this.Tag_Layout.ResumeLayout(false);
            this.Tag_Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CustomerFW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCCustomersFWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSoftwareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.TableLayoutPanel Tag_Layout;
        private MetroFramework.Controls.MetroPanel pan_SW_Titolo;
        private MetroFramework.Controls.MetroLabel titolo_ID;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_annulla;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.BindingSource gCCustomersFWBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_CustomersFWTableAdapter gC_CustomersFWTableAdapter;
        private MetroFramework.Controls.MetroLabel Tag_lab_Cliente;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource gCCustomersBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_CustomersTableAdapter gC_CustomersTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dg_CustomerFW;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_CustomerFW_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_CustomerFW_IdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_CustomerFW_Id_CustomerFW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_CustomerFW_DisplayTitle;
        private MetroFramework.Controls.MetroLabel Tag_lab_FW_Orig;
        private MetroFramework.Controls.MetroLabel Tag_Lab_field_des_FW;
        private System.Windows.Forms.BindingSource gCSoftwareBindingSource;
        private DB_FactoryDataSetTableAdapters.GC_SoftwareTableAdapter gC_SoftwareTableAdapter;
    }
}
