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
    public partial class frm_projectsSmallLedger : Form
    {
        public frm_projectsSmallLedger()
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
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString); spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster where spentMaster_detailType = 1 OR spentMaster_detailType = 4;";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                a.SelectCommand.Connection.Close();
            }
        }

        private string getSumOfIndebtedAndCreditor(long spentMasterID, int _id, string sType, string accDocEvent_id)
        {
            SqlCommand sqlCmd = new SqlCommand();
            try
            {
                SqlParameter sqlPar;
                sqlCmd.Connection = new SqlConnection(connectionString);
                sqlCmd.CommandText = "returnSumOfEvents";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                sqlCmd.Parameters.AddWithValue("@_id", _id);
                sqlCmd.Parameters.AddWithValue("@sType", sType);
                sqlCmd.Parameters.AddWithValue("@stopAt_accDocEvent_id", accDocEvent_id);
                sqlPar = sqlCmd.Parameters.Add("@result", SqlDbType.NVarChar);
                sqlPar.Direction = ParameterDirection.ReturnValue;
                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();

                return sqlCmd.Parameters["@result"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCmd.Connection.Close();
            }
            return "0";
        }
        
        private void playTheSound()
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void completeTheLedger(int nSpentMasterID, int nDetailID, long spentMasterID)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);
                c.Parameters.AddWithValue("@detailID", nDetailID);
                c.Parameters.AddWithValue("@toAccDoc_id", spentMasterID);
                c.CommandText = "completeTheLedger";
                c.Connection.Open();
                c.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }
        }

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            try
            {
                dAdapter.SelectCommand.Parameters.Clear();

                if (rdu_showAll.Checked)
                {
                    sWhere = ";";
                }
                else if (rdu_showInDate.Checked)
                {
                    sWhere = " Where dbo.AccountingDocs.accDoc_date = @accDoc_date ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_inDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = " Where dbo.AccountingDocs.accDoc_date >= @accDoc_fromDate AND dbo.AccountingDocs.accDoc_date <= @accDoc_toDate ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_fromDate", mTbx_fromDate.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_toDate", mTbx_toDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = " Where dbo.AccountingDocs.accDoc_id >= @accDoc_fromID AND dbo.AccountingDocs.accDoc_id <= @accDoc_toID ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_fromID", tbx_fromID.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_toID", tbx_toID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sWhere;
        }

        private void frm_personsSmallLedger_Load(object sender, EventArgs e)
        {
            refreshMasterSpentsDataset();            
            refreshProjectsDataset();

            try
            {
                mTbx_inDate.Text = numberConvertor.nowDateInAppropriateFormat();
                mTbx_toDate.Text = numberConvertor.nowDateInAppropriateFormat();
                mTbx_fromDate.Text = numberConvertor.nowDateInAppropriateFormat();
            }
            catch
            {
            }
        }

        private string getSumOfIndebtedAndCreditor(long spentMasterID, int nDetailID, string accDocEvent_id)
        {
            SqlCommand sqlCmd = new SqlCommand();
            try
            {
                SqlParameter sqlPar;
                sqlCmd.Connection = new SqlConnection(connectionString);
                sqlCmd.CommandText = "returnSumOfEvents";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                sqlCmd.Parameters.AddWithValue("@stopAt_accDocEvent_id", accDocEvent_id);
                sqlPar = sqlCmd.Parameters.Add("@result", SqlDbType.NVarChar);
                sqlPar.Direction = ParameterDirection.ReturnValue;
                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();

                return sqlCmd.Parameters["@result"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCmd.Connection.Close();
            }
            return "0";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string ind = "", cre = "", rem = "", detect = "", sWhere = "";

            if (limitString[6] == '0')//limitString[6] == allow show projects ledger
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (projectsTableBindingSource.Count == 0)
                {
                    MessageBox.Show("پروژه ای تعریف نشده است، برای اطلاعات بیشتر به راهنمای برنامه مراجعه کنید");
                    return;
                }

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                //getting the small ledger code
                int nDetailID = int.Parse(tbx_projectID.Text);
                long spentMasterID = -1;

                //build the where structure
                string swhere = "";
                sWhere = buildTheWhereStatement();
                swhere = "WHERE (detailsTable.projectID = @detailID)AND(spentMaster.spentMaster_detailType = 1 OR spentMaster.spentMaster_detailType = 4) ";
                if (sWhere == ";")
                {
                    sWhere = "Where(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                }
                else
                {
                    sWhere += " AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                }
                if (chk_filterLedger.Checked)
                {
                    sWhere += " AND(detailsTable.spentMasterID = @spentMasterID) ";
                    spentMasterID = long.Parse(tbx_ledgerCode.Text);
                }
                sWhere = sWhere.Replace("Where", "AND");
                sWhere = swhere + sWhere;

                try
                {
                    projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", tbx_projectID.Text);
                }
                catch
                {
                }

                //-----------------------------
                completeTheLedger(-3, nDetailID, spentMasterID);

                dAdapter.SelectCommand.Parameters.AddWithValue("@detailID", nDetailID);
                dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                         "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, detailsTable.detail_name, " +
                                                         "spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id, accDocEventsTable.accDocEvent_detectID " +
                                                         "FROM            AccountingDocs INNER JOIN accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                         "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                         sWhere + " ORDER BY dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_id;";
                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "viw_ledger");
                dAdapter.SelectCommand.Connection.Close();

                bs.DataSource = dSet;
                bs.DataMember = "viw_ledger";

                ////////////////////////////////////////////////////////
                string accDocEvent_id = "";
                if (bs.Count > 0)
                {
                    accDocEvent_id = dSet.Tables["viw_ledger"].Rows[0]["accDocEvent_id"].ToString();

                    string sWh = "";
                    if (chk_filterLedger.Checked)
                    {
                        sWh = "WHERE (detailsTable.projectID = @detailID)AND(spentMaster.spentMaster_detailType = 1 OR spentMaster.spentMaster_detailType = 4)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL)AND(detailsTable.spentMasterID = @spentMasterID) ";
                    }
                    else
                    {
                        sWh = "WHERE (detailsTable.projectID = @detailID)AND(spentMaster.spentMaster_detailType = 1 OR spentMaster.spentMaster_detailType = 4)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    }

                    dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                         "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, detailsTable.detail_name, " +
                                                         "spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id, accDocEventsTable.accDocEvent_detectID " +
                                                         "FROM            AccountingDocs INNER JOIN accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                         "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                         sWh +
                                                         "ORDER BY dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_id;";
                    dAdapter.SelectCommand.Connection.Open();
                    dSet.Clear();
                    dAdapter.Fill(dSet, "viw_ledger");
                    dAdapter.SelectCommand.Connection.Close();

                    bs.Position = bs.Find("accDocEvent_id", accDocEvent_id);
                    if (bs.Position > 0)
                    {
                        bs.MovePrevious();

                        rem = dSet.Tables["viw_ledger"].Rows[bs.Position]["accDocEvent_retail"].ToString();
                        detect = dSet.Tables["viw_ledger"].Rows[bs.Position]["accDocEvent_detectID"].ToString();

                        //get Indebted and creditor money. the below function returns 'indebted;creditor'
                        string s = getSumOfIndebtedAndCreditor(-3, nDetailID, accDocEvent_id);
                        ind = s.Substring(0, s.IndexOf(";"));
                        s = s.Remove(0, s.IndexOf(";") + 1);
                        cre = s;

                        if (detect == "1")
                            detect = "بد";
                        else if (detect == "2")
                            detect = "بس";
                        else if (detect == "3")
                            detect = "--";
                    }
                }
                ////////////////////////////////////////////                    
                dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                      "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, detailsTable.detail_name, " +
                                                         "spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id, accDocEventsTable.accDocEvent_detectID " +
                                                         "FROM            AccountingDocs INNER JOIN accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                         "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                         sWhere + " ORDER BY dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_id;";

                dAdapter.SelectCommand.Connection.Open();
                dSet.Clear();
                dAdapter.Fill(dSet, "viw_ledger");
                dAdapter.SelectCommand.Connection.Close();

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
                    //total of remain money in chars
                    frmPrintAccDoc.TotalOfInvoice = dSet.Tables["viw_ledger"].Rows[bs.Count - 1]["accDocEvent_retail"].ToString();
                    if (sWhere != ";")
                    {
                        frmPrintAccDoc.s_ind = ind;
                        frmPrintAccDoc.s_cre = cre;
                        frmPrintAccDoc.s_rem = rem;
                        frmPrintAccDoc.s_detect = detect;
                    }
                    frmPrintAccDoc.crystalReportViewer1.DisplayGroupTree = false;
                    //frmPrintAccDoc.bookType = cmb_masterSpentName.Text + " " + cmb_detail.Text;
                    frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_projectsSmallLedger.rpt";
                    //frmPrintAccDoc.sFilePath = @"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_projectsSmallLedger.rpt";
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
            try
            {
                mTbx_inDate.Enabled = rdu_showInDate.Checked;
            }
            catch
            {
            }
        }

        private void rdu_showBetweenDates_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_betweenDates.Enabled = rdu_showBetweenDates.Checked;
            }
            catch
            {
            }
        }

        private void rdu_showBetweenAccDoc_ids_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_betweenIDs.Enabled = rdu_showBetweenAccDoc_ids.Checked;

            }
            catch
            {
            }
        }

        private void cmb_persons_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = projectsTableBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = projectsTableBindingSource.DataMember;
                frmFindRecords.listDisplayMember = cmb_projects.DisplayMember;
                frmFindRecords.listValueMember = cmb_projects.ValueMember;
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    try
                    {
                        projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", frmFindRecords.foundRecordID);
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

        private void mTbx_inDate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    mTbx_inDate.Text = numberConvertor.nowDateInAppropriateFormat();
                }
            }
            catch
            {
            }
        }

        private void mTbx_fromDate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    mTbx_fromDate.Text = numberConvertor.nowDateInAppropriateFormat();
                }
            }
            catch
            {
            }
        }

        private void mTbx_toDate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    mTbx_toDate.Text = numberConvertor.nowDateInAppropriateFormat();
                }
            }
            catch
            {
            }
        }

        private void mTbx_inDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_inDate.Text = numberConvertor.makeChangeToDateString(mTbx_inDate.Text);
                if (mTbx_inDate.Text.Length < 9)
                {
                    MessageBox.Show("تاریخ را درست وارد کنید");
                    mTbx_inDate.Focus();
                }
                if (numberConvertor.findDateError(1370, mTbx_inDate.Text) == "d")
                {
                    MessageBox.Show("روز را درست وارد کنید");
                    mTbx_inDate.Focus();
                    mTbx_inDate.Select(8, 2);
                }
                if (numberConvertor.findDateError(1370, mTbx_inDate.Text) == "m")
                {
                    MessageBox.Show("ماه را درست وارد کنید");
                    mTbx_inDate.Focus();
                    mTbx_inDate.Select(5, 2);
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

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void chk_filterLedger_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ledger.Enabled = chk_filterLedger.Checked;
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
