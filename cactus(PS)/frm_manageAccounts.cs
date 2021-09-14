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
    public partial class frm_manageAccounts : Form
    {        
        public frm_manageAccounts()
        {
            InitializeComponent();
        }

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
                int nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                                
                bs.DataSource = pSDatabase5DataSet;
                bs.DataMember = "AccountingDocs";
                int pos = bs.Find("accountID", nAccountID);
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
                long nAvilableDocNumber = checkThisIDOnTheAccDocTable();
                if (nAvilableDocNumber != -1)//the accDoc has issused
                {
                    SqlCommand sqlCmd = new SqlCommand("update accountingDocs set accDoc_comment = @accDoc_comment where accDoc_id = @accDoc_id;");                                                      
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);                    
                    sqlCmd.Parameters.AddWithValue("@accDoc_comment", "موجودی اولیه حساب" + "--" + cmb_bankName.Text + " " + cmb_accounts.Text);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();
                    /////////////////

                    sqlCmd = new SqlCommand("update accDocEventsTable set accDocEvent_indebted = @accDocEvent_indebted ,accDocEvent_creditor = 0 where accDoc_id = @accDoc_id and accDocEvent_row = 1;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);                    
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_indebted", tbx_account_amount.Text);                    
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();                    
                    ////////////////////////////////////////
                    sqlCmd = new SqlCommand("update accDocEventsTable set accDocEvent_indebted = 0 ,accDocEvent_creditor = @accDocEvent_creditor, accDocEvent_itIsJustLedger = 1 where accDoc_id = @accDoc_id and accDocEvent_row = 2;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_creditor", tbx_account_amount.Text);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();                    
                }
                else//create a new accDoc
                {
                    int nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];

                    nAvilableDocNumber = getAvilableAccountingDocumentNumber();

                    SqlCommand sqlCmd = new SqlCommand("insert into accountingDocs(accDoc_id, projectID, accountID, accDoc_date, accDoc_comment) " +
                                                      "values(@accDoc_id, @projectID, @accountID, @accDoc_date, @accDoc_comment)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@projectID", currentPrjectID);
                    sqlCmd.Parameters.AddWithValue("@accountID", nAccountID);
                    sqlCmd.Parameters.AddWithValue("@accDoc_date", numberConvertor.nowDateInAppropriateFormat());
                    sqlCmd.Parameters.AddWithValue("@accDoc_comment", "موجودی اولیه حساب" + "--" + cmb_bankName.Text + " " + cmb_accounts.Text);

                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();

                    //insert into the docEvent table 
                    //first of all insert the 'هزینه حقوق' text
                    sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank, spentMasterID, projectID, personID, accountID) " +
                                                                   "values(@accDoc_id, @accDocEvent_row, @accDocEvent_indebted, 0, 1, 1, @spentMasterID, @projectID, @personID, @accountID)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 1);
                    sqlCmd.Parameters.AddWithValue("@projectID", currentPrjectID);
                    sqlCmd.Parameters.AddWithValue("@personID", numberConvertor.ThisComapnyID(connectionString));
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_indebted", tbx_account_amount.Text);                    
                    sqlCmd.Parameters.AddWithValue("@accountID", nAccountID);
                    sqlCmd.Parameters.AddWithValue("@spentMasterID", numberConvertor.getSpentMasterID("بانک", connectionString));

                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();

                    //////////////////////////////////////////////

                    sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, accDocEvent_row, accDocEvent_indebted, accDocEvent_creditor, accDocEvent_itIsIndebted, accDocEvent_itIsBank, spentMasterID, projectID, personID, accountID, accDocEvent_itIsJustLedger) " +
                                                                   "values(@accDoc_id, @accDocEvent_row, 0, @accDocEvent_creditor, 0, 0, @spentMasterID, @projectID, @personID, @accountID, 1)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 2);
                    sqlCmd.Parameters.AddWithValue("@projectID", currentPrjectID);
                    sqlCmd.Parameters.AddWithValue("@personID", numberConvertor.ThisComapnyID(connectionString));
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_creditor", tbx_account_amount.Text);
                    sqlCmd.Parameters.AddWithValue("@accountID", nAccountID);
                    sqlCmd.Parameters.AddWithValue("@spentMasterID", numberConvertor.getSpentMasterID("سرمایه", connectionString));

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

        private void updateAllFields()
        {
            try
            {
                int nAccountID = int.Parse( pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"].ToString());
                int nBankID = int.Parse(pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"].ToString());
                int nAccountType_id = int.Parse( pSDatabase5DataSet.accountTypesTable.Rows[accountTypesTableBindingSource.Position]["accountType_id"].ToString());
                
                accountsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand("update accountsTable set bankID = @bankID ,account_amount = @account_amount, account_chapterName = @account_chapterName, account_chapterNO = @account_chapterNO, accountType_id = @accountType_id where accountID = @accountID;");
                accountsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@accountID", nAccountID);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@bankID", nBankID);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@account_amount", tbx_account_amount.Text);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@account_chapterName", tbx_chapterName.Text);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@account_chapterNO", tbx_chapterNO.Text);
                accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@accountType_id", nAccountType_id);

                accountsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                accountsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                accountsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();

                refreshAccountsTableDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enableDisableControls(bool enable)
        {
            try
            {
                cmb_bankName.Enabled = enable;
                tbx_account_amount.ReadOnly = !enable;
                tbx_chapterName.ReadOnly = !enable;
                tbx_chapterNO.ReadOnly = !enable;
                cmb_accountTypes_Title.Enabled = enable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshBanksTableDataset()
        {
            try
            {

                banksTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                banksTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                banksTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM banksTable order by bankName;";
                banksTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                //banksTableTableAdapter.Adapter.SelectCommand.Connection = connection;
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

        private void refreshAccountsTableDataset()
        {
            try
            {
                accountsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                accountsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                int pos = accountsTableBindingSource.Position;
                runSQLCommand("SELECT * FROM accountsTable;");
                accountsTableBindingSource.Position = pos;
            }
            catch (SqlException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    accountsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    accountsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
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
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    accountsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    //accountsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                    accountsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    accountsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    accountsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.AccountsTable.Clear();
                    accountsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    accountsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    accountsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    //accountsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
                    accountsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    accountsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    accountsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.AccountsTable.Clear();
                    accountsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    accountsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                try
                {
                    accountsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //accountsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    accountsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    accountsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    accountsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.AccountsTable.Clear();
                    accountsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountsTable);

                }
                catch (SqlException)
                {
                    MessageBox.Show("این حساب را نمی توانید حذف کنید.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    accountsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

       

        private void frm_manageAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.accountTypesTable' table. You can move, or remove it, as needed.
            this.accountTypesTableTableAdapter.Fill(this.pSDatabase5DataSet.accountTypesTable);

            refreshBanksTableDataset();
            refreshAccountsTableDataset();
        }

        private void btn_defineNewAccount_Click(object sender, EventArgs e)
        {
            try
            {

                if (limitString[0] == '0')//limitString[0] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nBankID = (int)pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];
                int nAccountType_ID = int.Parse(pSDatabase5DataSet.accountTypesTable.Rows[accountTypesTableBindingSource.Position]["accountType_id"].ToString());

                frm_getString frmGetString = new frm_getString();
                frmGetString.Text = "شماره حساب را وارد کنید";
                frmGetString.tbx_.RightToLeft = RightToLeft.No;
                frmGetString.ShowDialog();

                if (frmGetString.OkClicked)
                {
                    if (frmGetString.tbx_.Text != "")
                    {
                        accountsTableTableAdapter.Adapter.InsertCommand = new SqlCommand("INSERT INTO accountsTable(bankID, account_number, accountType_id, account_amount, account_remain) VALUES(@nBankID, @account_number, 1, 0, 0);");
                        accountsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                        accountsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                        accountsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nBankID", nBankID);
                        accountsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@account_number", frmGetString.tbx_.Text);
                        accountsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@accountType_id", nAccountType_ID);  
                        accountsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                        accountsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                        accountsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                        //accountsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@account_chapterName", tbx_chapterName.Text);
                        //accountsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@account_chapterNO", tbx_chapterNO.Text);
                       
                        refreshAccountsTableDataset();

                        accountsTableBindingSource.Position = accountsTableBindingSource.Find("account_number", frmGetString.tbx_.Text);

                        this.AcceptButton = btn_saveAccountChanges;

                        //click save changees
                        btn_saveAccountChanges_Click(sender, e);

                        int AccountID = (int)pSDatabase5DataSet.AccountsTable[accountsTableBindingSource.Position]["accountID"];
                        if (numberConvertor.createDetailViaDetail(AccountID, "acn", this.connectionString) == -1)
                        {
                            MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_banksName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modifyAccount_Click(object sender, EventArgs e)
        {
            try
            {

                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (accountsTableBindingSource.Position > -1)
                {
                    string sOldAccountNumber = cmb_accounts.Text;

                    frm_getString frmGetString = new frm_getString();
                    frmGetString.Text = "شماره حساب را اصلاح کنید";
                    frmGetString.tbx_.Text = sOldAccountNumber;
                    frmGetString.ShowDialog();

                    if (frmGetString.OkClicked)
                    {
                        if (frmGetString.tbx_.Text != "")
                        {
                            int nOldPos = accountsTableBindingSource.Position;

                            int nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                            int n_bankID = int.Parse(pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"].ToString());

                            accountsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                            accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                            accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nBankID", n_bankID);
                            accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sAccountNumber", frmGetString.tbx_.Text);
                            accountsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nAccountID", nAccountID);

                            runSQLCommand("UPDATE accountsTable SET account_number = @sAccountNumber WHERE accountID = @nAccountID;");

                            refreshAccountsTableDataset();

                            accountsTableBindingSource.Position = nOldPos;

                            if (numberConvertor.createDetailViaDetail(nAccountID, "acn", this.connectionString) == -1)
                            {
                                MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_defineNewBank_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accountsTableBindingSource.Position > -1)
            {
                if (MessageBox.Show("آیا از حذف حساب مطمئنید ؟ ", "حذف حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                    accountsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    accountsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    accountsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nAccountID", nAccountID);
                    runSQLCommand("DELETE FROM accountsTable WHERE accountID = @nAccountID;");

                    refreshAccountsTableDataset();
                }
            }
        }

        private void btn_saveAccountChanges_Click(object sender, EventArgs e)
        {
            try
            {
            if (limitString[1] == '0')//limitString[1] == allow edit data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (accountsTableBindingSource.Count == 0)
                {
                    return;
                }

                if (tbx_account_amount.ReadOnly)
                {
                    btn_saveAccountChanges.Text = "ثبت اصلاحات";
                    enableDisableControls(true);//enable
                    cmb_bankName.Focus();
                }
                else
                {
                    btn_saveAccountChanges.Text = "اصلاح مشخصات";
                    if (cmb_bankName.Text == "")
                    {
                        cmb_bankName.Focus();
                        return;
                    }
                    else if (tbx_account_amount.Text == "")
                    {
                        tbx_account_amount.Focus();
                        return;
                    }
                    enableDisableControls(false);
                    this.AcceptButton = btn_ok;

                    updateAllFields();

                    int AccountID = (int)pSDatabase5DataSet.AccountsTable[accountsTableBindingSource.Position]["accountID"];
                    if (numberConvertor.createDetailViaDetail(AccountID, "acn", this.connectionString) == -1)
                    {
                        MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                    }
                    //saveAccountingDocument();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!tbx_account_amount.ReadOnly)//if data had not been saved.
            {
                btn_saveAccountChanges_Click(sender, e);
            }

            Close();
        }

        private void tbx_account_amount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbx_chapterName.Focus();
                }
            }
            catch
            {
            }
        }

        private void tbx_chapterName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbx_chapterNO.Focus();
                }
            }
            catch
            {
            }
        }

        private void tbx_account_amount_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void cmb_bankName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbx_account_amount.Focus();
                }
            }
            catch
            {
            }
        }

        private void tbx_chapterNO_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_saveAccountChanges;
        }

        private void cmb_bankName_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tbx_chapterNO_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cmb_bankName_Leave(object sender, EventArgs e)
        {
            try
            {
                int pos = banksTableBindingSource.Find("bankName", cmb_bankName.Text);
                if (pos == -1)//define a new bank
                {
                    if (MessageBox.Show("بانکی که وارد کردید در لیست بانکهای برنامه موجود نمی باشد" + "\n" + "آیا مایلید که این بانک به لیست برنامه اضافه شود ؟", "اضافه کردن بانک جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string newBankName = cmb_bankName.Text;
                        banksTableTableAdapter.Adapter.InsertCommand = new SqlCommand("INSERT INTO banksTable(bankName) VALUES(@sBankName);");
                        banksTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                        banksTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                        banksTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sBankName", newBankName);
                        banksTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                        banksTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                        banksTableTableAdapter.Adapter.InsertCommand.Connection.Close();

                        refreshBanksTableDataset();

                        banksTableBindingSource.Position = banksTableBindingSource.Find("bankName", newBankName);
                    }
                    else
                    {
                        banksTableBindingSource.Position = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_account_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_account_amount.Text == "")
                {
                    tbx_account_amount.Text = "0";
                }
                toolTip1.SetToolTip(tbx_account_amount, numberConvertor.convertToChars(tbx_account_amount.Text) + " ریال ");
            }
            catch
            {
            }
        }

        private void frm_manageAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"accounts_closed\"");
            }
            catch
            {
            }
        }

       
       
    }
}
