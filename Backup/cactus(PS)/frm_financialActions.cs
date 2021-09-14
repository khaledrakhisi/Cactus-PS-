using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Persia;

namespace cactus_PS_
{
    public partial class frm_financialActions : Form
    {
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
        
        private string currentDocType;

        private bool b_openForModify;
        public bool openForModify
        {
            get { return b_openForModify; }
            set { b_openForModify = value; }
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
        private int n_currentPersonID;
        public int currentPersonID
        {
            get { return n_currentPersonID; }
        }
        private int n_currentDocID;
        public int currentDocID
        {
            get { return n_currentDocID; }
        }
        
        private long nAvilDocID;
        private string s_orig_docType;

        private void refreshBanksDataset()
        {
            try
            {
                banksTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                banksTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM banksTable order by bankName;";
                banksTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                banksTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.BanksTable.Clear();
                banksTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.BanksTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                banksTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }


        private void refreshAccountsDataset()
        {
            try
            {

                int nBankID = (int)pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];

                accountsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                accountsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM accountsTable WHERE bankID = @nBankID;";
                accountsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                accountsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nBankID", nBankID);
                accountsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                accountsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.AccountsTable.Clear();
                accountsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                accountsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }

        }

        private int detectPerson()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                int personID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];

                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "detectPerson";
                c.Parameters.AddWithValue("@personID", personID);
                c.Parameters.AddWithValue("@toAccDoc_id", tbx_ID.Text);
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
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

            return (int)c.Parameters["@result"].Value;
        }

