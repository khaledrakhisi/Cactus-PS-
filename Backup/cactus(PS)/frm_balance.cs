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
    public partial class frm_balance : Form
    {
        public frm_balance()
        {
            InitializeComponent();
        }

        SqlDataAdapter dAdapter;

        private string s_limitString;
        public string limitString
        {
            get { return s_limitString; }
            set { s_limitString = value; }
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private void refreshMasterSpentsDataset()
        {
            try
            {
                spentMasterTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString); 
                spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster order by spentMasterName;";
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

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            try
            {
                if (rdu_showInDate.Checked)
                {
                    sWhere = " WHERE        (dbo.AccountingDocs.accDoc_date <= @untilDate)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.Clear();
                    dAdapter.SelectCommand.Parameters.AddWithValue("@untilDate", mTbx_tilDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = " WHERE        (dbo.AccountingDocs.accDoc_date >= @fromDate AND dbo.AccountingDocs.accDoc_date <= @toDate)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.Clear();
                    dAdapter.SelectCommand.Parameters.AddWithValue("@fromDate", mTbx_fromDate.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@toDate", mTbx_toDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = " WHERE        (dbo.AccountingDocs.accDoc_id >= @fromID AND dbo.AccountingDocs.accDoc_id <= @toID)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.Clear();
                    dAdapter.SelectCommand.Parameters.AddWithValue("@fromID", tbx_fromID.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@toID", tbx_toID.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sWhere;
        }
        
        private void playTheSound()
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void rdu_showDetailBalance_CheckedChanged(object sender, EventArgs e)
        {
            pnl_showDetailBalance.Enabled = rdu_onlyShowDetailBalance.Checked;
        }

        private void chk_ledger_CheckedChanged(object sender, EventArgs e)
        {
            cmb_masterSpentName.Enabled = chk_ledger.Checked;
        }

        private void frm_balance_Load(object sender, EventArgs e)
        {
            refreshMasterSpentsDataset();

            try
            {
                mTbx_tilDate.Text = numberConvertor.nowDateInAppropriateFormat();
                mTbx_fromDate.Text = numberConvertor.nowDateInAppropriateFormat();
                mTbx_toDate.Text = numberConvertor.nowDateInAppropriateFormat();
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[7] == '0')//limitString[1] == allow show 'balance'
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                string sWhereStatment = buildTheWhereStatement();

                if (rdu_onlyShowLedgerBalance.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT dbo.spentMaster.spentMasterName, SUM(dbo.accDocEventsTable.accDocEvent_indebted) AS indTotal, SUM(dbo.accDocEventsTable.accDocEvent_creditor) AS creTotal, dbo.detailsTable.spentMasterID,'' as detail_name, '' as DetailID " +
                                                         "FROM   dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                         sWhereStatment +
                                                         "GROUP BY dbo.spentMaster.spentMasterName, dbo.detailsTable.spentMasterID;";

                    dAdapter.SelectCommand.Connection.Open();
                    dAdapter.Fill(dSet, "viw_balance");
                    dAdapter.SelectCommand.Connection.Close();
                }

                else if (rdu_onlyShowDetailBalance.Checked)
                {
                    int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];
                    string sWhere = "";
                    if (chk_ledger.Checked)
                    {
                        sWhere = "WHERE (dbo.detailsTable.spentMasterID = @spentMasterID) AND (dbo.spentMaster.spentMaster_detailType <> 0)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    }
                    else
                    {
                        sWhere = "WHERE (dbo.spentMaster.spentMaster_detailType <> 0)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    }

                    dAdapter.SelectCommand.CommandText = "SELECT dbo.spentMaster.spentMasterName, SUM(dbo.accDocEventsTable.accDocEvent_indebted) AS indTotal, SUM(dbo.accDocEventsTable.accDocEvent_creditor) AS creTotal, '' as spentMasterID, dbo.detailsTable.detail_name, dbo.accDocEventsTable.detailID " +
                                                         "FROM   dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                         sWhere +
                                                         "GROUP BY dbo.spentMaster.spentMasterName, dbo.detailsTable.detail_name, dbo.accDocEventsTable.detailID;";
                    
                    dAdapter.SelectCommand.Parameters.Clear();
                    dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);
                    dAdapter.SelectCommand.Connection.Open();
                    dAdapter.Fill(dSet, "viw_balance");
                    dAdapter.SelectCommand.Connection.Close();
                }

                bs.DataSource = dSet;
                bs.DataMember = "viw_balance";

                if (bs.Count == 0)
                {
                    MessageBox.Show("اطلاعاتی پیدا نشد، لطفاً مجدداً سعی کنید");
                }
                else
                {
                    try
                    {
                        playTheSound();
                    }
                    catch
                    {
                    }

                    frm_printAccDoc frmPrintAccDoc = new frm_printAccDoc();
                    frmPrintAccDoc.connectionString = this.connectionString;
             
                    string sDateString = "";
                    if (rdu_showInDate.Checked)
                    {
                        sDateString = "منتهی به تاریخ :" + mTbx_tilDate.Text;
                    }
                    else if (rdu_showBetweenDates.Checked)
                    {
                        sDateString = "از تاریخ :" + mTbx_fromDate.Text + "    تا تاریخ : " + mTbx_toDate.Text;
                    }
                    else if (rdu_showBetweenAccDoc_ids.Checked)
                    {
                        sDateString = "از سند شماره :" + tbx_fromID.Text + "    تا سند شماره : " + tbx_toID.Text;
                    }
                    frmPrintAccDoc.dateString = sDateString;                    
                    if (rdu_TwoColumnsBalance.Checked)
                    {
                        frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_twoBalance.rpt";//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_twoBalance.rpt";
                    }
                    else if (rdu_fourColumnsBalance.Checked)
                    {
                        frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_balance.rpt";//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_balance.rpt";
                    }
                    frmPrintAccDoc.dSet = dSet;
                    frmPrintAccDoc.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdu_showInDate_CheckedChanged(object sender, EventArgs e)
        {
            mTbx_tilDate.Enabled = rdu_showInDate.Checked;
        }

        private void rdu_showBetweenDates_CheckedChanged(object sender, EventArgs e)
        {
            pnl_betweenDates.Enabled = rdu_showBetweenDates.Checked;
        }

        private void rdu_showBetweenAccDoc_ids_CheckedChanged(object sender, EventArgs e)
        {
            pnl_betweenIDs.Enabled = rdu_showBetweenAccDoc_ids.Checked;
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

        private void mTbx_tilDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_tilDate.Text = numberConvertor.makeChangeToDateString(mTbx_tilDate.Text);
                if (mTbx_tilDate.Text.Length < 9)
                {
                    MessageBox.Show("تاریخ را درست وارد کنید");
                    mTbx_tilDate.Focus();
                }
                if (numberConvertor.findDateError(1370, mTbx_tilDate.Text) == "d")
                {
                    MessageBox.Show("روز را درست وارد کنید");
                    mTbx_tilDate.Focus();
                    mTbx_tilDate.Select(8, 2);
                }
                if (numberConvertor.findDateError(1370, mTbx_tilDate.Text) == "m")
                {
                    MessageBox.Show("ماه را درست وارد کنید");
                    mTbx_tilDate.Focus();
                    mTbx_tilDate.Select(5, 2);
                }
            }
            catch
            {
            }
        }

        private void mTbx_fromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_fromDate.Text = numberConvertor.makeChangeToDateString(mTbx_fromDate.Text);
                if (mTbx_fromDate.Text.Length < 9)
                {
                    MessageBox.Show("تاریخ را درست وارد کنید");
                    mTbx_fromDate.Focus();
                }
                if (numberConvertor.findDateError(1370, mTbx_fromDate.Text) == "d")
                {
                    MessageBox.Show("روز را درست وارد کنید");
                    mTbx_fromDate.Focus();
                    mTbx_fromDate.Select(8, 2);
                }
                if (numberConvertor.findDateError(1370, mTbx_fromDate.Text) == "m")
                {
                    MessageBox.Show("ماه را درست وارد کنید");
                    mTbx_fromDate.Focus();
                    mTbx_fromDate.Select(5, 2);
                }
            }
            catch
            {
            }
        }

        private void mTbx_toDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_toDate.Text = numberConvertor.makeChangeToDateString(mTbx_toDate.Text);
                if (mTbx_toDate.Text.Length < 9)
                {
                    MessageBox.Show("تاریخ را درست وارد کنید");
                    mTbx_toDate.Focus();
                }
                if (numberConvertor.findDateError(1370, mTbx_toDate.Text) == "d")
                {
                    MessageBox.Show("روز را درست وارد کنید");
                    mTbx_toDate.Focus();
                    mTbx_toDate.Select(8, 2);
                }
                if (numberConvertor.findDateError(1370, mTbx_toDate.Text) == "m")
                {
                    MessageBox.Show("ماه را درست وارد کنید");
                    mTbx_toDate.Focus();
                    mTbx_toDate.Select(5, 2);
                }
            }
            catch
            {
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void rdu_TwoColumnsBalance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdu_fourColumnsBalance_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
