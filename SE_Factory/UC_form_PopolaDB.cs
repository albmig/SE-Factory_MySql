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
        Splash SplashDB = new Splash();
        bool splashclosed = false;

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

            jLabelBindingSource.Filter = "DATA_RICHIESTA_CONSEGNA <> '30/12/1899'";
            jLabelBindingSource.Sort = "DATA_RICHIESTA_CONSEGNA ASC, NUMERO_ORDINE ASC, NUMERO_RIGA ASC";

            //this.jLabelTableAdapter.Fill(this.dB_FactoryDataSet.JLabel);
            this.jLabel_ClientiTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_Clienti);
            this.gC_CustomersTableAdapter.Fill(this.dB_FactoryDataSet.GC_Customers);
            this.gC_DevicesTableAdapter.Fill(this.dB_FactoryDataSet.GC_Devices);
            this.gC_KitTableAdapter.Fill(this.dB_FactoryDataSet.GC_Kit);
            this.jLabel_fullTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_full);

            SplashDB.Close();
            splashclosed = true;
        }

        private void UC_form_PopolaDB_Layout(object sender, LayoutEventArgs e)
        {
            if (!splashclosed)
            {
                SplashDB.Show();
            }
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
            foreach (DataRow OpenManager_row in dB_FactoryDataSet.JLabel_Clienti.Rows)
            {
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
                NewDevice.Dev_DescKit = (string)JLabelFull["DESCREST_KIT"].ToString().TrimEnd(' ');
                if (NewDevice.Dev_DescKit == "") { NewDevice.Dev_DescKit = (string)JLabelFull["DESCR_KIT"].ToString().TrimEnd(' '); }

                lab_Conv_Art.Text = NewDevice.Dev_CodiceKit;
                if (lab_Conv_Art.Text == "") { lab_Conv_Art.Text = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' '); }
                lab_Conv_Art.Refresh();

                //Settaggio per lavorazione solo sistema (non kit+sistema)
                if (NewDevice.Dev_CodiceKit == "") { solosistema = true; } else { solosistema = false; }

                if ((!solosistema) && (NewDevice.Dev_CodiceKit == codicekitlavorato)) { continue; }
                if ((solosistema) && (NewDevice.Dev_CodiceComponente == codicesistemalavorato)) { continue; }

                //Aggiornamento tabella Customer - Firmware
                NewDevice.Dev_Customer = 0;
                if ((string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ') != "") { NewDevice.Dev_Customer = FindCustomerFirmware(JLabelFull); }

                //Trovato solo il codice sistema (vendita device singolo)
                if (solosistema)
                {
                    string codicecomp = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');
                    if (codicecomp.StartsWith("XCBL")) { NewDevice.isCable = true; } else { NewDevice.isCable = false; }
                    if ((!codicecomp.StartsWith("XS")) && (!codicecomp.StartsWith("XX")) && (!NewDevice.isCable)) { continue; }
                    if (codicecomp.StartsWith("XS172P")) { continue; } // verifica se cradle

                    NewDevice.isPalm = GFunc.isPalm(codicecomp);
                    NewDevice.isCntr = GFunc.isCntr(codicecomp);
                    if (((!NewDevice.isPalm) && (!NewDevice.isCntr)) && (!NewDevice.isCable)) { continue; }

                    NewDevice.Dev_CodiceComponente = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');
                    NewDevice.Dev_DescComponente = (string)JLabelFull["DESCREST_SISTEMA"].ToString().TrimEnd(' ');
                    if (NewDevice.Dev_DescComponente == "") { NewDevice.Dev_DescComponente = (string)JLabelFull["DESCR_SISTEMA"].ToString().TrimEnd(' '); }
                    NewDevice.Dev_Firmware = (string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ');
                    NewDevice.Dev_StartDate = DateTime.Today;
                    NewDevice.Dev_EndDate = default(DateTime);

                    //test aggiuntivi x definire se SmartLine (al momento non ho la famiglia)
                    if (NewDevice.isPalm && (GFunc.isEasy(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isNimble(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isNemo(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isRescue(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isLift(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isBravo(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isPhilo(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isEasyWire(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isTrend(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isTrendB(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isTrendLCD(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isTrendWire(NewDevice.Dev_CodiceComponente)))
                    {
                        NewDevice.Dev_FamProd = 7;
                        NewDevice.isSmartLine = false;
                    }

                    if (NewDevice.isCntr && (GFunc.isEasyXII(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr4(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr8(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr20(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr20B(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr32(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isMulti12(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isPowerDrive12(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isPowerDrive24(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isPowerDrive12SW(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isPowerDrive24SW(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntrNimble(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntrNimbleSW(NewDevice.Dev_CodiceComponente) ||
                                             GFunc.isCntr8AC(NewDevice.Dev_CodiceComponente)))
                    {
                        NewDevice.Dev_FamProd = 8;
                        NewDevice.isSmartLine = false;
                    }
                    if (!NewDevice.isCable)
                    {
                        //Verifica se presente in devices
                        DataRow DBF_row = dB_FactoryDataSet.GC_Devices.Rows.Find(NewDevice.Dev_CodiceComponente);
                        if (DBF_row != null) // verifica contenuti
                        {
                            DBF_row.SetModified();
                            DBF_row.BeginEdit();
                            DBF_row["Dev_FamProd"] = NewDevice.Dev_FamProd;
                            DBF_row["Dev_CodiceItem"] = NewDevice.Dev_CodiceComponente;
                            DBF_row["Dev_DescItem"] = NewDevice.Dev_DescComponente;
                            DBF_row["Dev_Firmware"] = NewDevice.Dev_Firmware;
                            DBF_row["Dev_StartDateFW"] = Convert.ToDateTime(NewDevice.Dev_StartDate);
                            DBF_row["Dev_EndDateFW"] = Convert.ToDateTime(NewDevice.Dev_EndDate);
                            DBF_row.EndEdit();
                            try
                            {
                                dB_FactoryDataSet.GC_Devices.AcceptChanges();
                                this.gC_DevicesTableAdapter.Update(DBF_row);
                            }
                            catch (DBConcurrencyException exc) { MessageBox.Show("aa"); }

                            UpdateCustomerFirmware(NewDevice.Dev_Customer, NewDevice.Dev_Firmware);
                        }
                        else // scrivi nuovo record
                        {
                            DataRow DBF_newrow = dB_FactoryDataSet.GC_Devices.NewRow();
                            DBF_newrow["Dev_FamProd"] = NewDevice.Dev_FamProd;
                            DBF_newrow["Dev_CodiceItem"] = NewDevice.Dev_CodiceComponente;
                            DBF_newrow["Dev_DescItem"] = NewDevice.Dev_DescComponente;
                            DBF_newrow["Dev_Firmware"] = NewDevice.Dev_Firmware;
                            DBF_newrow["Dev_StartDateFW"] = Convert.ToDateTime(NewDevice.Dev_StartDate);
                            DBF_newrow["Dev_EndDateFW"] = Convert.ToDateTime(NewDevice.Dev_EndDate);
                            dB_FactoryDataSet.GC_Devices.Rows.Add(DBF_newrow);
                            gC_DevicesTableAdapter.Update(DBF_newrow);

                            UpdateCustomerFirmware(NewDevice.Dev_Customer, NewDevice.Dev_Firmware);
                        }

                        dB_FactoryDataSet.GC_Devices.AcceptChanges();
                    }
                }

                //Trovato codice kit (vendita kit completo)
                if (!solosistema)
                {
                    NewDevice.Dev_Firmware = (string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ');

                    //Cancello la versione di kit già presente in db
                    if (NewDevice.Dev_CodiceKit != codicekitlavorato)
                    {
                        string sel = "Kit_Composto = " + "'" + NewDevice.Dev_CodiceKit + "'";
                        DataRow[] rowstodelete = dB_FactoryDataSet.GC_Kit.Select(sel);
                        foreach (DataRow rowtd in rowstodelete)
                        {
                            int key = (int)rowtd["Id"];
                            gC_KitTableAdapter.DeleteQuery(key);
                            rowtd.Delete();
                            dB_FactoryDataSet.GC_Kit.AcceptChanges();
                        }
                    }

                    DataTable db_esploso = new DB_FactoryDataSet.NM_V_ANAGRAFICA_DB_DESCRIZIONEESTESADataTable();
                    db_esploso = this.db_esplosoTableAdapter.GetDataBy(NewDevice.Dev_CodiceKit);

                    foreach (DataRow rigaesploso in db_esploso.Rows)
                    {
                        string codicecomp = rigaesploso["CODICE_COMPONENTE"].ToString().TrimEnd(' ');
                        if (codicecomp.StartsWith("XCBL")) { NewDevice.isCable = true; } else { NewDevice.isCable = false; }
                        if ((!codicecomp.StartsWith("XS")) && (!codicecomp.StartsWith("XX")) && (!NewDevice.isCable)) { continue; }
                        if (codicecomp.StartsWith("XS172P")) { continue; } // verifica se cradle

                        NewDevice.isPalm = GFunc.isPalm(codicecomp);
                        NewDevice.isCntr = GFunc.isCntr(codicecomp);
                        if (((!NewDevice.isPalm) && (!NewDevice.isCntr)) && (!NewDevice.isCable)) { continue; }

                        //verifica presenza su GC_Kit
                        string filtro = "Kit_Composto = " + "'" + NewDevice.Dev_CodiceKit + "' AND Kit_Componente = " + "'" + codicecomp + "'";
                        DataRow[] kit_exisistingrows = dB_FactoryDataSet.GC_Kit.Select(filtro);
                        if (kit_exisistingrows.Count() > 0) { continue; }

                        NewDevice.Dev_CodiceComponente = rigaesploso["CODICE_COMPONENTE"].ToString().TrimEnd(' ');
                        NewDevice.Dev_DescComponente = (string)rigaesploso["DESEST_COMPONENTE"].ToString().TrimEnd(' ');
                        if (NewDevice.Dev_DescComponente == "") { NewDevice.Dev_DescComponente = (string)rigaesploso["Descrizione"].ToString().TrimEnd(' '); }
                        NewDevice.Dev_StartDate = default(DateTime);
                        NewDevice.Dev_EndDate = default(DateTime);
                        if (rigaesploso["DATA_INIZIO_VALIDITA"].ToString() != "") { NewDevice.Dev_StartDate = Convert.ToDateTime(rigaesploso["DATA_INIZIO_VALIDITA"].ToString()); }
                        if (rigaesploso["DATA_FINE_VALIDITA"].ToString() != "") { NewDevice.Dev_EndDate = Convert.ToDateTime(rigaesploso["DATA_FINE_VALIDITA"].ToString()); }
                        NewDevice.Dev_Qta = Convert.ToInt16(rigaesploso["Quantita"]);

                        //Scrittura del record
                        DataRow Kit_newrow = dB_FactoryDataSet.GC_Kit.NewRow();
                        Kit_newrow["Kit_Composto"] = NewDevice.Dev_CodiceKit;
                        Kit_newrow["Kit_DescComposto"] = NewDevice.Dev_DescKit;
                        Kit_newrow["Kit_Componente"] = NewDevice.Dev_CodiceComponente;
                        Kit_newrow["Kit_DescComponente"] = NewDevice.Dev_DescComponente;
                        Kit_newrow["Kit_Qta"] = NewDevice.Dev_Qta;
                        Kit_newrow["Kit_DataInizioVal"] = NewDevice.Dev_StartDate;
                        Kit_newrow["Kit_DataFineVal"] = NewDevice.Dev_EndDate;
                        dB_FactoryDataSet.GC_Kit.Rows.Add(Kit_newrow);
                        gC_KitTableAdapter.Update(Kit_newrow);

                        //test aggiuntivi x definire se SmartLine (al momento non ho la famiglia)
                        if (NewDevice.isPalm && (GFunc.isEasy(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isNimble(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isNemo(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isRescue(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isLift(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isBravo(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isPhilo(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isEasyWire(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isTrend(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isTrendB(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isTrendLCD(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isTrendWire(NewDevice.Dev_CodiceComponente)))
                        {
                            NewDevice.Dev_FamProd = 7;
                            NewDevice.isSmartLine = false;
                        }

                        if (NewDevice.isCntr && (GFunc.isEasyXII(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr4(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr8(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr20(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr20B(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr32(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isMulti12(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isPowerDrive12(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isPowerDrive24(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isPowerDrive12SW(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isPowerDrive24SW(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntrNimble(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntrNimbleSW(NewDevice.Dev_CodiceComponente) ||
                                                 GFunc.isCntr8AC(NewDevice.Dev_CodiceComponente)))
                        {
                            NewDevice.Dev_FamProd = 8;
                            NewDevice.isSmartLine = false;
                        }

                        if (!NewDevice.isCable)
                        {
                            //Verifica se presente in devices
                            DataRow DBF_row = dB_FactoryDataSet.GC_Devices.Rows.Find(NewDevice.Dev_CodiceComponente);
                            if (DBF_row != null) // verifica contenuti
                            {
                                DBF_row.SetModified();
                                DBF_row.BeginEdit();
                                DBF_row["Dev_FamProd"] = NewDevice.Dev_FamProd;
                                DBF_row["Dev_CodiceItem"] = NewDevice.Dev_CodiceComponente;
                                DBF_row["Dev_DescItem"] = NewDevice.Dev_DescComponente;
                                DBF_row["Dev_Firmware"] = NewDevice.Dev_Firmware;
                                DBF_row["Dev_StartDateFW"] = Convert.ToDateTime(NewDevice.Dev_StartDate);
                                DBF_row["Dev_EndDateFW"] = Convert.ToDateTime(NewDevice.Dev_EndDate);
                                DBF_row.EndEdit();
                                try
                                {
                                    dB_FactoryDataSet.GC_Devices.AcceptChanges();
                                    this.gC_DevicesTableAdapter.Update(DBF_row);
                                }
                                catch (DBConcurrencyException exc) { MessageBox.Show("aa"); }

                                UpdateCustomerFirmware(NewDevice.Dev_Customer, NewDevice.Dev_Firmware);
                            }
                            else // scrivi nuovo record
                            {
                                DataRow DBF_newrow = dB_FactoryDataSet.GC_Devices.NewRow();
                                DBF_newrow["Dev_FamProd"] = NewDevice.Dev_FamProd;
                                DBF_newrow["Dev_CodiceItem"] = NewDevice.Dev_CodiceComponente;
                                DBF_newrow["Dev_DescItem"] = NewDevice.Dev_DescComponente;
                                DBF_newrow["Dev_Firmware"] = NewDevice.Dev_Firmware;
                                DBF_newrow["Dev_StartDateFW"] = Convert.ToDateTime(NewDevice.Dev_StartDate);
                                DBF_newrow["Dev_EndDateFW"] = Convert.ToDateTime(NewDevice.Dev_EndDate);
                                dB_FactoryDataSet.GC_Devices.Rows.Add(DBF_newrow);
                                gC_DevicesTableAdapter.Update(DBF_newrow);

                                UpdateCustomerFirmware(NewDevice.Dev_Customer, NewDevice.Dev_Firmware);
                            }
                        }
                    }
                    dB_FactoryDataSet.GC_Kit.AcceptChanges();
                    dB_FactoryDataSet.GC_Devices.AcceptChanges();
                }

                codicekitlavorato = NewDevice.Dev_CodiceKit;
                codicesistemalavorato = NewDevice.Dev_CodiceComponente;
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

        private void UpdateCustomerFirmware(int codcli, string codfw)
        {
            if (codcli == 0)
            {
                return;
            }

            string sel = "CFW_IdCustomer = " + "'" + codcli + "'" +
                " AND CFW_SW_Code = " + "'" + codfw.TrimEnd(' ') + "'";
            DataRow[] FWpresente = dB_FactoryDataSet.GC_CustomersFW.Select(sel);
            if (FWpresente.Count() == 0)
            {
                DataRow DBF_newrow = dB_FactoryDataSet.GC_CustomersFW.NewRow();
                DBF_newrow["CFW_IdCustomer"] = codcli;
                DBF_newrow["CFW_SW_Code"] = codfw.TrimEnd(' ');
                dB_FactoryDataSet.GC_CustomersFW.Rows.Add(DBF_newrow);
                gC_CustomersFWTableAdapter.Update(DBF_newrow);
            }
        }
    }
}
