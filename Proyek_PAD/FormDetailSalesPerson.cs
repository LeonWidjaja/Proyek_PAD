using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_PAD
{
    public partial class FormDetailSalesPerson : Form
    {
        private SalesPerson loggedInUser;
        public FormDetailSalesPerson(SalesPerson loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void FormSalesPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
