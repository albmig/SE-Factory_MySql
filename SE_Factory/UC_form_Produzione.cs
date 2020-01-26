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
using System.Diagnostics;
using FluentFTP;

namespace SE_Factory
{
    public partial class UC_form_Produzione : UserControl
    {
        public string codice_kit = "";
        public string codice_sistema = "";
        public string codice_fw = "";
        public string codice_fw_fulltmppath = "";
        public string ser_num_read = "";
        public string ser_num_write = "";
        public string ID_code = "";
        public string ID_newcode = "";
        //public string db_prod_SW_path = "";
        //public string db_prod_SW_path_withname = "";
        //public string db_prod_SW_path_w_subfolder = "";
        //public string db_prod_CNF_path_withname = "";
        //public string db_prodotto = "";
        //public string db_sw_selezionato = "";
        //public string device = "--device EFR32MG12P332F1024GL125"; //versione prima scheda
        public string device = "--device EFR32BG13P733F512GM48";   //seconda scheda - forse definitiva
                                                                   //public string UNIQUE_ID = "";
                                                                   //public string UNIQUE_ID_NEW = "";
        public bool Program_OK = true;

        //public byte char_d = 0;
        //public byte char_e = 0;
        //public ushort ID_Reversed = 0;

        //public byte Combine_e(byte a_byte, byte b_byte)
        //{
        //    byte combined = (byte)((a_byte << 4) | b_byte);
        //    return combined;
        //}

        //public byte Combine_d(byte c_byte, byte d_byte)
        //{
        //    byte combined = (byte)((c_byte << 4) | d_byte);
        //    return combined;
        //}

        //public ushort Combine_id(byte id1_byte, byte id2_byte)
        //{
        //    ushort combined = (ushort)((id2_byte << 8) | id1_byte);
        //    return combined;
        //}

        public UC_form_Produzione()
        {
            InitializeComponent();
        }

