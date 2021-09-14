using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace cactus_PS_
{
    public partial class frm_editAccDocEvent : Form
    {
        public frm_editAccDocEvent()
        {                      
            InitializeComponent();
            nDetailID = -1;
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
        public int currentProjectID
        {
            get { return n_currentProjectID; }
            set { n_currentProjectID = value; }
        }
        public int nDetailID;

        private void refreshTheDetailsDataset()
        {
            try
            {
                viw_detailsTableAdapter.Adapter.SelectCommand = new SqlCommand("SELECT        dbo.detailsTable.spentMasterID, dbo.detailsTable.detailID, dbo.spentMaster.spentMasterName + ' ' + dbo.detailsTable.detail_name AS fullDetailName FROM dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID;");
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                viw_detailsTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.viw_details.Clear();
                viw_detailsTableAdapter.Adapter.Fill(pSDatabase5DataSet.viw_details);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void frm_editAccDocEvent_Load(object sender, EventArgs e)
        {
            try
            {
                refreshTheDetailsDataset();

                if (nDetailID != -1)
                {
                    viwdetailsBindingSource.Position = viwdetailsBindingSource.Find("detailID", nDetailID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                nDetailID = int.Parse(lbl_detailID.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_indebted_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_indebted.Text == "")
                {
                    tbx_indebted.Text = "0";
                }
                if (long.Parse(tbx_indebted.Text) > 0)
                {
                    tbx_creditor.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void tbx_creditor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_creditor.Text == "")
                {
                    tbx_creditor.Text = "0";
                }
                if (long.Parse(tbx_creditor.Text) > 0)
                {
                    tbx_indebted.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void frm_editAccDocEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && tbx_creditor.Text == tbx_indebted.Text)
            {
                if (tbx_creditor.Text != "0" && tbx_indebted.Text != "0")
                {
                    MessageBox.Show("مبلغ بدهکاری با مبلغ بستانکاری برابر می باشد امکان اضافه کردن سطر وجود ندارد");
                }
                else
                {
                    tbx_indebted.Focus();
                }
                e.Cancel = true;                
            }            
        }

        private void chk_detail_CheckedChanged(object sender, EventArgs e)
        {
            //cmb_detail.Enabled = chk_detail.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_detail_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = viwdetailsBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = viwdetailsBindingSource.DataMember;
                frmFindRecords.listDisplayMember = cmb_detail.DisplayMember;
                frmFindRecords.listValueMember = cmb_detail.ValueMember;
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    try
                    {
                        viwdetailsBindingSource.Position = viwdetailsBindingSource.Find("detailID", frmFindRecords.foundRecordID);
                    }
                    catch
                    {
                    }

                }
                e.Handled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void cmb_detail_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmb_detail_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_detail_DropDownClosed(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"accDocs_row_selected\"");
            }
            catch
            {
            }
        }
    }
}
