namespace SE_Factory
{
    partial class New_Form_SW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Form_SW));
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.SW_lab_codice_SW = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.tbox_Sw_name = new System.Windows.Forms.MaskedTextBox();
            this.tbox_Sw_version = new System.Windows.Forms.MaskedTextBox();
            this.tbox_Sw_frequency = new System.Windows.Forms.MaskedTextBox();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_sw_div11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lab_old_codice = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(395, 137);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(22, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "_L";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // SW_lab_codice_SW
            // 
            this.SW_lab_codice_SW.AutoSize = true;
            this.SW_lab_codice_SW.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SW_lab_codice_SW.Location = new System.Drawing.Point(23, 137);
            this.SW_lab_codice_SW.Name = "SW_lab_codice_SW";
            this.SW_lab_codice_SW.Size = new System.Drawing.Size(155, 19);
            this.SW_lab_codice_SW.Style = MetroFramework.MetroColorStyle.Red;
            this.SW_lab_codice_SW.TabIndex = 14;
            this.SW_lab_codice_SW.Text = "Nuovo Codice Software:";
            this.SW_lab_codice_SW.UseCustomBackColor = true;
            this.SW_lab_codice_SW.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(184, 137);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(49, 19);
            this.metroLabel21.TabIndex = 15;
            this.metroLabel21.Text = "XSWR";
            this.metroLabel21.UseCustomBackColor = true;
            // 
            // tbox_Sw_name
            // 
            this.tbox_Sw_name.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.tbox_Sw_name.Location = new System.Drawing.Point(235, 135);
            this.tbox_Sw_name.Mask = ">AAAAA";
            this.tbox_Sw_name.Name = "tbox_Sw_name";
            this.tbox_Sw_name.Size = new System.Drawing.Size(44, 23);
            this.tbox_Sw_name.TabIndex = 16;
            this.tbox_Sw_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Sw_version
            // 
            this.tbox_Sw_version.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.tbox_Sw_version.Location = new System.Drawing.Point(290, 135);
            this.tbox_Sw_version.Mask = ">AAA";
            this.tbox_Sw_version.Name = "tbox_Sw_version";
            this.tbox_Sw_version.Size = new System.Drawing.Size(44, 23);
            this.tbox_Sw_version.TabIndex = 17;
            this.tbox_Sw_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Sw_frequency
            // 
            this.tbox_Sw_frequency.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.tbox_Sw_frequency.Location = new System.Drawing.Point(345, 135);
            this.tbox_Sw_frequency.Mask = ">&";
            this.tbox_Sw_frequency.Name = "tbox_Sw_frequency";
            this.tbox_Sw_frequency.Size = new System.Drawing.Size(44, 23);
            this.tbox_Sw_frequency.TabIndex = 18;
            this.tbox_Sw_frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_div11,
            this.menu_sw_salva,
            this.menu_sw_div12,
            this.menu_sw_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(0, 0);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(420, 24);
            this.pan_Menu_salva.TabIndex = 56;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // menu_sw_div11
            // 
            this.menu_sw_div11.Enabled = false;
            this.menu_sw_div11.Name = "menu_sw_div11";
            this.menu_sw_div11.ShowShortcutKeys = false;
            this.menu_sw_div11.Size = new System.Drawing.Size(22, 20);
            this.menu_sw_div11.Text = "|";
            // 
            // menu_sw_salva
            // 
            this.menu_sw_salva.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_salva.Image")));
            this.menu_sw_salva.Name = "menu_sw_salva";
            this.menu_sw_salva.Size = new System.Drawing.Size(62, 20);
            this.menu_sw_salva.Text = "Salva";
            // 
            // menu_sw_div12
            // 
            this.menu_sw_div12.Enabled = false;
            this.menu_sw_div12.Name = "menu_sw_div12";
            this.menu_sw_div12.ShowShortcutKeys = false;
            this.menu_sw_div12.Size = new System.Drawing.Size(22, 20);
            this.menu_sw_div12.Text = "|";
            // 
            // menu_sw_annulla
            // 
            this.menu_sw_annulla.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_annulla.Image")));
            this.menu_sw_annulla.Name = "menu_sw_annulla";
            this.menu_sw_annulla.Size = new System.Drawing.Size(76, 20);
            this.menu_sw_annulla.Text = "Annulla";
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(420, 0);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(140, 24);
            this.pan_Menu_exit.TabIndex = 57;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pan_Menu_salva, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pan_Menu_exit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 25);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "Crea revisione da:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lab_old_codice
            // 
            this.lab_old_codice.AutoSize = true;
            this.lab_old_codice.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_old_codice.Location = new System.Drawing.Point(184, 103);
            this.lab_old_codice.Name = "lab_old_codice";
            this.lab_old_codice.Size = new System.Drawing.Size(117, 19);
            this.lab_old_codice.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_old_codice.TabIndex = 60;
            this.lab_old_codice.Text = "Crea revisione da:";
            this.lab_old_codice.UseCustomBackColor = true;
            this.lab_old_codice.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // New_Form_SW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_old_codice);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.SW_lab_codice_SW);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.tbox_Sw_name);
            this.Controls.Add(this.tbox_Sw_version);
            this.Controls.Add(this.tbox_Sw_frequency);
            this.Name = "New_Form_SW";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "New_Form_SW";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.New_Form_SW_Load);
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel SW_lab_codice_SW;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MaskedTextBox tbox_Sw_name;
        private System.Windows.Forms.MaskedTextBox tbox_Sw_version;
        private System.Windows.Forms.MaskedTextBox tbox_Sw_frequency;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div11;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_annulla;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lab_old_codice;
        private System.Windows.Forms.Button button1;
    }
}