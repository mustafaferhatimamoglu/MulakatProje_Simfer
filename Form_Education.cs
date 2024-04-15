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
        public Form_Education(int r)
        {
            InitializeComponent();
            dataGridView1.DataSource = Operations.Database.SQL_query("select * from TBL_EDUCATION where [FID] = "+r);
        }
    }
}
