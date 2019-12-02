using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Factory
{
    public partial class Win_form_PDF : Form
    {
        public string windowsTempPath = "";

        public Win_form_PDF(string value)
        {
            InitializeComponent();
            windowsTempPath = value;
        }

        private void Win_form_PDF_Load(object sender, EventArgs e)
        {
            pdf_view.Load(windowsTempPath);
        }
    }
}
