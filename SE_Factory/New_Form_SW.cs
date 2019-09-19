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
    public partial class New_Form_SW : MetroForm
    {
        public New_Form_SW()
        {
            InitializeComponent();
        }

        private void New_Form_SW_Load(object sender, EventArgs e)
        {
            if (GVar.glob_new_sw_tipocodice=="R")
            {
                this.Text = "Creazione nuova revisione software";
            }
            if (GVar.glob_new_sw_tipocodice == "N")
            {
                this.Text = "Creazione nuovo codice software";
            }

            //Estrapolo i codici software
            lab_old_codice.Text = GVar.glob_new_sw_codice;
            tbox_Sw_name.Text = GVar.glob_new_sw_codice.Substring(4, 5);
            tbox_Sw_version.Text = ""; //GVar.glob_new_sw_codice.Substring(9, 3);
            tbox_Sw_frequency.Text = GVar.glob_new_sw_codice.Substring(12, 1);
            tbox_Sw_name.Enabled = false;
            tbox_Sw_frequency.Enabled=false;
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
