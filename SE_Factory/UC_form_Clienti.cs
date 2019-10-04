using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Factory
{
    public partial class UC_form_Clienti : UserControl
    {
        public UC_form_Clienti()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UC_form_Clienti_Load(object sender, EventArgs e)
        {
            jLabelBindingSource.Filter = "DATA_RICHIESTA_CONSEGNA <> '30/12/1899'";
            jLabelBindingSource.Sort = "DATA_RICHIESTA_CONSEGNA ASC, NUMERO_ORDINE ASC, NUMERO_RIGA ASC";

            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel'. È possibile spostarla o rimuoverla se necessario.
            this.jLabelTableAdapter.Fill(this.dB_FactoryDataSet.JLabel);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.jLabel_ClientiTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.gC_CustomersTableAdapter.Fill(this.dB_FactoryDataSet.GC_Customers);

            //Imposto DataGrid
            tIPOORDINECLIENTEDataGridViewTextBoxColumn.Visible = true;
            rAGIONESOCIALEDataGridViewTextBoxColumn.Visible = true;
            nUMEROORDINEDataGridViewTextBoxColumn.Visible = true;
            nUMERORIGADataGridViewTextBoxColumn.Visible = true;
            tIPODBDataGridViewTextBoxColumn.Visible = false;
            cODICEKITDataGridViewTextBoxColumn.Visible = true;
            cODICESISTEMADataGridViewTextBoxColumn.Visible = true;
            dESCRIZIONEDataGridViewTextBoxColumn.Visible = true;
            dATARICHIESTACONSEGNADataGridViewTextBoxColumn.Visible = true;
            dATACONFERMACONSEGNADataGridViewTextBoxColumn.Visible = false;
            uMDataGridViewTextBoxColumn.Visible = true;
            pREZZOUNITARIOKITDataGridViewTextBoxColumn.Visible = false;
            pREZZOUNITARIODataGridViewTextBoxColumn.Visible = false;
            qTAORDINATAKITDataGridViewTextBoxColumn.Visible = false;
            qTAORDINATADataGridViewTextBoxColumn.Visible = true;
            qTASPEDITAKITDataGridViewTextBoxColumn.Visible = false;
            qTASPEDITADataGridViewTextBoxColumn.Visible = false;
            iMPORTOKITDataGridViewTextBoxColumn.Visible = false;
            iMPORTODataGridViewTextBoxColumn.Visible = false;
            iMPORTOEVASOKITDataGridViewTextBoxColumn.Visible = false;
            iMPORTOEVASODataGridViewTextBoxColumn.Visible = false;
            sTATORIGAORDINEDataGridViewTextBoxColumn.Visible = false;
            sOFTWAREDataGridViewTextBoxColumn.Visible = true;

            tIPOORDINECLIENTEDataGridViewTextBoxColumn.HeaderText = "Tipo Ord.";
            rAGIONESOCIALEDataGridViewTextBoxColumn.HeaderText = "Ragione Sociale";
            nUMEROORDINEDataGridViewTextBoxColumn.HeaderText = "N° ordine";
            nUMERORIGADataGridViewTextBoxColumn.HeaderText = "Riga";
            cODICEKITDataGridViewTextBoxColumn.HeaderText = "Cod. Kit";
            cODICESISTEMADataGridViewTextBoxColumn.HeaderText = "Cod. Sistema";
            dESCRIZIONEDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            dATARICHIESTACONSEGNADataGridViewTextBoxColumn.HeaderText = "Data Evasione";
            uMDataGridViewTextBoxColumn.HeaderText = "UM";
            qTAORDINATADataGridViewTextBoxColumn.HeaderText = "Q.tà Ordinata";
            sTATORIGAORDINEDataGridViewTextBoxColumn.HeaderText = "Stato Evasione";
            sOFTWAREDataGridViewTextBoxColumn.HeaderText = "Software";

            nUMEROORDINEDataGridViewTextBoxColumn.DisplayIndex = 0;
            tIPOORDINECLIENTEDataGridViewTextBoxColumn.DisplayIndex = 1;
            nUMERORIGADataGridViewTextBoxColumn.DisplayIndex = 2;
            rAGIONESOCIALEDataGridViewTextBoxColumn.DisplayIndex = 3;
            cODICEKITDataGridViewTextBoxColumn.DisplayIndex = 4;
            cODICESISTEMADataGridViewTextBoxColumn.DisplayIndex = 5;
            dESCRIZIONEDataGridViewTextBoxColumn.DisplayIndex = 6;
            dATARICHIESTACONSEGNADataGridViewTextBoxColumn.DisplayIndex = 7;
            uMDataGridViewTextBoxColumn.DisplayIndex = 8;
            qTAORDINATADataGridViewTextBoxColumn.DisplayIndex = 9;
            sTATORIGAORDINEDataGridViewTextBoxColumn.DisplayIndex = 10;
            sOFTWAREDataGridViewTextBoxColumn.DisplayIndex = 11;

            nUMEROORDINEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tIPOORDINECLIENTEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nUMERORIGADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rAGIONESOCIALEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cODICEKITDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cODICESISTEMADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dESCRIZIONEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dATARICHIESTACONSEGNADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            uMDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qTAORDINATADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sTATORIGAORDINEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sOFTWAREDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg_Ordini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tIPOORDINECLIENTEDataGridViewTextBoxColumn.DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            nUMEROORDINEDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nUMERORIGADataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cODICEKITDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cODICESISTEMADataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dATARICHIESTACONSEGNADataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            uMDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qTAORDINATADataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sTATORIGAORDINEDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sOFTWAREDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            qTAORDINATADataGridViewTextBoxColumn.DefaultCellStyle.Format = "### ### ##0";
        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
