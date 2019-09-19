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
    public partial class UC_form_Paths : UserControl
    {
        public UC_form_Paths()
        {
            InitializeComponent();
        }

        private void pan_Menu_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UC_form_Paths_Load(object sender, EventArgs e)
        {
            tb_Paths_Doc.Text = Properties.Settings.Default.Path_URL_Documentazione;
            tb_Paths_Sw.Text = Properties.Settings.Default.Path_URL_Software;
            tb_Paths_Images.Text = Properties.Settings.Default.Path_URL_Images;

            GVar.glob_form_status = "V";
            Setting_Form();
        }

        private void Setting_Form()
        {
            switch (GVar.glob_form_status)
            {
                case "N":
                    tb_Paths_Doc.Enabled = true;
                    tb_Paths_Sw.Enabled = true;
                    tb_Paths_Images.Enabled = true;
                    btn_test_web_doc.Enabled = true;
                    btn_test_web_sw.Enabled = true;
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;
                    break;
                case "E":
                    tb_Paths_Doc.Enabled = true;
                    tb_Paths_Sw.Enabled = true;
                    tb_Paths_Images.Enabled = true;
                    btn_test_web_doc.Enabled = true;
                    btn_test_web_sw.Enabled = true;
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;
                    break;
                case "V":
                    tb_Paths_Doc.Enabled = false;
                    tb_Paths_Sw.Enabled = false;
                    tb_Paths_Images.Enabled = false;
                    btn_test_web_doc.Enabled = false;
                    btn_test_web_sw.Enabled = false;
                    pan_Menu_comandi.Enabled = true;
                    pan_Menu_salva.Enabled = false;
                    pan_Menu_exit.Enabled = true;
                    break;
            }
        }

        private void menu_sw_edit_Click(object sender, EventArgs e)
        {
            GVar.glob_form_status = "E";
            Setting_Form();
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            tb_Paths_Doc.Text = Properties.Settings.Default.Path_URL_Documentazione;
            tb_Paths_Sw.Text = Properties.Settings.Default.Path_URL_Software;
            tb_Paths_Images.Text = Properties.Settings.Default.Path_URL_Images;

            GVar.glob_form_status = "V";
            Setting_Form();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            //annulla slash finali
            string xxx = "";

            xxx = tb_Paths_Doc.Text.TrimEnd('\\');
            tb_Paths_Doc.Text = xxx;
            xxx = tb_Paths_Sw.Text.TrimEnd('\\');
            tb_Paths_Sw.Text = xxx;
            xxx = tb_Paths_Images.Text.TrimEnd('\\');
            tb_Paths_Images.Text = xxx;

            Properties.Settings.Default.Path_URL_Documentazione = tb_Paths_Doc.Text;
            Properties.Settings.Default.Path_URL_Software = tb_Paths_Sw.Text;
            Properties.Settings.Default.Path_URL_Images = tb_Paths_Images.Text;
            Properties.Settings.Default.Save();

            GVar.glob_form_status = "V";
            Setting_Form();
        }
    }
}