        private void UC_form_Produzione_Load(object sender, EventArgs e)
        {
            dg_Ordini.Visible = false;
            image_Device.Visible = false;

            this.gC_OrdiniTableAdapter.Fill(this.dB_FactoryDataSet.GC_Ordini);
            this.gC_SerialNumbersTableAdapter.Fill(this.dB_FactoryDataSet.GC_SerialNumbers);

            GVar.CloseSplash = true;

            string ordinamento = "Ord_DATA_RICHIESTA_CONSEGNA ASC, Ord_NUMERO_ORDINE ASC, Ord_NUMERO_RIGA ASC, Ord_CODICE_KIT ASC, Ord_CODICE_SISTEMA ASC";
            gCOrdiniBindingSource.Sort = ordinamento;

            string filtro = "Ord_STATO_ORDINE <> 'C'";
            gCOrdiniBindingSource.Filter = filtro;
            Setting_Form();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Setting_Form()
        {
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

            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].DisplayIndex = 0;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].DisplayIndex = 1;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].DisplayIndex = 2;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].DisplayIndex = 3;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].DisplayIndex = 4;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].DisplayIndex = 5;

            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].HeaderText = "Ragione Sociale";
            dg_Ordini.Columns["ordRAGIONESOCIALEDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].HeaderText = "Tipo Ordine";
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordTIPOORDINECLIENTEDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].HeaderText = "N. Ordine";
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMEROORDINEDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].HeaderText = "Riga";
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordNUMERORIGADataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].HeaderText = "Codice KIT";
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICEKITDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].HeaderText = "Codice DEVICE";
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordCODICESISTEMADataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordDESCRIZIONEDataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordDESCRIZIONEDataGridViewTextBoxColumn"].HeaderText = "Descrizione";
            dg_Ordini.Columns["ordDESCRIZIONEDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].HeaderText = "Data di consegna";
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordDATARICHIESTACONSEGNADataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].HeaderText = "Q.tà Ordinata";
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAORDINATADataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].Visible = true;
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].HeaderText = "Q.tà Evasa";
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_Ordini.Columns["ordQTAEVASADataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //            dg_Ordini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            but_print_again.Visible = false;
        }

        private void gCOrdiniBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            AzzeraLabel();

            if (gCOrdiniBindingSource.Count > 0)
            {
                CaricaImmagine();
                AbilitaPDF();

                FromRecordToDisplay();
            }
        }

        private void CaricaImmagine()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;
            string codsistema = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');

            if (codsistema == "")
            {
                image_Device.Image = null;
                return;
            }

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
            lab_sist.Text = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
            lab_descr_sist.Text = currentRow["Ord_DESCR_SISTEMA"].ToString().TrimEnd(' ');
            lab_descrest_sist.Text = currentRow["Ord_DESCREST_SISTEMA"].ToString().TrimEnd(' ');
            lab_modello.Text = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
            lab_fw.Text = currentRow["Ord_SOFTWARE"].ToString().TrimEnd(' ');
            lab_descr_fw.Text = currentRow["Ord_DESCR_SOFTWARE"].ToString().TrimEnd(' ');
            lab_descrest_fw.Text = currentRow["Ord_DESCREST_SOFTWARE"].ToString().TrimEnd(' ');

            // Pannello Programmazione
            lab_numord_Progr.Text = lab_numord.Text;
            lab_ragsoc_Progr.Text = lab_ragsoc.Text;
            lab_kit_Progr.Text = lab_kit.Text;
            lab_descr_kit_Progr.Text = lab_descr_kit.Text;
            lab_descrest_kit_Progr.Text = lab_descrest_kit.Text;
            lab_sist_Progr.Text = lab_sist.Text;
            lab_descr_sist_Progr.Text = lab_descr_sist.Text;
            lab_descrest_sist_Progr.Text = lab_descrest_sist.Text;
            lab_modello_Progr.Text = lab_modello.Text;
            lab_fw_Progr.Text = lab_fw.Text;
            lab_descr_fw_Progr.Text = lab_descr_fw.Text;
            lab_descrest_fw_Progr.Text = lab_descrest_fw.Text;
            lab_num_progr_Progr.Text= currentRow["Ord_QTA_EVASA"].ToString().TrimEnd(' ');

            //variabili di programma
            codice_kit = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');
            codice_sistema = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
            codice_fw = currentRow["Ord_SOFTWARE"].ToString().TrimEnd(' ');
            ID_code = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
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

        private void Program_Board()
        {
            dos_box.Clear();

            System.Media.SoundPlayer newplayer = new System.Media.SoundPlayer();
            string newsound = ".\\Windows Notify.wav";
            newplayer.SoundLocation = newsound;
            newplayer.Load();
            newplayer.Play();

            ProcessStartInfo psi = new ProcessStartInfo(@"cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            string text_dos = "";

            //Download del Firmware
            codice_fw_fulltmppath = DownloadFirmware(codice_fw);

            //Interrogazione interfaccia
            try
            {
                var proc = Process.Start(psi);

                // Setting "DEBUG MODE"
                proc.StandardInput.WriteLine(Properties.Settings.Default.Path_URL_Commander + @"\commander.exe adapter dbgmode OUT");

                // La riga sottostante è da verificare
                proc.StandardInput.WriteLine(Properties.Settings.Default.Path_URL_Commander + @"\commander.exe device info " + device);
                proc.StandardInput.WriteLine(Properties.Settings.Default.Path_URL_Commander + @"\commander.exe --version");
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = text_dos;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    Program_OK = false;
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {

            }

            // Ricerca delle informazioni

            //Part Number
            if (text_dos.Contains("Part Number    :"))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Part Number    :"))
                    {
                        string linea_PN = dos_box.Lines[i].ToString();
                        lab_PartNumber.Text = linea_PN.Substring(17);
                        break;
                    }
                }
            }

            //Unique ID
            if (text_dos.Contains("Unique ID      :"))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Unique ID      :"))
                    {
                        string linea_ID = dos_box.Lines[i].ToString();
                        lab_IDNumber.Text = linea_ID.Substring(17, 16);
                        ser_num_read = linea_ID.Substring(17, 16);
                        ser_num_write = ConvertiID(ser_num_read);
                        //ser_num_write = GVar.glob_result_id[0].ToString() + GVar.glob_result_id[1].ToString() + GVar.glob_result_id[2].ToString() + GVar.glob_result_id[3].ToString() +
                        //                lab_IDNumber.Text.Substring(0, 6) + lab_IDNumber.Text.Substring(10, 6);
                        break;
                    }
                }
            }

            //Serial Number
            if (text_dos.Contains("Emulator found with SN="))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Emulator found with SN="))
                    {
                        string linea_SN = dos_box.Lines[i].ToString();
                        lab_SN.Text = linea_SN.Substring(23, 9);
                        break;
                    }
                }
            }

            //Inserimento firmware
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash " + codice_fw_fulltmppath + " --address 0x0 " + device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    Program_OK = false;
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {

            }

            //Verifica
            try
            {
                var proc = Process.Start(psi);

                string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe verify " + codice_fw_fulltmppath + " " + device;
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;
                dos_box.Refresh();

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    Program_OK = false;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {

            }

            //Scrittura ID
            try
            {
                string coppia_1 = ID_code.Substring(0, 2);
                string coppia_2 = ID_code.Substring(2, 2);

                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash --patch 0x0fe00000:0x0068:2" + " " + device;
                string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash --patch 0x0fe00000:0x" + coppia_2 + coppia_1 + ":2" + " " + device;
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    Program_OK = false;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {

            }

            but_print_again.Visible = true;

            PrintLabel();
        }

        private void AzzeraLabel()
        {
            lab_numord.Text = "";
            lab_ragsoc.Text = "";
            lab_kit.Text = "";
            lab_descr_kit.Text = "";
            lab_descrest_kit.Text = "";
            lab_sist.Text = "";
            lab_descr_sist.Text = "";
            lab_descrest_sist.Text = "";
            lab_modello.Text = "";
            lab_fw.Text = "";
            lab_descr_fw.Text = "";
            lab_descrest_fw.Text = "";

            // Pannello Programmazione
            lab_numord_Progr.Text = lab_numord.Text;
            lab_ragsoc_Progr.Text = lab_ragsoc.Text;
            lab_kit_Progr.Text = lab_kit.Text;
            lab_descr_kit_Progr.Text = lab_descr_kit.Text;
            lab_descrest_kit_Progr.Text = lab_descrest_kit.Text;
            lab_sist_Progr.Text = lab_sist.Text;
            lab_descr_sist_Progr.Text = lab_descr_sist.Text;
            lab_descrest_sist_Progr.Text = lab_descrest_sist.Text;
            lab_modello_Progr.Text = lab_modello.Text;
            lab_fw_Progr.Text = lab_fw.Text;
            lab_descr_fw_Progr.Text = lab_descr_fw.Text;
            lab_descrest_fw_Progr.Text = lab_descrest_fw.Text;
            lab_num_progr_Progr.Text = "0";

            //variabili di programma
            codice_kit = "";
            codice_sistema = "";
            codice_fw = "";
            ID_code = "";

            lab_PartNumber.Text = "";
            lab_IDNumber.Text = "";
            lab_SN.Text = "";

            btn_pdfview.Visible = false;
        }

        private void but_print_again_Click(object sender, EventArgs e)
        {
            PrintLabel();
        }

        private void PrintLabel()
        {
            //Stampa Etichetta
            if (!Properties.Settings.Default.IP_Printer_alwaysprint)
            {
                return;
            }

            /* Create Object Instance */
            string tmp_file = @".\SL_label.txt";
            string text = "";

            // Stampa QRCode e codici su etichette gialle
            text = text + "m m" + "\r";
            text = text + "J" + "\r";
            text = text + "H 100" + "\r";
            text = text + "S l1;0,0,13,16,35" + "\r";
            text = text + "B 1,1,0,QRCODE,0.25;" + ser_num_write + "\r";
            text = text + "T 9,2,0,3,pt7; " + codice_kit + "\r";
            text = text + "T 9,5,0,3,pt7; " + codice_sistema + "\r";
            text = text + "T 9,8,0,3,pt7; " + codice_fw + "\r";
            text = text + "T 9,11,0,3,pt7; " + ser_num_write + "\r";
            text = text + "A 1" + "\r";
            // fine Etichette gialle

            //Etichette gialle
            //text = text + "m m" + "\r";
            //text = text + "J" + "\r";
            //text = text + "H 100" + "\r";
            //text = text + "S l1;0,0,13,16,35" + "\r";
            ////string new_lab_ID = lab_IDNumber.Text.Substring(0, 5) + GVar.glob_result_id[0] + GVar.glob_result_id[1] + GVar.glob_result_id[2] + GVar.glob_result_id[3] + lab_IDNumber.Text.Substring(9, 7);

            //text = text + "B 0,0,0,QRCODE,0.25;" + ser_num_write + "\r";
            //text = text + "T 12,2,0,3,pt7,q80; " + codice_fw + "\r";
            //text = text + "T 12,6,0,3,pt7,q80; " + ser_num_read + "\r";
            //text = text + "T 12,10,0,3,pt7,q80; " + ser_num_write + "\r";

            //text = text + "I 7,0,0,1,1,a;LogoSE" + "\r";
            //text = text + "A 1" + "\r";
            // fine Etichette gialle

            //Doppia etichetta piccola bianca - Software
            //text = text + "m m" + "\r";
            //text = text + "J" + "\r";
            //text = text + "H 100" + "\r";
            ////text = text + "S l1;0,0,7,9,20,3,2" + "\r";
            //text = text + "S l1;0,0,7,9,20,23,2" + "\r";
            //text = text + "B 1,0,0,QRCODE,0.25;" + ser_num_write + "\r";
            //text = text + "T 6,2,0,5,pt7,q60; " + codice_fw + "\r";
            ////text = text + "T 12,6,0,3,pt7,q80; " + lab_IDNumber.Text + "\r";
            //text = text + "T 6,5,0,5,pt7,q60; " + ser_num_write + "\r";

            ////text = text + "I 7,0,0,1,1,a;LogoSE" + "\r";
            //text = text + "A 2" + "\r";


            File.Delete(tmp_file);

            if (!File.Exists(tmp_file))
            {
                using (var txtFile = File.AppendText(tmp_file))
                {
                    txtFile.WriteLine(text);
                }
            }
            else if (File.Exists(tmp_file))
            {
                using (var txtFile = File.AppendText(tmp_file))
                {
                    txtFile.WriteLine(text);
                }
            }

            // create an FTP client
            string ipprinter = Properties.Settings.Default.IP_Printer.ToString();
            FtpClient client = new FtpClient(ipprinter);
            client.Credentials = new NetworkCredential("ftpprint", "print");
            client.Connect();
            // upload a file and retry 3 times before giving up
            client.RetryAttempts = 3;
            client.UploadFile(tmp_file, "/SL_label.txt", FtpRemoteExists.Overwrite, true, FtpVerify.Retry);
            client.Disconnect();

            //File.Delete(tmp_file);

            but_Programma.BackColor = Color.LightGreen;
        }

        private void but_Programma_Click(object sender, EventArgs e)
        {
            Program_OK = true;
            Program_Board();
            if (Program_OK)
            {
                AggiornaSN();
                AggiornaOrdini();
            }
        }

        private string DownloadFirmware(string codfw)
        {
            bool documentotrovato = true;
            //Carica immagine scheda
            string pathFW = Properties.Settings.Default.Path_URL_Software;
            char last = pathFW[pathFW.Length - 1];
            if (last != '/') { pathFW = pathFW + '/'; }
            pathFW = pathFW + codfw + "/";
            pathFW = pathFW + codfw + ".s37";
            string tmpfolder = GFunc.TempFolder();
            string windowsTempPath = tmpfolder + codfw + ".s37";

            using (var client = new WebClient())
            {
                try { client.DownloadFile(pathFW, windowsTempPath); }
                catch (WebException ex) { documentotrovato = false; }
            }

            if (documentotrovato) { return windowsTempPath; } else { return ""; }
        }

        private string ConvertiID(string ID)
        {
            string id_write = "";
            id_write = ID_code;
            id_write = id_write + ID.Substring(0, 6) + ID.Substring(10, 6);
            return id_write;
        }

        private void AggiornaSN()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;

            //Verifica se record già presente.
            string filtro = "Ser_ReadSerial = " + "'" + ser_num_read + "'";
            DataRow[] DBF_row = dB_FactoryDataSet.GC_SerialNumbers.Select(filtro);
            if (DBF_row.Count() == 0) // Nessun serial trovato
            {
                DataRow DBF_newrow = dB_FactoryDataSet.GC_SerialNumbers.NewRow();
                DBF_newrow["Ser_Kit"] = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');
                DBF_newrow["Ser_ID_Cli"] = (int)currentRow["Ord_Id_Cli"];
                DBF_newrow["Ser_Device"] = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
                DBF_newrow["Ser_Device_ID_Code"] = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
                DBF_newrow["Ser_OfficialSerial"] = ser_num_write;
                DBF_newrow["Ser_ReadSerial"] = ser_num_read;
                DBF_newrow["Ser_SW_Code"] = currentRow["Ord_SOFTWARE"].ToString().TrimEnd(' ');
                DBF_newrow["Ser_DateProduction"] = DateTime.Today;
                DBF_newrow["Ser_Commessa"] = lab_numord.Text;
                string modello = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
                char ident = modello[0];
                DBF_newrow["Ser_FamProd_ID_HEX"] = ident;
                DBF_newrow["Ser_HW_Compatible"] = "";
                dB_FactoryDataSet.GC_SerialNumbers.Rows.Add(DBF_newrow);
                this.gC_SerialNumbersTableAdapter.Update(DBF_newrow);
            }
            else
            {
                for (int i = 0; i < DBF_row.Length; i++)
                {
                    DBF_row[i].SetModified();
                    DBF_row[i].BeginEdit();
                    DBF_row[i]["Ser_Kit"] = currentRow["Ord_CODICE_KIT"].ToString().TrimEnd(' ');
                    DBF_row[i]["Ser_ID_Cli"] = (int)currentRow["Ord_Id_Cli"];
                    DBF_row[i]["Ser_Device"] = currentRow["Ord_CODICE_SISTEMA"].ToString().TrimEnd(' ');
                    DBF_row[i]["Ser_Device_ID_Code"] = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
                    DBF_row[i]["Ser_OfficialSerial"] = ser_num_write;
                    DBF_row[i]["Ser_ReadSerial"] = ser_num_read;
                    DBF_row[i]["Ser_SW_Code"] = currentRow["Ord_SOFTWARE"].ToString().TrimEnd(' ');
                    DBF_row[i]["Ser_DateProduction"] = DateTime.Today;
                    DBF_row[i]["Ser_Commessa"] = lab_numord.Text;
                    string modello = currentRow["Ord_MODELLO"].ToString().TrimEnd(' ');
                    char ident = modello[0];
                    DBF_row[i]["Ser_FamProd_ID_HEX"] = ident;
                    DBF_row[i]["Ser_HW_Compatible"] = "";
                    DBF_row[i].EndEdit();
                    try
                    {
                        this.gC_SerialNumbersTableAdapter.Update(DBF_row);
                        dB_FactoryDataSet.GC_SerialNumbers.AcceptChanges();
                        this.gC_SerialNumbersTableAdapter.Update(DBF_row);
                    }
                    catch (DBConcurrencyException exc) { MessageBox.Show("aa"); }
                }
            }
            dB_FactoryDataSet.GC_SerialNumbers.AcceptChanges();
        }

        private void AggiornaOrdini()
        {
            DataRow currentRow = ((DataRowView)gCOrdiniBindingSource.Current).Row;

            currentRow.SetModified();
            currentRow.BeginEdit();
            int qtaev = (int)currentRow["Ord_QTA_EVASA"];
            qtaev++;
            currentRow["Ord_QTA_EVASA"] = qtaev;
            currentRow.EndEdit();
            try
            {
                this.gC_OrdiniTableAdapter.Update(currentRow);
                dB_FactoryDataSet.GC_Ordini.AcceptChanges();
                this.gC_OrdiniTableAdapter.Update(currentRow);
            }
            catch (DBConcurrencyException exc) { MessageBox.Show("aa"); }

        }

        private void fineProgrammazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produzione_Progr_Layout.Visible = false;
            Produzione_Sel_Layout.Visible = true;
        }
    }
}
