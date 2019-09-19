namespace SE_Factory
{
    partial class UC_form_Printers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_form_Printers));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.IP_Label = new MetroFramework.Controls.MetroLabel();
            this.tb_IP_printer_addr = new System.Windows.Forms.MaskedTextBox();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_sw_div11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_SW_Titolo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.toggle_always_print = new MetroFramework.Controls.MetroToggle();
            this.tableLayoutPanel2.SuspendLayout();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.pan_SW_Titolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.IP_Label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_IP_printer_addr, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pan_Menu_comandi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pan_Menu_salva, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.pan_Menu_exit, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.pan_SW_Titolo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.toggle_always_print, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // IP_Label
            // 
            this.IP_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IP_Label.AutoSize = true;
            this.IP_Label.BackColor = System.Drawing.Color.Transparent;
            this.IP_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.IP_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IP_Label.Location = new System.Drawing.Point(3, 73);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(102, 19);
            this.IP_Label.TabIndex = 4;
            this.IP_Label.Text = "IP Stampante:";
            this.IP_Label.UseCustomBackColor = true;
            this.IP_Label.UseCustomForeColor = true;
            // 
            // tb_IP_printer_addr
            // 
            this.tb_IP_printer_addr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_IP_printer_addr.Location = new System.Drawing.Point(123, 71);
            this.tb_IP_printer_addr.Mask = "000,000,000,000";
            this.tb_IP_printer_addr.Name = "tb_IP_printer_addr";
            this.tb_IP_printer_addr.Size = new System.Drawing.Size(100, 23);
            this.tb_IP_printer_addr.TabIndex = 58;
            this.tb_IP_printer_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.SetColumnSpan(this.pan_Menu_comandi, 6);
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 28);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(720, 20);
            this.pan_Menu_comandi.TabIndex = 21;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.SetColumnSpan(this.pan_Menu_salva, 3);
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_div11,
            this.menu_sw_salva,
            this.menu_sw_div12,
            this.menu_sw_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(720, 28);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(360, 20);
            this.pan_Menu_salva.TabIndex = 56;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // menu_sw_div11
            // 
            this.menu_sw_div11.Enabled = false;
            this.menu_sw_div11.Name = "menu_sw_div11";
            this.menu_sw_div11.ShowShortcutKeys = false;
            this.menu_sw_div11.Size = new System.Drawing.Size(22, 16);
            this.menu_sw_div11.Text = "|";
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
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1080, 28);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(120, 20);
            this.pan_Menu_exit.TabIndex = 57;
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
            // menu_sw_exit
            // 
            this.menu_sw_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_exit.Image")));
            this.menu_sw_exit.Name = "menu_sw_exit";
            this.menu_sw_exit.Size = new System.Drawing.Size(67, 16);
            this.menu_sw_exit.Text = "Uscita";
            this.menu_sw_exit.Click += new System.EventHandler(this.menu_sw_exit_Click);
            // 
            // pan_SW_Titolo
            // 
            this.pan_SW_Titolo.Controls.Add(this.metroLabel21);
            this.pan_SW_Titolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_SW_Titolo.HorizontalScrollbarBarColor = true;
            this.pan_SW_Titolo.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_SW_Titolo.HorizontalScrollbarSize = 10;
            this.pan_SW_Titolo.Location = new System.Drawing.Point(3, 3);
            this.pan_SW_Titolo.Name = "pan_SW_Titolo";
            this.pan_SW_Titolo.Size = new System.Drawing.Size(114, 22);
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
            this.metroLabel21.Size = new System.Drawing.Size(268, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Settaggio IP Stampante Barcode";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseStyleColors = true;
            // 
            // toggle_always_print
            // 
            this.toggle_always_print.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toggle_always_print.AutoSize = true;
            this.toggle_always_print.Location = new System.Drawing.Point(243, 74);
            this.toggle_always_print.Name = "toggle_always_print";
            this.toggle_always_print.Size = new System.Drawing.Size(80, 17);
            this.toggle_always_print.TabIndex = 59;
            this.toggle_always_print.Text = "Off";
            this.toggle_always_print.UseSelectable = true;
            // 
            // UC_form_Printers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UC_form_Printers";
            this.Size = new System.Drawing.Size(1200, 1200);
            this.Load += new System.EventHandler(this.UC_form_Printers_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.pan_SW_Titolo.ResumeLayout(false);
            this.pan_SW_Titolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel pan_SW_Titolo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div11;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_annulla;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroLabel IP_Label;
        private System.Windows.Forms.MaskedTextBox tb_IP_printer_addr;
        private MetroFramework.Controls.MetroToggle toggle_always_print;
    }
}
