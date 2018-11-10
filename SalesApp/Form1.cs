using SalesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        private void GetLists()
        {
            using (var context = new SalesContext())
            {
                salesPersonBindingSource.DataSource = context.People
                    .Where(e => e.Active)
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList();


                salesRegionBindingSource.DataSource = context.Regions
                    .Where(e => e.Active)
                    .OrderBy(e => e.Name)
                    .ToList();

            }
        }


        private void peopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshSalesbutton_Click(object sender, EventArgs e)
        {
            var personId = (int)peopleComboBox.SelectedValue;
            var regionId = (int)regionComboBox.SelectedValue;

            using (var context = new SalesContext())
            {
                saleBindingSource.DataSource = context.Sales
                    .Where(s => s.PersonId == personId &&
                                s.RegionId == regionId)
                    .OrderBy(s => s.Date)
                    .ToList();
            }
        }

        private void salesTargetButton_Click(object sender, EventArgs e)
        {
            var personId = (int) peopleComboBox.SelectedValue;
            using (var context = new SalesContext())
            {
                var person = context.People.SingleOrDefault(p => p.Id == personId);

                if (person != null)
                {
                    MessageBox.Show(string.Format("{0} has a sales target of {1:C}",
                        person.Fullname, person.SalesTarget));
                }
            }
        }
    }
}
