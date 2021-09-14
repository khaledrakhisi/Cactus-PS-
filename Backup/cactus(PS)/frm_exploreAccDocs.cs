using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace cactus_PS_
{
    public partial class frm_exploreAccDocs : Form
    {
        public frm_exploreAccDocs()
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
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void enableControls(bool bEnable)
        {
            try
            {
                num_fromNumber.Enabled = bEnable;
                num_toNumber.Enabled = bEnable;
            }
            catch
            {
            }
        }

        private string getTotalOfInvoiceWithNumber(long nAccDoc_id)
        {
            SqlCommand sqlCmd = new SqlCommand();
            try
            {
                SqlParameter sqlPar;
                sqlCmd.Connection = new SqlConnection(connectionString);
                sqlCmd.CommandText = "getAnAccDocTotal";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@accDoc_id", nAccDoc_id);
                sqlPar = sqlCmd.Parameters.Add("@result", SqlDbType.BigInt);
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

        private string makeTheWhereExpresstion()
        {
            string sWhere = "";
            try
            {
                //via accounting document number
                if (tabControl1.SelectedIndex == 0)
                {
                    dAdapter.SelectCommand.Parameters.Clear();

                    sWhere = "where dbo.AccountingDocs.accDoc_id ";
                    if (rdu_lessThanNumber.Checked)
                    {
                        sWhere += "<= @accDoc_id";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_id", num_toNumber.Value.ToString());
                    }
                    else if (rdu_moreThanNumber.Checked)
                    {
                        sWhere += ">= @accDoc_id";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_id", num_toNumber.Value.ToString());
                    }
                    else if (rdu_equalsToNumber.Checked)
                    {
                        sWhere += "= @accDoc_id";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_id", num_toNumber.Value.ToString());
                    }
                    else if (rdu_betweensNumber.Checked)
                    {
                        sWhere += ">= @accDoc_id_from AND dbo.AccountingDocs.accDoc_id <= @accDoc_id_to";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_id_from", num_fromNumber.Value.ToString());
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_id_to", num_toNumber.Value.ToString());
                    }
                    else if (rdu_allAccDocs.Checked)
                    {
                        sWhere = "";
                    }
                    
                }//via accounting document number

                //via accounting document Date
                else if (tabControl1.SelectedIndex == 1)
                {
                    dAdapter.SelectCommand.Parameters.Clear();

                    sWhere = "where dbo.AccountingDocs.accDoc_date ";
                    if (rdu_lessThanDate.Checked)
                    {
                        sWhere += "<= @accDoc_date";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_toDate.Text);
                    }
                    else if (rdu_moreThanDate.Checked)
                    {
                        sWhere += ">= @accDoc_date";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_toDate.Text);
                    }
                    else if (rdu_equalsToDate.Checked)
                    {
                        sWhere += "= @accDoc_date";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date", mTbx_toDate.Text);
                    }
                    else if (rdu_betweensDate.Checked)
                    {
                        sWhere += ">= @accDoc_date_from AND dbo.AccountingDocs.accDoc_date <= @accDoc_date_to";
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date_from", mTbx_fromDate.Text);
                        dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_date_to", mTbx_toDate.Text);
                    }
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    //filter via accounting doc 'price'
                    dAdapter.SelectCommand.Parameters.Clear();
                    long AccDocPrice = 0;
                    try
                    {
                        AccDocPrice = long.Parse(tbx_accDocPrice.Text);
                    }
                    catch
                    {
                        MessageBox.Show("مبلغ را درست وارد کنید");
                        return "";
                    }

                    sWhere = "Where dbo.AccountingDocs.accDoc_price = @accDoc_price";
                    //sWhere = "WHERE  (dbo.accDocEventsTable.accDocEvent_indebted = @accDoc_price)";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_price", AccDocPrice);
                    
                }
                else if (tabControl1.SelectedIndex == 3)
                {
                    //filter via accounting doc 'comment'
                    dAdapter.SelectCommand.Parameters.Clear();

                    sWhere = "Where dbo.AccountingDocs.accDoc_comment LIKE @accDoc_comment";
                    dAdapter.SelectCommand.Parameters.AddWithValue("@accDoc_comment", "%" + tbx_AccDocComment.Text + "%");
                }
                else
                {
                    //filter via accounting doc 'spentMaster'
                    //int spentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];

                    //dAdapter.SelectCommand.Parameters.Clear();

                    //sWhere = "where (dbo.accDocEventsTable.spentMasterID = @spentMasterID OR dbo.accDocEventsTable.spentMasterID = @bankSpentMasterID) and (dbo.accDocEventsTable.accDoc_id = dbo.accountingDocs.accDoc_id) order by dbo.accDocEventsTable.accDoc_id;";
                    //dAdapter.SelectCommand.Parameters.AddWithValue("@spentMasterID", spentMasterID);
                    //dAdapter.SelectCommand.Parameters.AddWithValue("@bankSpentMasterID", numberConvertor.getSpentMasterID("بانک", connectionString));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return sWhere;

        }
        private void rdu_betweensNumber_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangeNumber.Top = num_toNumber.Top;            
            pnl_rangeNumber.Visible = rdu_betweensNumber.Checked;            
        }

        private void btn_provideReport_Click(object sender, EventArgs e)
        {            
            try
            {
                if (limitString[10] == '0')//limitString[10] == allow show 'accounting docs'
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);
                
                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                dAdapter.SelectCommand.CommandText = "SELECT        TOP (100) PERCENT dbo.AccountingDocs.accDoc_id, dbo.AccountingDocs.accDoc_date, dbo.AccountingDocs.accDoc_comment, dbo.AccountingDocs.tempo, " +
                                                     "dbo.accDocEventsTable.accDocEvent_id, dbo.accDocEventsTable.accDocEvent_row, dbo.accDocEventsTable.accDocEvent_indebted, " +
                                                     "dbo.accDocEventsTable.accDocEvent_creditor, dbo.accDocEventsTable.accDocEvent_itIsIndebted, dbo.accDocEventsTable.accDocEvent_itIsBank, " +
                                                     "dbo.spentMaster.spentMasterName + ' ' + dbo.detailsTable.detail_name AS detailTitle, dbo.detailsTable.spentMasterID, dbo.detailsTable.detailID " +
                                                     "FROM            dbo.AccountingDocs INNER JOIN dbo.accDocEventsTable ON dbo.AccountingDocs.accDoc_id = dbo.accDocEventsTable.accDoc_id INNER JOIN dbo.detailsTable ON dbo.accDocEventsTable.detailID = dbo.detailsTable.detailID INNER JOIN " +
                                                     "dbo.spentMaster ON dbo.detailsTable.spentMasterID = dbo.spentMaster.spentMasterID " +
                                                     makeTheWhereExpresstion() + " ORDER BY dbo.accDocEventsTable.accDocEvent_row";
                                                     
                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "viw_accDoc");
                dAdapter.SelectCommand.Connection.Close();

                bs.DataSource = dSet;
                bs.DataMember = "viw_accDoc";
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
                    //frmPrintAccDoc.TotalOfInvoice = sTotalOfInvoice;
                    frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_accDoc2.rpt";
                    //frmPrintAccDoc.sFilePath = @"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_accDoc2.rpt";
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

        private void rdu_betweensDate_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangeDate.Top = mTbx_toDate.Top;
            pnl_rangeDate.Visible = rdu_betweensDate.Checked;
        }

        private void mTbx_toDate_KeyDown(object sender, KeyEventArgs e)
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

        private void mTbx_fromDate_KeyDown(object sender, KeyEventArgs e)
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

        private void frm_exploreAccDocs_Load(object sender, EventArgs e)
        {            
            try
            {

                mTbx_toDate.Text = numberConvertor.nowDateInAppropriateFormat();
                mTbx_fromDate.Text = numberConvertor.nowDateInAppropriateFormat();

                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                num_toNumber.Focus();
                num_toNumber.Select(0, num_toNumber.Value.ToString().Length);
            }
            catch
            {
            }
        }

        private void rdu_allAccDocs_CheckedChanged(object sender, EventArgs e)
        {
            enableControls(!rdu_allAccDocs.Checked);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void tbx_accDocPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_accDocPrice.Text == "")
                {
                    tbx_accDocPrice.Text = "0";
                }
                lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_accDocPrice.Text) + " ریال";
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

        private void mTbx_fromDate_Leave(object sender, EventArgs e)
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
    }
}
