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
    public partial class UC_form_Ordini : UserControl
    {
        public UC_form_Ordini()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UC_form_Ordini_Load(object sender, EventArgs e)
        {
            jLabelBindingSource.Filter = "DATA_RICHIESTA_CONSEGNA <> '30/12/1899'";
            jLabelBindingSource.Sort = "DATA_RICHIESTA_CONSEGNA ASC, NUMERO_ORDINE ASC, NUMERO_RIGA ASC";

            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel'. È possibile spostarla o rimuoverla se necessario.
            this.jLabelTableAdapter.Fill(this.dB_FactoryDataSet.JLabel);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.JLabel_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.jLabel_ClientiTableAdapter.Fill(this.dB_FactoryDataSet.JLabel_Clienti);

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
    }
}
