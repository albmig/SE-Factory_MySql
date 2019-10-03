using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using FluentFTP;
using System.Diagnostics;


namespace SE_Factory
{
    public partial class UC_form_Gecko : UserControl
    {
        public string db_prod_SW_path = "";
        public string db_prod_SW_path_withname = "";
        public string db_prod_SW_path_w_subfolder = "";
        public string db_prod_CNF_path_withname = "";
        public string db_prodotto = "";
        public string db_sw_selezionato = "";
        public string device = "--device EFR32MG12P332F1024GL125"; //versione prima scheda
        //public string device = "--device EFR32BG13P733F512GM48";   //seconda scheda - forse definitiva
        public string UNIQUE_ID = "";
        public string UNIQUE_ID_NEW = "";



        public UC_form_Gecko()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UC_form_Gecko_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Schede'. È possibile spostarla o rimuoverla se necessario.
            this.schedeTableAdapter.Fill(this.dB_FactoryDataSet.local_Schede);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.dB_FactoryDataSet.local_Fam_Prod);
        }

        private void famProdBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            {
                schedeBindingSource.Filter = "";
                P_sch_image.Image = null;
                C_sch_image.Image = null;
                if (famProdBindingSource.Current != null)
                {
                    DataRow currentRow = ((DataRowView)famProdBindingSource.Current).Row;

                    GVar.glob_tipo_item = currentRow["Fam_Tipo"].ToString();
                    GVar.glob_hex_id = currentRow["Fam_Hex_ID"].ToString();
                    GVar.glob_result_id[0] = Convert.ToChar(currentRow["Fam_Hex_ID"]);

                    if (GVar.glob_tipo_item == "P")
                    {
                        ID_pan_C.Visible = false;
                        ID_pan_P.Visible = true;

                        schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
                    }
                    if (GVar.glob_tipo_item == "C")
                    {
                        ID_pan_P.Visible = false;
                        ID_pan_C.Visible = true;

                        schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
                    }
                }
            }
        }

        private void schedeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ID_radio_868_P.Checked = true;
            ID_radio_868_C.Checked = true;

            //Azzero Palmari
            ID_toggle_Display.Checked = false;
            ID_toggle_Accel.Checked = false;
            ID_toggle_SP.Checked = false;
            ID_toggle_Buzzer.Checked = false;
            ID_toggle_Vibracall.Checked = false;
            ID_toggle_Torcia.Checked = false;
            ID_toggle_Fungo.Checked = false;
            ID_toggle_Display.Enabled = false;
            ID_toggle_Accel.Enabled = false;

            //Azzero Controller
            ID_toggle_PlugExp.Checked = false;
            ID_toggle_PlugPLE.Checked = false;
            ID_toggle_TastEmerg.Checked = false;
            ID_toggle_GuidaLuce.Checked = false;
            ID_toggle_AntExt.Checked = false;
            ID_toggle_CanBus.Checked = false;
            ID_toggle_Prop.Checked = false;

            DataRow currentRow = ((DataRowView)schedeBindingSource.Current).Row;

            if (GVar.glob_tipo_item == "P")
            {
                lab_Des_Scheda_P.Text = currentRow["Prod_Descrizione"].ToString();

                switch (currentRow["Prod_Sch"])
                {
                    case "XSCHSE371PXX": //Easy SmartLine Display - Completa - retroilluminazione, accelerometro, display
                        ID_toggle_Display.Checked = true;
                        ID_toggle_Accel.Checked = true;
                        break;
                    case "XSCHSE371PAX": //Easy SmartLine - Retroilluminazione, accelerometro
                        ID_toggle_Accel.Checked = true;
                        break;
                    case "XSCHSE371PBX": //Easy SmartLine - Solo retroilluminazione
                        break;
                    case "XSCHSE381PXX": //Trend SmartLine Display - Completa - retroilluminazione, accelerometro, display
                        ID_toggle_Display.Checked = true;
                        ID_toggle_Accel.Checked = true;
                        break;
                    case "XSCHSE381PAX": //Trend SmartLine - Retroilluminazione, accelerometro
                        ID_toggle_Accel.Checked = true;
                        break;
                    case "XSCHSE381PBX": //Trend SmartLine - Solo retroilluminazione
                        break;
                    default:
                        break;
                }

                //Carica immagine scheda
                var request = WebRequest.Create(currentRow["Prod_Image_Url"].ToString());

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    P_sch_image.Image = Bitmap.FromStream(stream);
                }
            }

            if (GVar.glob_tipo_item == "C")
            {
                lab_Des_Scheda_C.Text = currentRow["Prod_Descrizione"].ToString();
                //Carica immagine scheda
                var request = WebRequest.Create(currentRow["Prod_Image_Url"].ToString());

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    C_sch_image.Image = Bitmap.FromStream(stream);
                }
            }
        }

        private void ID_toggle_Buzzer_CheckStateChanged(object sender, EventArgs e)
        {
            if (ID_toggle_Buzzer.Checked == true)
            {
                ID_toggle_Vibracall.Checked = false;
                ID_toggle_Torcia.Checked = false;
            }
        }

        private void ID_toggle_Vibracall_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_toggle_Vibracall.Checked == true)
            {
                ID_toggle_Buzzer.Checked = false;
                ID_toggle_Torcia.Checked = false;
            }
        }

        private void ID_toggle_Torcia_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_toggle_Torcia.Checked == true)
            {
                ID_toggle_Buzzer.Checked = false;
                ID_toggle_Vibracall.Checked = false;
            }
        }

        private void Calcola_ID_Palmare()
        {
            if (GVar.glob_tipo_item == "P")
            {
                Array.Clear(GVar.glob_bin_id, 0, 12);
                if (ID_radio_868_P.Checked) { GVar.glob_bin_id[0] = '1'; } else { GVar.glob_bin_id[0] = '0'; }
                if (ID_radio_915_P.Checked) { GVar.glob_bin_id[1] = '1'; } else { GVar.glob_bin_id[1] = '0'; }
                if (ID_radio_433_P.Checked) { GVar.glob_bin_id[2] = '1'; } else { GVar.glob_bin_id[2] = '0'; }
                if (ID_toggle_Display.Checked) { GVar.glob_bin_id[3] = '1'; } else { GVar.glob_bin_id[3] = '0'; }
                if (ID_toggle_Accel.Checked) { GVar.glob_bin_id[4] = '1'; } else { GVar.glob_bin_id[4] = '0'; }
                if (ID_toggle_SP.Checked) { GVar.glob_bin_id[5] = '1'; } else { GVar.glob_bin_id[5] = '0'; }
                if (ID_toggle_Buzzer.Checked) { GVar.glob_bin_id[6] = '1'; } else { GVar.glob_bin_id[6] = '0'; }
                if (ID_toggle_Vibracall.Checked) { GVar.glob_bin_id[7] = '1'; } else { GVar.glob_bin_id[7] = '0'; }
                if (ID_toggle_Torcia.Checked) { GVar.glob_bin_id[8] = '1'; } else { GVar.glob_bin_id[8] = '0'; }
                if (ID_toggle_Fungo.Checked) { GVar.glob_bin_id[9] = '1'; } else { GVar.glob_bin_id[9] = '0'; }
                GVar.glob_bin_id[10] = '0';
                GVar.glob_bin_id[11] = '0';
            }
            if (GVar.glob_tipo_item == "C")
            {
                Array.Clear(GVar.glob_bin_id, 0, 12);
                if (ID_radio_868_C.Checked) { GVar.glob_bin_id[0] = '1'; } else { GVar.glob_bin_id[0] = '0'; }
                if (ID_radio_915_C.Checked) { GVar.glob_bin_id[1] = '1'; } else { GVar.glob_bin_id[1] = '0'; }
                if (ID_radio_433_C.Checked) { GVar.glob_bin_id[2] = '1'; } else { GVar.glob_bin_id[2] = '0'; }
                if (ID_toggle_PlugExp.Checked) { GVar.glob_bin_id[3] = '1'; } else { GVar.glob_bin_id[3] = '0'; }
                if (ID_toggle_PlugPLE.Checked) { GVar.glob_bin_id[4] = '1'; } else { GVar.glob_bin_id[4] = '0'; }
                if (ID_toggle_TastEmerg.Checked) { GVar.glob_bin_id[5] = '1'; } else { GVar.glob_bin_id[5] = '0'; }
                if (ID_toggle_GuidaLuce.Checked) { GVar.glob_bin_id[6] = '1'; } else { GVar.glob_bin_id[6] = '0'; }
                if (ID_toggle_AntExt.Checked) { GVar.glob_bin_id[7] = '1'; } else { GVar.glob_bin_id[7] = '0'; }
                if (ID_toggle_CanBus.Checked) { GVar.glob_bin_id[8] = '1'; } else { GVar.glob_bin_id[8] = '0'; }
                if (ID_toggle_Prop.Checked) { GVar.glob_bin_id[9] = '1'; } else { GVar.glob_bin_id[9] = '0'; }
                GVar.glob_bin_id[10] = '0';
                GVar.glob_bin_id[11] = '0';
            }

            string binary = "";
            for (int i = 0; i < 12; i++)
            {
                binary = binary + GVar.glob_bin_id[i].ToString();
            }

            // Binary to Hex conversion
            string myhex = Convert.ToString(Convert.ToInt32(binary, 2), 16);
            GVar.glob_result_id[0] = GVar.glob_hex_id[0];
            GVar.glob_result_id[1] = Convert.ToChar(myhex.ToUpper().Substring(0, 1));
            GVar.glob_result_id[2] = Convert.ToChar(myhex.ToUpper().Substring(1, 1));
            GVar.glob_result_id[3] = Convert.ToChar(myhex.ToUpper().Substring(2, 1));

            ID_Result.Text = new string(GVar.glob_result_id);
        }

        private void ID_timer_Tick(object sender, EventArgs e)
        {
            Calcola_ID_Palmare();
        }

        private void Gecko_Layout_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //if ((e.Row == 2) && ((e.Column == 6) || (e.Column == 7)))
            if (e.Row == 2)
                e.Graphics.FillRectangle(Brushes.LightSteelBlue, e.CellBounds);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ID_pan_P.Visible = false;
            ID_pan_C.Visible = false;
            ID_combo_Famiglia.Enabled = false;
            btn_Prog_Window.Visible = false;

            tv_SWBrowser.Height = 700;
            dos_box.Height = 700;
            but_Programma.BackColor = Color.LightGreen;

            but_print_again.Visible = false;

            Commander_Layout.Visible = true;
            Cursor.Current = Cursors.WaitCursor;
            CaricaDatiProgrammazione();
            Cursor.Current = Cursors.Default;
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = tv_SWBrowser.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.bin");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void CaricaDatiProgrammazione()
        {
            dos_box.Clear();
            //box_sw_txt.Clear();
            lab_sw_Selezionato.Text = " ";
            lab_PartNumber.Text = " ";
            lab_IDNumber.Text = " ";
            lab_SN.Text = " ";
            //box_cnf_txt.Clear();
            //lab_cnf_Selezionato.Text = "";
            // Clear All Nodes if Already Exists  
            tv_SWBrowser.Nodes.Clear();
            //tv_CNFBrowser.Nodes.Clear();

            //PropertyDescriptor db_prodottoPropertyDescriptor = famProdBindingSource.GetItemProperties(null)["Fam_Name"];
            //db_prodotto = (string)db_prodottoPropertyDescriptor.GetValue(famProdBindingSource.Current);


            //PropertyDescriptor db_prod_SW_pathPropertyDescriptor = famProdBindingSource.GetItemProperties(null)["Fam_SW_path"];
            //db_prod_SW_path = (string)db_prod_SW_pathPropertyDescriptor.GetValue(famProdBindingSource.Current) + @"\";
            db_prod_SW_path = Properties.Settings.Default.Path_URL_Software+ @"\";

            // Setting Inital Value of Progress Bar  
            Application.UseWaitCursor = true;

            if (db_prod_SW_path != "" && Directory.Exists(db_prod_SW_path))
            {
                LoadDirectory(db_prod_SW_path);
            }
            else
                MessageBox.Show("Select Directory!!");
            //tv_SWBrowser.ExpandAll();
            for (int i = 0; i < tv_SWBrowser.Nodes.Count; i++)
            {
                tv_SWBrowser.Nodes[i].Expand();
            }

            Application.UseWaitCursor = false;
        }

        private void tv_SWBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dos_box.Clear();
            db_prod_CNF_path_withname = "";
            string txtfilext = tv_SWBrowser.SelectedNode.Text;
            if ((e.Node.Level > 1) && (e.Node.Parent != null))
            {
                db_prod_SW_path_w_subfolder = db_prod_SW_path + e.Node.Parent.Text + @"\";
            }
            else
            {
                db_prod_SW_path_w_subfolder = db_prod_SW_path;
            }

            db_prod_SW_path_withname = db_prod_SW_path_w_subfolder + txtfilext;

            if (txtfilext.EndsWith(".bin"))
            {
                lab_sw_Selezionato.Text = tv_SWBrowser.SelectedNode.Text;
            }
            else
            {
                lab_sw_Selezionato.Text = "";
            }
            string txtfile = Path.GetFileNameWithoutExtension(txtfilext);
            db_sw_selezionato = txtfile;
            string nomefile = db_prod_SW_path_w_subfolder + @"\" + txtfile + ".txt";
        }

        private void but_Programma_Click(object sender, EventArgs e)
        {
            if (lab_sw_Selezionato.Text.Trim(' ') == "")
            {
                MessageBox.Show("Impossibile proseguire! Selezionare il software!");
                return;
            }

            but_Programma.BackColor = Color.Magenta;
            dos_box.Clear();

            ProcessStartInfo psi = new ProcessStartInfo(@"cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            string text_dos = "";

            //Interrogazione interfaccia
            try
            {
                var proc = Process.Start(psi);

                // La riga sottostante è da verificare
                proc.StandardInput.WriteLine(Properties.Settings.Default.Path_URL_Commander + @"\commander.exe device info " + device);
                proc.StandardInput.WriteLine(Properties.Settings.Default.Path_URL_Commander + @"\commander.exe --version");
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = text_dos;

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    text_dos = "";
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
                        UNIQUE_ID = linea_ID.Substring(17, 16);
                        UNIQUE_ID_NEW = GVar.glob_result_id[0].ToString() + GVar.glob_result_id[1].ToString() + GVar.glob_result_id[2].ToString() + GVar.glob_result_id[3].ToString() + 
                                        lab_IDNumber.Text.Substring(0, 6) + lab_IDNumber.Text.Substring(10, 6);
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

                string programstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash " + db_prod_SW_path_withname + " --address 0x0 " + device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    text_dos = "";
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

                string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe verify " + db_prod_SW_path_withname + " " + device;
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;

                if (text_dos.Contains("...OK!"))
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
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {

            }

            //Lettura Memoria
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe readmem --range 0x0:+256 " + device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos;

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    text_dos = "";
                    return;
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

            //Etichette gialle
            //text = text + "m m" + "\r";
            //text = text + "J" + "\r";
            //text = text + "H 100" + "\r";
            //text = text + "S l1;0,0,13,16,35" + "\r";
            //string new_lab_ID = lab_IDNumber.Text.Substring(0, 5) + GVar.glob_result_id[0] + GVar.glob_result_id[1] + GVar.glob_result_id[2] + GVar.glob_result_id[3] + lab_IDNumber.Text.Substring(9, 7);

            //text = text + "B 0,0,0,QRCODE,0.25;" + UNIQUE_ID_NEW + "\r";
            //text = text + "T 12,2,0,3,pt7,q80; " + db_sw_selezionato + "\r";
            //text = text + "T 12,6,0,3,pt7,q80; " + lab_IDNumber.Text + "\r";
            //text = text + "T 12,10,0,3,pt7,q80; " + UNIQUE_ID_NEW + "\r";

            //text = text + "I 7,0,0,1,1,a;LogoSE" + "\r";
            //text = text + "A 1" + "\r";
            // fine Etichette gialle

            //Doppia etichetta piccola bianca - Software
            text = text + "m m" + "\r";
            text = text + "J" + "\r";
            text = text + "H 100" + "\r";
            //text = text + "S l1;0,0,7,9,20,3,2" + "\r";
            text = text + "S l1;0,0,7,9,20,23,2" + "\r";
            text = text + "B 1,0,0,QRCODE,0.25;" + UNIQUE_ID_NEW + "\r";
            text = text + "T 6,2,0,5,pt7,q60; " + db_sw_selezionato + "\r";
            //text = text + "T 12,6,0,3,pt7,q80; " + lab_IDNumber.Text + "\r";
            text = text + "T 6,5,0,5,pt7,q60; " + UNIQUE_ID_NEW + "\r";

            //text = text + "I 7,0,0,1,1,a;LogoSE" + "\r";
            text = text + "A 2" + "\r";


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
            client.UploadFile(tmp_file, "/SL_label.txt", FtpExists.Overwrite, true, FtpVerify.Retry);
            client.Disconnect();

            //File.Delete(tmp_file);

            but_Programma.BackColor = Color.LightGreen;
        }

        private void but_print_again_Click(object sender, EventArgs e)
        {
            PrintLabel();
        }
    }
}
