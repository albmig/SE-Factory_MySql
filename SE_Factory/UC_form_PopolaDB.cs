using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;
using System.Reflection;
using System.Data.SqlClient;

namespace SE_Factory
{
    public partial class UC_form_PopolaDB : UserControl
    {
        public class device
        {
            public int Dev_FamProd;
            public string Dev_CodiceKit;
            public string Dev_DescKit;
            public string Dev_CodiceComponente;
            public string Dev_DescComponente;
            public string Dev_Firmware;
            public DateTime Dev_StartDate;
            public DateTime Dev_EndDate;
            public int Dev_Qta;
            public int Dev_Customer;
            public bool isPalm;
            public bool isCntr;
            public bool isCable;
            public bool isSmartLine;
            public string Modello;
            //public bool is433;
            //public bool is868;
            //public bool is915;
            //public bool isCaroil;
            //public bool isCradle;
            //public bool isEasy;
            //public bool isNimble;
            //public bool isNemo;
            //public bool isRescue;
            //public bool isLift;
            //public bool isBravo;
            //public bool isPhilo;
            //public bool isEasywire;
            //public bool isTrend;
            //public bool isTrendB;
            //public bool isTrendLcd;
            //public bool isTrendWire;
            //public bool isEasyXII;
            //public bool isEasyXXI;
            //public bool isCntr4;
            //public bool isCntr8;
            //public bool isCntr20;
            //public bool isCntr20B;
            //public bool isCntr32;
            //public bool isMulti12;
            //public bool isPowerDrive12;
            //public bool isPowerDrive24;
            //public bool isPowerDrive12SW;
            //public bool isPowerDrive24SW;
            //public bool isCntrNimble;
            //public bool isCntrNimbleSW;
            //public bool isCntr8AC;
        }

        int NumCliToAdd = 0;
        int NumKitToAdd = 0;
        int NumArtToAdd = 0;

        public UC_form_PopolaDB()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void UC_form_PopolaDB_Load(object sender, EventArgs e)
        {
            lab_clienti.Text = "";
            lab_articoli.Text = "";
            lab_Conv_Art.Text = "";
            lab_Conv_Cli.Text = "";

            jLabelBindingSource.Filter = "DATA_RICHIESTA_CONSEGNA <> '30/12/1899'";
            jLabelBindingSource.Sort = "DATA_RICHIESTA_CONSEGNA ASC, NUMERO_ORDINE ASC, NUMERO_RIGA ASC";

            //this.jLabelTableAdapter.Fill(this.dB_FactoryDataSet.JLabel);
            this.jLabel_ClientiTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_Clienti);
            this.gC_CustomersTableAdapter.Fill(this.dB_FactoryDataSet.GC_Customers);
            this.gC_CustomersFWTableAdapter.Fill(this.dB_FactoryDataSet.GC_CustomersFW);
            this.gC_DevicesTableAdapter.Fill(this.dB_FactoryDataSet.GC_Devices);
            this.gC_KitTableAdapter.Fill(this.dB_FactoryDataSet.GC_Kit);
            this.jLabel_fullTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_full);

