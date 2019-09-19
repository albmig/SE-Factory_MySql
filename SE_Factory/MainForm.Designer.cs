namespace SE_Factory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Menu = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Home = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_09 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Spedizioni = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_08 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Ordini = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_07 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Gecko = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_06 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Clienti = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_05 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_Sw = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_04 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_prodotti = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_03 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_ID = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_02 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_printer = new MetroFramework.Controls.MetroTile();
            this.menu_spacer_01 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_paths = new MetroFramework.Controls.MetroTile();
            this.panel_default_printer = new MetroFramework.Controls.MetroPanel();
            this.lab_def_printer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_Application = new MetroFramework.Controls.MetroUserControl();
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tool_Strip_label_SW = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool_Strip_path_SW = new System.Windows.Forms.ToolStripStatusLabel();
            this.lab_sep_strip_01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool_Strip_label_Commander = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool_Strip_path_Commander = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel_Menu.SuspendLayout();
            this.panel_default_printer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.menu_btn_Home);
            this.panel_Menu.Controls.Add(this.menu_spacer_09);
            this.panel_Menu.Controls.Add(this.menu_btn_Spedizioni);
            this.panel_Menu.Controls.Add(this.menu_spacer_08);
            this.panel_Menu.Controls.Add(this.menu_btn_Ordini);
            this.panel_Menu.Controls.Add(this.menu_spacer_07);
            this.panel_Menu.Controls.Add(this.menu_btn_Gecko);
            this.panel_Menu.Controls.Add(this.menu_spacer_06);
            this.panel_Menu.Controls.Add(this.menu_btn_Clienti);
            this.panel_Menu.Controls.Add(this.menu_spacer_05);
            this.panel_Menu.Controls.Add(this.menu_btn_Sw);
            this.panel_Menu.Controls.Add(this.menu_spacer_04);
            this.panel_Menu.Controls.Add(this.menu_btn_prodotti);
            this.panel_Menu.Controls.Add(this.menu_spacer_03);
            this.panel_Menu.Controls.Add(this.menu_btn_ID);
            this.panel_Menu.Controls.Add(this.menu_spacer_02);
            this.panel_Menu.Controls.Add(this.menu_btn_printer);
            this.panel_Menu.Controls.Add(this.menu_spacer_01);
            this.panel_Menu.Controls.Add(this.menu_btn_paths);
            this.panel_Menu.Controls.Add(this.panel_default_printer);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.HorizontalScrollbarBarColor = true;
            this.panel_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Menu.HorizontalScrollbarSize = 10;
            this.panel_Menu.Location = new System.Drawing.Point(23, 83);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(150, 568);
            this.panel_Menu.TabIndex = 1;
            this.panel_Menu.VerticalScrollbarBarColor = true;
            this.panel_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Menu.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Home
            // 
            this.menu_btn_Home.ActiveControl = null;
            this.menu_btn_Home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Home.Location = new System.Drawing.Point(0, 492);
            this.menu_btn_Home.Name = "menu_btn_Home";
            this.menu_btn_Home.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Home.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Home.TabIndex = 8;
            this.menu_btn_Home.Text = "Uscita";
            this.menu_btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Home.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Home.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Home.TileImage")));
            this.menu_btn_Home.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Home.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Home.UseCustomBackColor = true;
            this.menu_btn_Home.UseCustomForeColor = true;
            this.menu_btn_Home.UseSelectable = true;
            this.menu_btn_Home.UseTileImage = true;
            this.menu_btn_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // menu_spacer_09
            // 
            this.menu_spacer_09.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_09.HorizontalScrollbarBarColor = true;
            this.menu_spacer_09.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_09.HorizontalScrollbarSize = 10;
            this.menu_spacer_09.Location = new System.Drawing.Point(0, 482);
            this.menu_spacer_09.Name = "menu_spacer_09";
            this.menu_spacer_09.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_09.TabIndex = 22;
            this.menu_spacer_09.VerticalScrollbarBarColor = true;
            this.menu_spacer_09.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_09.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Spedizioni
            // 
            this.menu_btn_Spedizioni.ActiveControl = null;
            this.menu_btn_Spedizioni.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_Spedizioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Spedizioni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Spedizioni.Location = new System.Drawing.Point(0, 440);
            this.menu_btn_Spedizioni.Name = "menu_btn_Spedizioni";
            this.menu_btn_Spedizioni.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Spedizioni.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Spedizioni.TabIndex = 23;
            this.menu_btn_Spedizioni.Text = "Spedizioni";
            this.menu_btn_Spedizioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Spedizioni.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Spedizioni.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Spedizioni.TileImage")));
            this.menu_btn_Spedizioni.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Spedizioni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Spedizioni.UseCustomBackColor = true;
            this.menu_btn_Spedizioni.UseCustomForeColor = true;
            this.menu_btn_Spedizioni.UseSelectable = true;
            this.menu_btn_Spedizioni.UseTileImage = true;
            this.menu_btn_Spedizioni.Click += new System.EventHandler(this.menu_btn_Spedizioni_Click);
            // 
            // menu_spacer_08
            // 
            this.menu_spacer_08.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_08.HorizontalScrollbarBarColor = true;
            this.menu_spacer_08.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_08.HorizontalScrollbarSize = 10;
            this.menu_spacer_08.Location = new System.Drawing.Point(0, 430);
            this.menu_spacer_08.Name = "menu_spacer_08";
            this.menu_spacer_08.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_08.TabIndex = 20;
            this.menu_spacer_08.VerticalScrollbarBarColor = true;
            this.menu_spacer_08.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_08.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Ordini
            // 
            this.menu_btn_Ordini.ActiveControl = null;
            this.menu_btn_Ordini.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_Ordini.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Ordini.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Ordini.Location = new System.Drawing.Point(0, 388);
            this.menu_btn_Ordini.Name = "menu_btn_Ordini";
            this.menu_btn_Ordini.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Ordini.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Ordini.TabIndex = 21;
            this.menu_btn_Ordini.Text = "Ordini aperti";
            this.menu_btn_Ordini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Ordini.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Ordini.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Ordini.TileImage")));
            this.menu_btn_Ordini.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Ordini.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Ordini.UseCustomBackColor = true;
            this.menu_btn_Ordini.UseCustomForeColor = true;
            this.menu_btn_Ordini.UseSelectable = true;
            this.menu_btn_Ordini.UseTileImage = true;
            this.menu_btn_Ordini.Click += new System.EventHandler(this.menu_btn_Ordini_Click);
            // 
            // menu_spacer_07
            // 
            this.menu_spacer_07.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_07.HorizontalScrollbarBarColor = true;
            this.menu_spacer_07.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_07.HorizontalScrollbarSize = 10;
            this.menu_spacer_07.Location = new System.Drawing.Point(0, 378);
            this.menu_spacer_07.Name = "menu_spacer_07";
            this.menu_spacer_07.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_07.TabIndex = 19;
            this.menu_spacer_07.VerticalScrollbarBarColor = true;
            this.menu_spacer_07.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_07.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Gecko
            // 
            this.menu_btn_Gecko.ActiveControl = null;
            this.menu_btn_Gecko.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_Gecko.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Gecko.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Gecko.Location = new System.Drawing.Point(0, 336);
            this.menu_btn_Gecko.Name = "menu_btn_Gecko";
            this.menu_btn_Gecko.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Gecko.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Gecko.TabIndex = 7;
            this.menu_btn_Gecko.Text = "Prog. Gecko";
            this.menu_btn_Gecko.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Gecko.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Gecko.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Gecko.TileImage")));
            this.menu_btn_Gecko.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Gecko.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Gecko.UseCustomBackColor = true;
            this.menu_btn_Gecko.UseCustomForeColor = true;
            this.menu_btn_Gecko.UseSelectable = true;
            this.menu_btn_Gecko.UseTileImage = true;
            this.menu_btn_Gecko.Click += new System.EventHandler(this.menu_btn_Gecko_Click);
            // 
            // menu_spacer_06
            // 
            this.menu_spacer_06.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_06.HorizontalScrollbarBarColor = true;
            this.menu_spacer_06.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_06.HorizontalScrollbarSize = 10;
            this.menu_spacer_06.Location = new System.Drawing.Point(0, 326);
            this.menu_spacer_06.Name = "menu_spacer_06";
            this.menu_spacer_06.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_06.TabIndex = 18;
            this.menu_spacer_06.VerticalScrollbarBarColor = true;
            this.menu_spacer_06.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_06.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Clienti
            // 
            this.menu_btn_Clienti.ActiveControl = null;
            this.menu_btn_Clienti.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_Clienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Clienti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Clienti.Location = new System.Drawing.Point(0, 284);
            this.menu_btn_Clienti.Name = "menu_btn_Clienti";
            this.menu_btn_Clienti.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Clienti.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Clienti.TabIndex = 6;
            this.menu_btn_Clienti.Text = "Conv. Clienti";
            this.menu_btn_Clienti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Clienti.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Clienti.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Clienti.TileImage")));
            this.menu_btn_Clienti.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Clienti.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Clienti.UseCustomBackColor = true;
            this.menu_btn_Clienti.UseCustomForeColor = true;
            this.menu_btn_Clienti.UseSelectable = true;
            this.menu_btn_Clienti.UseTileImage = true;
            this.menu_btn_Clienti.Click += new System.EventHandler(this.menu_btn_Clienti_Click);
            // 
            // menu_spacer_05
            // 
            this.menu_spacer_05.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_05.HorizontalScrollbarBarColor = true;
            this.menu_spacer_05.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_05.HorizontalScrollbarSize = 10;
            this.menu_spacer_05.Location = new System.Drawing.Point(0, 274);
            this.menu_spacer_05.Name = "menu_spacer_05";
            this.menu_spacer_05.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_05.TabIndex = 16;
            this.menu_spacer_05.VerticalScrollbarBarColor = true;
            this.menu_spacer_05.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_05.VerticalScrollbarSize = 10;
            // 
            // menu_btn_Sw
            // 
            this.menu_btn_Sw.ActiveControl = null;
            this.menu_btn_Sw.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_Sw.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_Sw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_Sw.Location = new System.Drawing.Point(0, 232);
            this.menu_btn_Sw.Name = "menu_btn_Sw";
            this.menu_btn_Sw.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_Sw.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_Sw.TabIndex = 5;
            this.menu_btn_Sw.Text = "Doc. Software";
            this.menu_btn_Sw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_Sw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_Sw.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_Sw.TileImage")));
            this.menu_btn_Sw.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_Sw.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_Sw.UseCustomBackColor = true;
            this.menu_btn_Sw.UseCustomForeColor = true;
            this.menu_btn_Sw.UseSelectable = true;
            this.menu_btn_Sw.UseTileImage = true;
            this.menu_btn_Sw.Click += new System.EventHandler(this.menu_btn_Sw_Click);
            // 
            // menu_spacer_04
            // 
            this.menu_spacer_04.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_04.HorizontalScrollbarBarColor = true;
            this.menu_spacer_04.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_04.HorizontalScrollbarSize = 10;
            this.menu_spacer_04.Location = new System.Drawing.Point(0, 222);
            this.menu_spacer_04.Name = "menu_spacer_04";
            this.menu_spacer_04.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_04.TabIndex = 14;
            this.menu_spacer_04.VerticalScrollbarBarColor = true;
            this.menu_spacer_04.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_04.VerticalScrollbarSize = 10;
            // 
            // menu_btn_prodotti
            // 
            this.menu_btn_prodotti.ActiveControl = null;
            this.menu_btn_prodotti.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_prodotti.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_prodotti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn_prodotti.Location = new System.Drawing.Point(0, 180);
            this.menu_btn_prodotti.Name = "menu_btn_prodotti";
            this.menu_btn_prodotti.Size = new System.Drawing.Size(150, 42);
            this.menu_btn_prodotti.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_prodotti.TabIndex = 4;
            this.menu_btn_prodotti.Text = "Prodotti";
            this.menu_btn_prodotti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_prodotti.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_prodotti.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_prodotti.TileImage")));
            this.menu_btn_prodotti.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_prodotti.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_prodotti.UseCustomBackColor = true;
            this.menu_btn_prodotti.UseCustomForeColor = true;
            this.menu_btn_prodotti.UseSelectable = true;
            this.menu_btn_prodotti.UseTileImage = true;
            this.menu_btn_prodotti.Click += new System.EventHandler(this.menu_btn_prodotti_Click);
            // 
            // menu_spacer_03
            // 
            this.menu_spacer_03.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_03.HorizontalScrollbarBarColor = true;
            this.menu_spacer_03.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_03.HorizontalScrollbarSize = 10;
            this.menu_spacer_03.Location = new System.Drawing.Point(0, 170);
            this.menu_spacer_03.Name = "menu_spacer_03";
            this.menu_spacer_03.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_03.TabIndex = 11;
            this.menu_spacer_03.VerticalScrollbarBarColor = true;
            this.menu_spacer_03.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_03.VerticalScrollbarSize = 10;
            // 
            // menu_btn_ID
            // 
            this.menu_btn_ID.ActiveControl = null;
            this.menu_btn_ID.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_ID.Location = new System.Drawing.Point(0, 120);
            this.menu_btn_ID.Name = "menu_btn_ID";
            this.menu_btn_ID.Size = new System.Drawing.Size(150, 50);
            this.menu_btn_ID.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_ID.TabIndex = 3;
            this.menu_btn_ID.Text = "Calcolo ID";
            this.menu_btn_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_ID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_ID.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_ID.TileImage")));
            this.menu_btn_ID.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_ID.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_ID.UseCustomBackColor = true;
            this.menu_btn_ID.UseCustomForeColor = true;
            this.menu_btn_ID.UseSelectable = true;
            this.menu_btn_ID.UseTileImage = true;
            this.menu_btn_ID.Click += new System.EventHandler(this.menu_btn_ID_Click);
            // 
            // menu_spacer_02
            // 
            this.menu_spacer_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_02.HorizontalScrollbarBarColor = true;
            this.menu_spacer_02.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_02.HorizontalScrollbarSize = 10;
            this.menu_spacer_02.Location = new System.Drawing.Point(0, 110);
            this.menu_spacer_02.Name = "menu_spacer_02";
            this.menu_spacer_02.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_02.TabIndex = 5;
            this.menu_spacer_02.VerticalScrollbarBarColor = true;
            this.menu_spacer_02.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_02.VerticalScrollbarSize = 10;
            // 
            // menu_btn_printer
            // 
            this.menu_btn_printer.ActiveControl = null;
            this.menu_btn_printer.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_printer.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_printer.Location = new System.Drawing.Point(0, 60);
            this.menu_btn_printer.Name = "menu_btn_printer";
            this.menu_btn_printer.Size = new System.Drawing.Size(150, 50);
            this.menu_btn_printer.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_printer.TabIndex = 2;
            this.menu_btn_printer.Text = "IP Stampante";
            this.menu_btn_printer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_printer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_printer.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_printer.TileImage")));
            this.menu_btn_printer.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_printer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_printer.UseCustomBackColor = true;
            this.menu_btn_printer.UseCustomForeColor = true;
            this.menu_btn_printer.UseSelectable = true;
            this.menu_btn_printer.UseTileImage = true;
            this.menu_btn_printer.Click += new System.EventHandler(this.menu_btn_printer_Click);
            // 
            // menu_spacer_01
            // 
            this.menu_spacer_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spacer_01.HorizontalScrollbarBarColor = true;
            this.menu_spacer_01.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_spacer_01.HorizontalScrollbarSize = 10;
            this.menu_spacer_01.Location = new System.Drawing.Point(0, 50);
            this.menu_spacer_01.Name = "menu_spacer_01";
            this.menu_spacer_01.Size = new System.Drawing.Size(150, 10);
            this.menu_spacer_01.TabIndex = 3;
            this.menu_spacer_01.VerticalScrollbarBarColor = true;
            this.menu_spacer_01.VerticalScrollbarHighlightOnWheel = false;
            this.menu_spacer_01.VerticalScrollbarSize = 10;
            // 
            // menu_btn_paths
            // 
            this.menu_btn_paths.ActiveControl = null;
            this.menu_btn_paths.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn_paths.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_paths.Location = new System.Drawing.Point(0, 0);
            this.menu_btn_paths.Name = "menu_btn_paths";
            this.menu_btn_paths.Size = new System.Drawing.Size(150, 50);
            this.menu_btn_paths.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_paths.TabIndex = 1;
            this.menu_btn_paths.Text = "Percorsi";
            this.menu_btn_paths.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_paths.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_paths.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_paths.TileImage")));
            this.menu_btn_paths.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_paths.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_paths.UseCustomBackColor = true;
            this.menu_btn_paths.UseCustomForeColor = true;
            this.menu_btn_paths.UseSelectable = true;
            this.menu_btn_paths.UseTileImage = true;
            this.menu_btn_paths.Click += new System.EventHandler(this.menu_btn_paths_Click);
            // 
            // panel_default_printer
            // 
            this.panel_default_printer.Controls.Add(this.lab_def_printer);
            this.panel_default_printer.Controls.Add(this.metroLabel1);
            this.panel_default_printer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_default_printer.HorizontalScrollbarBarColor = true;
            this.panel_default_printer.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_default_printer.HorizontalScrollbarSize = 10;
            this.panel_default_printer.Location = new System.Drawing.Point(0, 508);
            this.panel_default_printer.Name = "panel_default_printer";
            this.panel_default_printer.Size = new System.Drawing.Size(150, 60);
            this.panel_default_printer.TabIndex = 10;
            this.panel_default_printer.VerticalScrollbarBarColor = true;
            this.panel_default_printer.VerticalScrollbarHighlightOnWheel = false;
            this.panel_default_printer.VerticalScrollbarSize = 10;
            // 
            // lab_def_printer
            // 
            this.lab_def_printer.AutoSize = true;
            this.lab_def_printer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_def_printer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_def_printer.Location = new System.Drawing.Point(0, 19);
            this.lab_def_printer.Name = "lab_def_printer";
            this.lab_def_printer.Size = new System.Drawing.Size(94, 19);
            this.lab_def_printer.TabIndex = 3;
            this.lab_def_printer.Text = "metroLabel2";
            this.lab_def_printer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Stampante definita";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_Application
            // 
            this.panel_Application.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Application.Location = new System.Drawing.Point(173, 83);
            this.panel_Application.Name = "panel_Application";
            this.panel_Application.Size = new System.Drawing.Size(770, 568);
            this.panel_Application.TabIndex = 4;
            this.panel_Application.UseSelectable = true;
            this.panel_Application.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_Application_ControlRemoved);
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Strip_label_SW,
            this.tool_Strip_path_SW,
            this.lab_sep_strip_01,
            this.tool_Strip_label_Commander,
            this.tool_Strip_path_Commander});
            this.statusStrip1.Location = new System.Drawing.Point(23, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tool_Strip_label_SW
            // 
            this.tool_Strip_label_SW.Name = "tool_Strip_label_SW";
            this.tool_Strip_label_SW.Size = new System.Drawing.Size(150, 17);
            this.tool_Strip_label_SW.Text = "Directory Archivi Software: ";
            // 
            // tool_Strip_path_SW
            // 
            this.tool_Strip_path_SW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tool_Strip_path_SW.Name = "tool_Strip_path_SW";
            this.tool_Strip_path_SW.Size = new System.Drawing.Size(127, 17);
            this.tool_Strip_path_SW.Text = "toolStripStatusLabel1";
            // 
            // lab_sep_strip_01
            // 
            this.lab_sep_strip_01.Name = "lab_sep_strip_01";
            this.lab_sep_strip_01.Size = new System.Drawing.Size(10, 17);
            this.lab_sep_strip_01.Text = "|";
            // 
            // tool_Strip_label_Commander
            // 
            this.tool_Strip_label_Commander.Name = "tool_Strip_label_Commander";
            this.tool_Strip_label_Commander.Size = new System.Drawing.Size(151, 17);
            this.tool_Strip_label_Commander.Text = "Directory Commander.exe: ";
            // 
            // tool_Strip_path_Commander
            // 
            this.tool_Strip_path_Commander.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tool_Strip_path_Commander.Name = "tool_Strip_path_Commander";
            this.tool_Strip_path_Commander.Size = new System.Drawing.Size(127, 17);
            this.tool_Strip_path_Commander.Text = "toolStripStatusLabel1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(330, 54);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 701);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel_Application);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 83, 23, 28);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sistematica Factory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_default_printer.ResumeLayout(false);
            this.panel_default_printer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panel_Menu;
        private MetroFramework.Controls.MetroTile menu_btn_ID;
        private MetroFramework.Controls.MetroPanel menu_spacer_01;
        private MetroFramework.Controls.MetroUserControl panel_Application;
        private MetroFramework.Controls.MetroPanel menu_spacer_02;
        private MetroFramework.Controls.MetroTile menu_btn_printer;
        private MetroFramework.Controls.MetroTile menu_btn_Home;
        private MetroFramework.Controls.MetroPanel panel_default_printer;
        private MetroFramework.Controls.MetroLabel lab_def_printer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private MetroFramework.Controls.MetroPanel menu_spacer_03;
        private MetroFramework.Controls.MetroTile menu_btn_prodotti;
        private MetroFramework.Controls.MetroTile menu_btn_Sw;
        private MetroFramework.Controls.MetroPanel menu_spacer_04;
        private MetroFramework.Controls.MetroPanel menu_spacer_05;
        private MetroFramework.Controls.MetroTile menu_btn_Clienti;
        private MetroFramework.Controls.MetroPanel menu_spacer_06;
        private MetroFramework.Controls.MetroTile menu_btn_paths;
        private MetroFramework.Controls.MetroPanel menu_spacer_07;
        private MetroFramework.Controls.MetroTile menu_btn_Gecko;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tool_Strip_label_SW;
        private System.Windows.Forms.ToolStripStatusLabel tool_Strip_path_SW;
        private System.Windows.Forms.ToolStripStatusLabel lab_sep_strip_01;
        private System.Windows.Forms.ToolStripStatusLabel tool_Strip_label_Commander;
        private System.Windows.Forms.ToolStripStatusLabel tool_Strip_path_Commander;
        private MetroFramework.Controls.MetroPanel menu_spacer_08;
        private MetroFramework.Controls.MetroTile menu_btn_Ordini;
        private MetroFramework.Controls.MetroPanel menu_spacer_09;
        private MetroFramework.Controls.MetroTile menu_btn_Spedizioni;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

