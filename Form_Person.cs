using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulakatProje_Simfer
{
    public partial class Form_Person : Form
    {
        int? PersonID = null;
        Operations.DB.Person person;
        List<Operations.DB.Person> childList;
        public Form_Person(int r_PersonID)
        {
            InitializeComponent();

            person = Operations.DB.Person.getData(r_PersonID);
            Button_Selected.Text = person.Name;

            Button_Parent1.Text = "Parent:" + Operations.DB.Person.getData(person.FID_PM).Name;
            Button_Parent2.Text = "Parent:" + Operations.DB.Person.getData(person.FID_PF).Name;
            Button_Partner.Text = "Partner:" + Operations.DB.Person.getData(person.Partner_ID).Name;

            childList = Operations.DB.Person.getChild(person.ID);
            foreach (var child in childList) { LB_Children.Items.Add(child.Name); }

            dataGridView1.DataSource = Operations.Database.SQL_query("select * from TBL_Person");

        }
        private void Form_Person_Load(object sender, EventArgs e)
        {

        }

        private void Button_Parent1_Click(object sender, EventArgs e)
        {
            GoNewForm(person.FID_PM);
        }

        private void Button_Parent2_Click(object sender, EventArgs e)
        {
            GoNewForm(person.FID_PF);
        }

        private void Button_Partner_Click(object sender, EventArgs e)
        {
            GoNewForm(person.Partner_ID);
        }
        private void LB_Children_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = (ListBox)sender;
            GoNewForm(childList.ElementAt(r.SelectedIndex).ID);
        }
        void GoNewForm(int? r)
        {
            try
            {
                var f = new Form_Person((int)r);
                f.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error.! Code:2404150046F");
            }
        }

        private void Button_EditEducations_Click(object sender, EventArgs e)
        {

        }


        private void LB_Educations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var r = e.RowIndex+1;
            GoNewForm(r);
        }
    }
}