            GVar.CloseSplash = true;
            update_Articoli.Focus();
        }

        private void VerificaUpdateClienti()
        {
            foreach (DataRow OpenManager_row in dB_FactoryDataSet.JLabel_Clienti.Rows)
            {
                int key = (Int32)OpenManager_row["CodAnagrafico"];
                DataRow DBF_row = dB_FactoryDataSet.GC_Customers.FindById(key);
                if (DBF_row == null) // verifica contenuti
                {
                    NumCliToAdd++;
                }
                lab_clienti.Text = "Risultano n. " + NumCliToAdd.ToString() + " clienti da aggiornare";
            }
        }

        private void VerificaUpdateArticoli()
        {
            foreach (DataRow JLabelFull in dB_FactoryDataSet.JLabel_full.Rows)
            {
                //Ricerca su Devices
                string key = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');
                string filter = "Dev_CodiceItem = " + "'" + key + "'";

                DataRow[] DBF_row = dB_FactoryDataSet.GC_Devices.Select(filter);
                if (DBF_row.Count() == 0) // Nessun device trovato
                {
                    NumArtToAdd++;
                }
                lab_articoli.Text = "Risultano n. " + NumArtToAdd.ToString() + " Devices da aggiornare";
            }
        }

        private void update_Clienti_Click(object sender, EventArgs e)
        {
            lab_Conv_Cli.Text = "Conversione in corso...";
            lab_Conv_Cli.Refresh();

            foreach (DataRow OpenManager_row in dB_FactoryDataSet.JLabel_Clienti.Rows)
            {
                lab_Conv_Cli.Text = OpenManager_row["CodAnagrafico"].ToString();
                lab_Conv_Cli.Refresh();

                int key = (Int32)OpenManager_row["CodAnagrafico"];
                DataRow DBF_row = dB_FactoryDataSet.GC_Customers.FindById(key);
                if (DBF_row != null) // verifica contenuti
                {
                    DBF_row["Cli_RagSoc"] = OpenManager_row["RagSocCognome"];
                    DBF_row["Cli_Indirizzo"] = OpenManager_row["IndirizzoFiscale"];
                    DBF_row["Cli_CAP"] = OpenManager_row["CapFiscale"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Citta"] = OpenManager_row["ComuneFiscale"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Prov"] = OpenManager_row["ProvinciaFiscale"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Nazione"] = OpenManager_row["NazioneFiscale"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Web"] = OpenManager_row["Http"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Email_1"] = OpenManager_row["EMail"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Email_2"] = OpenManager_row["EMailPECComm"].ToString().TrimEnd(' ');
                    string numtel = OpenManager_row["Prefisso"].ToString().TrimEnd(' ') + OpenManager_row["Telefono"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Tel_1"] = numtel;
                    numtel = OpenManager_row["PrefissoAggiuntivo"].ToString().TrimEnd(' ') + OpenManager_row["TelefonoAggiuntivo"].ToString().TrimEnd(' ');
                    DBF_row["Cli_Tel_2"] = numtel;
                    gC_CustomersTableAdapter.Update(DBF_row);
                }
                else // scrivi nuovo record
                {
                    DataRow DBF_newrow = dB_FactoryDataSet.GC_Customers.NewRow();
                    DBF_newrow["Id"] = OpenManager_row["CodAnagrafico"];
                    DBF_newrow["Cli_RagSoc"] = OpenManager_row["RagSocCognome"];
                    DBF_newrow["Cli_Indirizzo"] = OpenManager_row["IndirizzoFiscale"];
                    DBF_newrow["Cli_CAP"] = OpenManager_row["CapFiscale"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Citta"] = OpenManager_row["ComuneFiscale"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Prov"] = OpenManager_row["ProvinciaFiscale"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Nazione"] = OpenManager_row["NazioneFiscale"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Web"] = OpenManager_row["Http"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Email_1"] = OpenManager_row["EMail"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Email_2"] = OpenManager_row["EMailPECComm"].ToString().TrimEnd(' ');
                    string numtel = OpenManager_row["Prefisso"].ToString().TrimEnd(' ') + OpenManager_row["Telefono"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Tel_1"] = numtel;
                    numtel = OpenManager_row["PrefissoAggiuntivo"].ToString().TrimEnd(' ') + OpenManager_row["TelefonoAggiuntivo"].ToString().TrimEnd(' ');
                    DBF_newrow["Cli_Tel_2"] = numtel;
                    dB_FactoryDataSet.GC_Customers.Rows.Add(DBF_newrow);
                    gC_CustomersTableAdapter.Update(DBF_newrow);
                }
            }

            dB_FactoryDataSet.GC_Customers.AcceptChanges();
        }

        private void verificaArchiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumCliToAdd = 0;
            VerificaUpdateClienti();

            NumKitToAdd = 0;
            NumArtToAdd = 0;
            VerificaUpdateArticoli();
        }

        private void update_Articoli_Click(object sender, EventArgs e)
        {
            string codicekitlavorato = "";
            string codicesistemalavorato = "";
            bool solosistema = false;
            lab_Conv_Art.Text = "Conversione in corso...";
            lab_Conv_Art.Refresh();

            DataView JlabelFull_DV = dB_FactoryDataSet.JLabel_full.DefaultView;
            JlabelFull_DV.Sort = "CODICE_KIT ASC, CODICE_SISTEMA ASC";

            foreach (DataRowView JLabelFull in JlabelFull_DV)
            {
                device NewDevice = new device();

                NewDevice.Dev_CodiceKit = (string)JLabelFull["CODICE_KIT"].ToString().TrimEnd(' ');
                NewDevice.Dev_CodiceComponente = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');
                NewDevice.isPalm = GFunc.isPalm(NewDevice.Dev_CodiceComponente);
                NewDevice.isCntr = GFunc.isCntr(NewDevice.Dev_CodiceComponente);

                lab_Conv_Art.Text = NewDevice.Dev_CodiceKit;
                if (lab_Conv_Art.Text == "") { lab_Conv_Art.Text = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' '); }
                lab_Conv_Art.Refresh();

                //verifica se SmartLine
                if (NewDevice.isPalm)
                {
                    NewDevice.isSmartLine = false;

                    if (GFunc.isEasy_SL(NewDevice.Dev_CodiceComponente)) { NewDevice.isSmartLine = true; NewDevice.Dev_FamProd = 1; }
                    if (GFunc.isTrend_SL(NewDevice.Dev_CodiceComponente)) { NewDevice.isSmartLine = true; NewDevice.Dev_FamProd = 2; }
                }
                if (NewDevice.isCntr)
                {
                    NewDevice.isSmartLine = false;
                    if (GFunc.isSmartbox8_SL(NewDevice.Dev_CodiceComponente)) { NewDevice.isSmartLine = true; NewDevice.Dev_FamProd = 3; }
                    if (GFunc.isSmartbox20_SL(NewDevice.Dev_CodiceComponente)) { NewDevice.isSmartLine = true; NewDevice.Dev_FamProd = 4; }
                }

                if ((!NewDevice.isPalm) && (!NewDevice.isCntr)) { continue; }
                if (!NewDevice.isSmartLine) { continue; }

                //Riempimento campi della classe
                NewDevice.Dev_DescKit = (string)JLabelFull["DESCREST_KIT"].ToString().TrimEnd(' ');
                if (NewDevice.Dev_DescKit == "") { NewDevice.Dev_DescKit = (string)JLabelFull["DESCR_KIT"].ToString().TrimEnd(' '); }
                NewDevice.Dev_DescComponente = (string)JLabelFull["DESCREST_SISTEMA"].ToString().TrimEnd(' ');
                if (NewDevice.Dev_DescComponente == "") { NewDevice.Dev_DescComponente = (string)JLabelFull["DESCR_SISTEMA"].ToString().TrimEnd(' '); }
                NewDevice.Dev_Firmware = (string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ');
                if ((string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ') != "") { NewDevice.Dev_Customer = FindCustomerFirmware(JLabelFull); }
                NewDevice.Modello = (string)JLabelFull["MODELLO"].ToString().TrimEnd(' ');

                //Settaggio per lavorazione solo sistema (non kit+sistema)
                if (NewDevice.Dev_CodiceKit == "") { solosistema = true; } else { solosistema = false; }

                if (!solosistema)
                {
                    if (NewDevice.Dev_CodiceKit != codicekitlavorato) //prima volta che lavoro questo kit - Ricreo Kit
                    {
                        RicreaKit(NewDevice);
                    }
                    codicekitlavorato = NewDevice.Dev_CodiceKit;
                    codicesistemalavorato = NewDevice.Dev_CodiceComponente;

                    PopolaDevice(NewDevice);
                    PopolaCustomers(NewDevice);
                    PopolaFWCustomers(NewDevice);
                }
                else
                {
                    PopolaDevice(NewDevice);
                    PopolaCustomers(NewDevice);
                    PopolaFWCustomers(NewDevice);
                    codicekitlavorato = NewDevice.Dev_CodiceKit;
                    codicesistemalavorato = NewDevice.Dev_CodiceComponente;
                }

            }

            lab_Conv_Art.Text = "Conversione terminata!";
            lab_Conv_Art.Refresh();
        }

        private int FindCustomerFirmware(DataRowView RigaOrd)
        {
            //Trovo riga ordine in JLabel_Clienti
            string selord = "NumOrdine = " + "'" + RigaOrd["NUMERO_ORDINE"].ToString().TrimEnd(' ') + "'" +
                            " AND TipoOrdine = " + "'" + RigaOrd["TIPO_ORDINE_CLIENTE"].ToString().TrimEnd(' ') + "'";
            DataRow[] TestaOrdine = dB_FactoryDataSet.JLabel_Clienti.Select(selord);
            int codcli = 0;
            if (TestaOrdine.Count() > 0)
            {
                foreach (DataRow RigaTestaOrdine in TestaOrdine)
                {
                    return (int)RigaTestaOrdine["CodAnagrafico"];
                }
            }
            return codcli;
        }

        //private void UpdateCustomerFirmware(int codcli, string codfw)
        //{
        //    if (codcli == 0)
        //    {
        //        return;
        //    }

        //    string sel = "CFW_IdCustomer = " + "'" + codcli + "'" +
        //        " AND CFW_SW_Code = " + "'" + codfw.TrimEnd(' ') + "'";

        //    DataRow[] FWpresente = dB_FactoryDataSet.GC_CustomersFW.Select(sel);
        //    if (FWpresente.Count() == 0)
        //    {
        //        DataRow DBF_newrow = dB_FactoryDataSet.GC_CustomersFW.NewRow();
        //        DBF_newrow["CFW_IdCustomer"] = codcli;
        //        DBF_newrow["CFW_SW_Code"] = codfw.TrimEnd(' ');
        //        dB_FactoryDataSet.GC_CustomersFW.Rows.Add(DBF_newrow);
        //        gC_CustomersFWTableAdapter.Update(DBF_newrow);
        //    }
        //}

        private void DeleteKit(device PassedNewDevice)
        {
            string sel = "Kit_Composto = " + "'" + PassedNewDevice.Dev_CodiceKit + "'";
            DataRow[] rowstodelete = dB_FactoryDataSet.GC_Kit.Select(sel);
            foreach (DataRow rowtd in rowstodelete)
            {
                int key = (int)rowtd["Id"];
                gC_KitTableAdapter.DeleteQuery(key);
                rowtd.Delete();
                dB_FactoryDataSet.GC_Kit.AcceptChanges();
            }
        }

        private void PopolaDevice(device PassedNewDevice)
        {
            if (PassedNewDevice.Dev_CodiceComponente.StartsWith("XCBL")) { PassedNewDevice.isCable = true; } else { PassedNewDevice.isCable = false; }
            if ((!PassedNewDevice.Dev_CodiceComponente.StartsWith("XS")) && (!PassedNewDevice.Dev_CodiceComponente.StartsWith("XX")) && (!PassedNewDevice.isCable)) { return; }
            if (PassedNewDevice.Dev_CodiceComponente.StartsWith("XS172P")) { return; } // verifica se cradle

            if (((!PassedNewDevice.isPalm) && (!PassedNewDevice.isCntr)) && (!PassedNewDevice.isCable)) { return; }

            //test aggiuntivi x definire se SmartLine (al momento non ho la famiglia)
            if (PassedNewDevice.isPalm && (GFunc.isEasy(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isNimble(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isNemo(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isRescue(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isLift(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isBravo(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isPhilo(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isEasyWire(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isTrend(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isTrendB(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isTrendLCD(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isTrendWire(PassedNewDevice.Dev_CodiceComponente)))
            {
                PassedNewDevice.Dev_FamProd = 7;
                PassedNewDevice.isSmartLine = false;
            }

            if (PassedNewDevice.isCntr && (GFunc.isEasyXII(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr4(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr8(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr20(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr20B(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr32(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isMulti12(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isPowerDrive12(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isPowerDrive24(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isPowerDrive12SW(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isPowerDrive24SW(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntrNimble(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntrNimbleSW(PassedNewDevice.Dev_CodiceComponente) ||
                                           GFunc.isCntr8AC(PassedNewDevice.Dev_CodiceComponente)))
            {
                PassedNewDevice.Dev_FamProd = 8;
                PassedNewDevice.isSmartLine = false;
            }

            if (!PassedNewDevice.isCable)
            {
                //Verifica se presente in devices
                DataRow DBF_row = dB_FactoryDataSet.GC_Devices.Rows.Find(PassedNewDevice.Dev_CodiceComponente);
                if (DBF_row != null) // verifica contenuti
                {
                    DBF_row.SetModified();
                    DBF_row.BeginEdit();
                    DBF_row["Dev_FamProd"] = PassedNewDevice.Dev_FamProd;
                    DBF_row["Dev_CodiceItem"] = PassedNewDevice.Dev_CodiceComponente;
                    DBF_row["Dev_DescItem"] = PassedNewDevice.Dev_DescComponente;
                    DBF_row["Dev_Firmware"] = PassedNewDevice.Dev_Firmware;
                    DBF_row["Dev_StartDateFW"] = Convert.ToDateTime(PassedNewDevice.Dev_StartDate);
                    DBF_row["Dev_EndDateFW"] = Convert.ToDateTime(PassedNewDevice.Dev_EndDate);
                    DBF_row["Dev_ID_Model"] = PassedNewDevice.Modello;
                    DBF_row.EndEdit();
                    try
                    {
                        dB_FactoryDataSet.GC_Devices.AcceptChanges();
                        this.gC_DevicesTableAdapter.Update(DBF_row);
                    }
                    catch (DBConcurrencyException exc) { MessageBox.Show("aa"); }

                    //UpdateCustomerFirmware(PassedNewDevice.Dev_Customer, PassedNewDevice.Dev_Firmware);
                }
                else // scrivi nuovo record
                {
                    DataRow DBF_newrow = dB_FactoryDataSet.GC_Devices.NewRow();
                    DBF_newrow["Dev_FamProd"] = PassedNewDevice.Dev_FamProd;
                    DBF_newrow["Dev_CodiceItem"] = PassedNewDevice.Dev_CodiceComponente;
                    DBF_newrow["Dev_DescItem"] = PassedNewDevice.Dev_DescComponente;
                    DBF_newrow["Dev_Firmware"] = PassedNewDevice.Dev_Firmware;
                    DBF_newrow["Dev_StartDateFW"] = Convert.ToDateTime(PassedNewDevice.Dev_StartDate);
                    DBF_newrow["Dev_EndDateFW"] = Convert.ToDateTime(PassedNewDevice.Dev_EndDate);
                    DBF_newrow["Dev_ID_Model"] = PassedNewDevice.Modello;
                    dB_FactoryDataSet.GC_Devices.Rows.Add(DBF_newrow);
                    gC_DevicesTableAdapter.Update(DBF_newrow);

                    //UpdateCustomerFirmware(PassedNewDevice.Dev_Customer, PassedNewDevice.Dev_Firmware);
                }
                dB_FactoryDataSet.GC_Devices.AcceptChanges();
            }

        }

        private void PopolaCustomers(device PassedNewDevice)
        { }

        private void PopolaFWCustomers(device PassedNewDevice)
        {
            if (PassedNewDevice.Dev_Customer == 0)
            {
                return;
            }

            string sel = "CFW_IdCustomer = " + "'" + PassedNewDevice.Dev_Customer + "'" +
                " AND CFW_SW_Code = " + "'" + PassedNewDevice.Dev_Firmware.TrimEnd(' ') + "'";

            DataRow[] FWpresente = dB_FactoryDataSet.GC_CustomersFW.Select(sel);
            if (FWpresente.Count() == 0)
            {
                DataRow DBF_newrow = dB_FactoryDataSet.GC_CustomersFW.NewRow();
                DBF_newrow["CFW_IdCustomer"] = PassedNewDevice.Dev_Customer;
                DBF_newrow["CFW_SW_Code"] = PassedNewDevice.Dev_Firmware.TrimEnd(' ');
                dB_FactoryDataSet.GC_CustomersFW.Rows.Add(DBF_newrow);
                gC_CustomersFWTableAdapter.Update(DBF_newrow);
            }
        }

        private void PopolaKit(device PassedNewDevice)
        {
            DataRow Kit_newrow = dB_FactoryDataSet.GC_Kit.NewRow();
            Kit_newrow["Kit_Composto"] = PassedNewDevice.Dev_CodiceKit;
            Kit_newrow["Kit_DescComposto"] = PassedNewDevice.Dev_DescKit;
            Kit_newrow["Kit_Componente"] = PassedNewDevice.Dev_CodiceComponente;
            Kit_newrow["Kit_DescComponente"] = PassedNewDevice.Dev_DescComponente;
            Kit_newrow["Kit_Qta"] = PassedNewDevice.Dev_Qta;
            Kit_newrow["Kit_DataInizioVal"] = PassedNewDevice.Dev_StartDate;
            Kit_newrow["Kit_DataFineVal"] = PassedNewDevice.Dev_EndDate;
            dB_FactoryDataSet.GC_Kit.Rows.Add(Kit_newrow);
            gC_KitTableAdapter.Update(Kit_newrow);
        }

        private void RicreaKit(device PassedNewDevice)
        {
            DeleteKit(PassedNewDevice);

            //Trova kit - Esplodi kit

            //Creazione della datatable esplosione distinta base
            DataTable db_esploso = new DB_FactoryDataSet.NM_V_ANAGRAFICA_DB_DESCRIZIONEESTESADataTable();
            db_esploso = this.db_esplosoTableAdapter.GetDataBy(PassedNewDevice.Dev_CodiceKit);
            foreach (DataRow rigaesploso in db_esploso.Rows)
            {
                string codcompon = rigaesploso["CODICE_COMPONENTE"].ToString().TrimEnd(' ');
                if (codcompon.StartsWith("XCBL")) { PassedNewDevice.isCable = true; } else { PassedNewDevice.isCable = false; }
                if ((!codcompon.StartsWith("XS")) && (!codcompon.StartsWith("XX")) && (!PassedNewDevice.isCable)) { continue; }
                if (codcompon.StartsWith("XS172P")) { continue; } // verifica se cradle
                PassedNewDevice.isPalm = GFunc.isPalm(codcompon);
                PassedNewDevice.isCntr = GFunc.isCntr(codcompon);
                if (((!PassedNewDevice.isPalm) && (!PassedNewDevice.isCntr)) && (!PassedNewDevice.isCable)) { continue; }

                PassedNewDevice.Dev_CodiceComponente = rigaesploso["CODICE_COMPONENTE"].ToString().TrimEnd(' ');
                //verifica presenza su GC_Kit
                string filtro = "Kit_Composto = " + "'" + PassedNewDevice.Dev_CodiceKit + "' AND Kit_Componente = " + "'" + PassedNewDevice.Dev_CodiceComponente + "'";
                DataRow[] kit_exisistingrows = dB_FactoryDataSet.GC_Kit.Select(filtro);
                if (kit_exisistingrows.Count() > 0) { continue; }

                PassedNewDevice.Dev_DescComponente = (string)rigaesploso["DESEST_COMPONENTE"].ToString().TrimEnd(' ');
                if (PassedNewDevice.Dev_DescComponente == "") { PassedNewDevice.Dev_DescComponente = (string)rigaesploso["Descrizione"].ToString().TrimEnd(' '); }
                PassedNewDevice.Dev_StartDate = default(DateTime);
                PassedNewDevice.Dev_EndDate = default(DateTime);
                if (rigaesploso["DATA_INIZIO_VALIDITA"].ToString() != "") { PassedNewDevice.Dev_StartDate = Convert.ToDateTime(rigaesploso["DATA_INIZIO_VALIDITA"].ToString()); }
                if (rigaesploso["DATA_FINE_VALIDITA"].ToString() != "") { PassedNewDevice.Dev_EndDate = Convert.ToDateTime(rigaesploso["DATA_FINE_VALIDITA"].ToString()); }
                PassedNewDevice.Dev_Qta = Convert.ToInt16(rigaesploso["Quantita"]);

                PopolaKit(PassedNewDevice);
            }

        }
    }
}
