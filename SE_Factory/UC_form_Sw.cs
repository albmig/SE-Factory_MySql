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
using MetroFramework.Forms;
using iTextSharp.text.pdf;

namespace SE_Factory
{
    public partial class UC_form_Sw : UserControl
    {
        DataSet ds_Factory = new DataSet();
        DataTable dt_GC_FamProd = new DataTable("dt_GC_FamProd");
        DataTable dt_GC_Schede = new DataTable("dt_GC_Schede");
        DataTable dt_GC_Software = new DataTable("dt_GC_Software");
        BindingSource bs_Fam_Prod = new BindingSource();
        BindingSource bs_Schede = new BindingSource();
        BindingSource bs_Software = new BindingSource();

        public string SchedeCompatibili_SW = "";
        public string TemplateFolder = @"D:\VS2017 - Projects\SE_Factory\Prova Moduli SW\Template_PDF_Software.pdf";

        public UC_form_Sw()
        {
            InitializeComponent();
        }

        private void famProdBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (famProdBindingSource.Current != null)
            {
                DataRow currentRow = ((DataRowView)famProdBindingSource.Current).Row;

                GVar.glob_tipo_item = currentRow["Fam_Tipo"].ToString();
                GVar.glob_hex_id = currentRow["Fam_Hex_ID"].ToString();
                GVar.glob_result_id[0] = Convert.ToChar(currentRow["Fam_Hex_ID"]);
                Setting_Form();
            }
        }

        private void ID_timer_Tick(object sender, EventArgs e)
        {
            Calcola_ID_Palmare();
        }

