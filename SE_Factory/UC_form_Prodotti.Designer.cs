namespace SE_Factory
{
    partial class UC_form_Prodotti
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
            this.ID_pan_Top = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ID_pan_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_pan_Top
            // 
            this.ID_pan_Top.Controls.Add(this.metroLabel1);
            this.ID_pan_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.ID_pan_Top.HorizontalScrollbarBarColor = true;
            this.ID_pan_Top.HorizontalScrollbarHighlightOnWheel = false;
            this.ID_pan_Top.HorizontalScrollbarSize = 10;
            this.ID_pan_Top.Location = new System.Drawing.Point(0, 0);
            this.ID_pan_Top.Name = "ID_pan_Top";
            this.ID_pan_Top.Size = new System.Drawing.Size(800, 60);
            this.ID_pan_Top.TabIndex = 6;
            this.ID_pan_Top.UseCustomBackColor = true;
            this.ID_pan_Top.VerticalScrollbarBarColor = true;
            this.ID_pan_Top.VerticalScrollbarHighlightOnWheel = false;
            this.ID_pan_Top.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Archivio Prodotti";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // UC_form_Prodotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID_pan_Top);
            this.Name = "UC_form_Prodotti";
            this.Size = new System.Drawing.Size(800, 466);
            this.ID_pan_Top.ResumeLayout(false);
            this.ID_pan_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ID_pan_Top;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
