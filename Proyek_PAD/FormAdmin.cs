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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            tbID.Enabled = false;
        }

        int index = -1;
        AdventureWorks2019Entities aw = new AdventureWorks2019Entities();

        public void resetInputs()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbTitle.Text = "";
            dtpHiredDate.Value = DateTime.Now;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            var employees = from emp in aw.Employees
                            join person in aw.People on emp.BusinessEntityID equals person.BusinessEntityID
                            orderby emp.BusinessEntityID ascending
                            select new
                            {
                                id = emp.BusinessEntityID,
                                name = person.FirstName + " " + person.MiddleName + " " + person.LastName,
                                title = emp.JobTitle,
                                hiredDate = emp.HireDate
                            };
            dataGridView1.DataSource = employees.ToList();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Job Title";
            dataGridView1.Columns[3].HeaderText = "Hired Date";

            var salesPerson = from sp in aw.SalesPersons
                              join person in aw.People on sp.BusinessEntityID equals person.BusinessEntityID
                              orderby sp.BusinessEntityID ascending
                              select new
                              {
                                  id = sp.BusinessEntityID,
                                  name = person.FirstName + " " + person.MiddleName + " " + person.LastName,
                                  salesQuota = sp.SalesQuota,
                                  bonus = sp.Bonus,
                                  commissionPct = sp.CommissionPct,
                                  salesYTD = sp.SalesYTD,
                                  salesLastYear = sp.SalesLastYear,
                                  modifiedDate = sp.ModifiedDate
                              };
            dataGridView2.DataSource = salesPerson.ToList();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Name";
            dataGridView2.Columns[2].HeaderText = "Sales Quota";
            dataGridView2.Columns[3].HeaderText = "Bonus";
            dataGridView2.Columns[4].HeaderText = "Commission Pct";
            dataGridView2.Columns[5].HeaderText = "Sales YTD";
            dataGridView2.Columns[6].HeaderText = "Sales Last Year";
            dataGridView2.Columns[7].HeaderText = "Modified Date";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            tbID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            tbTitle.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dtpHiredDate.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells[3].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals(""))
            {
                if (!tbTitle.Text.Equals(""))
                {
                    if (!dtpHiredDate.Text.Equals(""))
                    {
                        SalesPerson salesPerson = new SalesPerson();
                        salesPerson.BusinessEntityID = Convert.ToInt32(tbID.Text);
                        salesPerson.TerritoryID = 0;
                        salesPerson.SalesQuota = 0;
                        salesPerson.Bonus = 0;
                        salesPerson.CommissionPct = 0;
                        salesPerson.SalesYTD = 0;
                        salesPerson.SalesLastYear = 0;
                        salesPerson.ModifiedDate = DateTime.Now;
                        aw.SalesPersons.Add(salesPerson);
                        aw.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Hired Date cannot be empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Job Title cannot be empty!");
                }
            }
            else
            {
                MessageBox.Show("Name cannot be empty!");
            }
        }
    }
}