        private void deleteThisDoc()
        {
            try
            {

                docsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                docsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                docsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nDocID", currentDocID);

                runSQLCommand("DELETE FROM docsTable WHERE docID = @nDocID;");

                refreshDocsTableDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private bool hasItAccDoc()
        {
            SqlCommand sql = new SqlCommand();
            try
            {
                sql = new SqlCommand("select count(*) from accountingDocs where docID = @docID;");
                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.AddWithValue("@docID", tbx_ID.Text);

                sql.Connection.Open();
                if ((int)sql.ExecuteScalar() > 0)
                {
                    return true;
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }
            return false;
        }

        private long checkThisIDOnTheAccDocTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {                
                BindingSource bs = new BindingSource();
                adapter.SelectCommand = new SqlCommand("select * from accountingDocs;");
                adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                pSDatabase5DataSet.AccountingDocs.Clear();
                try
                {
                    adapter.Fill(pSDatabase5DataSet.AccountingDocs);
                }
                catch
                {
                }
                bs.DataSource = pSDatabase5DataSet;
                bs.DataMember = "AccountingDocs";
                int pos = bs.Find("docID", tbx_ID.Text);
                if (pos == -1)
                    return -1;
                else
                    return (long)pSDatabase5DataSet.AccountingDocs.Rows[pos]["accDoc_id"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.SelectCommand.Connection.Close();
            }

            return -1;
        }

        private long getAvilableAccountingDocumentNumber()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnAvilableDocumentNumber";
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

            return (long)c.Parameters["@result"].Value;
        }

        private void saveAccountingDocument()
        {            
            try
            {
                n_currentPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];

                SqlCommand sqlCmd;
                long nAvilableDocNumber = checkThisIDOnTheAccDocTable(), nMoney = 0;
                int nDetailID = 0;
                bool bEditingAccDoc = false;

                if (nAvilableDocNumber != -1)//the accDoc has issused
                {                                       
                    bEditingAccDoc = true;

                    sqlCmd = new SqlCommand("delete from accDocEventsTable where accDoc_id = @accDoc_id and accDocEvent_itIsBank = 0;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();

                    nMoney = detectPerson();
                }
                //create a new accDoc
                else
                {
                    nMoney = detectPerson();
                    nAvilableDocNumber = long.Parse(tbx_ID.Text);
                    sqlCmd = new SqlCommand("insert into accountingDocs(accDoc_id, docID, accDoc_date, accDoc_comment) " +
                                                      "values(@accDoc_id, @docID, @accDoc_date, @accDoc_comment)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@docID", tbx_ID.Text);
                    sqlCmd.Parameters.AddWithValue("@accDoc_date", mTbx_Date.Text);
                    sqlCmd.Parameters.AddWithValue("@accDoc_comment", "");
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();
                }

                if (rdu_receiveAnCheque.Checked)//واریز به حساب
                {                    
                    if (nMoney == 0 || nMoney < 0)//اگر طرف حساب بی حساب یا بستانکار باشد
                    {
                        //insert into the docEvent table 
                        //first of all insert the 'هزینه حقوق' text
                        nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب پرداخت", connectionString), currentPersonID, "prs", this.connectionString);
                        sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted,accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                             "values(@accDoc_id, @detailID, @accDocEvent_row, 0, @creditorPrice, 0, 0)");
                        sqlCmd.Connection = new SqlConnection(connectionString);
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                        sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 2);
                        sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                        sqlCmd.Parameters.AddWithValue("@creditorPrice", tbx_price.Text);
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Connection.Close();
                    }
                    else if (nMoney > 0)//اگر طرف حساب بدهکار باشد
                    {
                        //insert into the docEvent table 
                        //first of all insert the 'هزینه حقوق' text                            
                        nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب دریافت", connectionString), currentPersonID, "prs", this.connectionString);
                        sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                             "values(@accDoc_id, @detailID, @accDocEvent_row, 0, @creditorPrice, 0, 0)");
                        sqlCmd.Connection = new SqlConnection(connectionString);
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                        sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 2);
                        sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                        if (long.Parse(tbx_price.Text) >= Math.Abs(nMoney))
                        {
                            sqlCmd.Parameters.AddWithValue("@creditorPrice", Math.Abs(nMoney));
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@creditorPrice", tbx_price.Text);
                        }
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Connection.Close();
                        if (long.Parse(tbx_price.Text) > Math.Abs(nMoney))
                        {
                            nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب پرداخت", connectionString), currentPersonID, "prs", this.connectionString);
                            sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                                 "values(@accDoc_id, @detailID, @accDocEvent_row, 0, @creditorPrice, 0, 0)");
                            sqlCmd.Connection = new SqlConnection(connectionString);
                            sqlCmd.Parameters.Clear();
                            sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                            sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 3);
                            sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                            sqlCmd.Parameters.AddWithValue("@creditorPrice", long.Parse(tbx_price.Text) - Math.Abs(nMoney));
                            sqlCmd.Connection.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Connection.Close();
                        }
                    }
                }



                else//برداشت از حساب
                {
                    //nMoney = detectPerson();
                    if (nMoney == 0 || nMoney > 0)//اگر طرف حساب بی حساب یا بدهکار باشد
                    {
                        nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب دریافت", connectionString), currentPersonID, "prs", this.connectionString);
                        sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                            "values(@accDoc_id, @detailID, @accDocEvent_row, @indebtedPrice, 0, 1, 0)");
                        sqlCmd.Connection = new SqlConnection(connectionString);
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                        sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 1);
                        sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                        sqlCmd.Parameters.AddWithValue("@indebtedPrice", tbx_price.Text);
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Connection.Close();
                    }
                    else if (nMoney < 0)//اگر طرف حساب بستانکار باشد
                    {
                        nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب پرداخت", connectionString), currentPersonID, "prs", this.connectionString);
                        sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                            "values(@accDoc_id, @detailID, @accDocEvent_row, @indebtedPrice, 0, 1, 0)");
                        sqlCmd.Connection = new SqlConnection(connectionString);
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                        sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 1);
                        sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                        if (long.Parse(tbx_price.Text) >= Math.Abs(nMoney))
                        {
                            sqlCmd.Parameters.AddWithValue("@indebtedPrice", Math.Abs(nMoney));
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@indebtedPrice", tbx_price.Text);
                        }
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Connection.Close();

                        if (long.Parse(tbx_price.Text) > Math.Abs(nMoney))
                        {
                            nDetailID = numberConvertor.getDetailID(numberConvertor.getSpentMasterID("حساب دریافت", connectionString), currentPersonID, "prs", this.connectionString);
                            sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                            "values(@accDoc_id, @detailID, @accDocEvent_row, @indebtedPrice, 0, 1, 0)");
                            sqlCmd.Connection = new SqlConnection(connectionString);
                            sqlCmd.Parameters.Clear();
                            sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                            sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 2);
                            sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                            sqlCmd.Parameters.AddWithValue("@indebtedPrice", long.Parse(tbx_price.Text) - Math.Abs(nMoney));

                            sqlCmd.Connection.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Connection.Close();
                        }
                    }
                }
                frm_issuseAccDoc frmAccDoc = new frm_issuseAccDoc();
                if (bEditingAccDoc)
                {
                    frmAccDoc.Text = "اصلاح سند حسابداری";                    
                }
                else
                {
                    frmAccDoc.Text = "صدور سند حسابداری";
                }
                frmAccDoc.additionalComment = "--" + cmb_familyAndName.Text;
                frmAccDoc.connectionString = connectionString;
                frmAccDoc.currentProjectID = -1;
                frmAccDoc.currentPersonID = currentPersonID;

                if (rdu_issuanceAnCheque.Checked)
                {
                    frmAccDoc.theChequeIsMine = true;
                }
                else if (rdu_receiveAnCheque.Checked)
                {
                    int nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                    frmAccDoc.theChequeIsMine = false;
                    frmAccDoc.accountID = nAccountID;
                }
                frmAccDoc.indebtedPrice = int.Parse(tbx_price.Text);
                frmAccDoc.num_accDocNumber.Value = nAvilableDocNumber;
                frmAccDoc.mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
                frmAccDoc.b_dontUpdateIndebted = true;
                if (frmAccDoc.ShowDialog() == DialogResult.Cancel && !bEditingAccDoc)
                {
                    //delete the uncompleted accounting document
                    sqlCmd = new SqlCommand("delete from accountingDocs where accdoc_id = @accDoc_id;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void deleteCheques()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SqlConnection(connectionString);
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@nDocID", currentDocID);
                sqlCmd.CommandText = "DELETE FROM ChequesTable WHERE docID = @nDocID;";
                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void selectActiveProject_Persons()
        {
            try
            {
                //  SELECT Active Project...persons 
                personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();                
                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable where(personPhone1 <> '06323229522' AND personForInfoPP = 0) order by personFamilyAndName;";
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.personsTable.Clear();
                personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }


        public frm_financialActions()
        {
            InitializeComponent();
        }

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    docsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    docsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                    docsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                    pSDatabase5DataSet.docsTable.Clear();
                    docsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.docsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    docsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    docsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    docsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    docsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    docsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.docsTable.Clear();
                    docsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.docsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    docsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    docsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    docsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    docsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    docsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.docsTable.Clear();
                    docsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.docsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    docsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                //try
                //{
                docsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                docsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                docsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                docsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                pSDatabase5DataSet.docsTable.Clear();
                docsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.docsTable);

                //}
                ////catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                docsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                //}
            }
        }

        
        private void refreshDocsTableDataSet()
        {
            docsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
            docsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            //docsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
            docsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nPersonID", currentPersonID);

            runSQLCommand("SELECT * FROM docsTable WHERE personID = @nPersonID;");

            if (docsTableBindingSource.Count == 0)
            {
                enableControls(false);
            }
            else
            {
                enableControls(true);
            }

            //upDateCurrentPositionLabel();
        }

        private void upDateCurrentPositionLabel()
        {
            try
            {
                if (docsTableBindingSource.Count > 0)
                {
                    lbl_currentPosition.Text = "سند " + (docsTableBindingSource.Position + 1).ToString() + " از " + docsTableBindingSource.Count.ToString();
                    //upDateAccountsList();
                }
                else
                {
                    lbl_currentPosition.Text = "*****";
                }

                if (docsTableBindingSource.Count > 0)
                {
                    if ((string)pSDatabase5DataSet.docsTable.Rows[docsTableBindingSource.Position]["docType"] == "iss")
                    {
                        rdu_issuanceAnCheque.Checked = true;
                    }
                    else
                    {
                        rdu_receiveAnCheque.Checked = true;
                    }
                    nAvilDocID = long.Parse(tbx_ID.Text);
                }
            }
            catch
            {
            }
            
        }

        private void enableControls(bool enable)
        {
            btn_delete.Enabled = enable;
            btn_saveChanges.Enabled = enable;
            btn_print.Enabled = enable;

            pnl_person.Enabled = enable;
            grp_actions.Enabled = enable;
            pnl_price.Enabled = enable;

            tbx_event.Enabled = enable;
        }

        private int calculateAnAccount_remainAmount()
        {
            //SqlCommand sqlCmd = new SqlCommand();
            //try
            //{                
            //    SqlParameter sqlPar;
            //    sqlCmd.Connection = new SqlConnection(connectionString);
            //    sqlCmd.CommandText = "subtractAnAccount";
            //    sqlCmd.CommandType = CommandType.StoredProcedure;
            //    sqlCmd.Parameters.Clear();
            //    sqlCmd.Parameters.AddWithValue("@accountID", currentAccountID);
            //    sqlPar = sqlCmd.Parameters.Add("@result", SqlDbType.Int);
            //    sqlPar.Direction = ParameterDirection.ReturnValue;
            //    sqlCmd.Connection.Open();
            //    sqlCmd.ExecuteNonQuery();
                
            //    return (int)sqlCmd.Parameters["@result"].Value;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    sqlCmd.Connection.Close();
            //}

            return 0;
        }        

        private void frm_financialActions_Load(object sender, EventArgs e)
        {
            refreshBanksDataset();
            refreshAccountsDataset();
            try
            {
                mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();

                selectActiveProject_Persons();

                refreshDocsTableDataSet();

                upDateCurrentPositionLabel();

                //upDateAccountsList();

                //calculateAnAccount_remainAmount();

                if (!openForModify)//this means 'open for add'
                {
                    rdu_issuanceAnCheque.Checked = true;
                }
                else
                {
                }

                lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_price.Text) + " ریال";

                nAvilDocID = long.Parse(tbx_ID.Text);

                if (docsTableBindingSource.Count > 0)
                {
                    if ((string)pSDatabase5DataSet.docsTable.Rows[docsTableBindingSource.Position]["docType"] == "iss")
                    {
                        rdu_issuanceAnCheque.Checked = true;
                    }
                    else
                    {
                        rdu_receiveAnCheque.Checked = true;
                    }                    
                }
            }
            catch
            {
            }
        }
       
        private void chk_byCheque_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdu_issuanceAnCheque.Checked)
            //{
            //    if (chk_byCheque.Checked)
            //    {
            //        grp_banks.Enabled = false;

            //        btn_defineCheque.Visible = true;

            //        tbx_price.ReadOnly = true;
            //    }
            //    else
            //    {
            //        grp_banks.Enabled = true;

            //        btn_defineCheque.Visible = false;

            //        tbx_price.ReadOnly = false;
            //    }
            //}
            //else
            //{
            //    if (chk_byCheque.Checked)
            //    {
            //        btn_defineCheque.Visible = true;
            //    }
            //    else
            //    {
            //        btn_defineCheque.Visible = false;
            //    }
            //}
        }

        private void rdu_issuanceAnCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdu_issuanceAnCheque.Checked)
            {
                tbx_price.BackColor = Color.LightSalmon;

                currentDocType = "iss";                

                //chk_byCheque_CheckedChanged(sender, e);
            }
        }

        private void rdu_receiveAnCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdu_receiveAnCheque.Checked)
            {
                tbx_price.BackColor = Color.White;

                //grp_banks.Enabled = true;

                currentDocType = "rcv";
            }
            pnl_banks.Enabled = rdu_receiveAnCheque.Checked;
        }

        private void btn_defineCheque_Click(object sender, EventArgs e)
        {
            //frm_manageCheques frmManageCheques = new frm_manageCheques();
            //try
            //{
            //    if (rdu_issuanceAnCheque.Checked)
            //    {
            //        frmManageCheques.theChequeIsMine = true;
            //    }
            //    else
            //    {
            //        frmManageCheques.theChequeIsMine = false;
            //        frmManageCheques.tbx_senderOrReceiver.Text = "شرکت پایدار صنعت شادگان";
            //    }
                
            //    frmManageCheques.currentPersonID = currentPersonID;                
            //    frmManageCheques.currentPrjectID = currentPrjectID;
            //    frmManageCheques.currentProjectTitle = currentProjectTitle;
            //    frmManageCheques.connectionString = connectionString;
            //    frmManageCheques.ShowDialog(this);
            //    tbx_price.Text = frmManageCheques.tbx_chequesTotal.Text;

            //    btn_saveChanges_Click(sender, e);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void tbx_price_TextChanged(object sender, EventArgs e)
        {
            if (tbx_price.Text == "")
            {
                tbx_price.Text = "0";
            }
            lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_price.Text) + " ریال";
        }

        private void cmb_familyAndName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = personsTableBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = personsTableBindingSource.DataMember;
                frmFindRecords.listDisplayMember = "personFamilyAndName";
                frmFindRecords.listValueMember = "personID";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    int nPosition = personsTableBindingSource.Find("personID", frmFindRecords.foundRecordID);
                    personsTableBindingSource.Position = nPosition;
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

        private void frm_financialActions_Shown(object sender, EventArgs e)
        {         
        }

        private void lbl_personID_TextChanged(object sender, EventArgs e)
        {
            n_currentPersonID = int.Parse(lbl_personID.Text);

            refreshDocsTableDataSet();

            upDateCurrentPositionLabel();

            //enableControls(false);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[0] == allow add data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableControls(true);

            mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
            
            nAvilDocID = getAvilableAccountingDocumentNumber();

            try
            {
                //int nAccountID, nBankID;
                //if (accountstablebindingsource.count == 0) return;
                //if (bankstablebindingsource.count == 0) return;                
                //nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                //nBankID = (int)pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];

                docsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@docID", nAvilDocID);
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPersonID", n_currentPersonID);
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@bankID", DBNull.Value);                
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@accountID", DBNull.Value);                
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sDate", mTbx_Date.Text);
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPrice", 0);
                docsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("sDocType", currentDocType);

                if (rdu_issuanceAnCheque.Checked)
                {
                    runSQLCommand("INSERT INTO docsTable(docID, projectID, personID, dDate, price, docType) VALUES(@docID, @nProjectID, @nPersonID, @sDate, @nPrice, @sDocType);");
                }
                else
                {
                    runSQLCommand("INSERT INTO docsTable(docID, projectID, personID, accountID, bankID, dDate, price, docType) VALUES(@docID, @nProjectID, @nPersonID, @accountID, @bankID, @sDate, @nPrice, @sDocType);");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            refreshDocsTableDataSet();

            docsTableBindingSource.MoveLast();

            upDateCurrentPositionLabel();

            tbx_price.Focus();
        }

        private void btn_goNext_Click(object sender, EventArgs e)
        {
            try
            {

                //btn_saveChanges_Click(sender, e);
                //if (calculateAnAccount_remainAmount() == 0)
                //{
                //    MessageBox.Show("مبلغ بیشتر موجودی حساب می باشد");
                //    return;
                //}

                if (docsTableBindingSource.Count > 0 && !hasItAccDoc())
                {
                    if (MessageBox.Show("کاربر گرامی شما این سند را ثبت نکرده اید" + "\n" + "آیا مایلید سند حذف شود ؟", "ثبت اسناد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        btn_saveChanges_Click(sender, e);
                        if (!hasItAccDoc())
                        {

                        }
                        else
                        {
                            docsTableBindingSource.MoveNext();
                            upDateCurrentPositionLabel();
                        }
                    }
                    else//if user would delete the doc
                    {
                        deleteThisDoc();
                        upDateCurrentPositionLabel();
                    }
                }
                else
                {
                    docsTableBindingSource.MoveNext();
                    upDateCurrentPositionLabel();
                }
            }
            catch
            {
            }
        }

        private void btn_returnPrior_Click(object sender, EventArgs e)
        {
            try
            {
                //btn_saveChanges_Click(sender, e);
                //if (calculateAnAccount_remainAmount() == 0)
                //{
                //    MessageBox.Show("مبلغ بیشتر موجودی حساب می باشد");
                //    return;
                //}

                if (docsTableBindingSource.Count > 0 && !hasItAccDoc())
                {
                    if (MessageBox.Show("کاربر گرامی شما این سند را ثبت نکرده اید" + "\n" + "آیا مایلید سند حذف شود ؟", "ثبت اسناد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        btn_saveChanges_Click(sender, e);
                        if (!hasItAccDoc())
                        {

                        }
                        else
                        {
                            docsTableBindingSource.MovePrevious();
                            upDateCurrentPositionLabel();
                        }
                    }
                    else//if user would delete the doc
                    {
                        deleteThisDoc();
                        upDateCurrentPositionLabel();
                    }
                }
                else
                {
                    docsTableBindingSource.MovePrevious();
                    upDateCurrentPositionLabel();
                }
            }
            catch
            {
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (limitString[1] == '0')//limitString[1] == allow edit data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (long.Parse(tbx_price.Text) <= 0)
            {
                MessageBox.Show("کاربر گرامی لطفا مبلغ را درست وارد کنید");
                tbx_price.Focus();
                return;
            }
            
            s_orig_docType = (string)pSDatabase5DataSet.docsTable.Rows[docsTableBindingSource.Position]["docType"];
            if ((s_orig_docType != currentDocType) || (long.Parse(tbx_ID.Text) != nAvilDocID))
            {
                SqlCommand sqlCmd=new SqlCommand();
                try
                {
                    sqlCmd = new SqlCommand("delete from accountingDocs where accdoc_id = @accDoc_id;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", tbx_ID.Text);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCmd.Connection.Close();                    
                }
            }

            int nOldPos = docsTableBindingSource.Position;

            try
            {
                int nAccountID = 0, nBankID = 0;
                if (rdu_receiveAnCheque.Checked)
                {
                    if (accountsTableBindingSource.Count == 0) return;
                    if (banksTableBindingSource.Count == 0) return;

                    nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                    nBankID = (int)pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];
                }

                string sqlStatement = "";
                if (rdu_receiveAnCheque.Checked)
                {
                    sqlStatement = "UPDATE docsTable SET docID = @new_docID, personID = @nPersonID, bankID = @bankID, accountID = @accountID, dDate = @sDate, price = @nPrice, docType = @sDocType, docComment = @sDocComment WHERE docID = @old_DocID;";
                }
                else
                {
                    sqlStatement = "UPDATE docsTable SET docID = @new_docID, personID = @nPersonID, dDate = @sDate, price = @nPrice, docType = @sDocType, docComment = @sDocComment WHERE docID = @old_DocID;";
                }

                docsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@new_docID", tbx_ID.Text);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@old_docID", nAvilDocID);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPersonID", n_currentPersonID);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@accountID", nAccountID);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@bankID", nBankID);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sDate", mTbx_Date.Text);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPrice", long.Parse(tbx_price.Text));
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("sDocType", currentDocType);
                docsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sDocComment", tbx_event.Text);
                docsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                docsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatement;
                docsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                docsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                pSDatabase5DataSet.docsTable.Clear();
                docsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.docsTable);                
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("شماره سند تکراری می باشد ،لطفاً شماره سند را تغییر دهید" + "\n" + sqlEx.Message);
                    tbx_ID.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            refreshDocsTableDataSet();

            docsTableBindingSource.Position = nOldPos;

            upDateCurrentPositionLabel();

            saveAccountingDocument();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("آیا از حذف این سند مطمئنید ؟", "حذف سند", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                deleteThisDoc();

                upDateCurrentPositionLabel();
            }
        }

        private void chk_byCheque_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void tbx_ID_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                n_currentDocID = int.Parse(tbx_ID.Text);
            }
            catch
            {
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                frm_receipt frmReceipt = new frm_receipt();
                frmReceipt.connectionString = connectionString;
                frmReceipt.currentDocID = currentDocID;
                frmReceipt.currentPersonID = currentPersonID;
                frmReceipt.currentPrjectID = currentPrjectID;
                frmReceipt.price = tbx_price.Text;
                frmReceipt.INReceipt = rdu_receiveAnCheque.Checked;
                frmReceipt.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_financialActions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (docsTableBindingSource.Count > 0 && !hasItAccDoc())
            {
                if (MessageBox.Show("کاربر گرامی شما این سند را ثبت نکرده اید" + "\n" + "آیا مایلید که این سند را ثبت کنید ؟" + "\n" + "اگر دکمه خیر را انتخاب کنید سند حذف می شود", "ثبت اسناد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    btn_saveChanges_Click(sender, e);
                    if (!hasItAccDoc())
                    {
                        deleteThisDoc();
                    }
                }
                else
                {
                    deleteThisDoc();
                }
            }
            ////........................
            //if (calculateAnAccount_remainAmount() == 0 && pnl_person.Enabled)
            //{
            //    if (n_errorDocPos == -1)
            //    {
            //        n_errorPersonPos = personsTableBindingSource.Position;
            //        n_errorDocPos = docsTableBindingSource.Position;
            //    }
            //    else
            //    {
            //        docsTableBindingSource.Position = n_errorDocPos;
            //        personsTableBindingSource.Position = n_errorPersonPos;
            //    }

            //    MessageBox.Show("مبلغ بیشتر از موجودی حساب می باشد");

            //    upDateCurrentPositionLabel();

            //    e.Cancel = true;
            //}
        }

        private void rdu_receiveAnCheque_MouseUp(object sender, MouseEventArgs e)
        {
            //if (!rdu_receiveAnCheque.Checked && long.Parse(tbx_price.Text) > 0 && chk_byCheque.Checked)//if END-USER defined cheques
            //{
            //    if (MessageBox.Show("آیا چک هایی را که تعریف کرده اید حذف شوند ؟", "حذف چک ها", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            //    {
            //        deleteCheques();
            //    }
            //    else
            //    {
            //        rdu_issuanceAnCheque.Checked = true;
            //    }
            //}
  
        }

        private void rdu_issuanceAnCheque_MouseUp(object sender, MouseEventArgs e)
        {
            //if (!rdu_issuanceAnCheque.Checked && long.Parse(tbx_price.Text) > 0 && chk_byCheque.Checked)//if END-USER defined cheques
            //{
            //    if (MessageBox.Show("آیا چک هایی را که تعریف کرده اید حذف شوند ؟", "حذف چک ها", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            //    {
            //        deleteCheques();
            //    }
            //    else
            //    {
            //        rdu_receiveAnCheque.Checked = true;
            //    }
            //}
        }

        private void rdu_issuanceAnCheque_KeyUp(object sender, KeyEventArgs e)
        {
            //if (long.Parse(tbx_price.Text) > 0 && chk_byCheque.Checked)//if END-USER defined cheques
            //{
            //    if (MessageBox.Show("آیا چک هایی را که تعریف کرده اید حذف شوند ؟", "حذف چک ها", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            //    {
            //        deleteCheques();
            //    }
            //    else
            //    {
            //        rdu_receiveAnCheque.Checked = true;
            //    }
            //}
        }

        private void rdu_receiveAnCheque_KeyUp(object sender, KeyEventArgs e)
        {
            //if (long.Parse(tbx_price.Text) > 0 && chk_byCheque.Checked)//if END-USER defined cheques
            //{
            //    if (MessageBox.Show("آیا چک هایی را که تعریف کرده اید حذف شوند ؟", "حذف چک ها", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            //    {
            //        deleteCheques();
            //    }
            //    else
            //    {
            //        rdu_issuanceAnCheque.Checked = true;
            //    }
            //}

        }

        private void cmb_familyAndName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = personsTableBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = personsTableBindingSource.DataMember;
                frmFindRecords.listDisplayMember = "personFamilyAndName";
                frmFindRecords.listValueMember = "personID";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    int nPosition = personsTableBindingSource.Find("personID", frmFindRecords.foundRecordID);
                    personsTableBindingSource.Position = nPosition;
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ////delete the documents that Defined with 0 price
            //docsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            //docsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            //runSQLCommand("DELETE FROM docsTable WHERE price = 0;");
        }

        private void tbx_price_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //if(accountsTableBindingSource.Position > -1)
                //    tbx_price.Text =((long) pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["account_remain"]).ToString();
            }
        }

        private void mTbx_Date_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void banksTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                refreshAccountsDataset();
            }
            catch
            {
            }
        }

        private void mTbx_Date_Leave(object sender, EventArgs e)
        {
            try
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
            catch
            {
            }
        }

        private void cmb_familyAndName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