        private void Calcola_ID_Palmare()
        {
            if (GVar.glob_tipo_item == "P")
            {
                Array.Clear(GVar.glob_bin_id, 0, 12);
                if (ID_radio_868_P.Checked) { GVar.glob_bin_id[0] = '1'; } else { GVar.glob_bin_id[0] = '0'; }
                if (ID_radio_915_P.Checked) { GVar.glob_bin_id[1] = '1'; } else { GVar.glob_bin_id[1] = '0'; }
                if (ID_radio_433_P.Checked) { GVar.glob_bin_id[2] = '1'; } else { GVar.glob_bin_id[2] = '0'; }
                if (ID_toggle_Display_P.Checked) { GVar.glob_bin_id[3] = '1'; } else { GVar.glob_bin_id[3] = '0'; }
                if (ID_toggle_Accel_P.Checked) { GVar.glob_bin_id[4] = '1'; } else { GVar.glob_bin_id[4] = '0'; }
                if (ID_toggle_SP_P.Checked) { GVar.glob_bin_id[5] = '1'; } else { GVar.glob_bin_id[5] = '0'; }
                if (ID_toggle_Buzzer_P.Checked) { GVar.glob_bin_id[6] = '1'; } else { GVar.glob_bin_id[6] = '0'; }
                if (ID_toggle_Vibracall_P.Checked) { GVar.glob_bin_id[7] = '1'; } else { GVar.glob_bin_id[7] = '0'; }
                if (ID_toggle_Torcia_P.Checked) { GVar.glob_bin_id[8] = '1'; } else { GVar.glob_bin_id[8] = '0'; }
                if (ID_toggle_Fungo_P.Checked) { GVar.glob_bin_id[9] = '1'; } else { GVar.glob_bin_id[9] = '0'; }
                GVar.glob_bin_id[10] = '0';
                GVar.glob_bin_id[11] = '0';
            }
            if (GVar.glob_tipo_item == "C")
            {
                Array.Clear(GVar.glob_bin_id, 0, 12);
                if (ID_radio_868_C.Checked) { GVar.glob_bin_id[0] = '1'; } else { GVar.glob_bin_id[0] = '0'; }
                if (ID_radio_915_C.Checked) { GVar.glob_bin_id[1] = '1'; } else { GVar.glob_bin_id[1] = '0'; }
                if (ID_radio_433_C.Checked) { GVar.glob_bin_id[2] = '1'; } else { GVar.glob_bin_id[2] = '0'; }
                if (ID_toggle_PlugExp_C.Checked) { GVar.glob_bin_id[3] = '1'; } else { GVar.glob_bin_id[3] = '0'; }
                if (ID_toggle_PlugPLE_C.Checked) { GVar.glob_bin_id[4] = '1'; } else { GVar.glob_bin_id[4] = '0'; }
                if (ID_toggle_TastEmerg_C.Checked) { GVar.glob_bin_id[5] = '1'; } else { GVar.glob_bin_id[5] = '0'; }
                if (ID_toggle_GuidaLuce_C.Checked) { GVar.glob_bin_id[6] = '1'; } else { GVar.glob_bin_id[6] = '0'; }
                if (ID_toggle_AntExt_C.Checked) { GVar.glob_bin_id[7] = '1'; } else { GVar.glob_bin_id[7] = '0'; }
                if (ID_toggle_CanBus_C.Checked) { GVar.glob_bin_id[8] = '1'; } else { GVar.glob_bin_id[8] = '0'; }
                if (ID_toggle_Prop_C.Checked) { GVar.glob_bin_id[9] = '1'; } else { GVar.glob_bin_id[9] = '0'; }
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
        }

        private void Setting_Form()
        {
            //SW_lab_gridcodificati.Visible = true;
            grid_SW_codificati.Visible = true;

            switch (GVar.glob_form_status)
            {
                case "N":
                    pan_SW_Codifica.Enabled = true;
                    //pan_SW_Lista.Visible = true;
                    //pan_SW_Lista.Enabled = false;
                    ID_combo_Famiglia.Enabled = true;
                    grid_SW_codificati.Enabled = false;
                    pan_SW_P.Visible = true;
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;
                    if (GVar.glob_tipo_item == "P")
                    {
                        pan_SW_P.Visible = true;
                        pan_P_Dx_revisioni.Visible = true;
                        pan_P_Dx_Funzionamento.Visible = true;
                        pan_SW_C.Visible = false;
                        pan_C_Dx_revisioni.Visible = false;
                        pan_C_Dx_Funzionamento.Visible = false;
                        pan_SW_P.Enabled = true;
                    }
                    if (GVar.glob_tipo_item == "C")
                    {
                        pan_SW_P.Visible = false;
                        pan_P_Dx_revisioni.Visible = false;
                        pan_P_Dx_Funzionamento.Visible = false;
                        pan_SW_C.Visible = true;
                        pan_C_Dx_revisioni.Visible = true;
                        pan_C_Dx_Funzionamento.Visible = true;
                        pan_SW_C.Enabled = true;
                    }
                    break;
                case "E":
                    //pan_SW_Lista.Visible = false;
                    ID_combo_Famiglia.Enabled = false;
                    grid_SW_codificati.Enabled = false;
                    pan_SW_P.Visible = true;
                    pan_SW_C.Visible = true;
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;
                    break;
                case "V":
                    //pan_SW_Lista.Visible = true;
                    //pan_SW_P.Visible = false;
                    //pan_SW_C.Visible = false;

                    ID_combo_Famiglia.Enabled = true;//aaaaaaaaaaaaaaaaaaaaaaaa
                    grid_SW_codificati.Enabled = true;

                    if (GVar.glob_tipo_item == "P")
                    {
                        pan_SW_P.Visible = true;
                        pan_P_Dx_revisioni.Visible = true;
                        pan_P_Dx_Funzionamento.Visible = true;
                        pan_SW_C.Visible = false;
                        pan_C_Dx_revisioni.Visible = false;
                        pan_C_Dx_Funzionamento.Visible = false;
                        pan_SW_P.Enabled = false;
                    }
                    if (GVar.glob_tipo_item == "C")
                    {
                        pan_SW_P.Visible = false;
                        pan_P_Dx_revisioni.Visible = false;
                        pan_P_Dx_Funzionamento.Visible = false;
                        pan_SW_C.Visible = true;
                        pan_C_Dx_revisioni.Visible = true;
                        pan_C_Dx_Funzionamento.Visible = true;
                        pan_SW_C.Enabled = false;
                    }
                    pan_SW_Codifica.Enabled = false;
                    pan_Menu_comandi.Enabled = true;
                    pan_Menu_salva.Enabled = false;
                    pan_Menu_exit.Enabled = true;
                    break;
            }

            //Azzero il campo check nel datagrid
            foreach (DataGridViewRow riga_P in grid_P_SchedeCompatibili.Rows)
            {
                riga_P.Cells["P_SchedaCompatibile"].Value = false;
            }
            foreach (DataGridViewRow riga_C in grid_C_SchedeCompatibili.Rows)
            {
                riga_C.Cells["C_SchedaCompatibile"].Value = false;
            }

            if ((GVar.glob_form_status == "E") || (GVar.glob_form_status == "V"))
            {
                //Visualizzo i dati in base ai valori del record
                if (famProdSoftwareBindingSource.Current != null)
                {
                    DataRow SW_view = ((DataRowView)famProdSoftwareBindingSource.Current).Row;

                    FromRecordToForm(SW_view);
                }
            }
            else
            {
                tbox_Sw_name.Text = "";
                tbox_Sw_version.Text = "";
                tbox_Sw_frequency.Text = "";
            }

            if (GVar.glob_form_status == "N")
            {
                AzzeraVarForm();
            }

            SettingGridGrouping();

            PopulateTreeView(dB_FactoryDataSet.Software);
        }

        private void tbox_Sw_name_Validating(object sender, CancelEventArgs e)
        {
            if ((!tbox_Sw_name.MaskFull) && (tbox_Sw_name.Text != ""))
            {
                MessageBox.Show("Campo non compilato completamente!");
                tbox_Sw_name.Focus();
            }
        }

        private void tbox_Sw_version_Validating(object sender, CancelEventArgs e)
        {
            if ((!tbox_Sw_version.MaskFull) && (tbox_Sw_version.Text != ""))
            {
                MessageBox.Show("Campo non compilato completamente!");
                tbox_Sw_version.Focus();
            }
        }

        private void tbox_Sw_frequency_Validating(object sender, CancelEventArgs e)
        {
            if ((!tbox_Sw_frequency.MaskFull) && (tbox_Sw_frequency.Text != ""))
            {
                MessageBox.Show("Campo non compilato completamente!");
                tbox_Sw_frequency.Focus();
            }

            if ((tbox_Sw_frequency.Text.ToUpper() != "X") &&
                (tbox_Sw_frequency.Text.ToUpper() != "A") &&
                (tbox_Sw_frequency.Text.ToUpper() != "B") &&
                (tbox_Sw_frequency.Text.ToUpper() != "N") &&
                (tbox_Sw_frequency.Text.ToUpper() != "Z"))
            {
                MessageBox.Show("Valore non corretto!");
                tbox_Sw_frequency.Focus();
            }

        }

        private void UC_form_Sw_Load(object sender, EventArgs e)
        {
            LoadMySQLData();
            ID_combo_Famiglia.DataSource = bs_Fam_Prod;
            grid_SW_codificati.DataSource = bs_Software;

            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.softwareTableAdapter.Fill(this.dB_FactoryDataSet.Software);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.dB_FactoryDataSet.Fam_Prod);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Schede'. È possibile spostarla o rimuoverla se necessario.
            this.schedeTableAdapter.Fill(this.dB_FactoryDataSet.Schede);

            //Setting_Form();
        }

