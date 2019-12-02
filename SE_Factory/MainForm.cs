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
            tool_Strip_path_SW.Text = Properties.Settings.Default.Path_URL_Software;
            tool_Strip_path_Commander.Text = Properties.Settings.Default.Path_URL_Commander;

            panel_Application.Visible = false;
            panel_Menu.Visible = true;

            VerificaDefaultPrinter();
            lab_def_printer.Text = GVar.glob_default_printer;

            //menu_btn_paths.Visible = false;
            //menu_spacer_01.Visible = false;

            menu_btn_prodotti.Visible = false;
            menu_spacer_04.Visible = false;

            //menu_btn_Sw.Visible = false;
            //menu_spacer_05.Visible = false;

            menu_btn_Clienti.Visible = true;
            menu_spacer_06.Visible = true;


        }

        private void menu_btn_ID_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_ID frm_child = new UC_form_ID();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;
            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void panel_Application_ControlRemoved(object sender, ControlEventArgs e)
        {
            panel_Application.Visible = false;
            panel_Menu.Visible = true;
        }

        private void menu_btn_printer_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Printers frm_child = new UC_form_Printers();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;

            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerificaDefaultPrinter()
        {
            GVar.glob_default_printer = Properties.Settings.Default.IP_Printer;

            //dB_FactoryDataSet.Printers.DefaultView.RowFilter = "Prn_Default = " + true;
            //DataTable dt = (dB_FactoryDataSet.Printers.DefaultView).ToTable();
            //int i = dt.Rows.Count;
            //if (i>1)
            //{
            //    MessageBox.Show("Troppe stampanti predefinite in tabella! Verrà selezionata la prima");
            //}
            //foreach (DataRow dr in dt.Rows)
            //{
            //    GVar.glob_default_printer = dr["Prn_Address"].ToString();
            //    break;
            //}
        }

        private void menu_btn_prodotti_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Prodotti frm_child = new UC_form_Prodotti();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;

            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void menu_btn_Sw_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Sw frm_child = new UC_form_Sw();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;

            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void menu_btn_Clienti_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_PopolaDB frm_child = new UC_form_PopolaDB();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;

            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;

        }

        private void menu_btn_paths_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Paths frm_child = new UC_form_Paths();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;
            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void menu_btn_Gecko_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Gecko frm_child = new UC_form_Gecko();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;
            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void menu_btn_Ordini_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_PopolaDB frm_child = new UC_form_PopolaDB();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;
            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;

        }

        private void menu_btn_Spedizioni_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_Spedizioni frm_child = new UC_form_Spedizioni();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;
            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }

        private void menu_btn_FWCust_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_form_TagFW frm_child = new UC_form_TagFW();
            frm_child.AutoSize = true;
            frm_child.Dock = DockStyle.Fill;
            frm_child.Visible = true;

            panel_Application.Controls.Add(frm_child);
            panel_Application.Dock = DockStyle.Fill;
            frm_child.Show();

            panel_Menu.Visible = false;
            panel_Application.Dock = DockStyle.Fill;
            panel_Application.Visible = true;
        }
    }
}
