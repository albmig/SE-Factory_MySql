using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SE_Factory
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Schede'. È possibile spostarla o rimuoverla se necessario.
            this.schedeTableAdapter.Fill(this.dB_FactoryDataSet.Schede);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.dB_FactoryDataSet.Fam_Prod);
            panel_Main.Visible = true;
            panel_ID.Visible = false;

        }

        private void menu_btn_ID_Click(object sender, EventArgs e)
        {
            panel_Menu.Visible = false;
            panel_Main.Visible = false;
            panel_ID.Visible = true;

        }

        private void ID_combo_Famiglia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.schedeTableAdapter.Fill(this.dB_FactoryDataSet.Schede);

            //if (famProdBindingSource.Current != null)
            //{
            //    DataRow currentRow = ((DataRowView)famProdBindingSource.Current).Row;

            //    label1.Text = currentRow["Id"].ToString();
            //    label1.Refresh();

            //    if (currentRow["Fam_Tipo"].ToString() == "P")
            //    {
            //        ID_pan_P.Dock = DockStyle.Fill;
            //        ID_pan_C.Visible = false;
            //        ID_pan_P.Visible = true;

            //        schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
            //    }
            //    if (currentRow["Fam_Tipo"].ToString() == "C")
            //    {
            //        //ID_pan_C.Dock = DockStyle.Fill;
            //        //ID_pan_P.Visible = false;
            //        //ID_pan_C.Visible = true;
            //        ID_pan_P.Dock = DockStyle.Fill;
            //        ID_pan_C.Visible = false;
            //        ID_pan_P.Visible = true;

            //        schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
            //    }
            //}
        }

        private void famProdBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (famProdBindingSource.Current != null)
            {
                DataRow currentRow = ((DataRowView)famProdBindingSource.Current).Row;

                label1.Text = currentRow["Id"].ToString();
                label1.Refresh();

                if (currentRow["Fam_Tipo"].ToString() == "P")
                {
                    ID_pan_P.Dock = DockStyle.Fill;
                    ID_pan_C.Visible = false;
                    ID_pan_P.Visible = true;

                    schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
                }
                if (currentRow["Fam_Tipo"].ToString() == "C")
                {
                    //ID_pan_C.Dock = DockStyle.Fill;
                    //ID_pan_P.Visible = false;
                    //ID_pan_C.Visible = true;
                    ID_pan_P.Dock = DockStyle.Fill;
                    ID_pan_C.Visible = false;
                    ID_pan_P.Visible = true;

                    schedeBindingSource.Filter = "Prod_Fam = " + currentRow["Id"].ToString();
                }
            }
        }
    }
}
