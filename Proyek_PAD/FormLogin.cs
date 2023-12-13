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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong!");
                return;
            }

            if (username == "admin")
            {
                if(password != "admin")
                {
                    MessageBox.Show("Password salah!");
                    return;
                }
                else if(password == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                }
            }

            /*AdventureWorks2019Entities context = new AdventureWorks2019Entities();
            SalesPerson user = from SalesPerson in context.SalesPersons
                               join Person in context.Persons on SalesPerson.BusinessEntityID equals Person.BusinessEntityID
                               where Person.EmailPromotion == 1 && Person.EmailAddress == username*/
        }
    }
}
