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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Menu = new MetroFramework.Controls.MetroPanel();
            this.menu_spacer_01 = new MetroFramework.Controls.MetroPanel();
            this.menu_btn_ID = new MetroFramework.Controls.MetroTile();
            this.panel_Main = new MetroFramework.Controls.MetroPanel();
            this.panel_ID = new MetroFramework.Controls.MetroPanel();
            this.ID_pan_C = new MetroFramework.Controls.MetroPanel();
            this.ID_lab_Controller = new MetroFramework.Controls.MetroLabel();
            this.ID_pan_P = new MetroFramework.Controls.MetroPanel();
            this.ID_lab_scheda_des = new System.Windows.Forms.Label();
            this.schedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FactoryDataSet = new SE_Factory.DB_FactoryDataSet();
            this.ID_combo_Scheda_P = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ID_lab_Palmare = new MetroFramework.Controls.MetroLabel();
            this.ID_pan_Top = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_combo_Famiglia = new System.Windows.Forms.ComboBox();
            this.famProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titolo_ID = new MetroFramework.Controls.MetroLabel();
            this.ID_lab_Famiglia = new MetroFramework.Controls.MetroLabel();
            this.fam_ProdTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.Fam_ProdTableAdapter();
            this.schedeTableAdapter = new SE_Factory.DB_FactoryDataSetTableAdapters.SchedeTableAdapter();
            this.panel_Menu.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.ID_pan_C.SuspendLayout();
            this.ID_pan_P.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).BeginInit();
            this.ID_pan_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.menu_spacer_01);
            this.panel_Menu.Controls.Add(this.menu_btn_ID);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.HorizontalScrollbarBarColor = true;
            this.panel_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Menu.HorizontalScrollbarSize = 10;
            this.panel_Menu.Location = new System.Drawing.Point(23, 83);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(150, 512);
            this.panel_Menu.TabIndex = 1;
            this.panel_Menu.VerticalScrollbarBarColor = true;
            this.panel_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Menu.VerticalScrollbarSize = 10;
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
            // menu_btn_ID
            // 
            this.menu_btn_ID.ActiveControl = null;
            this.menu_btn_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn_ID.Location = new System.Drawing.Point(0, 0);
            this.menu_btn_ID.Name = "menu_btn_ID";
            this.menu_btn_ID.Size = new System.Drawing.Size(150, 50);
            this.menu_btn_ID.Style = MetroFramework.MetroColorStyle.White;
            this.menu_btn_ID.TabIndex = 2;
            this.menu_btn_ID.Text = "Calcolo ID";
            this.menu_btn_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn_ID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menu_btn_ID.TileImage = ((System.Drawing.Image)(resources.GetObject("menu_btn_ID.TileImage")));
            this.menu_btn_ID.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btn_ID.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menu_btn_ID.UseCustomForeColor = true;
            this.menu_btn_ID.UseSelectable = true;
            this.menu_btn_ID.UseTileImage = true;
            this.menu_btn_ID.Click += new System.EventHandler(this.menu_btn_ID_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.HorizontalScrollbarBarColor = true;
            this.panel_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Main.HorizontalScrollbarSize = 10;
            this.panel_Main.Location = new System.Drawing.Point(173, 83);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(737, 512);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.UseCustomBackColor = true;
            this.panel_Main.VerticalScrollbarBarColor = true;
            this.panel_Main.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Main.VerticalScrollbarSize = 10;
            // 
            // panel_ID
            // 
            this.panel_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ID.Controls.Add(this.ID_pan_C);
            this.panel_ID.Controls.Add(this.ID_pan_P);
            this.panel_ID.Controls.Add(this.ID_pan_Top);
            this.panel_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ID.HorizontalScrollbarBarColor = true;
            this.panel_ID.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_ID.HorizontalScrollbarSize = 10;
            this.panel_ID.Location = new System.Drawing.Point(173, 83);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(737, 512);
            this.panel_ID.TabIndex = 3;
            this.panel_ID.UseCustomBackColor = true;
            this.panel_ID.VerticalScrollbarBarColor = true;
            this.panel_ID.VerticalScrollbarHighlightOnWheel = false;
            this.panel_ID.VerticalScrollbarSize = 10;
            this.panel_ID.Visible = false;
            // 
            // ID_pan_C
            // 
            this.ID_pan_C.Controls.Add(this.ID_lab_Controller);
            this.ID_pan_C.Dock = System.Windows.Forms.DockStyle.Left;
            this.ID_pan_C.HorizontalScrollbarBarColor = true;
            this.ID_pan_C.HorizontalScrollbarHighlightOnWheel = false;
            this.ID_pan_C.HorizontalScrollbarSize = 10;
            this.ID_pan_C.Location = new System.Drawing.Point(586, 100);
            this.ID_pan_C.Name = "ID_pan_C";
            this.ID_pan_C.Size = new System.Drawing.Size(341, 412);
            this.ID_pan_C.TabIndex = 6;
            this.ID_pan_C.VerticalScrollbarBarColor = true;
            this.ID_pan_C.VerticalScrollbarHighlightOnWheel = false;
            this.ID_pan_C.VerticalScrollbarSize = 10;
            this.ID_pan_C.Visible = false;
            // 
            // ID_lab_Controller
            // 
            this.ID_lab_Controller.AutoSize = true;
            this.ID_lab_Controller.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID_lab_Controller.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ID_lab_Controller.Location = new System.Drawing.Point(20, 20);
            this.ID_lab_Controller.Name = "ID_lab_Controller";
            this.ID_lab_Controller.Size = new System.Drawing.Size(90, 25);
            this.ID_lab_Controller.Style = MetroFramework.MetroColorStyle.Red;
            this.ID_lab_Controller.TabIndex = 8;
            this.ID_lab_Controller.Text = "Controller";
            this.ID_lab_Controller.UseStyleColors = true;
            // 
            // ID_pan_P
            // 
            this.ID_pan_P.Controls.Add(this.ID_lab_scheda_des);
            this.ID_pan_P.Controls.Add(this.ID_combo_Scheda_P);
            this.ID_pan_P.Controls.Add(this.metroLabel1);
            this.ID_pan_P.Controls.Add(this.ID_lab_Palmare);
            this.ID_pan_P.Dock = System.Windows.Forms.DockStyle.Left;
            this.ID_pan_P.HorizontalScrollbarBarColor = true;
            this.ID_pan_P.HorizontalScrollbarHighlightOnWheel = false;
            this.ID_pan_P.HorizontalScrollbarSize = 10;
            this.ID_pan_P.Location = new System.Drawing.Point(0, 100);
            this.ID_pan_P.Name = "ID_pan_P";
            this.ID_pan_P.Size = new System.Drawing.Size(586, 412);
            this.ID_pan_P.TabIndex = 5;
            this.ID_pan_P.UseCustomBackColor = true;
            this.ID_pan_P.VerticalScrollbarBarColor = true;
            this.ID_pan_P.VerticalScrollbarHighlightOnWheel = false;
            this.ID_pan_P.VerticalScrollbarSize = 10;
            this.ID_pan_P.Visible = false;
            // 
            // ID_lab_scheda_des
            // 
            this.ID_lab_scheda_des.AutoSize = true;
            this.ID_lab_scheda_des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedeBindingSource, "Prod_Descrizione", true));
            this.ID_lab_scheda_des.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_lab_scheda_des.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lab_scheda_des.Location = new System.Drawing.Point(156, 97);
            this.ID_lab_scheda_des.Name = "ID_lab_scheda_des";
            this.ID_lab_scheda_des.Size = new System.Drawing.Size(40, 17);
            this.ID_lab_scheda_des.TabIndex = 12;
            this.ID_lab_scheda_des.Text = "label1";
            // 
            // schedeBindingSource
            // 
            this.schedeBindingSource.DataMember = "Schede";
            this.schedeBindingSource.DataSource = this.dB_FactoryDataSet;
            // 
            // dB_FactoryDataSet
            // 
            this.dB_FactoryDataSet.DataSetName = "DB_FactoryDataSet";
            this.dB_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_combo_Scheda_P
            // 
            this.ID_combo_Scheda_P.DataSource = this.schedeBindingSource;
            this.ID_combo_Scheda_P.DisplayMember = "Prod_Sch";
            this.ID_combo_Scheda_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_combo_Scheda_P.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.ID_combo_Scheda_P.FormattingEnabled = true;
            this.ID_combo_Scheda_P.ItemHeight = 15;
            this.ID_combo_Scheda_P.Location = new System.Drawing.Point(159, 66);
            this.ID_combo_Scheda_P.Name = "ID_combo_Scheda_P";
            this.ID_combo_Scheda_P.Size = new System.Drawing.Size(277, 23);
            this.ID_combo_Scheda_P.TabIndex = 11;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Scheda utilizzata:";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // ID_lab_Palmare
            // 
            this.ID_lab_Palmare.AutoSize = true;
            this.ID_lab_Palmare.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID_lab_Palmare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ID_lab_Palmare.Location = new System.Drawing.Point(20, 20);
            this.ID_lab_Palmare.Name = "ID_lab_Palmare";
            this.ID_lab_Palmare.Size = new System.Drawing.Size(74, 25);
            this.ID_lab_Palmare.Style = MetroFramework.MetroColorStyle.Red;
            this.ID_lab_Palmare.TabIndex = 7;
            this.ID_lab_Palmare.Text = "Palmare";
            this.ID_lab_Palmare.UseCustomBackColor = true;
            this.ID_lab_Palmare.UseStyleColors = true;
            // 
            // ID_pan_Top
            // 
            this.ID_pan_Top.Controls.Add(this.label1);
            this.ID_pan_Top.Controls.Add(this.ID_combo_Famiglia);
            this.ID_pan_Top.Controls.Add(this.titolo_ID);
            this.ID_pan_Top.Controls.Add(this.ID_lab_Famiglia);
            this.ID_pan_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.ID_pan_Top.HorizontalScrollbarBarColor = true;
            this.ID_pan_Top.HorizontalScrollbarHighlightOnWheel = false;
            this.ID_pan_Top.HorizontalScrollbarSize = 10;
            this.ID_pan_Top.Location = new System.Drawing.Point(0, 0);
            this.ID_pan_Top.Name = "ID_pan_Top";
            this.ID_pan_Top.Size = new System.Drawing.Size(737, 100);
            this.ID_pan_Top.TabIndex = 4;
            this.ID_pan_Top.UseCustomBackColor = true;
            this.ID_pan_Top.VerticalScrollbarBarColor = true;
            this.ID_pan_Top.VerticalScrollbarHighlightOnWheel = false;
            this.ID_pan_Top.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // ID_combo_Famiglia
            // 
            this.ID_combo_Famiglia.DataSource = this.famProdBindingSource;
            this.ID_combo_Famiglia.DisplayMember = "Fam_Name";
            this.ID_combo_Famiglia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_combo_Famiglia.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_combo_Famiglia.FormattingEnabled = true;
            this.ID_combo_Famiglia.ItemHeight = 15;
            this.ID_combo_Famiglia.Location = new System.Drawing.Point(159, 68);
            this.ID_combo_Famiglia.Name = "ID_combo_Famiglia";
            this.ID_combo_Famiglia.Size = new System.Drawing.Size(277, 23);
            this.ID_combo_Famiglia.TabIndex = 6;
            this.ID_combo_Famiglia.ValueMember = "Fam_Tipo";
            this.ID_combo_Famiglia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // famProdBindingSource
            // 
            this.famProdBindingSource.DataMember = "Fam_Prod";
            this.famProdBindingSource.DataSource = this.dB_FactoryDataSet;
            this.famProdBindingSource.CurrentChanged += new System.EventHandler(this.famProdBindingSource_CurrentChanged);
            // 
            // titolo_ID
            // 
            this.titolo_ID.AutoSize = true;
            this.titolo_ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titolo_ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.titolo_ID.Location = new System.Drawing.Point(20, 20);
            this.titolo_ID.Name = "titolo_ID";
            this.titolo_ID.Size = new System.Drawing.Size(125, 25);
            this.titolo_ID.Style = MetroFramework.MetroColorStyle.Red;
            this.titolo_ID.TabIndex = 2;
            this.titolo_ID.Text = "Calcolo dell\'ID";
            this.titolo_ID.UseCustomBackColor = true;
            this.titolo_ID.UseStyleColors = true;
            // 
            // ID_lab_Famiglia
            // 
            this.ID_lab_Famiglia.AutoSize = true;
            this.ID_lab_Famiglia.Location = new System.Drawing.Point(20, 68);
            this.ID_lab_Famiglia.Name = "ID_lab_Famiglia";
            this.ID_lab_Famiglia.Size = new System.Drawing.Size(133, 19);
            this.ID_lab_Famiglia.TabIndex = 3;
            this.ID_lab_Famiglia.Text = "Famiglia di prodotto:";
            this.ID_lab_Famiglia.UseCustomBackColor = true;
            // 
            // fam_ProdTableAdapter
            // 
            this.fam_ProdTableAdapter.ClearBeforeFill = true;
            // 
            // schedeTableAdapter
            // 
            this.schedeTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.panel_ID);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Menu);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 83, 23, 28);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sistematica Factory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_ID.ResumeLayout(false);
            this.ID_pan_C.ResumeLayout(false);
            this.ID_pan_C.PerformLayout();
            this.ID_pan_P.ResumeLayout(false);
            this.ID_pan_P.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FactoryDataSet)).EndInit();
            this.ID_pan_Top.ResumeLayout(false);
            this.ID_pan_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panel_Menu;
        private MetroFramework.Controls.MetroTile menu_btn_ID;
        private MetroFramework.Controls.MetroPanel panel_Main;
        private MetroFramework.Controls.MetroPanel panel_ID;
        private MetroFramework.Controls.MetroLabel titolo_ID;
        private MetroFramework.Controls.MetroPanel ID_pan_Top;
        private MetroFramework.Controls.MetroLabel ID_lab_Famiglia;
        private DB_FactoryDataSet dB_FactoryDataSet;
        private System.Windows.Forms.BindingSource famProdBindingSource;
        private DB_FactoryDataSetTableAdapters.Fam_ProdTableAdapter fam_ProdTableAdapter;
        private MetroFramework.Controls.MetroPanel menu_spacer_01;
        private MetroFramework.Controls.MetroPanel ID_pan_C;
        private MetroFramework.Controls.MetroLabel ID_lab_Controller;
        private MetroFramework.Controls.MetroPanel ID_pan_P;
        private MetroFramework.Controls.MetroLabel ID_lab_Palmare;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource schedeBindingSource;
        private DB_FactoryDataSetTableAdapters.SchedeTableAdapter schedeTableAdapter;
        private System.Windows.Forms.ComboBox ID_combo_Famiglia;
        private System.Windows.Forms.ComboBox ID_combo_Scheda_P;
        private System.Windows.Forms.Label ID_lab_scheda_des;
        private System.Windows.Forms.Label label1;
    }
}