        private void CreaPDF()
        {
            System.Threading.Thread.Sleep(1000);

            string P_InputStream = TemplateFolder;

            string P_OutputStream = @"D:\VS2017 - Projects\SE_Factory\Prova Moduli SW\FolderOut\result.pdf";

            using (FileStream outFile = new FileStream(P_OutputStream, FileMode.Create))
            {
                PdfReader pdfReader = new PdfReader(P_InputStream);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, outFile);
                AcroFields fields = pdfStamper.AcroFields;

                if ((famProdSoftwareBindingSource.Current != null) && (GVar.glob_tipo_item == "P"))
                {
                    DataRow SW_view = ((DataRowView)famProdSoftwareBindingSource.Current).Row;

                    fields.SetField("Customer", SW_view["SW_Customer"].ToString());
                    fields.SetField("SW_Code", SW_view["SW_Code"].ToString());
                    fields.SetField("Chip_Code", SW_view["SW_Microchip_Code"].ToString());
                    fields.SetField("Schede", SW_view["SW_SchedeCompatibili"].ToString());

                    fields.SetField("P_Radio_Freq", SW_view["SW_P_Opt_RF"].ToString());
                    if ((bool)SW_view["SW_P_Opt_Oled"]) { fields.SetField("P_Oled_si", "1"); } else { fields.SetField("P_Oled_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Accel"]) { fields.SetField("P_Accel_si", "1"); } else { fields.SetField("P_Accel_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_SP"]) { fields.SetField("P_SP_si", "1"); } else { fields.SetField("P_SP_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Buzzer"]) { fields.SetField("P_Buz_si", "1"); } else { fields.SetField("P_Buz_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Vibracall"]) { fields.SetField("P_Vibra_si", "1"); } else { fields.SetField("P_Vibra_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_LedTorch"]) { fields.SetField("P_Torcia_si", "1"); } else { fields.SetField("P_Torcia_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_EmButt"]) { fields.SetField("P_Emer_si", "1"); } else { fields.SetField("P_Emer_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_Backlight"]) { fields.SetField("P_use_back_si", "1"); } else { fields.SetField("P_use_back_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_ShiftPage"]) { fields.SetField("P_shiftpage_si", "1"); } else { fields.SetField("P_shiftpage_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_Accel"]) { fields.SetField("P_use_accel_si", "1"); } else { fields.SetField("P_use_accel_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_SP"]) { fields.SetField("P_use_SP_si", "1"); } else { fields.SetField("P_use_SP_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_Buzzer"]) { fields.SetField("P_use_buzz_si", "1"); } else { fields.SetField("P_use_buzz_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_Vibracall"]) { fields.SetField("P_use_vibra_si", "1"); } else { fields.SetField("P_use_vibra_no", "1"); }
                    if ((bool)SW_view["SW_P_Opt_Use_LedTorch"]) { fields.SetField("P_use_torch_si", "1"); } else { fields.SetField("P_use_torch_no", "1"); }
                    fields.SetField("P_max_pair", SW_view["SW_P_Opt_MaxPairDevices"].ToString());

                    fields.SetField("C_Radio_Freq", SW_view["SW_R_Opt_RF"].ToString());
                    if ((bool)SW_view["SW_R_Opt_Plug_Exp"]) { fields.SetField("C_PlugExp_si", "1"); } else { fields.SetField("C_PlugExp_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Plug_Ple"]) { fields.SetField("C_PlugPle_si", "1"); } else { fields.SetField("C_PlugPle_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Em_Keyb"]) { fields.SetField("C_EmerKey_si", "1"); } else { fields.SetField("C_EmerKey_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Status_Led"]) { fields.SetField("C_StatusLed_si", "1"); } else { fields.SetField("C_StatusLed_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Ext_Ant"]) { fields.SetField("C_ExtAnt_si", "1"); } else { fields.SetField("C_ExtAnt_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Can"]) { fields.SetField("C_Can_si", "1"); } else { fields.SetField("C_Can_no", "1"); }
                    if ((bool)SW_view["SW_R_Opt_Prop_Out"]) { fields.SetField("C_Prop_si", "1"); } else { fields.SetField("C_Prop_no", "1"); }
                    fields.SetField("C_Timeout", SW_view["SW_R_Opt_TimeOut"].ToString());
                    fields.SetField("C_ContKey", SW_view["SW_R_Opt_Cont_Keys"].ToString());
                    fields.SetField("C_MaxPair", SW_view["SW_R_Opt_MaxPairDevices"].ToString());
                    if ((bool)SW_view["SW_R_Opt_ShiftPage"]) { fields.SetField("C_ShiftPage_si", "1"); } else { fields.SetField("C_ShiftPage_no", "1"); }
                    fields.SetField("C_OutNum", SW_view["SW_R_Opt_Output_No"].ToString());
                    fields.SetField("C_InpDig", SW_view["SW_R_Opt_Dig_Input_No"].ToString());
                    fields.SetField("C_InpAna", SW_view["SW_R_Opt_Ana_Input_No"].ToString());

                    fields.SetField("Revision", SW_view["SW_Revisioni"].ToString());
                    fields.SetField("Operation", SW_view["SW_Funzionamento"].ToString());
                }
                pdfStamper.Close();
                pdfReader.Close();
                MessageBox.Show("PDF generato correttamente!");
            }

        }

        private void modificaCodiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow currentRow = ((DataRowView)famProdSoftwareBindingSource.Current).Row;

            //// Get the selected row from the ListBox
            //int index = dB_FactoryDataSet.Software;
            //if (index == (-1))
            //{
            //    lblMessage.Text = "Please select a Customer";
            //    return;
            //}
            //else
            //{
            //    lblMessage.Text = "";
            //}
            //DataRow targetRow = _dataTable.Rows[index];

            //dB_FactoryDataSet.Software.Rows(curr)
            //DataRow SW_new_record = dB_FactoryDataSet.Software.NewRow();
            //dB_FactoryDataSet.Software.AcceptChanges();
            //dB_FactoryDataSet.Software.(SW_new_record, true);

            //memorizzo l'id del record su cui sono posizionato, nel caso venga annullato l'inserimento
            GVar.Last_SW_ID_Record = (int)currentRow["Id"];

            GVar.glob_form_status = "E";
            Setting_Form();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVar.glob_form_status = "N";
            Setting_Form();
            //SW_lab_gridcodificati.Visible = false;
            grid_SW_codificati.Visible = false;

            pan_SW_P.Visible = false;
            pan_SW_C.Visible = false;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void famProdSoftwareBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Setting_Form();

            if (famProdSoftwareBindingSource.Count != 0)
            {
                DataRow SW_view = ((DataRowView)famProdSoftwareBindingSource.Current).Row;
                FromRecordToForm(SW_view);
            }
            else
            {
                AzzeraVarForm();
            }
        }

        private void creaPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreaPDF();
        }

        private void grid_P_SchedeCompatibili_Validated(object sender, EventArgs e)
        {
            if (grid_P_SchedeCompatibili.Rows.Count > 0)
            {
                SchedeCompatibili_SW = "";
                string testo = "";
                for (int i = 0; i < grid_P_SchedeCompatibili.Rows.Count; i++)
                {
                    DataGridViewRow selectedRow = grid_P_SchedeCompatibili.Rows[i];
                    bool isChecked = Convert.ToBoolean(selectedRow.Cells["P_SchedaCompatibile"].Value);

                    if (isChecked)
                    {
                        if (testo == "")
                        {
                            testo = selectedRow.Cells["P_prodSch"].Value.ToString();
                        }
                        else
                        {
                            testo = testo + "|";
                            testo = testo + selectedRow.Cells["P_prodSch"].Value.ToString();
                        }
                    }
                }
                SchedeCompatibili_SW = testo;
            }
        }

        private void creaRevisioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow SW_new_record = dB_FactoryDataSet.Software.NewRow();
            SW_new_record.ItemArray = ((DataRowView)famProdSoftwareBindingSource.Current).Row.ItemArray;
            string addline = "\n----------------------------------------\n";

            //memorizzo l'id del record su cui sono posizionato, nel caso venga annullato l'inserimento
            GVar.Last_SW_ID_Record = (int)SW_new_record["Id"];

            SW_new_record["SW_Code"] = "XSWR00001999X_SL";
            SW_new_record["SW_Revisioni"] = addline + SW_new_record["SW_Revisioni"].ToString();
            SW_new_record["SW_Funzionamento"] = addline + SW_new_record["SW_Funzionamento"].ToString();

            int lastnumber = (int)this.softwareTableAdapter.LastID() + 1;
            SW_new_record["Id"] = lastnumber;

            dB_FactoryDataSet.Software.Rows.Add(SW_new_record);

            //dB_FactoryDataSet.Software.FindById(lastnumber);

            famProdSoftwareBindingSource.Position = famProdSoftwareBindingSource.Find("Id", lastnumber);

            GVar.glob_form_status = "E";
            Setting_Form();
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            dB_FactoryDataSet.Software.RejectChanges();

            famProdSoftwareBindingSource.CancelEdit();

            famProdSoftwareBindingSource.Position = famProdSoftwareBindingSource.Find("Id", GVar.Last_SW_ID_Record);

            GVar.glob_form_status = "V";
            Setting_Form();

            //UC_form_Sw_Load(this, null);
            //Setting_Form();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            if (GVar.glob_form_status == "N")
            {
                DB_FactoryDataSet.SoftwareRow insertRow;
                insertRow = dB_FactoryDataSet.Software.NewSoftwareRow();
                FromRowToRecord(insertRow);
                this.dB_FactoryDataSet.Software.Rows.Add(insertRow);

                try
                {
                    this.softwareTableAdapter.Update(this.dB_FactoryDataSet.Software);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Failed update");
                }
            }

            if (GVar.glob_form_status == "E")
            {
                DataRow currentRow = ((DataRowView)famProdSoftwareBindingSource.Current).Row;
                FromRowToRecord(currentRow);

                try
                {
                    //this.Validate;
                    this.famProdBindingSource.EndEdit();
                    this.softwareTableAdapter.Update(this.dB_FactoryDataSet.Software);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Failed update");
                }
            }

            GVar.glob_form_status = "V";
            UC_form_Sw_Load(this, null);
        }

        private void FromRowToRecord(DataRow SW_new_record)
        {
            //DataRow SW_new_record = dB_FactoryDataSet.Software.NewRow();
            //SW_new_record.ItemArray = ((DataRowView)famProdSoftwareBindingSource.Current).Row.ItemArray;


            //Ricostruisco il codice del software
            string nome_sw = "XSWR" + tbox_Sw_name.Text + tbox_Sw_version.Text + tbox_Sw_frequency.Text + "_L";
            SW_new_record["SW_Code"] = nome_sw;

            DataRowView famiglie = (DataRowView)famProdBindingSource.Current;

            //SW_new_record["SW_Fam_Prod"] = ID_combo_Famiglia.ValueMember;
            SW_new_record["SW_Fam_Prod"] = famiglie["Id"];

            SW_new_record["SW_Customer"] = "Sistematica S.r.l.";
            SW_new_record["SW_SchedeCompatibili"] = SchedeCompatibili_SW;
            SW_new_record["SW_Microchip_Code"] = "EFR32BG13";
            string P_Opt_RF = "";
            if (ID_radio_868_P.Checked) { P_Opt_RF = "868"; }
            if (ID_radio_915_P.Checked) { P_Opt_RF = "915"; }
            if (ID_radio_433_P.Checked) { P_Opt_RF = "433"; }
            if (ID_radio_Filo_P.Checked) { P_Opt_RF = "Filo"; }
            if (ID_radio_None_P.Checked) { P_Opt_RF = "None"; }
            SW_new_record["SW_P_Opt_RF"] = P_Opt_RF;
            if (ID_toggle_Display_P.Checked) { SW_new_record["SW_P_Opt_Oled"] = true; } else { SW_new_record["SW_P_Opt_Oled"] = false; }
            if (ID_toggle_Accel_P.Checked) { SW_new_record["SW_P_Opt_Accel"] = true; } else { SW_new_record["SW_P_Opt_Accel"] = false; }
            if (ID_toggle_SP_P.Checked) { SW_new_record["SW_P_Opt_SP"] = true; } else { SW_new_record["SW_P_Opt_SP"] = false; }
            if (ID_toggle_Buzzer_P.Checked) { SW_new_record["SW_P_Opt_Buzzer"] = true; } else { SW_new_record["SW_P_Opt_Buzzer"] = false; }
            if (ID_toggle_Vibracall_P.Checked) { SW_new_record["SW_P_Opt_Vibracall"] = true; } else { SW_new_record["SW_P_Opt_Vibracall"] = false; }
            if (ID_toggle_Torcia_P.Checked) { SW_new_record["SW_P_Opt_LedTorch"] = true; } else { SW_new_record["SW_P_Opt_LedTorch"] = false; }
            if (ID_toggle_Fungo_P.Checked) { SW_new_record["SW_P_Opt_EmButt"] = true; } else { SW_new_record["SW_P_Opt_EmButt"] = false; }
            if (ID_toggle_use_Backlight_P.Checked) { SW_new_record["SW_P_Opt_Use_Backlight"] = true; } else { SW_new_record["SW_P_Opt_Use_Backlight"] = false; }
            if (ID_toggle_ShiftPage_P.Checked) { SW_new_record["SW_P_Opt_ShiftPage"] = true; } else { SW_new_record["SW_P_Opt_ShiftPage"] = false; }
            if (ID_toggle_use_Accel_P.Checked) { SW_new_record["SW_P_Opt_Use_Accel"] = true; } else { SW_new_record["SW_P_Opt_Use_Accel"] = false; }
            if (ID_toggle_use_SP_P.Checked) { SW_new_record["SW_P_Opt_Use_SP"] = true; } else { SW_new_record["SW_P_Opt_Use_SP"] = false; }
            if (ID_toggle_use_Buzzer_P.Checked) { SW_new_record["SW_P_Opt_Use_Buzzer"] = true; } else { SW_new_record["SW_P_Opt_Use_Buzzer"] = false; }
            if (ID_toggle_use_Vibracall_P.Checked) { SW_new_record["SW_P_Opt_Use_Vibracall"] = true; } else { SW_new_record["SW_P_Opt_Use_Vibracall"] = false; }
            if (ID_toggle_use_Torch_P.Checked) { SW_new_record["SW_P_Opt_Use_LedTorch"] = true; } else { SW_new_record["SW_P_Opt_Use_LedTorch"] = false; }
            SW_new_record["SW_P_Opt_MaxPairDevices"] = Convert.ToInt32(tb_Max_Pairable_P.Text);

            string R_Opt_RF = "";
            if (ID_radio_868_C.Checked) { R_Opt_RF = "868"; }
            if (ID_radio_915_C.Checked) { R_Opt_RF = "915"; }
            if (ID_radio_433_C.Checked) { R_Opt_RF = "433"; }
            if (ID_radio_Filo_C.Checked) { R_Opt_RF = "Filo"; }
            if (ID_radio_None_C.Checked) { R_Opt_RF = "None"; }
            SW_new_record["SW_R_Opt_RF"] = R_Opt_RF;
            if (ID_toggle_PlugExp_C.Checked) { SW_new_record["SW_R_Opt_Plug_Exp"] = true; } else { SW_new_record["SW_R_Opt_Plug_Exp"] = false; }
            if (ID_toggle_PlugPLE_C.Checked) { SW_new_record["SW_R_Opt_Plug_Ple"] = true; } else { SW_new_record["SW_R_Opt_Plug_Ple"] = false; }
            if (ID_toggle_TastEmerg_C.Checked) { SW_new_record["SW_R_Opt_Em_Keyb"] = true; } else { SW_new_record["SW_R_Opt_Em_Keyb"] = false; }
            if (ID_toggle_GuidaLuce_C.Checked) { SW_new_record["SW_R_Opt_Status_Led"] = true; } else { SW_new_record["SW_R_Opt_Status_Led"] = false; }
            if (ID_toggle_AntExt_C.Checked) { SW_new_record["SW_R_Opt_Ext_Ant"] = true; } else { SW_new_record["SW_R_Opt_Ext_Ant"] = false; }
            if (ID_toggle_CanBus_C.Checked) { SW_new_record["SW_R_Opt_Can"] = true; } else { SW_new_record["SW_R_Opt_Can"] = false; }
            if (ID_toggle_Prop_C.Checked) { SW_new_record["SW_R_Opt_Prop_Out"] = true; } else { SW_new_record["SW_R_Opt_Prop_Out"] = false; }
            SW_new_record["SW_R_Opt_TimeOut"] = Convert.ToDecimal(tb_timeout_C.Text);
            SW_new_record["SW_R_Opt_Cont_Keys"] = Convert.ToInt32(tb_contemporarykeys_C.Text);
            SW_new_record["SW_R_Opt_MaxPairDevices"] = Convert.ToInt32(tb_Max_Pairable_C.Text);
            if (ID_toggle_ShiftPage_C.Checked) { SW_new_record["SW_R_Opt_ShiftPage"] = true; } else { SW_new_record["SW_R_Opt_ShiftPage"] = false; }
            SW_new_record["SW_R_Opt_Output_No"] = Convert.ToInt32(tb_NumOutput_C.Text);
            SW_new_record["SW_R_Opt_Dig_Input_No"] = Convert.ToInt32(tb_input_Dig_C.Text);
            SW_new_record["SW_R_Opt_Ana_Input_No"] = Convert.ToInt32(tb_input_Ana_C.Text);
            SW_new_record["SW_Revisioni"] = richtb__Revisioni_P.Text;
            SW_new_record["SW_Funzionamento"] = richtb_Funzionamento_P.Text;
        }

        private void FromRecordToForm(DataRow SW_view)
        {
            //Estrapolo i codici software
            string nome_sw = SW_view["SW_Code"].ToString();
            tbox_Sw_name.Text = nome_sw.Substring(4, 5);
            tbox_Sw_version.Text = nome_sw.Substring(9, 3);
            tbox_Sw_frequency.Text = nome_sw.Substring(12, 1);


            //Analizzo i campi del record
            string analisi_schede = SW_view["SW_SchedeCompatibili"].ToString();
            char[] delimitatore = new char[] { '|' };
            GVar.glob_schede_compatibili.Clear();
            foreach (string substringa in analisi_schede.Split(delimitatore))
            {
                GVar.glob_schede_compatibili.Add(substringa);

                //verifica la presenza nel datagrid
                foreach (DataGridViewRow riga in grid_P_SchedeCompatibili.Rows)
                {
                    if (riga.Cells["P_prodSch"].Value.ToString() == substringa)
                    {
                        riga.Cells["P_SchedaCompatibile"].Value = true;
                    }
                }
            }

            switch (SW_view["SW_P_Opt_RF"])
            {
                case "868":
                    ID_radio_868_P.Checked = true;
                    ID_radio_915_P.Checked = false;
                    ID_radio_433_P.Checked = false;
                    ID_radio_Filo_P.Checked = false;
                    ID_radio_None_P.Checked = false;
                    break;
                case "915":
                    ID_radio_868_P.Checked = false;
                    ID_radio_915_P.Checked = true;
                    ID_radio_433_P.Checked = false;
                    ID_radio_Filo_P.Checked = false;
                    ID_radio_None_P.Checked = false;
                    break;
                case "433":
                    ID_radio_868_P.Checked = false;
                    ID_radio_915_P.Checked = false;
                    ID_radio_433_P.Checked = true;
                    ID_radio_Filo_P.Checked = false;
                    ID_radio_None_P.Checked = false;
                    break;
                case "Filo":
                    ID_radio_868_P.Checked = false;
                    ID_radio_915_P.Checked = false;
                    ID_radio_433_P.Checked = false;
                    ID_radio_Filo_P.Checked = true;
                    ID_radio_None_P.Checked = false;
                    break;
                case "None":
                    ID_radio_868_P.Checked = false;
                    ID_radio_915_P.Checked = false;
                    ID_radio_433_P.Checked = false;
                    ID_radio_Filo_P.Checked = false;
                    ID_radio_None_P.Checked = true;
                    break;
            }

            if ((bool)SW_view["SW_P_Opt_Oled"]) { ID_toggle_Display_P.Checked = true; } else { ID_toggle_Display_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Accel"]) { ID_toggle_Accel_P.Checked = true; } else { ID_toggle_Accel_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_SP"]) { ID_toggle_SP_P.Checked = true; } else { ID_toggle_SP_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Buzzer"]) { ID_toggle_Buzzer_P.Checked = true; } else { ID_toggle_Buzzer_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Vibracall"]) { ID_toggle_Vibracall_P.Checked = true; } else { ID_toggle_Vibracall_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_LedTorch"]) { ID_toggle_Torcia_P.Checked = true; } else { ID_toggle_Torcia_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_EmButt"]) { ID_toggle_Fungo_P.Checked = true; } else { ID_toggle_Fungo_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_Backlight"]) { ID_toggle_use_Backlight_P.Checked = true; } else { ID_toggle_use_Backlight_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_ShiftPage"]) { ID_toggle_ShiftPage_P.Checked = true; } else { ID_toggle_ShiftPage_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_Accel"]) { ID_toggle_use_Accel_P.Checked = true; } else { ID_toggle_use_Accel_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_SP"]) { ID_toggle_use_SP_P.Checked = true; } else { ID_toggle_use_SP_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_Buzzer"]) { ID_toggle_use_Buzzer_P.Checked = true; } else { ID_toggle_use_Buzzer_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_Vibracall"]) { ID_toggle_use_Vibracall_P.Checked = true; } else { ID_toggle_use_Vibracall_P.Checked = false; }
            if ((bool)SW_view["SW_P_Opt_Use_LedTorch"]) { ID_toggle_use_Torch_P.Checked = true; } else { ID_toggle_use_Torch_P.Checked = false; }
            tb_Max_Pairable_P.Text = SW_view["SW_P_Opt_MaxPairDevices"].ToString();

            switch (SW_view["SW_R_Opt_RF"])
            {
                case "868":
                    ID_radio_868_C.Checked = true;
                    ID_radio_915_C.Checked = false;
                    ID_radio_433_C.Checked = false;
                    ID_radio_Filo_C.Checked = false;
                    ID_radio_None_C.Checked = false;
                    break;
                case "915":
                    ID_radio_868_C.Checked = false;
                    ID_radio_915_C.Checked = true;
                    ID_radio_433_C.Checked = false;
                    ID_radio_Filo_C.Checked = false;
                    ID_radio_None_C.Checked = false;
                    break;
                case "433":
                    ID_radio_868_C.Checked = false;
                    ID_radio_915_C.Checked = false;
                    ID_radio_433_C.Checked = true;
                    ID_radio_Filo_C.Checked = false;
                    ID_radio_None_C.Checked = false;
                    break;
                case "Filo":
                    ID_radio_868_C.Checked = false;
                    ID_radio_915_C.Checked = false;
                    ID_radio_433_C.Checked = false;
                    ID_radio_Filo_C.Checked = true;
                    ID_radio_None_C.Checked = false;
                    break;
                case "None":
                    ID_radio_868_C.Checked = false;
                    ID_radio_915_C.Checked = false;
                    ID_radio_433_C.Checked = false;
                    ID_radio_Filo_C.Checked = false;
                    ID_radio_None_C.Checked = true;
                    break;
            }
            if ((bool)SW_view["SW_R_Opt_Plug_Exp"]) { ID_toggle_PlugExp_C.Checked = true; } else { ID_toggle_PlugExp_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Plug_Ple"]) { ID_toggle_PlugPLE_C.Checked = true; } else { ID_toggle_PlugPLE_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Em_Keyb"]) { ID_toggle_TastEmerg_C.Checked = true; } else { ID_toggle_TastEmerg_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Status_Led"]) { ID_toggle_GuidaLuce_C.Checked = true; } else { ID_toggle_GuidaLuce_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Ext_Ant"]) { ID_toggle_AntExt_C.Checked = true; } else { ID_toggle_AntExt_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Can"]) { ID_toggle_CanBus_C.Checked = true; } else { ID_toggle_CanBus_C.Checked = false; }
            if ((bool)SW_view["SW_R_Opt_Prop_Out"]) { ID_toggle_Prop_C.Checked = true; } else { ID_toggle_Prop_C.Checked = false; }
            tb_timeout_C.Text = SW_view["SW_R_Opt_TimeOut"].ToString();
            tb_contemporarykeys_C.Text = SW_view["SW_R_Opt_Cont_Keys"].ToString();
            tb_Max_Pairable_C.Text = SW_view["SW_R_Opt_MaxPairDevices"].ToString();
            if ((bool)SW_view["SW_R_Opt_ShiftPage"]) { ID_toggle_ShiftPage_C.Checked = true; } else { ID_toggle_ShiftPage_C.Checked = false; }
            tb_NumOutput_C.Text = SW_view["SW_R_Opt_Output_No"].ToString();
            tb_input_Dig_C.Text = SW_view["SW_R_Opt_Dig_Input_No"].ToString();
            tb_input_Ana_C.Text = SW_view["SW_R_Opt_Ana_Input_No"].ToString();

            richtb__Revisioni_P.Text = SW_view["SW_Revisioni"].ToString();
            richtb_Funzionamento_P.Text = SW_view["SW_Funzionamento"].ToString();

        }

        private void AzzeraVarForm()
        {
            ID_radio_868_P.Checked = true;
            ID_radio_915_P.Checked = false;
            ID_radio_433_P.Checked = false;
            ID_radio_Filo_P.Checked = false;
            ID_radio_None_P.Checked = false;
            ID_toggle_Display_P.Checked = false;
            ID_toggle_Accel_P.Checked = false;
            ID_toggle_SP_P.Checked = false;
            ID_toggle_Buzzer_P.Checked = false;
            ID_toggle_Vibracall_P.Checked = false;
            ID_toggle_Torcia_P.Checked = false;
            ID_toggle_Fungo_P.Checked = false;
            ID_toggle_use_Backlight_P.Checked = false;
            ID_toggle_use_Accel_P.Checked = false;
            ID_toggle_use_SP_P.Checked = false;
            ID_toggle_use_Buzzer_P.Checked = false;
            ID_toggle_use_Vibracall_P.Checked = false;
            ID_toggle_use_Torch_P.Checked = false;
            ID_toggle_ShiftPage_P.Checked = false;
            tb_Max_Pairable_P.Text = "1";

            ID_radio_868_C.Checked = true;
            ID_radio_915_C.Checked = false;
            ID_radio_433_C.Checked = false;
            ID_radio_Filo_C.Checked = false;
            ID_radio_None_C.Checked = false;
            ID_toggle_PlugExp_C.Checked = false;
            ID_toggle_PlugPLE_C.Checked = false;
            ID_toggle_TastEmerg_C.Checked = false;
            ID_toggle_GuidaLuce_C.Checked = false;
            ID_toggle_AntExt_C.Checked = false;
            ID_toggle_CanBus_C.Checked = false;
            ID_toggle_Prop_C.Checked = false;
            ID_toggle_use_Backlight_C.Checked = false;
            ID_toggle_use_Accel_C.Checked = false;
            ID_toggle_use_SP_C.Checked = false;
            ID_toggle_use_Buzzer_C.Checked = false;
            ID_toggle_use_Vibracall_C.Checked = false;
            ID_toggle_use_Torch_C.Checked = false;
            ID_toggle_ShiftPage_C.Checked = false;
            tb_Max_Pairable_C.Text = "1";
            tb_contemporarykeys_C.Text = "0";
            tb_timeout_C.Text = "2";
            tb_NumOutput_C.Text = "0";
            tb_input_Dig_C.Text = "0";
            tb_input_Ana_C.Text = "0";

            richtb__Revisioni_P.Text = "";
            richtb_Funzionamento_P.Text = "";
            richtb__Revisioni_C.Text = "";
            richtb_Funzionamento_C.Text = "";
        }

        private void PopulateTreeView(DataTable dtParent) // versione funzionante
        {
            //xxxtreeView1.Nodes.Clear();
            //foreach (DataRow dr in dtParent.Rows)
            //{
            //    string nparent = dr["SW_Versione"].ToString().PadLeft(5, '0');
            //    string nchild = dr["SW_Revisione"].ToString().PadLeft(3, '0');

            //    if (xxxtreeView1.Nodes.ContainsKey(nparent) == true)
            //    {
            //        TreeNode child = new TreeNode();
            //        child.Text = nchild;
            //        child.Name = nchild;
            //        xxxtreeView1.Nodes[nparent].Nodes.Add(child);
            //    }
            //    else
            //    {
            //        TreeNode parent = new TreeNode();
            //        parent.Text = nparent;
            //        parent.Name = nparent;
            //        xxxtreeView1.Nodes.Add(parent);
            //        TreeNode child = new TreeNode();
            //        child.Text = nchild;
            //        child.Name = nchild;
            //        parent.Nodes.Add(child);
            //    }
            //}
        }

        //private void PopulateTreeView(DataTable dtParent)
        //{
        //    treeView1.Nodes.Clear();

        //    treeView1.BeginUpdate();

        //    // Iterate throght the DataRow Collection
        //    foreach (DataRow dr in dtParent.Rows)
        //    {
        //        string nparent = dr["SW_Versione"].ToString().PadLeft(5, '0');
        //        string nchild = dr["SW_Revisione"].ToString().PadLeft(3, '0');

        //        TreeNode Node = treeView1.Nodes.Add("Node for " + nparent);

        //        if (Node != null)
        //        {
        //            int iCol = 0;

        //            foreach (var item in dr.ItemArray)
        //            {
        //                string itemString = item as string;
        //                if (itemString != null && itemString.Length > 0)
        //                {
        //                    Node.Nodes.Add(dtParent.Columns[iCol].ColumnName + " - " + itemString);
        //                }

        //                iCol++;
        //            }
        //        }
        //    }
        //    treeView1.EndUpdate();
        //}

        private void SettingGridGrouping()
        {
            // Row selection
            grid_SW_codificati.TableDescriptor.AllowEdit = false;
            grid_SW_codificati.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            // Auto Column size
            grid_SW_codificati.AllowProportionalColumnSizing = true;


            //grid_SW_codificati.Table.ExpandAllRecords();
            grid_SW_codificati.Table.ExpandAllGroups();
            //this.grid_SW_codificati.Table.ExpandAllRecords();
            //this.grid_SW_codificati.Table.ExpandAllGroups();
        }

        private void LoadMySQLData()
        {
            ////////////////////////////////////////////////////////////////////////////////////
            // Caricamento tabelle MySQL
            ////////////////////////////////////////////////////////////////////////////////////

            Application.UseWaitCursor = true;
            dt_GC_FamProd = MySQLMgmt.Fill_SQL_FamProd();
            dt_GC_FamProd.TableName = "dt_GC_FamProd";
            ds_Factory.Tables.Add(dt_GC_FamProd);

            dt_GC_Schede = MySQLMgmt.Fill_SQL_Schede();
            dt_GC_Schede.TableName = "dt_GC_Schede";
            ds_Factory.Tables.Add(dt_GC_Schede);

            dt_GC_Software = MySQLMgmt.Fill_SQL_Software();
            dt_GC_Software.TableName = "dt_GC_Software";
            ds_Factory.Tables.Add(dt_GC_Software);

            DataRelation dtRelSchede_Fam;
            DataColumn FamSchCol = ds_Factory.Tables["dt_GC_FamProd"].Columns["Id"];
            DataColumn SchedeCol = ds_Factory.Tables["dt_GC_Schede"].Columns["Prod_Fam"];
            dtRelSchede_Fam = new DataRelation("Schede_Fam_relation ", FamSchCol, SchedeCol);
            ds_Factory.Tables["dt_GC_Schede"].ParentRelations.Add(dtRelSchede_Fam);

            DataRelation dtRelSoftware_Fam;
            DataColumn FamSwCol = ds_Factory.Tables["dt_GC_FamProd"].Columns["Id"];
            DataColumn SoftwareCol = ds_Factory.Tables["dt_GC_Software"].Columns["SW_Fam_Prod"];
            dtRelSoftware_Fam = new DataRelation("Software_Fam_relation ", FamSwCol, SoftwareCol);
            ds_Factory.Tables["dt_GC_Software"].ParentRelations.Add(dtRelSoftware_Fam);

            // Create a BindingSource  
            //BindingSource bs_Fam_Prod = new BindingSource();
            bs_Fam_Prod.DataSource = ds_Factory.Tables["dt_GC_FamProd"];
            //BindingSource bs_Schede = new BindingSource();
            bs_Schede.DataSource = ds_Factory.Tables["dt_GC_Schede"];
            //BindingSource bs_Software = new BindingSource();
            bs_Software.DataSource = ds_Factory.Tables["dt_GC_Software"];


            Application.UseWaitCursor = false;
        }

    }
}
