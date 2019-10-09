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

namespace SE_Factory
{
    public partial class UC_form_PopolaDB : UserControl
    {
        public class device
        {
            public int Dev_FamProd;
            public string Dev_CodiceItem;
            public string Dev_DescItem;
            public string Dev_Firmware;
            public DateTime Dev_StartDateFW;
            public DateTime Dev_EndDateFW;
            public bool isPalm;
            public bool isCntr;
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

        bool ArticoloDaScrivere = false; 
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

            jLabelBindingSource.Filter = "DATA_RICHIESTA_CONSEGNA <> '30/12/1899'";
            jLabelBindingSource.Sort = "DATA_RICHIESTA_CONSEGNA ASC, NUMERO_ORDINE ASC, NUMERO_RIGA ASC";

            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel'. È possibile spostarla o rimuoverla se necessario.
            this.jLabelTableAdapter.Fill(this.dB_FactoryDataSet.JLabel);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.jLabel_ClientiTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.gC_CustomersTableAdapter.Fill(this.dB_FactoryDataSet.GC_Customers);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.jLabel_fullTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_full);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.gC_DevicesTableAdapter.Fill(this.dB_FactoryDataSet.GC_Devices);

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
                //device NewDevice = new device();
                //NewDevice.Dev_CodiceItem = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');

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

            dB_FactoryDataSet.AcceptChanges();
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
            string codicedev = "";
            foreach (DataRow JLabelFull in dB_FactoryDataSet.JLabel_full.Rows)
            {
                codicedev = (string)JLabelFull["CODICE_SISTEMA"].ToString().TrimEnd(' ');
                device NewDevice = new device();
                NewDevice.Dev_CodiceItem = codicedev;
                NewDevice.Dev_DescItem = (string)JLabelFull["DESCREST_SISTEMA"].ToString().TrimEnd(' ');
                NewDevice.Dev_Firmware = (string)JLabelFull["SOFTWARE"].ToString().TrimEnd(' ');

                NewDevice.isPalm = GFunc.isPalm(codicedev);
                NewDevice.isCntr = GFunc.isCntr(codicedev);

                if ((!NewDevice.isPalm) && (!NewDevice.isCntr))
                {
                    continue;
                }

                ArticoloDaScrivere = false;

                //elimino articoli fuori standard
                if (GFunc.isCarOil(codicedev) || GFunc.isCradle(codicedev))
                {
                    ArticoloDaScrivere = false;
                    NewDevice.isSmartLine = false;
                }
                else
                {
                    ArticoloDaScrivere = true;
                    NewDevice.isSmartLine = false;
                }

                //test aggiuntivi x definire se SmartLine (al momento non ho la famiglia)
                if (NewDevice.isPalm && (GFunc.isEasy(codicedev) ||
                                         GFunc.isNimble(codicedev) ||
                                         GFunc.isNemo(codicedev) ||
                                         GFunc.isRescue(codicedev) ||
                                         GFunc.isLift(codicedev) ||
                                         GFunc.isBravo(codicedev) ||
                                         GFunc.isPhilo(codicedev) ||
                                         GFunc.isEasyWire(codicedev) ||
                                         GFunc.isTrend(codicedev) ||
                                         GFunc.isTrendB(codicedev) ||
                                         GFunc.isTrendLCD(codicedev) ||
                                         GFunc.isTrendWire(codicedev)))
                {
                    NewDevice.Dev_FamProd = 7;
                    ArticoloDaScrivere = true;
                    NewDevice.isSmartLine = false;
                }

                if (NewDevice.isCntr && (GFunc.isEasyXII(codicedev) ||
                                         GFunc.isCntr4(codicedev) ||
                                         GFunc.isCntr8(codicedev) ||
                                         GFunc.isCntr20(codicedev) ||
                                         GFunc.isCntr20B(codicedev) ||
                                         GFunc.isCntr32(codicedev) ||
                                         GFunc.isMulti12(codicedev) ||
                                         GFunc.isPowerDrive12(codicedev) ||
                                         GFunc.isPowerDrive24(codicedev) ||
                                         GFunc.isPowerDrive12SW(codicedev) ||
                                         GFunc.isPowerDrive24SW(codicedev) ||
                                         GFunc.isCntrNimble(codicedev) ||
                                         GFunc.isCntrNimbleSW(codicedev) ||
                                         GFunc.isCntr8AC(codicedev)))
                {
                    NewDevice.Dev_FamProd = 8;
                    ArticoloDaScrivere = true;
                    NewDevice.isSmartLine = false;
                }

                if (!ArticoloDaScrivere)
                {
                    continue;
                }

                //Ricerca su Devices
                //string filter = "Dev_CodiceItem = " + "'" + codicedev + "'";
                //dB_FactoryDataSet.GC_Devices.PrimaryKey = new DataColumn[] { dB_FactoryDataSet.GC_Devices.Columns["Dev_CodiceItem"] };
                DataRow DBF_row = dB_FactoryDataSet.GC_Devices.FindByDev_CodiceItem(codicedev);
                //DataRow DBF_row = dB_FactoryDataSet.GC_Devices.Rows.Find(codicedev);
                //DataRow[] DBF_row = dB_FactoryDataSet.GC_Devices.Select(filter);
                if (DBF_row != null) // verifica contenuti
                {
                    DBF_row["Dev_FamProd"] = NewDevice.Dev_FamProd;
                    DBF_row["Dev_CodiceItem"] = NewDevice.Dev_CodiceItem;
                    DBF_row["Dev_DescItem"] = NewDevice.Dev_DescItem;
                    DBF_row["Dev_Firmware"] = NewDevice.Dev_Firmware;
                    DBF_row["Dev_StartDateFW"] = NewDevice.Dev_StartDateFW;
                    DBF_row["Dev_EndDateFW"] = NewDevice.Dev_EndDateFW;
                    //gC_DevicesTableAdapter.Update(DBF_row);
                    try
                    {
                        this.Validate();
                        this.gCDevicesBindingSource.EndEdit();
                        this.gC_DevicesTableAdapter.Update(DBF_row);
                    }
                    catch (System.Exception ex)
                    {
                        //MessageBox.Show("Error");
                    }
                }
                else // scrivi nuovo record
                {
                    DataRow DBF_newrow = dB_FactoryDataSet.GC_Devices.NewRow();
                    DBF_newrow["Dev_FamProd"] = NewDevice.Dev_FamProd;
                    DBF_newrow["Dev_CodiceItem"] = NewDevice.Dev_CodiceItem;
                    DBF_newrow["Dev_DescItem"] = NewDevice.Dev_DescItem;
                    DBF_newrow["Dev_Firmware"] = NewDevice.Dev_Firmware;
                    DBF_newrow["Dev_StartDateFW"] = NewDevice.Dev_StartDateFW;
                    DBF_newrow["Dev_EndDateFW"] = NewDevice.Dev_EndDateFW;
                    dB_FactoryDataSet.GC_Devices.Rows.Add(DBF_newrow);
                    gC_DevicesTableAdapter.Update(DBF_newrow);
                }
            }

        }
    }
}
