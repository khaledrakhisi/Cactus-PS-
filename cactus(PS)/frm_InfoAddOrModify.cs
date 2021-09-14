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
    public partial class frm_InfoAddOrModify : Form
    {
        private bool b_openForAdd;

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private bool b_okClicked;
        public bool okClicked
        {
            get { return b_okClicked;}
            set { b_okClicked = true; }
        }

        private int n_curentPersonID;
        public int currentPersonID
        {
            get { return n_curentPersonID; }
            set { n_curentPersonID = value; }
        }

        public frm_InfoAddOrModify(bool openForAdd)
        {
            b_openForAdd = openForAdd;
            InitializeComponent();
        }

        private void refreshPersonsTableDataset()
        {
            personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
            personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
            personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            //personsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("", );
            personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable;";
            personsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
            pSDatabase5DataSet.personsTable.Clear();
            personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
            personsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
        }

        private void frm_InfoAddOrModify_Load(object sender, EventArgs e)
        {
            //connectionString = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
            //connectionString += "D:\\DEVELOP\\CSPROJECT\\CACTUS(PS)\\CACTUS(PS)\\PSDATABASE5.MDF;";
            //connectionString += "Integrated Security=True;Connect Timeout=30;User Instance=True";

            refreshPersonsTableDataset();

            if (b_openForAdd)
            {
                personsTableBindingSource.MoveLast();
            }
            else
            {
                int pos = personsTableBindingSource.Find("personID", currentPersonID);
                if(pos > -1)
                    personsTableBindingSource.Position = pos;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            b_okClicked = true;
        }

        private void frm_InfoAddOrModify_Shown(object sender, EventArgs e)
        {
            b_okClicked = false;
        }

        
    }
}
