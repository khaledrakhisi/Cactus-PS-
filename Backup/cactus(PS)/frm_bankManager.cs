using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cactus_PS_
{
    public partial class frm_bankManager : Form
    {
        public frm_bankManager()
        {
            InitializeComponent();
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                DataSet dset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(tbx_sqlCmd.Text);
                adapter.SelectCommand.Connection = new SqlConnection(tbx_connectionString.Text);
                adapter.SelectCommand.Connection.Open();
                dset.Clear();
                adapter.SelectCommand.ExecuteNonQuery();

                try
                {

                    adapter.Fill(dset, "table1");
                }
                catch 
                {
                }
                adapter.SelectCommand.Connection.Close();

                bs.DataSource = dset;
                bs.DataMember = "table1";

                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_bankManager_Load(object sender, EventArgs e)
        {
            tbx_connectionString.Text = this.connectionString;
        }
    }
}
