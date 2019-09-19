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

namespace SE_Factory
{
    public partial class UC_form_ID : UserControl
    {
        public UC_form_ID()
        {
            InitializeComponent();
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

        private void ID_uc_form_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Schede'. È possibile spostarla o rimuoverla se necessario.
            this.schedeTableAdapter.Fill(this.dB_FactoryDataSet.Schede);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.dB_FactoryDataSet.Fam_Prod);
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
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

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
