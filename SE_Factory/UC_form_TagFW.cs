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
    public partial class UC_form_TagFW : UserControl
    {
        public UC_form_TagFW()
        {
            InitializeComponent();
        }

        private void UC_form_TagFW_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.CustomerFW'. È possibile spostarla o rimuoverla se necessario.
            this.gC_CustomersFWTableAdapter.Fill(this.dB_FactoryDataSet.GC_CustomersFW);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.CustomerFW'. È possibile spostarla o rimuoverla se necessario.
            this.gC_CustomersTableAdapter.Fill(this.dB_FactoryDataSet.GC_Customers);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.CustomerFW'. È possibile spostarla o rimuoverla se necessario.
            this.gC_SoftwareTableAdapter.Fill(this.dB_FactoryDataSet.GC_Software);

            gCCustomersFWBindingSource.Sort = "CFW_SW_Code ASC";
            gCCustomersBindingSource.Sort = "Cli_RagSoc ASC";
            GVar.CloseSplash = true;

            Setting_Form();
        }

        private void Setting_Form()
        {
            //tolgo visibilità x evitare brutto effetto visivo
            //dg_CustomerFW.Columns["dg_CustomerFW_Id"].Visible = false;
            //dg_CustomerFW.Columns["dg_CustomerFW_IdCustomer"].Visible = false;
            dg_CustomerFW.Columns["dg_CustomerFW_Id_CustomerFW"].Visible = true;
            dg_CustomerFW.Columns["dg_CustomerFW_Id_CustomerFW"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg_CustomerFW.Columns["dg_CustomerFW_Id_CustomerFW"].HeaderText = "Cod. Firmware";
            dg_CustomerFW.Columns["dg_CustomerFW_DisplayTitle"].Visible = true;
            dg_CustomerFW.Columns["dg_CustomerFW_DisplayTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg_CustomerFW.Columns["dg_CustomerFW_DisplayTitle"].HeaderText = "Tag da mostrare";
            dg_CustomerFW.Visible = true;
            menu_sw_salva.Enabled = false;
            menu_sw_annulla.Enabled = false;
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void gCCustomersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // Set filter for Id
            DataRowView current = (DataRowView)gCCustomersBindingSource.Current;
            int codcli = (int)current["Id"];
            metroLabel1.Text = codcli.ToString();
            gCCustomersFWBindingSource.Filter = "CFW_IdCustomer = " + "'" + codcli + "'";
            metroLabel2.Text = gCCustomersFWBindingSource.Filter.ToString();
        }

        private void gCCustomersFWBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)gCCustomersFWBindingSource.Current;

            Tag_Lab_field_des_FW.Text = "Articolo non trovato!";
            if (current != null)
            {
                //cerca descrizione software
                string codfw = (string)current["CFW_SW_Code"];
                DataView view = new DataView();
                view.Table = dB_FactoryDataSet.Tables["GC_Software"];
                view.RowFilter = "SW_Code = " + "'" + codfw + "'";
                view.RowStateFilter = DataViewRowState.ModifiedCurrent;
                int pippo = view.Count;
                if (view.Count > 0)
                {
                    Tag_Lab_field_des_FW.Text = pippo.ToString();
                }
            }
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("salva");
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("annulla");
        }
    }
}
