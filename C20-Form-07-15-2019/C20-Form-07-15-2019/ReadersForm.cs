using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_Form_07_15_2019
{
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conSql);
            string conCom = "Select * from Books";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(conCom, conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Books");
            dtgView.DataSource = ds.Tables["Books"];
            conn.Close();
        }
    }
}
