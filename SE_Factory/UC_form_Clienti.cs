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

        private void UC_form_Clienti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.sM_V_ANAGRAFICA_CLIENTITableAdapter.Fill(this.dB_FactoryDataSet.SM_V_ANAGRAFICA_CLIENTI);

            this.sMVANAGRAFICACLIENTIBindingSource.Sort = "Mastro ASC, Conto ASC, SOTTOCONTO ASC";

            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.dB_FactoryDataSet.Fam_Prod);
            // TODO: questa riga di codice carica i dati nella tabella 'dB_FactoryDataSet.Software'. È possibile spostarla o rimuoverla se necessario.
            this.softwareTableAdapter.Fill(this.dB_FactoryDataSet.Software);
        }
    }
}
