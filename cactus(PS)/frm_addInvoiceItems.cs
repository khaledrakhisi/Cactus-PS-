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
    public partial class frm_addInvoiceItems : Form
    {
        public frm_addInvoiceItems()
        {
            n_defaultSpentDefID = -1;
            InitializeComponent();
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }
        private string s_currentProjectTitle;
        public string currentProjectTitle
        {
            get { return s_currentProjectTitle; }
            set { s_currentProjectTitle = value; }
        }
        private int n_currentProjectID;
        public int currentPrjectID
        {
            get { return n_currentProjectID; }
            set { n_currentProjectID = value; }
        }

        private int n_defaultSpentDefID;
        public int defaultSpentDefID
        {
            get { return n_defaultSpentDefID; }
            set
            {
                refreshMasterSpentsDataset();
                refreshDefSpentsDataset(true);//select all the spentDefs

                n_defaultSpentDefID = value;
                
                int nSpentMasterID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Find("spentDefID", n_defaultSpentDefID)]["spentMasterID"];
                spentMasterBindingSource.Position = spentMasterBindingSource.Find("spentMasterID", nSpentMasterID);
                spentDefBindingSource.Position  = spentDefBindingSource.Find("spentDefID", n_defaultSpentDefID);
            }
        }

        private void refreshProjectsDataset()
        {
            SqlDataAdapter a = new SqlDataAdapter();            
            try
            {
                a.SelectCommand = new SqlCommand("select * from projectsTable;");
                a.SelectCommand.Connection = new SqlConnection(connectionString);
                pSDatabase5DataSet.projectsTable.Clear();
                a.SelectCommand.Connection.Open();
                a.Fill(pSDatabase5DataSet.projectsTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                a.SelectCommand.Connection.Close();
            }
        }

        private void refreshMasterSpentsDataset()
        {
            try
            {
                spentMasterTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster;";
                spentMasterTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                spentMasterTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.spentMaster.Clear();
                spentMasterTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentMasterTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void refreshDefSpentsDataset(bool b_selectAll)
        {
            try
            {
                if (spentMasterBindingSource.Count == 0) return;

                string sWhere = ";";
                if (!b_selectAll)
                {
                    sWhere = " WHERE spentMasterID = @nSpentMasterID;";
                }

                int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];

                spentDefTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentDefTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentDef" + sWhere;
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);
                spentDefTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();

                pSDatabase5DataSet.spentDef.Clear();
                spentDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentDef);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void frm_addInvoiceItems_Load(object sender, EventArgs e)
        {
            refreshProjectsDataset();

            if (currentProjectTitle != "")
            {
                projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectTitle", currentProjectTitle);
            }
            else
            {
                projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", currentPrjectID);
            }

            try
            {
                if (n_defaultSpentDefID == -1)
                {
                    refreshMasterSpentsDataset();
                    refreshDefSpentsDataset(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void spentMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                refreshDefSpentsDataset(false);    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tbx_amount.Text == "")
                {
                    tbx_amount.Text = "0";
                }            
            }
            catch
            {
            }
        }

        private void tbx_phi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_phi.Text == "")
                {
                    tbx_phi.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {            
        }

        private void frm_addInvoiceItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK && (tbx_amount.Text == "0" || tbx_phi.Text == "0"))
                {
                    MessageBox.Show("لطفا مقدار و یا مبلغ فی را وارد کنید");

                    if (tbx_amount.Text == "0")
                    {
                        tbx_amount.Focus();
                    }
                    else if (tbx_phi.Text == "0")
                    {
                        tbx_phi.Focus();
                    }
                    e.Cancel = true;
                }
            }
            catch
            {
            }
        }
    }
}
