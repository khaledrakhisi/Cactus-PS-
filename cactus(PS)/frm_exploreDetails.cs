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
    public partial class frm_exploreDetails : Form
    {
        public frm_exploreDetails()
        {
            InitializeComponent();
        }

        SqlDataAdapter dAdapter;

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private void playTheSound()
        {
            try
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch
            {
            }
        }

        private void refreshMasterSpentsDataset()
        {
            try
            {
                spentMasterTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString); spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster;";
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

        private void rdu_detailsByFilter_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ledgerGroup.Enabled = rdu_detailsByFilter.Checked;
        }

        private void frm_exploreDetails_Load(object sender, EventArgs e)
        {
            refreshMasterSpentsDataset();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                if (rdu_all.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT        dbo.spentMaster.spentMasterID as ID, dbo.spentMaster.spentMasterName as title , 'm' as kind " +
                                                         "FROM            dbo.spentMaster;";

                    dAdapter.SelectCommand.Connection.Open();
                    dAdapter.Fill(dSet, "viw_detailsCodes");
                    dAdapter.SelectCommand.Connection.Close();

                    dAdapter.SelectCommand.CommandText = "SELECT        dbo.detailsTable.detailID as ID, dbo.spentMaster.spentMasterName + ' ' +dbo.detailsTable.detail_name as title, 'd' as kind " +
                                                         "FROM            dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID " +
                                                         "WHERE dbo.detailsTable.detail_name <> '';";
                }
                else if (rdu_ledgers.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT        dbo.spentMaster.spentMasterID as ID, dbo.spentMaster.spentMasterName as title , 'm' as kind " +
                                                         "FROM            dbo.spentMaster;";
                }
                else if (rdu_details.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT        dbo.detailsTable.detailID as ID, dbo.spentMaster.spentMasterName + ' ' +dbo.detailsTable.detail_name as title, 'm' as kind " +
                                                         "FROM            dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID " +
                                                         "WHERE dbo.detailsTable.detail_name <> '';";
                }
                else if (rdu_detailsByFilter.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT        dbo.detailsTable.detailID as ID, dbo.spentMaster.spentMasterName + ' ' +dbo.detailsTable.detail_name as title, 'm' as kind " +
                                                         "FROM            dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID " +
                                                         "WHERE dbo.detailsTable.detail_name <> '' AND dbo.detailsTable.spentMasterID = @spentMasterID;";
                    dAdapter.SelectCommand.Parameters.AddWithValue("spentMasterID", tbx_ledgerCode.Text);
                }

                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "viw_detailsCodes");
                dAdapter.SelectCommand.Connection.Close();

                bs.DataSource = dSet;
                bs.DataMember = "viw_detailsCodes";

                //preparing the report engine
                if (bs.Count == 0)
                {
                    MessageBox.Show("اطلاعاتی پیدا نشد، لطفاً مجدداً سعی کنید");
                }
                else
                {
                    playTheSound();

                    frm_printAccDoc frmPrintAccDoc = new frm_printAccDoc();
                    frmPrintAccDoc.connectionString = this.connectionString;
                    frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_detailsCode.rpt";//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_detailsCode.rpt";
                    frmPrintAccDoc.dSet = dSet;
                    frmPrintAccDoc.ShowDialog();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void cmb_masterSpentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = spentMasterBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = spentMasterBindingSource.DataMember;
                frmFindRecords.listDisplayMember = cmb_masterSpentName.DisplayMember;
                frmFindRecords.listValueMember = cmb_masterSpentName.ValueMember;
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    try
                    {
                        spentMasterBindingSource.Position = spentMasterBindingSource.Find("spentMasterID", frmFindRecords.foundRecordID);
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
    }
}
