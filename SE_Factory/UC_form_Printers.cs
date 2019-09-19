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
    public partial class UC_form_Printers : UserControl
    {
        public UC_form_Printers()
        {
            InitializeComponent();
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP_Printer = tb_IP_printer_addr.Text;
            if (toggle_always_print.Checked)
            {
                Properties.Settings.Default.IP_Printer_alwaysprint = true;
            }
            else
            {
                Properties.Settings.Default.IP_Printer_alwaysprint = true;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Salvataggio effettuato correttamente");
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            tb_IP_printer_addr.Text = Properties.Settings.Default.IP_Printer;
            if (Properties.Settings.Default.IP_Printer_alwaysprint)
            {
                toggle_always_print.Checked = true;
            }
            else
            {
                toggle_always_print.Checked = false;
            }

            tb_IP_printer_addr.Refresh();
        }

        private void UC_form_Printers_Load(object sender, EventArgs e)
        {
            tb_IP_printer_addr.Text = Properties.Settings.Default.IP_Printer;
            if (Properties.Settings.Default.IP_Printer_alwaysprint)
            {
                toggle_always_print.Checked = true;
            }
            else
            {
                toggle_always_print.Checked = false;
            }
            tb_IP_printer_addr.PromptChar = ' ';
            tb_IP_printer_addr.ResetOnSpace = false;
            tb_IP_printer_addr.SkipLiterals = false;
            tb_IP_printer_addr.ValidatingType = typeof(System.Net.IPAddress);
        }
    }
}
