using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SE_Factory
{
    public partial class UC_form_Produzione : UserControl
    {
        public UC_form_Produzione()
        {
            InitializeComponent();
        }

        private void UC_form_Produzione_Load(object sender, EventArgs e)
        {
            dg_Ordini.Visible = false;
            image_Device.Visible = false;

            this.gC_OrdiniTableAdapter.Fill(this.dB_FactoryDataSet.GC_Ordini);
            GVar.CloseSplash = true;

            string ordinamento = "Ord_DATA_RICHIESTA_CONSEGNA ASC, Ord_NUMERO_ORDINE ASC, Ord_NUMERO_RIGA ASC, Ord_CODICE_KIT ASC, Ord_CODICE_SISTEMA ASC";
            gCOrdiniBindingSource.Sort = ordinamento;
            Setting_Form();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Setting_Form()
        {
            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].DisplayIndex = 0;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].DisplayIndex = 1;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].DisplayIndex = 2;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].DisplayIndex = 3;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].DisplayIndex = 4;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].DisplayIndex = 5;

            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].HeaderText = "Ragione Sociale";

            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].HeaderText = "Tipo Ordine";
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].HeaderText = "N. Ordine";
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].HeaderText = "Riga";
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].HeaderText = "Codice KIT";
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].HeaderText = "Codice DEVICE";
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordDESCRIZIONEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordDESCRIZIONEDataGridViewTextBoxColumn"].HeaderText = "Descrizione";

            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].HeaderText = "Data di consegna";
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].HeaderText = "Q.tà Ordinata";
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].HeaderText = "Q.tà Evasa";
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg_Ordini.Columns["idDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordIdCliDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDATACONFERMACONSEGNADataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordUMDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordQTAORDINATAKITDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordSOFTWAREDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRKITDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRESTKITDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRSISTEMADataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRESTSISTEMADataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordMODELLODataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRSOFTWAREDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordDESCRESTSOFTWAREDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordSTATOORDINEDataGridViewTextBoxColumn"].Visible = false;
            dg_Ordini.Columns["ordPROGPROGRAMMAZIONIDataGridViewTextBoxColumn"].Visible = false;

            dg_Ordini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dg_Ordini.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dg_Ordini.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dg_Ordini.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dg_Ordini.GridColor = Color.Silver;

            Produzione_Sel_Layout.Visible = true;
            Produzione_Progr_Layout.Visible = false;
            dg_Ordini.Visible = true;
            image_Device.Visible = true;
            btn_pdfview.Visible = true;
            panel_dati.Visible = true;
            panel_dati_2.Visible = true;
        }

        private void gCOrdiniBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CaricaImmagine();
            AbilitaPDF();

            FromRecordToDisplay();
        }

        private void CaricaImmagine()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;
            string codsistema = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
            //Carica immagine scheda
            string pathimage = Properties.Settings.Default.Path_URL_Images;
            char last = pathimage[pathimage.Length - 1];
            if (last != '/') { pathimage = pathimage + '/'; }
            pathimage = pathimage + codsistema + '/';

            if (GFunc.isPalm(codsistema)) { pathimage = pathimage + codsistema + "_Full.jpg"; }
            if (GFunc.isCntr(codsistema)) { pathimage = pathimage + codsistema + ".jpg"; }

            var request = WebRequest.Create(pathimage);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                image_Device.Image = Bitmap.FromStream(stream);
            }
        }

        private void AbilitaPDF()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;
            string kit = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');
            if (kit != "") { btn_pdfview.Visible = true; } else { btn_pdfview.Visible = false; }
        }

        private void btn_pdfview_Click(object sender, EventArgs e)
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;
            string codkit = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');

            if (!CaricaPDFIta(codkit) && !CaricaPDFEn(codkit)) { MessageBox.Show("Documento PDF non trovato!"); }
        }

        private bool CaricaPDFIta(string codkit)
        {
            bool documentotrovato = true;
            //Carica immagine scheda
            string pathpdf = Properties.Settings.Default.Path_URL_Documentazione;
            char last = pathpdf[pathpdf.Length - 1];
            if (last != '/') { pathpdf = pathpdf + '/'; }
            pathpdf = pathpdf + codkit;
            pathpdf = pathpdf + "/it/";
            pathpdf = pathpdf + codkit + ".pdf";
            string tmpfolder = GFunc.TempFolder();
            string windowsTempPath = tmpfolder + codkit + ".pdf";

            using (var client = new WebClient())
            {
                try { client.DownloadFile(pathpdf, windowsTempPath); }
                catch (WebException ex) { documentotrovato = false; }
            }

            if (documentotrovato)
            {
                Win_form_PDF form_pdf = new Win_form_PDF(windowsTempPath);
                form_pdf.Visible = true;
                return true;
            }
            else { return false; }
        }

        private bool CaricaPDFEn(string codkit)
        {
            bool documentotrovato = true;
            //Carica immagine scheda
            string pathpdf = Properties.Settings.Default.Path_URL_Documentazione;
            char last = pathpdf[pathpdf.Length - 1];
            if (last != '/') { pathpdf = pathpdf + '/'; }
            pathpdf = pathpdf + codkit;
            pathpdf = pathpdf + "/en/";
            pathpdf = pathpdf + codkit + ".pdf";
            string tmpfolder = GFunc.TempFolder();
            string windowsTempPath = tmpfolder + codkit + ".pdf";

            using (var client = new WebClient())
            {
                try { client.DownloadFile(pathpdf, windowsTempPath); }
                catch (WebException ex) { documentotrovato = false; }
            }

            if (documentotrovato)
            {
                Win_form_PDF form_pdf = new Win_form_PDF(windowsTempPath);
                form_pdf.Visible = true;
                return true;
            }
            else { return false; }
        }

        private void FromRecordToDisplay()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;
            lab_numord.Text = currentRow["Ord_NUMERO_ORDINE"].ToString().TrimEnd(' ') + "/" +
                              currentRow["Ord_TIPO_ORDINE_CLIENTE"].ToString().TrimEnd(' ') + "-" +
                              currentRow["Ord_NUMERO_RIGA"].ToString().TrimEnd(' ').PadLeft(5, '0');

            lab_ragsoc.Text = currentRow["Ord_RAGIONE_SOCIALE"].ToString().TrimEnd(' ');
            lab_kit.Text = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');
            lab_descr_kit.Text = currentRow["Ord_DESCR_KIT"].ToString().TrimEnd(' ');
            lab_descrest_kit.Text = currentRow["Ord_DESCREST_KIT"].ToString().TrimEnd(' ');
            lab_sist.Text= currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
            lab_descr_sist.Text = currentRow["Ord_DESCR_SISTEMA"].ToString().TrimEnd(' ');
            lab_descrest_sist.Text = currentRow["Ord_DESCREST_SISTEMA"].ToString().TrimEnd(' ');
            lab_modello.Text= currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
            lab_fw.Text = currentRow["Ord_SOFTWARE"].ToString().TrimEnd(' ');
            lab_descr_fw.Text = currentRow["Ord_DESCR_SOFTWARE"].ToString().TrimEnd(' ');
            lab_descrest_fw.Text = currentRow["Ord_DESCREST_SOFTWARE"].ToString().TrimEnd(' ');

        }

        private void aggiornaDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Processing ProcSplash = new Processing();
            ProcSplash.Show();

            System.Threading.Thread.Sleep(10000);
            GVar.CloseSplash = true;
        }

        private void btn_Prog_Window_Click(object sender, EventArgs e)
        {
            Produzione_Sel_Layout.Visible = false;
            Produzione_Progr_Layout.Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Produzione_Progr_Layout.Visible = false;
            Produzione_Sel_Layout.Visible = true;
        }
    }
}
