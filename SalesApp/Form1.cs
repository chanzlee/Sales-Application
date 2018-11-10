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
    }
}
