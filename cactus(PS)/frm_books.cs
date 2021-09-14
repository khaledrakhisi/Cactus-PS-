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
    public partial class frm_books : Form
    {
        public frm_books()
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

        private string getSumOfIndebtedAndCreditor(long spentMasterID, int nDetailID ,string accDocEvent_id)
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

        private void refreshTheDetailsDataset()
        {
            try
            {
                viw_detailsTableAdapter.Adapter.SelectCommand = new SqlCommand("SELECT        dbo.detailsTable.spentMasterID, dbo.detailsTable.detailID, dbo.spentMaster.spentMasterName + ' ' + dbo.detailsTable.detail_name AS fullDetailName FROM dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID WHERE(spentMaster.spentMaster_detailType <> 0)");
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
        
        private void completeTheLedger(int nSpentMasterID, int nDetailID)
        {
            SqlCommand c = new SqlCommand();
            try
            {                
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);
                c.Parameters.AddWithValue("@detailID", nDetailID);
                c.Parameters.AddWithValue("@toAccDoc_id", -1);
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
                    sWhere = " Where dbo.AccountingDocs.accDoc_date = @accDoc_date AND (dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_inDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = " Where dbo.AccountingDocs.accDoc_date >= @accDoc_fromDate AND dbo.AccountingDocs.accDoc_date <= @accDoc_toDate AND (dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_fromDate", mTbx_fromDate.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_toDate", mTbx_toDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = " Where dbo.AccountingDocs.accDoc_id >= @accDoc_fromID AND dbo.AccountingDocs.accDoc_id <= @accDoc_toID AND (dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_fromID", tbx_fromID.Text);
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_toID", tbx_toID.Text);
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string ind = "", cre = "", rem = "", detect = "", sWhere = "";

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                //دفتر روزنامه
                if (rdu_journal.Checked)
                {
                    if (limitString[3] == '0')//limitString[3] == allow show 'journal'
                    {
                        MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sJournalWhere = buildTheWhereStatement();
                    if (sJournalWhere == ";")
                    {
                        sJournalWhere = "WHERE(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    }
                    dAdapter.SelectCommand.CommandText = "SELECT     TOP (100) PERCENT dbo.AccountingDocs.accDoc_id, dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_comment, " +
                                                    "dbo.AccountingDocs.tempo, dbo.accDocEventsTable.accDocEvent_id, dbo.accDocEventsTable.accDocEvent_row, dbo.accDocEventsTable.accDocEvent_indebted, " +
                                                    "dbo.accDocEventsTable.accDocEvent_creditor, dbo.accDocEventsTable.accDocEvent_itIsIndebted, dbo.accDocEventsTable.accDocEvent_itIsBank, " +
                                                    "dbo.spentMaster.spentMasterName + ' ' + dbo.detailsTable.detail_name AS detailTitle , dbo.detailsTable.spentMasterID, dbo.detailsTable.detailID " +
                                                    "FROM         dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                    sJournalWhere + " ORDER BY dbo.accDocEventsTable.accDocEvent_row;";
                    dAdapter.SelectCommand.Connection.Open();
                    dAdapter.Fill(dSet, "viw_accDoc");
                    dAdapter.SelectCommand.Connection.Close();

                    bs.DataSource = dSet;
                    bs.DataMember = "viw_accDoc";
                }
                //دفتر کل
                else if (rdu_bigJournal.Checked)
                {
                    if (limitString[4] == '0')//limitString[4] == allow show 'ledger'
                    {
                        MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (spentMasterBindingSource.Count == 0)
                    {
                        MessageBox.Show("لطفاً سرفصل کل مورد نظر را از لیست انتخاب کنید");
                        return;
                    }
                    //getting the ledger code
                    int spentMasterID = int.Parse(tbx_ledgerCode.Text);
                    spentMasterBindingSource.Position = spentMasterBindingSource.Find("spentMasterID", tbx_ledgerCode.Text);

                    completeTheLedger(spentMasterID, -1);

                    sWhere = buildTheWhereStatement();
                    if (sWhere == ";")
                    {
                        sWhere = "WHERE (detailsTable.spentMasterID = @spentMasterID)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ORDER BY dbo.AccountingDocs.accDoc_date,  dbo.AccountingDocs.accDoc_id;";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                    }
                    else
                    {
                        sWhere = sWhere.Remove(0, 6);//remove the 'where' keyword
                        sWhere = " WHERE (detailsTable.spentMasterID = @spentMasterID) " + "AND " + sWhere + "ORDER BY dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_id;";
                        //////////////////////////////////////////                         
                        dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                             "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id " +
                                                             "FROM            AccountingDocs INNER JOIN " +
                                                             "accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN " +
                                                             "detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                             "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                             sWhere;                                                             

                        dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                        dAdapter.SelectCommand.Connection.Open();
                        dSet.Clear();
                        dAdapter.Fill(dSet, "viw_ledger");
                        dAdapter.SelectCommand.Connection.Close();

                        bs.DataSource = dSet;
                        bs.DataMember = "viw_ledger";

                        string accDocEvent_id = "";
                        if (bs.Count > 0)
                        {
                            accDocEvent_id = dSet.Tables["viw_ledger"].Rows[0]["accDocEvent_id"].ToString();

                            //////////////////////select all//////////////////////////                            
                            dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                             "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id , accDocEventsTable.accDocEvent_detectID " +
                                                             "FROM            AccountingDocs INNER JOIN " +
                                                             "accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN " +
                                                             "detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                             "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                             "WHERE (detailsTable.spentMasterID = @spentMasterID)AND(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ORDER BY dbo.AccountingDocs.accDoc_date,  dbo.AccountingDocs.accDoc_id;";
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

                                //get Indebted and creditor money. the below function returns them in 'indebted;creditor' form
                                string s = getSumOfIndebtedAndCreditor(spentMasterID, -1, accDocEvent_id);
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
                            /////////////////////////////////////////////////
                        }
                    }

                    dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                             "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, " +
                                                             "spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id, accDocEventsTable.accDocEvent_detectID " +
                                                             "FROM            AccountingDocs INNER JOIN accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                             "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                             sWhere;
                    dAdapter.SelectCommand.Connection.Open();
                    dSet.Clear();
                    dAdapter.Fill(dSet, "viw_ledger");
                    dAdapter.SelectCommand.Connection.Close();

                    bs.DataSource = dSet;
                    bs.DataMember = "viw_ledger";
                }

                //دفتر معین
                else if (rdu_smallJournal.Checked)
                {
                    if (limitString[5] == '0')//limitString[5] == allow show 'small ledger'
                    {
                        MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (viwdetailsBindingSource.Count == 0)
                    {
                        MessageBox.Show("کاربر گرامی"+"\n"+"شما در حال حاضر هیچ گونه سرفصل معینی را تعریف نکرده اید"+"\n"+"برای اطلاعات بیشتر به راهنمای برنامه مراجعه کنید");
                        return;
                    }

                    string swhere = "";

                    //getting the small ledger code
                    int nDetailID = int.Parse(tbx_detailCode.Text);
                    //viwdetailsBindingSource.Position = viwdetailsBindingSource.Find("detailID", nDetailID);

                    sWhere = buildTheWhereStatement();

                    swhere = "WHERE (detailsTable.detailID = @detailID) ";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@detailID", nDetailID);

                    if (sWhere == ";") sWhere = "Where(dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) ";
                    sWhere = sWhere.Replace("Where", "AND");
                    sWhere = swhere + sWhere;
                    completeTheLedger(-1, nDetailID);

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

                        dAdapter.SelectCommand.CommandText = "SELECT        AccountingDocs.accDoc_id, AccountingDocs.accDoc_date, AccountingDocs.accDoc_comment, accDocEventsTable.accDocEvent_indebted, " +
                                                             "accDocEventsTable.accDocEvent_creditor, accDocEventsTable.accDocEvent_retail, detailsTable.spentMasterID, detailsTable.detailID, detailsTable.detail_name, " +
                                                             "spentMaster.spentMasterName, accDocEventsTable.accDocEvent_id, accDocEventsTable.accDocEvent_detectID " +
                                                             "FROM            AccountingDocs INNER JOIN accDocEventsTable ON AccountingDocs.accDoc_id = accDocEventsTable.accDoc_id INNER JOIN detailsTable ON accDocEventsTable.detailID = detailsTable.detailID INNER JOIN " +
                                                             "spentMaster ON detailsTable.spentMasterID = spentMaster.spentMasterID " +
                                                             "WHERE (detailsTable.detailID = @detailID)AND (dbo.AccountingDocs.accDoc_isItTemporary = 0 OR dbo.AccountingDocs.accDoc_isItTemporary is NULL) " +
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
                            string s = getSumOfIndebtedAndCreditor(-1, nDetailID, accDocEvent_id);
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
                }

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

                    if (rdu_journal.Checked)//دفتر روزنامه
                    {
                        long total = 0;
                        while (bs.Position < bs.Count - 1)
                        {
                            try
                            {
                                Application.DoEvents();
                                total += (long)dSet.Tables["viw_accDoc"].Rows[bs.Position]["accDocEvent_indebted"];
                            }
                            catch
                            {
                            }
                            bs.Position++;
                        }

                        frmPrintAccDoc.TotalOfInvoice = total.ToString();
                        frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_journal.rpt";
                    }
                    else//دفتر کل و معین
                    {
                        //total of remain money in chars
                        frmPrintAccDoc.TotalOfInvoice = dSet.Tables["viw_ledger"].Rows[bs.Count - 1]["accDocEvent_retail"].ToString();

                        if (rdu_bigJournal.Checked)//کل
                        {
                            if (sWhere != ";")
                            {
                                frmPrintAccDoc.s_ind = ind;
                                frmPrintAccDoc.s_cre = cre;
                                frmPrintAccDoc.s_rem = rem;
                                frmPrintAccDoc.s_detect = detect;
                            }
                            
                            frmPrintAccDoc.crystalReportViewer1.DisplayGroupTree = false;
                            frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_ledger.rpt";
                            //frmPrintAccDoc.sFilePath = @"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_ledger.rpt";
                        }
                        else if (rdu_smallJournal.Checked)//معین
                        {
                            if (sWhere != ";")
                            {
                                frmPrintAccDoc.s_ind = ind;
                                frmPrintAccDoc.s_cre = cre;
                                frmPrintAccDoc.s_rem = rem;
                                frmPrintAccDoc.s_detect = detect;
                            }
                            frmPrintAccDoc.crystalReportViewer1.DisplayGroupTree = false;
                            //frmPrintAccDoc.bookType = cmb_masterSpentName.Text + " " + cmb_detail.Text;
                            frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_smallLedger.rpt";
                            //frmPrintAccDoc.sFilePath = @"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_smallLedger.rpt";
                        }
                    }

                    frmPrintAccDoc.dSet = dSet;
                    frmPrintAccDoc.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dAdapter.SelectCommand.Connection.Close();
            }
        }

        private void frm_books_Load(object sender, EventArgs e)
        {            
            refreshMasterSpentsDataset();
            refreshTheDetailsDataset();

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

        private void rdu_bigJournal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_bigJournal.Checked)
                {
                    pnl_masterSpent.Enabled = true;
                    pnl_detail.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void rdu_smallJournal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_smallJournal.Checked)
                {
                    pnl_masterSpent.Enabled = false;
                    pnl_detail.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void rdu_journal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_journal.Checked)
                {
                    pnl_detail.Enabled = false;
                    pnl_masterSpent.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void spentMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void rdu_showAll_CheckedChanged(object sender, EventArgs e)
        {

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

        private void frm_books_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"smallLedger_closed\"");
            }
            catch
            {
            }
        }
    }
}
