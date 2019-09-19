namespace SE_Factory
{
    partial class UC_form_Spedizioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_Spedizioni));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Spedizioni_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Sped_Titolo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Browse_SN = new System.Windows.Forms.TableLayoutPanel();
            this.Sped_lab_SN = new MetroFramework.Controls.MetroLabel();
            this.tb_file_SN = new MetroFramework.Controls.MetroTextBox();
            this.pan_Browse_Folder = new System.Windows.Forms.TableLayoutPanel();
            this.Sped_lab_Folder = new MetroFramework.Controls.MetroLabel();
            this.tb_Folder_Sped = new MetroFramework.Controls.MetroTextBox();
            this.button_go_sped = new MetroFramework.Controls.MetroButton();
            this.dg_spedizioni = new System.Windows.Forms.DataGridView();
            this.fileSpedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elaboratoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spedNeohmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.dg_SN = new System.Windows.Forms.DataGridView();
            this.serialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialKitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialCommessaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNnumdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNdatadocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNconfdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xlsSerialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pan_avanzamento = new System.Windows.Forms.TableLayoutPanel();
            this.lab_doc_sist = new MetroFramework.Controls.MetroLabel();
            this.lab_data_bolla = new MetroFramework.Controls.MetroLabel();
            this.lab_riga = new MetroFramework.Controls.MetroLabel();
            this.lab_file_analizzato = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_avanzamento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Spedizioni_Layout.SuspendLayout();
            this.pan_Sped_Titolo.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.pan_Browse_SN.SuspendLayout();
            this.pan_Browse_Folder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_spedizioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spedNeohmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlsSerialsBindingSource)).BeginInit();
            this.pan_avanzamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spedizioni_Layout
            // 
            this.Spedizioni_Layout.ColumnCount = 10;
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Spedizioni_Layout.Controls.Add(this.pan_Sped_Titolo, 0, 0);
            this.Spedizioni_Layout.Controls.Add(this.pan_Menu_comandi, 0, 1);
            this.Spedizioni_Layout.Controls.Add(this.pan_Menu_salva, 6, 1);
            this.Spedizioni_Layout.Controls.Add(this.pan_Menu_exit, 9, 1);
            this.Spedizioni_Layout.Controls.Add(this.pan_Browse_SN, 0, 2);
            this.Spedizioni_Layout.Controls.Add(this.pan_Browse_Folder, 0, 3);
            this.Spedizioni_Layout.Controls.Add(this.dg_spedizioni, 0, 4);
            this.Spedizioni_Layout.Controls.Add(this.dg_SN, 0, 5);
            this.Spedizioni_Layout.Controls.Add(this.pan_avanzamento, 0, 6);
            this.Spedizioni_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spedizioni_Layout.Location = new System.Drawing.Point(0, 0);
            this.Spedizioni_Layout.Name = "Spedizioni_Layout";
            this.Spedizioni_Layout.RowCount = 10;
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Spedizioni_Layout.Size = new System.Drawing.Size(1200, 1200);
            this.Spedizioni_Layout.TabIndex = 1;
            // 
            // pan_Sped_Titolo
            // 
            this.Spedizioni_Layout.SetColumnSpan(this.pan_Sped_Titolo, 2);
            this.pan_Sped_Titolo.Controls.Add(this.metroLabel21);
            this.pan_Sped_Titolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Sped_Titolo.HorizontalScrollbarBarColor = true;
            this.pan_Sped_Titolo.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_Sped_Titolo.HorizontalScrollbarSize = 10;
            this.pan_Sped_Titolo.Location = new System.Drawing.Point(3, 3);
            this.pan_Sped_Titolo.Name = "pan_Sped_Titolo";
            this.pan_Sped_Titolo.Size = new System.Drawing.Size(234, 22);
            this.pan_Sped_Titolo.TabIndex = 20;
            this.pan_Sped_Titolo.UseCustomBackColor = true;
            this.pan_Sped_Titolo.VerticalScrollbarBarColor = true;
            this.pan_Sped_Titolo.VerticalScrollbarHighlightOnWheel = false;
            this.pan_Sped_Titolo.VerticalScrollbarSize = 10;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(0, 0);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(180, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Situazione Spedizioni";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseStyleColors = true;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.Spedizioni_Layout.SetColumnSpan(this.pan_Menu_comandi, 6);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 28);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(720, 24);
            this.pan_Menu_comandi.TabIndex = 21;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.Spedizioni_Layout.SetColumnSpan(this.pan_Menu_salva, 3);
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
            // pan_Browse_SN
            // 
            this.pan_Browse_SN.ColumnCount = 10;
            this.Spedizioni_Layout.SetColumnSpan(this.pan_Browse_SN, 10);
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_SN.Controls.Add(this.Sped_lab_SN, 0, 0);
            this.pan_Browse_SN.Controls.Add(this.tb_file_SN, 3, 0);
            this.pan_Browse_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Browse_SN.Location = new System.Drawing.Point(3, 55);
            this.pan_Browse_SN.Name = "pan_Browse_SN";
            this.pan_Browse_SN.RowCount = 1;
            this.pan_Browse_SN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_Browse_SN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Browse_SN.Size = new System.Drawing.Size(1194, 30);
            this.pan_Browse_SN.TabIndex = 62;
            // 
            // Sped_lab_SN
            // 
            this.Sped_lab_SN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sped_lab_SN.AutoSize = true;
            this.pan_Browse_SN.SetColumnSpan(this.Sped_lab_SN, 4);
            this.Sped_lab_SN.Location = new System.Drawing.Point(3, 5);
            this.Sped_lab_SN.Name = "Sped_lab_SN";
            this.Sped_lab_SN.Size = new System.Drawing.Size(211, 19);
            this.Sped_lab_SN.TabIndex = 4;
            this.Sped_lab_SN.Text = "Seleziona il file dei numeri di serie:";
            this.Sped_lab_SN.UseCustomBackColor = true;
            // 
            // tb_file_SN
            // 
            this.pan_Browse_SN.SetColumnSpan(this.tb_file_SN, 4);
            // 
            // 
            // 
            this.tb_file_SN.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tb_file_SN.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tb_file_SN.CustomButton.Location = new System.Drawing.Point(448, 2);
            this.tb_file_SN.CustomButton.Name = "";
            this.tb_file_SN.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_file_SN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_file_SN.CustomButton.TabIndex = 1;
            this.tb_file_SN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_file_SN.CustomButton.UseSelectable = true;
            this.tb_file_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_file_SN.ForeColor = System.Drawing.Color.White;
            this.tb_file_SN.Lines = new string[] {
        "\\\\192.168.0.8\\ricerca e sviluppo\\Produzione\\Numeri di serie\\Numeri di serie.xls"};
            this.tb_file_SN.Location = new System.Drawing.Point(479, 3);
            this.tb_file_SN.MaxLength = 32767;
            this.tb_file_SN.Name = "tb_file_SN";
            this.tb_file_SN.PasswordChar = '\0';
            this.tb_file_SN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_file_SN.SelectedText = "";
            this.tb_file_SN.SelectionLength = 0;
            this.tb_file_SN.SelectionStart = 0;
            this.tb_file_SN.ShortcutsEnabled = true;
            this.tb_file_SN.ShowButton = true;
            this.tb_file_SN.ShowClearButton = true;
            this.tb_file_SN.Size = new System.Drawing.Size(470, 24);
            this.tb_file_SN.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_file_SN.TabIndex = 0;
            this.tb_file_SN.Text = "\\\\192.168.0.8\\ricerca e sviluppo\\Produzione\\Numeri di serie\\Numeri di serie.xls";
            this.tb_file_SN.UseSelectable = true;
            this.tb_file_SN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_file_SN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pan_Browse_Folder
            // 
            this.pan_Browse_Folder.ColumnCount = 10;
            this.Spedizioni_Layout.SetColumnSpan(this.pan_Browse_Folder, 10);
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_Browse_Folder.Controls.Add(this.Sped_lab_Folder, 0, 0);
            this.pan_Browse_Folder.Controls.Add(this.tb_Folder_Sped, 3, 0);
            this.pan_Browse_Folder.Controls.Add(this.button_go_sped, 8, 0);
            this.pan_Browse_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Browse_Folder.Location = new System.Drawing.Point(3, 91);
            this.pan_Browse_Folder.Name = "pan_Browse_Folder";
            this.pan_Browse_Folder.RowCount = 1;
            this.pan_Browse_Folder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_Browse_Folder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Browse_Folder.Size = new System.Drawing.Size(1194, 30);
            this.pan_Browse_Folder.TabIndex = 0;
            // 
            // Sped_lab_Folder
            // 
            this.Sped_lab_Folder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sped_lab_Folder.AutoSize = true;
            this.pan_Browse_Folder.SetColumnSpan(this.Sped_lab_Folder, 4);
            this.Sped_lab_Folder.Location = new System.Drawing.Point(3, 5);
            this.Sped_lab_Folder.Name = "Sped_lab_Folder";
            this.Sped_lab_Folder.Size = new System.Drawing.Size(356, 19);
            this.Sped_lab_Folder.TabIndex = 4;
            this.Sped_lab_Folder.Text = "Seleziona cartella dove sono presenti i files delle spedizioni:";
            this.Sped_lab_Folder.UseCustomBackColor = true;
            // 
            // tb_Folder_Sped
            // 
            this.pan_Browse_Folder.SetColumnSpan(this.tb_Folder_Sped, 4);
            // 
            // 
            // 
            this.tb_Folder_Sped.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tb_Folder_Sped.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.tb_Folder_Sped.CustomButton.Location = new System.Drawing.Point(448, 2);
            this.tb_Folder_Sped.CustomButton.Name = "";
            this.tb_Folder_Sped.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Folder_Sped.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Folder_Sped.CustomButton.TabIndex = 1;
            this.tb_Folder_Sped.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Folder_Sped.CustomButton.UseSelectable = true;
            this.tb_Folder_Sped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Folder_Sped.ForeColor = System.Drawing.Color.White;
            this.tb_Folder_Sped.Lines = new string[] {
        "metroTextBox1"};
            this.tb_Folder_Sped.Location = new System.Drawing.Point(479, 3);
            this.tb_Folder_Sped.MaxLength = 32767;
            this.tb_Folder_Sped.Name = "tb_Folder_Sped";
            this.tb_Folder_Sped.PasswordChar = '\0';
            this.tb_Folder_Sped.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Folder_Sped.SelectedText = "";
            this.tb_Folder_Sped.SelectionLength = 0;
            this.tb_Folder_Sped.SelectionStart = 0;
            this.tb_Folder_Sped.ShortcutsEnabled = true;
            this.tb_Folder_Sped.ShowButton = true;
            this.tb_Folder_Sped.ShowClearButton = true;
            this.tb_Folder_Sped.Size = new System.Drawing.Size(470, 24);
            this.tb_Folder_Sped.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_Folder_Sped.TabIndex = 0;
            this.tb_Folder_Sped.Text = "metroTextBox1";
            this.tb_Folder_Sped.UseSelectable = true;
            this.tb_Folder_Sped.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Folder_Sped.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button_go_sped
            // 
            this.button_go_sped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_go_sped.Location = new System.Drawing.Point(955, 3);
            this.button_go_sped.Name = "button_go_sped";
            this.button_go_sped.Size = new System.Drawing.Size(113, 24);
            this.button_go_sped.TabIndex = 5;
            this.button_go_sped.Text = "Elabora";
            this.button_go_sped.UseSelectable = true;
            this.button_go_sped.Click += new System.EventHandler(this.button_go_sped_Click);
            // 
            // dg_spedizioni
            // 
            this.dg_spedizioni.AllowUserToAddRows = false;
            this.dg_spedizioni.AllowUserToDeleteRows = false;
            this.dg_spedizioni.AutoGenerateColumns = false;
            this.dg_spedizioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_spedizioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_spedizioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileSpedDataGridViewTextBoxColumn,
            this.elaboratoDataGridViewCheckBoxColumn});
            this.Spedizioni_Layout.SetColumnSpan(this.dg_spedizioni, 10);
            this.dg_spedizioni.DataSource = this.spedNeohmBindingSource;
            this.dg_spedizioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_spedizioni.Location = new System.Drawing.Point(3, 127);
            this.dg_spedizioni.Name = "dg_spedizioni";
            this.dg_spedizioni.RowHeadersVisible = false;
            this.dg_spedizioni.Size = new System.Drawing.Size(1194, 150);
            this.dg_spedizioni.TabIndex = 0;
            // 
            // fileSpedDataGridViewTextBoxColumn
            // 
            this.fileSpedDataGridViewTextBoxColumn.DataPropertyName = "File_Sped";
            this.fileSpedDataGridViewTextBoxColumn.HeaderText = "Nome del file";
            this.fileSpedDataGridViewTextBoxColumn.Name = "fileSpedDataGridViewTextBoxColumn";
            // 
            // elaboratoDataGridViewCheckBoxColumn
            // 
            this.elaboratoDataGridViewCheckBoxColumn.DataPropertyName = "Elaborato";
            this.elaboratoDataGridViewCheckBoxColumn.HeaderText = "Elaborato";
            this.elaboratoDataGridViewCheckBoxColumn.Name = "elaboratoDataGridViewCheckBoxColumn";
            this.elaboratoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // spedNeohmBindingSource
            // 
            this.spedNeohmBindingSource.DataMember = "SpedNeohm";
            this.spedNeohmBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg_SN
            // 
            this.dg_SN.AllowUserToAddRows = false;
            this.dg_SN.AllowUserToDeleteRows = false;
            this.dg_SN.AutoGenerateColumns = false;
            this.dg_SN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_SN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialIdDataGridViewTextBoxColumn,
            this.serialCliDataGridViewTextBoxColumn,
            this.serialDesDataGridViewTextBoxColumn,
            this.serialKitDataGridViewTextBoxColumn,
            this.serialArtDataGridViewTextBoxColumn,
            this.serialCommessaDataGridViewTextBoxColumn,
            this.serialNnumdocDataGridViewTextBoxColumn,
            this.serialNdatadocDataGridViewTextBoxColumn,
            this.serialNconfdocDataGridViewTextBoxColumn});
            this.Spedizioni_Layout.SetColumnSpan(this.dg_SN, 10);
            this.dg_SN.DataSource = this.xlsSerialsBindingSource;
            this.dg_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_SN.Location = new System.Drawing.Point(3, 283);
            this.dg_SN.Name = "dg_SN";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_SN.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_SN.RowHeadersVisible = false;
            this.dg_SN.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_SN.Size = new System.Drawing.Size(1194, 300);
            this.dg_SN.TabIndex = 63;
            // 
            // serialIdDataGridViewTextBoxColumn
            // 
            this.serialIdDataGridViewTextBoxColumn.DataPropertyName = "Serial_Id";
            this.serialIdDataGridViewTextBoxColumn.HeaderText = "Numero di serie";
            this.serialIdDataGridViewTextBoxColumn.Name = "serialIdDataGridViewTextBoxColumn";
            // 
            // serialCliDataGridViewTextBoxColumn
            // 
            this.serialCliDataGridViewTextBoxColumn.DataPropertyName = "Serial_Cli";
            this.serialCliDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.serialCliDataGridViewTextBoxColumn.Name = "serialCliDataGridViewTextBoxColumn";
            // 
            // serialDesDataGridViewTextBoxColumn
            // 
            this.serialDesDataGridViewTextBoxColumn.DataPropertyName = "Serial_Des";
            this.serialDesDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.serialDesDataGridViewTextBoxColumn.Name = "serialDesDataGridViewTextBoxColumn";
            // 
            // serialKitDataGridViewTextBoxColumn
            // 
            this.serialKitDataGridViewTextBoxColumn.DataPropertyName = "Serial_Kit";
            this.serialKitDataGridViewTextBoxColumn.HeaderText = "Kit";
            this.serialKitDataGridViewTextBoxColumn.Name = "serialKitDataGridViewTextBoxColumn";
            // 
            // serialArtDataGridViewTextBoxColumn
            // 
            this.serialArtDataGridViewTextBoxColumn.DataPropertyName = "Serial_Art";
            this.serialArtDataGridViewTextBoxColumn.HeaderText = "Articolo";
            this.serialArtDataGridViewTextBoxColumn.Name = "serialArtDataGridViewTextBoxColumn";
            // 
            // serialCommessaDataGridViewTextBoxColumn
            // 
            this.serialCommessaDataGridViewTextBoxColumn.DataPropertyName = "Serial_Commessa";
            this.serialCommessaDataGridViewTextBoxColumn.HeaderText = "Comm. Sistematica";
            this.serialCommessaDataGridViewTextBoxColumn.Name = "serialCommessaDataGridViewTextBoxColumn";
            // 
            // serialNnumdocDataGridViewTextBoxColumn
            // 
            this.serialNnumdocDataGridViewTextBoxColumn.DataPropertyName = "Serial_N_numdoc";
            this.serialNnumdocDataGridViewTextBoxColumn.HeaderText = "Neohm - Num. doc.";
            this.serialNnumdocDataGridViewTextBoxColumn.Name = "serialNnumdocDataGridViewTextBoxColumn";
            // 
            // serialNdatadocDataGridViewTextBoxColumn
            // 
            this.serialNdatadocDataGridViewTextBoxColumn.DataPropertyName = "Serial_N_datadoc";
            this.serialNdatadocDataGridViewTextBoxColumn.HeaderText = "Neohm - Data doc.";
            this.serialNdatadocDataGridViewTextBoxColumn.Name = "serialNdatadocDataGridViewTextBoxColumn";
            // 
            // serialNconfdocDataGridViewTextBoxColumn
            // 
            this.serialNconfdocDataGridViewTextBoxColumn.DataPropertyName = "Serial_N_confdoc";
            this.serialNconfdocDataGridViewTextBoxColumn.HeaderText = "Neohm - Conf. Ord.";
            this.serialNconfdocDataGridViewTextBoxColumn.Name = "serialNconfdocDataGridViewTextBoxColumn";
            this.serialNconfdocDataGridViewTextBoxColumn.Visible = false;
            // 
            // xlsSerialsBindingSource
            // 
            this.xlsSerialsBindingSource.DataMember = "xls_Serials";
            this.xlsSerialsBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // pan_avanzamento
            // 
            this.pan_avanzamento.ColumnCount = 10;
            this.Spedizioni_Layout.SetColumnSpan(this.pan_avanzamento, 10);
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pan_avanzamento.Controls.Add(this.lab_doc_sist, 3, 3);
            this.pan_avanzamento.Controls.Add(this.lab_data_bolla, 2, 3);
            this.pan_avanzamento.Controls.Add(this.lab_riga, 1, 3);
            this.pan_avanzamento.Controls.Add(this.lab_file_analizzato, 1, 2);
            this.pan_avanzamento.Controls.Add(this.metroLabel2, 0, 2);
            this.pan_avanzamento.Controls.Add(this.lab_avanzamento, 1, 0);
            this.pan_avanzamento.Controls.Add(this.metroLabel1, 0, 0);
            this.pan_avanzamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_avanzamento.Location = new System.Drawing.Point(3, 589);
            this.pan_avanzamento.Name = "pan_avanzamento";
            this.pan_avanzamento.RowCount = 4;
            this.pan_avanzamento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_avanzamento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_avanzamento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_avanzamento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_avanzamento.Size = new System.Drawing.Size(1194, 60);
            this.pan_avanzamento.TabIndex = 64;
            // 
            // lab_doc_sist
            // 
            this.lab_doc_sist.AutoSize = true;
            this.lab_doc_sist.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_doc_sist.Location = new System.Drawing.Point(360, 38);
            this.lab_doc_sist.Name = "lab_doc_sist";
            this.lab_doc_sist.Size = new System.Drawing.Size(82, 19);
            this.lab_doc_sist.TabIndex = 11;
            this.lab_doc_sist.Text = "Data Bolla:";
            this.lab_doc_sist.UseCustomBackColor = true;
            // 
            // lab_data_bolla
            // 
            this.lab_data_bolla.AutoSize = true;
            this.lab_data_bolla.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_data_bolla.Location = new System.Drawing.Point(241, 38);
            this.lab_data_bolla.Name = "lab_data_bolla";
            this.lab_data_bolla.Size = new System.Drawing.Size(82, 19);
            this.lab_data_bolla.TabIndex = 10;
            this.lab_data_bolla.Text = "Data Bolla:";
            this.lab_data_bolla.UseCustomBackColor = true;
            // 
            // lab_riga
            // 
            this.lab_riga.AutoSize = true;
            this.lab_riga.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_riga.Location = new System.Drawing.Point(122, 38);
            this.lab_riga.Name = "lab_riga";
            this.lab_riga.Size = new System.Drawing.Size(67, 19);
            this.lab_riga.TabIndex = 9;
            this.lab_riga.Text = "Articolo:";
            this.lab_riga.UseCustomBackColor = true;
            // 
            // lab_file_analizzato
            // 
            this.lab_file_analizzato.AutoSize = true;
            this.pan_avanzamento.SetColumnSpan(this.lab_file_analizzato, 9);
            this.lab_file_analizzato.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_file_analizzato.Location = new System.Drawing.Point(122, 19);
            this.lab_file_analizzato.Name = "lab_file_analizzato";
            this.lab_file_analizzato.Size = new System.Drawing.Size(105, 19);
            this.lab_file_analizzato.TabIndex = 8;
            this.lab_file_analizzato.Text = "Avanzamento:";
            this.lab_file_analizzato.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "File analizzato:";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // lab_avanzamento
            // 
            this.lab_avanzamento.AutoSize = true;
            this.pan_avanzamento.SetColumnSpan(this.lab_avanzamento, 9);
            this.lab_avanzamento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_avanzamento.Location = new System.Drawing.Point(122, 0);
            this.lab_avanzamento.Name = "lab_avanzamento";
            this.lab_avanzamento.Size = new System.Drawing.Size(105, 19);
            this.lab_avanzamento.TabIndex = 6;
            this.lab_avanzamento.Text = "Avanzamento:";
            this.lab_avanzamento.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Avanzamento:";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // UC_form_Spedizioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Spedizioni_Layout);
            this.Name = "UC_form_Spedizioni";
            this.Size = new System.Drawing.Size(1200, 1200);
            this.Load += new System.EventHandler(this.UC_form_Spedizioni_Load);
            this.Spedizioni_Layout.ResumeLayout(false);
            this.Spedizioni_Layout.PerformLayout();
            this.pan_Sped_Titolo.ResumeLayout(false);
            this.pan_Sped_Titolo.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.pan_Browse_SN.ResumeLayout(false);
            this.pan_Browse_SN.PerformLayout();
            this.pan_Browse_Folder.ResumeLayout(false);
            this.pan_Browse_Folder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_spedizioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spedNeohmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlsSerialsBindingSource)).EndInit();
            this.pan_avanzamento.ResumeLayout(false);
            this.pan_avanzamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Spedizioni_Layout;
        private MetroFramework.Controls.MetroPanel pan_Sped_Titolo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel pan_Browse_Folder;
        private MetroFramework.Controls.MetroLabel Sped_lab_Folder;
        private MetroFramework.Controls.MetroTextBox tb_Folder_Sped;
        private MetroFramework.Controls.MetroButton button_go_sped;
        private System.Windows.Forms.DataGridView dg_spedizioni;
        private System.Windows.Forms.TableLayoutPanel pan_Browse_SN;
        private MetroFramework.Controls.MetroLabel Sped_lab_SN;
        private MetroFramework.Controls.MetroTextBox tb_file_SN;
        private System.Windows.Forms.DataGridView dg_SN;
        private System.Windows.Forms.TableLayoutPanel pan_avanzamento;
        private MetroFramework.Controls.MetroLabel lab_avanzamento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSpedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elaboratoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource spedNeohmBindingSource;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialKitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialCommessaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNnumdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNdatadocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNconfdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource xlsSerialsBindingSource;
        private MetroFramework.Controls.MetroLabel lab_file_analizzato;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lab_riga;
        private MetroFramework.Controls.MetroLabel lab_data_bolla;
        private MetroFramework.Controls.MetroLabel lab_doc_sist;
    }
}
