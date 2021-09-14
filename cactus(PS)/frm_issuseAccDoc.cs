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
    public partial class frm_issuseAccDoc : Form
    {
        public frm_issuseAccDoc()
        {
            n_accountID = -1;
            b_dontUpdateIndebted = false;
            s_additionalComment = "";
            n_indebtedPrice = 0;
            n_creditorPrice = 0;
            InitializeComponent();
        }

        private int n_currentPersonID;
        public int currentPersonID
        {
            get { return n_currentPersonID; }
            set { n_currentPersonID = value; }
        }
        private string s_additionalComment;
        public string additionalComment
        {
            set { s_additionalComment = value; }
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
        private long n_indebtedPrice;
        public long indebtedPrice
        {
            get { return n_indebtedPrice; }
            set { n_indebtedPrice = value; }
        }
        private long n_creditorPrice;
        public long creditorPrice
        {
            get { return n_creditorPrice; }
            set { n_creditorPrice = value; }
        }
        private bool b_theChequeIsMine;
        public bool theChequeIsMine
        {            
            set { b_theChequeIsMine = value; }
        }
        private int n_accountID;
        public int accountID
        {            
            set { n_accountID = value; }
        }

        private long n_oldAccDoc_id;

        public bool b_dontUpdateIndebted;

        private void saveAccountIDToTheDocument(bool itIsIndebted)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "saveAccountIDToTheAccDocEvent";
                c.Parameters.AddWithValue("@accDoc_id", (long)num_accDocNumber.Value);
                c.Parameters.AddWithValue("@itIsIndebted", itIsIndebted);                
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

        private string getChequesNumbers()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "getChequesNumbers";
                c.Parameters.AddWithValue("@accDoc_id", (long)num_accDocNumber.Value);
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.BigInt);
                p.Direction = ParameterDirection.ReturnValue;
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

            return c.Parameters["@result"].Value.ToString();
        }

        private long getTheCreditorPrice()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "getAccDocCreditorPrice";
                c.Parameters.AddWithValue("@accDoc_id", (long)num_accDocNumber.Value);
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.BigInt);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
                c.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return long.Parse(c.Parameters["@result"].Value.ToString());
        }

        private void btn_defineCheque_Click(object sender, EventArgs e)
        {
            try
            {
                //save for help
                try
                {
                    File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"cheques\"");
                }
                catch
                {
                }

                //int nThisCompanyID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Find("personPhone1", "06323229522")]["personID"];

                frm_manageCheques frmManageCheques = new frm_manageCheques();
                frmManageCheques.theChequeIsMine = true;
                frmManageCheques.currentPersonID = currentPersonID;
                frmManageCheques.theChequeIsMine = b_theChequeIsMine;
                frmManageCheques.accDoc_id = n_oldAccDoc_id;
                frmManageCheques.currentPrjectID = currentProjectID;
                frmManageCheques.currentProjectTitle = currentProjectTitle;
                frmManageCheques.connectionString = connectionString;
                frmManageCheques.defaultPrice = indebtedPrice;
                frmManageCheques.ShowDialog(this);
                if (b_theChequeIsMine)
                {
                    tbx_creditorPrice.Text = frmManageCheques.tbx_chequesTotal.Text;
                }
                else
                {
                    tbx_indebtedPrice.Text = frmManageCheques.tbx_chequesTotal.Text;
                }
                if (tbx_comment.Text.Contains("چک شماره") || tbx_comment.Text == "طی چک" || tbx_comment.Text == "")
                {
                    tbx_comment.Text = "طی چک شماره  " + getChequesNumbers() + s_additionalComment;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshAccDocEventDataset()
        {
            try
            {
                accDocEventsTableTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from accDocEventsTable;");
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.accDocEventsTable.Clear();
                accDocEventsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.accDocEventsTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }
        private void refreshAccDocDataset()
        {
            try
            {
                accDocEventsTableTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from accountingDocs;");
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.AccountingDocs.Clear();
                accDocEventsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountingDocs);
            }
            catch
            {
            }
            finally
            {
                accDocEventsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void frm_issuseAccDoc_Load(object sender, EventArgs e)
        {            
            refreshAccDocDataset();
            refreshAccDocEventDataset();
            
            try
            {                
                accDocEventsTableBindingSource.Position = accDocEventsTableBindingSource.Find("accDoc_id", (long)num_accDocNumber.Value);
            }
            catch
            {
            }

            try
            {                
                if (b_theChequeIsMine)
                {
                    btn_defineCheque.Top = tbx_creditorPrice.Top;

                    tbx_indebtedPrice.Text = n_indebtedPrice.ToString();
                    tbx_creditorPrice.Text = getTheCreditorPrice().ToString();
                }
                else
                {
                    btn_defineCheque.Top = tbx_indebtedPrice.Top;

                    //tbx_indebtedPrice.Text = getTheCreditorPrice().ToString();
                    tbx_creditorPrice.Text = n_indebtedPrice.ToString();
                }

                n_oldAccDoc_id = (long)num_accDocNumber.Value;

                num_accDocNumber.Select(0, num_accDocNumber.Value.ToString().Length);

                accountingDocsBindingSource.Position = accountingDocsBindingSource.Find("accDoc_id", num_accDocNumber.Value);
                if (pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_date"] != DBNull.Value && (string)pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_date"] != "")
                {
                    mTbx_Date.Text = pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_date"].ToString();
                }
                if (pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_comment"] != DBNull.Value && (string)pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_comment"] != "")
                {
                    tbx_comment.Text = pSDatabase5DataSet.AccountingDocs.Rows[accountingDocsBindingSource.Position]["accDoc_comment"].ToString();
                }
            }
            catch
            {
            }
        }

        private void tbx_indebtedPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_indebtedPrice.Text) + " ریال ";
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tbx_creditorPrice.Text != tbx_indebtedPrice.Text)
            {
                MessageBox.Show("مبلغ بدهکاری و بستانکاری مساوی نمی باشند ،لطفاً اصلاح کنید");
                return;
            }

            //update the Basic Fields of AccDoc
            try
            {                
                SqlCommand sql = new SqlCommand("update accountingDocs set accDoc_id = @new_accDoc_id, accDoc_price = @accDoc_price, accDoc_date = @accDoc_date, accDoc_comment = @accDoc_comment ,tempo = @tempo where accDoc_id = @old_accDoc_id;");
                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("new_accDoc_id", num_accDocNumber.Value.ToString());
                sql.Parameters.AddWithValue("old_accDoc_id", n_oldAccDoc_id);
                sql.Parameters.AddWithValue("accDoc_price", tbx_indebtedPrice.Text);
                sql.Parameters.AddWithValue("accDoc_date", mTbx_Date.Text);
                sql.Parameters.AddWithValue("tempo", numberConvertor.convertToChars(tbx_creditorPrice.Text) + " ریال");
                sql.Parameters.AddWithValue("accDoc_comment", tbx_comment.Text);
                sql.Connection.Open();
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("شماره سند وارد شده تکراری می باشد");
                }
                else
                    MessageBox.Show(sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!b_dontUpdateIndebted)
            {
                //update the advanced field of accDoc like indebted
                try
                {
                    SqlCommand sql = new SqlCommand();
                    if (b_theChequeIsMine)
                    {
                        sql = new SqlCommand("update accDocEventsTable set accDocEvent_creditor = 0, accDocEvent_indebted = @accDocEvent_price ,accDocEvent_retail = NULL where (accDoc_id = @new_accDoc_id AND accDocEvent_itIsBank = 0);");
                    }
                    else
                    {
                        sql = new SqlCommand("update accDocEventsTable set accDocEvent_creditor = @accDocEvent_price, accDocEvent_indebted = 0 ,accDocEvent_retail = NULL where (accDoc_id = @new_accDoc_id AND accDocEvent_itIsBank = 0);");
                    }
                    sql.Connection = new SqlConnection(connectionString);
                    sql.Parameters.Clear();                    
                    sql.Parameters.AddWithValue("new_accDoc_id", num_accDocNumber.Value.ToString());
                    sql.Parameters.AddWithValue("accDocEvent_price", tbx_indebtedPrice.Text);
                    sql.Connection.Open();
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            //update the advanced field of accDoc like creditor
            try
            {
                //SqlCommand sql = new SqlCommand();
                //sql = new SqlCommand("update accDocEventsTable set accDocEvent_indebted = 0, accDocEvent_creditor = @accDocEvent_creditor, accDocEvent_retail = NULL where (accDoc_id = @new_accDoc_id AND accDocEvent_itIsIndebted = 0);");                
                //sql.Connection = new SqlConnection(connectionString);
                //sql.Parameters.Clear();
                ////sql.Parameters.AddWithValue("projectID", objProject);
                ////sql.Parameters.AddWithValue("personID", objPerson);
                ////sql.Parameters.AddWithValue("accountID", objAccount);
                //sql.Parameters.AddWithValue("new_accDoc_id", num_accDocNumber.Value.ToString());
                //sql.Parameters.AddWithValue("accDocEvent_creditor", tbx_creditorPrice.Text);
                //sql.Connection.Open();
                //sql.ExecuteNonQuery();
                //sql.Connection.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }            
            saveAccountIDToTheDocument(!b_theChequeIsMine);           

            MessageBox.Show("سند شماره " + num_accDocNumber.Value.ToString() + " با موفقیت به ثبت رسید ", "سند حسابداری", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"issuse_ok\"");
            }
            catch
            {
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbx_creditorPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mTbx_Date_Leave(object sender, EventArgs e)
        {
            mTbx_Date.Text = numberConvertor.makeChangeToDateString(mTbx_Date.Text);
            if (mTbx_Date.Text.Length < 9)
            {
                MessageBox.Show("تاریخ را درست وارد کنید");
                mTbx_Date.Focus();
            }
            if (numberConvertor.findDateError(1370, mTbx_Date.Text) == "d")
            {
                MessageBox.Show("روز را درست وارد کنید");
                mTbx_Date.Focus();
                mTbx_Date.Select(8, 2);
            }
            if (numberConvertor.findDateError(1370, mTbx_Date.Text) == "m")
            {
                MessageBox.Show("ماه را درست وارد کنید");
                mTbx_Date.Focus();
                mTbx_Date.Select(5, 2);
            }
        }

        private void frm_issuseAccDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.Text.Contains("اصلاح"))
                {
                    SqlCommand sql = new SqlCommand("select count(*) from chequesTable where accDoc_id = @accDoc_id;");
                    sql.Connection = new SqlConnection(connectionString);
                    sql.Parameters.Clear();
                    sql.Parameters.AddWithValue("@accDoc_id", n_oldAccDoc_id.ToString());
                    sql.Connection.Open();
                    string sChequesCount = sql.ExecuteScalar().ToString();
                    sql.Connection.Close();
                    
                    if (sChequesCount == "0")
                    {
                        if (MessageBox.Show("کاربر گرامی، شما تمامی چک های تعریف شده برای این سند را حذف کردید" + "\nآیا مایلید که این سند حذف شود ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //delete the uncompleted accounting document
                            sql = new SqlCommand("delete from accountingDocs where accdoc_id = @accDoc_id;");
                            sql.Connection = new SqlConnection(connectionString);
                            sql.Parameters.Clear();
                            sql.Parameters.AddWithValue("@accDoc_id", n_oldAccDoc_id.ToString());
                            sql.Connection.Open();
                            sql.ExecuteNonQuery();
                            sql.Connection.Close();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mTbx_Date_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
                }

            }
            catch
            {
            }
        }
    }
}
