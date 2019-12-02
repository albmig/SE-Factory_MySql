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
    public partial class Processing : Form
    {
        public Processing()
        {
            InitializeComponent();
        }

        private void ProcessingTimer_Tick(object sender, EventArgs e)
        {
            if (GVar.CloseSplash)
            {
                this.Close();
            }

        }
    }
}
