using System;
using System.Data;

namespace SE_Factory
{
    internal class Bs_Fam_Prod_CurrentChanged
    {
        private Action<object, DataRowChangeEventArgs> bs_Fam_Prod_CurrentChanged;

        public Bs_Fam_Prod_CurrentChanged(Action<object, DataRowChangeEventArgs> bs_Fam_Prod_CurrentChanged)
        {
            this.bs_Fam_Prod_CurrentChanged = bs_Fam_Prod_CurrentChanged;
        }
    }
}