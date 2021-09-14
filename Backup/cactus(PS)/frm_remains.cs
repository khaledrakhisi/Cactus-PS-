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
    public partial class frm_remains : Form
    {
        public frm_remains()
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

        private string buildTheWhereStatementForDate()
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
                    sWhere = " Having dbo.AccountingDocs.accDoc_date = @accDoc_date ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_inDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = " Having dbo.AccountingDocs.accDoc_date >= @accDoc_fromDate AND dbo.AccountingDocs.accDoc_date <= @accDoc_toDate ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_fromDate", mTbx_fromDate.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_toDate", mTbx_toDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = " Having dbo.AccountingDocs.accDoc_id >= @accDoc_fromID AND dbo.AccountingDocs.accDoc_id <= @accDoc_toID ";
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

        private string buildTheWhereStatement()
        {
            string sStatement = "", sCondition = "";

            dAdapter.SelectCommand.Parameters.Clear();

            if (rdu_allCases.Checked)
            {
                return "";
            }
            else if (rdu_betweenPrice.Checked)
            {
                sCondition = " >= @fromPrice) AND (ABS(SUM(dbo.accDocEventsTable.accDocEvent_indebted) - SUM(dbo.accDocEventsTable.accDocEvent_creditor)) <= @toPrice) ";
                dAdapter.SelectCommand.Parameters.AddWithValue("@fromPrice", tbx_fromPrice.Text);
                dAdapter.SelectCommand.Parameters.AddWithValue("@toPrice", tbx_toPrice.Text);
            }
            else if (rdu_equalsPrice.Checked)
            {
                sCondition = " = @price) ";
                dAdapter.SelectCommand.Parameters.AddWithValue("@price", tbx_fromPrice.Text);
            }
            else if (rdu_moreThanPrice.Checked)
            {
                sCondition = " > @price) ";
                dAdapter.SelectCommand.Parameters.AddWithValue("@price", tbx_fromPrice.Text);
            }
            else if (rdu_lessThanPrice.Checked)
            {
                sCondition = " < @price) ";
                dAdapter.SelectCommand.Parameters.AddWithValue("@price", tbx_fromPrice.Text);
            }

            if (cmb_conditionKind.SelectedIndex == 0)
            {
                sStatement = "Having (ABS(SUM(dbo.accDocEventsTable.accDocEvent_indebted) - SUM(dbo.accDocEventsTable.accDocEvent_creditor))" + sCondition + " AND (SUM(dbo.accDocEventsTable.accDocEvent_indebted) - SUM(dbo.accDocEventsTable.accDocEvent_creditor) > 0)";//"> 0" means indebted
            }
            else if (cmb_conditionKind.SelectedIndex == 1)
            {
                sStatement = "Having (ABS(SUM(dbo.accDocEventsTable.accDocEvent_indebted) - SUM(dbo.accDocEventsTable.accDocEvent_creditor))" + sCondition + " AND (SUM(dbo.accDocEventsTable.accDocEvent_indebted) - SUM(dbo.accDocEventsTable.accDocEvent_creditor) < 0)";//"< 0" means creditor
            }

            
            return sStatement;
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

        private void frm_remains_Load(object sender, EventArgs e)
        {
            refreshProjectsDataset();
            refreshMasterSpentsDataset();

            try
            {
                cmb_conditionKind.SelectedIndex = 0;
            }
            catch
            {
            }

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

        private void chk_filterByLedger_CheckedChanged(object sender, EventArgs e)
        {
            pnl_masterSpent.Enabled = chk_filterByLedger.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdu_betweenPrice_CheckedChanged(object sender, EventArgs e)
        {
            pnl_toPrice.Visible = rdu_betweenPrice.Checked;
        }

        private void rdu_showDetailRemains_CheckedChanged(object sender, EventArgs e)
        {
            pnl_detailRemains.Enabled = rdu_showDetailRemains.Checked;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[8] == '0')//limitString[8] == allow show remains
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sWhere = "", adjustDate = "تاریخ تنظیم" + " : " + numberConvertor.nowDateInAppropriateFormat();

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                sWhere = buildTheWhereStatement();

                //مانده حساب های کل
                if (rdu_showLedgerRemains.Checked)
                {
                    dAdapter.SelectCommand.CommandText = "SELECT     'مـــانده حــسابهای کـــل' as reportTitle, '" + adjustDate + "' as para3, '' as detailID, '' as detail_name,  dbo.spentMaster.spentMasterID, dbo.spentMaster.spentMasterName, SUM(dbo.accDocEventsTable.accDocEvent_indebted) AS indTotal, SUM(dbo.accDocEventsTable.accDocEvent_creditor) AS creTotal " +
                                                         "FROM            dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                         "GROUP BY dbo.spentMaster.spentMasterID, dbo.spentMaster.spentMasterName " +
                                                         sWhere;     //having          
                }
                else if (rdu_showDetailRemains.Checked)
                {
                    if (chk_filterByLedger.Checked)
                    {
                        if (sWhere == "")
                        {
                            sWhere = "Having";
                        }
                        else
                        {
                            sWhere += " AND";
                        }
                        sWhere += " (dbo.detailsTable.spentMasterID = @spentMasterID)";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", tbx_ledgerCode.Text);

                        try
                        {
                            spentMasterBindingSource.Position = spentMasterBindingSource.Find("spentMasterID", tbx_ledgerCode.Text);
                        }
                        catch
                        {
                        }

                    }

                    dAdapter.SelectCommand.CommandText = "SELECT    'مـــانده حــسابهای معیـــن' as reportTitle, '' as spentMasterID, '" + adjustDate + "' as para3, dbo.spentMaster.spentMasterName, SUM(dbo.accDocEventsTable.accDocEvent_indebted) AS indTotal, SUM(dbo.accDocEventsTable.accDocEvent_creditor) AS creTotal, dbo.detailsTable.detailID, dbo.detailsTable.detail_name " +
                                                         "FROM            dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                         "GROUP BY dbo.detailsTable.spentMasterID, dbo.spentMaster.spentMasterName, dbo.detailsTable.detailID, dbo.detailsTable.detail_name " +
                                                         sWhere;  //having                         
                }

                else if (rdu_showProjectsRemains.Checked)
                {
                    string sHaving = "";
                    sHaving = buildTheWhereStatementForDate();

                    if (sHaving == ";")
                    {
                        sHaving = " Where (dbo.detailsTable.projectID = @projectID) ";
                    }
                    else
                    {
                        sHaving = sHaving.Replace("Having", "Where");
                        sHaving += " AND (dbo.detailsTable.projectID = @projectID) ";
                    }
                    dAdapter.SelectCommand.Parameters.AddWithValue("@projectID", tbx_projectID.Text);

                    try
                    {
                        projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", tbx_projectID.Text);
                    }
                    catch
                    {
                    }

                    string sProjectCode = "'کـــد پــروژه" + " : " + tbx_projectID.Text + "'";
                    string sProjectName = "'نـــام پـروژه" + " : " + cmb_projects.Text + "'";
                    dAdapter.SelectCommand.CommandText = "SELECT       'مــــانده پـــروژه ها' as reportTitle, " + sProjectCode + " as para1, " + sProjectName + " as para2 , '" + adjustDate + "' as para3, '' as detailID, '' as detail_name, dbo.spentMaster.spentMasterID, dbo.spentMaster.spentMasterName, SUM(dbo.accDocEventsTable.accDocEvent_indebted) AS indTotal, SUM(dbo.accDocEventsTable.accDocEvent_creditor) AS creTotal " +
                                                         "FROM            dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                         sHaving +
                                                         "GROUP BY dbo.spentMaster.spentMasterID, dbo.spentMaster.spentMasterName, dbo.detailsTable.spentMasterID ;";                        
                }

                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "viw_ledgerRemains");
                dAdapter.SelectCommand.Connection.Close();

                bs.DataSource = dSet;
                bs.DataMember = "viw_ledgerRemains";

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
                    frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_remains.rpt";
                    //frmPrintAccDoc.sFilePath = @"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_remains.rpt";
                    frmPrintAccDoc.dSet = dSet;
                    frmPrintAccDoc.ShowDialog();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdu_allCases_CheckedChanged(object sender, EventArgs e)
        {
            tbx_fromPrice.Enabled = !rdu_allCases.Checked;
        }

        private void rdu_showProjectsRemains_CheckedChanged(object sender, EventArgs e)
        {
            pnl_projects.Enabled = rdu_showProjectsRemains.Checked;
            try
            {
                grp_conditions.Visible = !rdu_showProjectsRemains.Checked;
                grp_dateConditions.Visible = rdu_showProjectsRemains.Checked;
                grp_dateConditions.Left = grp_bookKind.Left;
            }
            catch
            {
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

        private void rdu_showLedgerRemains_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_projects_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
