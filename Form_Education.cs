using MulakatProje_Simfer.Operations.DB;
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
    public partial class Form_Education : Form
    {
        Person person;
        public Form_Education(int r)
        {
            person = new Person();
            person.ID = r;
            InitializeComponent();
            dataGridView1.DataSource = Operations.Database.SQL_query("select * from TBL_EDUCATION where [FID] = " + r);
        }

        private void TB_StartYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Operations.Auxilary_Form.OnlyNumber(e);
        }

        private void TB_EndYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Operations.Auxilary_Form.OnlyNumber(e);
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Operations.Database.SQL_query("INSERT INTO" +
                " [TBL_EDUCATION] VALUES " +
                "(" + person.ID +
                ",'" + TB_SchoolName.Text + "'" +
                ",'" + TB_SchoolCity.Text + "'" +
                "," + TB_StartYear.Text +
                "," + TB_EndYear.Text +
                ",'" + TB_Type.Text + "')");
        }
    }
}
