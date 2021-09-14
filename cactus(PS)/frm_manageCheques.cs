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
using System.IO;

namespace cactus_PS_
{
    public partial class frm_manageCheques : Form
    {
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
        private long n_accDoc_id;
        public long accDoc_id
        {
            get { return n_accDoc_id; }
            set { n_accDoc_id = value; }
        }
        private bool b_theChequeIsMine;
        public bool theChequeIsMine
        {
            get { return b_theChequeIsMine; }
            set { b_theChequeIsMine = value; }
        }
        private int n_currentPersonID;
        public int currentPersonID
        {
            get {return n_currentPersonID;}
            set { n_currentPersonID = value; }
        }
        private long n_defaultPrice;
        public long defaultPrice
        {
            get { return n_defaultPrice; }
            set { n_defaultPrice = value; }
        }

        private bool bChequeSaved = false;
        private string sReminderText = "";

        public frm_manageCheques()
        {
            n_defaultPrice = 0;
            InitializeComponent();
        }
       
        private void giveItToReminder()
        {
            string sFileText = "";
            string bankName = "", sChequePrice = "", sOwner = "";
            
            chequesTableBindingSource.MoveFirst();
            do
            {
                if (chequesTableBindingSource.Count > 0)
                {
                    try
                    {
                        bankName = " بانک " + pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Find("bankID", (int)pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["bankID"])]["bankName"].ToString();
                        if (pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["account_chapterName"].ToString() != "")
                        {
                            bankName += " شعبه " + pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["account_chapterName"].ToString();
                        }
                    }
                    catch
                    {
                    }

                    try
                    {
                        sChequePrice = "مبلغ چک : " + numberConvertor.splitNumber(pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequePrice"].ToString(), false) + " ریال ";                        

                        if ((bool)pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeIsMine"])
                        {
                            int nPersonID = (int)pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["personID"];
                            sOwner = "دریافت کننده : " + pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Find("personID", nPersonID)]["personFamilyAndName"];
                        }
                        else
                        {
                            int nPersonID = (int)pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["personID"];
                            sOwner = "پرداخت کننده : " + pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Find("personID", nPersonID)]["personFamilyAndName"];
                        }
                    }
                    catch
                    {
                    }

                    sFileText += "[delete]\r\n";
                    sFileText += "id=\"" + pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeID"].ToString() + "\"\r\n";
                    sFileText += ";\r\n";

                    sFileText += "[insert]\r\n";
                    sFileText += "id=\"" + pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeID"].ToString() + "\"\r\n";
                    sFileText += "title=\"" + "زمان سررسید چک شماره " + pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeNumber"].ToString() + bankName + "." + sChequePrice + "." + sOwner + "\"\r\n";
                    sFileText += "date=\"" + pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["usanceDate"].ToString() + "\"\r\n";
                    sFileText += "time=\"" + "12:01:01\"\r\n";
                    sFileText += ";\r\n";
                }
                if (chequesTableBindingSource.Position == chequesTableBindingSource.Count - 1) break;
                chequesTableBindingSource.MoveNext();                
            } while (true);
            
            File.WriteAllText(Application.StartupPath + "\\man.inf", sReminderText + sFileText);
        }

        private void emptyTheControls()
        {
            tbx_chequeNumber.Text = "";
            //tbx_to.Text = "";

            //num_price.Value = 0;
            tbx_price.Text = "0";

        }

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

        private void refreshThePersonsDataset()
        {
            try
            {                
                personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable;";
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();                
                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
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

        private long getaccount_amount()
        {
            return (long)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["account_remain"];
        }

        private void refreshAccountsTableDataset()
        {
            if (banksTableBindingSource.Position > -1)
            {
                int bankID =(int) pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];

                accountsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                accountsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                accountsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM accountsTable WHERE bankID = @nBankID;";
                accountsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nBankID", bankID);
                accountsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection();
                accountsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                accountsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.AccountsTable.Clear();
                accountsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.AccountsTable);
                accountsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void enableControls(bool enable)
        {
            tbx_chequeNumber.Enabled = enable;
            mTbx_issuanceDate.Enabled = enable;
            mTbx_usanceDate.Enabled = enable;
            //tbx_to.Enabled = enable;

            cmb_accountNumber.Enabled = enable;
            cmb_banksName.Enabled = enable;

            tbx_price.Enabled = enable;

            btn_deleteCheque.Enabled = enable;
            btn_saveChanges.Enabled = enable;
            btn_nextCheque.Enabled = enable;
            btn_priorCheque.Enabled = enable;

            lbl_priceInChars.Enabled = enable;
        }

        private void upDateAccountsList()
        {
            try
            {
                if (chequesTableBindingSource.Count > 0 && theChequeIsMine)
                {
                    int nAccountID = (int)pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["accountID"];                    

                    refreshAccountsTableDataset();

                    accountsTableBindingSource.Position = accountsTableBindingSource.Find("accountID", nAccountID);                    

                }
            }
            catch
            {                
            }
        }

        private long calculateSumOfCheques()
        {
            SqlCommand c = new SqlCommand();
            try
            { 
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "calculateChequesSUM";
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@accDoc_id", accDoc_id);

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

            return long.Parse( c.Parameters["@result"].Value.ToString());
        }

        private bool upGradeTheCurrentCheque()
        {
            try
            {
                if (tbx_chequeNumber.Text == "")
                {
                    tbx_chequeNumber.Focus();
                    return false;
                }                
                else if (tbx_price.Text == "0")
                {
                    tbx_price.Focus();
                    return false;
                }
                else if (tbx_account_number.Visible && tbx_account_number.Text == "")
                {
                    tbx_account_number.Focus();
                    return false;
                }

                /*if (long.Parse(tbx_price.Text) > getaccount_amount() && chequesTableBindingSource.Count > 1)
                {
                    MessageBox.Show("مبلغ چک از موجودی حساب بیشتر است", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }*/

                int nOldPos = chequesTableBindingSource.Position;

                int nAccountID = 0;
                if (theChequeIsMine)
                {
                    if (accountsTableBindingSource.Count == 0)
                    {
                        MessageBox.Show("برای این بانک حسابی تعریف نشده است" + "\n" + "لطفا برای تعریف حسابهای بانکی از منوی تنظیمات گزینه حسابهای بانکی را برگزینید");
                        return false;
                    }
                    nAccountID = (int)pSDatabase5DataSet.AccountsTable.Rows[accountsTableBindingSource.Position]["accountID"];
                }
                int nChequeID = (int) pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeID"];
                int nBankID = (int) pSDatabase5DataSet.BanksTable.Rows[banksTableBindingSource.Position]["bankID"];

                chequesTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nChequeID", nChequeID);                
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPersonID", currentPersonID);//(int)pSDatabase5DataSet.personsTable.Rows[0]["personID"]);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sChequeNumber", tbx_chequeNumber.Text);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sIssuanceDate", mTbx_issuanceDate.Text);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUsanceDate", mTbx_usanceDate.Text);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nAccountID", nAccountID);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nBankID", nBankID);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@isTO", tbx_account_number.Text);
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@cChequePrice", double.Parse(tbx_price.Text));
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sChequeState", "cur");
                chequesTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@bChequeIsMine", theChequeIsMine);

                if (theChequeIsMine)
                {
                    runSQLCommand("UPDATE chequesTable SET chequeNumber = @sChequeNumber, issuanceDate = @sIssuanceDate, usanceDate = @sUsanceDate, accountID = @nAccountID, bankID = @nBankID,isTo = @isTo, chequePrice = @cChequePrice, chequeState = @sChequeState, chequeIsMine = @bChequeIsMine WHERE chequeID = @nChequeID;");
                }
                else
                {
                    runSQLCommand("UPDATE chequesTable SET chequeNumber = @sChequeNumber, issuanceDate = @sIssuanceDate, usanceDate = @sUsanceDate, bankID = @nBankID,isTo = @isTo, chequePrice = @cChequePrice, chequeState = @sChequeState, chequeIsMine = @bChequeIsMine WHERE chequeID = @nChequeID;");
                }

                upGradeTheChequesDataset();

                tbx_chequesTotal.Text = calculateSumOfCheques().ToString();
              
                chequesTableBindingSource.Position = nOldPos;

                bChequeSaved = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;

        }

        private void upGradeTheChequesDataset()
        {
            try
            {
                int nOldPos = chequesTableBindingSource.Position;

                chequesTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                chequesTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                //chequesTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
                chequesTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@accDoc_id", accDoc_id);
                runSQLCommand("SELECT * FROM chequesTable WHERE accDoc_id = @accDoc_id;");
                   
                chequesTableBindingSource.Position = nOldPos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upGradeTheChequePositionLabel()
        {
            try
            {
                string sChequePos = "", sChequesCount = "";

                sChequePos = (chequesTableBindingSource.Position + 1).ToString();
                sChequesCount = (chequesTableBindingSource.Count).ToString();

                if (sChequesCount == "0")
                {
                    lbl_currentChequePosition.Text = "*********";
                }
                else
                    lbl_currentChequePosition.Text = "چک " + sChequePos + "از " + sChequesCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void runSQLCommand(string sqlStatment)
        {
            try
            {
                string sTemp;
                sTemp = sqlStatment.ToUpper();

                if (sTemp.Contains("SELECT"))
                {

                    try
                    {
                        chequesTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);                        
                        chequesTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                        chequesTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                        pSDatabase5DataSet.chequesTable.Clear();
                        chequesTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.chequesTable);

                    }
                    catch 
                    {                        
                    }
                    finally
                    {
                        chequesTableTableAdapter.Adapter.SelectCommand.Connection.Close();
                    }
                }
                else if (sTemp.Contains("UPDATE"))
                {
                    try
                    {
                        chequesTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                        
                        chequesTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                        chequesTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                        chequesTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                        pSDatabase5DataSet.chequesTable.Clear();
                        chequesTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.chequesTable);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        chequesTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                    }
                }
                else if (sTemp.Contains("INSERT"))
                {
                    try
                    {
                        chequesTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                        chequesTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                        chequesTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                        chequesTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                        pSDatabase5DataSet.chequesTable.Clear();
                        chequesTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.chequesTable);
                        
                    }
                    catch
                    {
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        chequesTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                    }
                }
                else if (sTemp.Contains("DELETE"))
                {
                    try
                    {
                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                        //chequesTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                        chequesTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                        chequesTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                        pSDatabase5DataSet.chequesTable.Clear();
                        chequesTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.chequesTable);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        

        private void mTbx_Date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbx_comment_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.KeyChar.ToString());
                if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '!' && e.KeyChar <= '*'))
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show("error");
                e.Handled = true;
            }    
        }

        private void tbx_comment_KeyDown(object sender, KeyEventArgs e)
        {
            
            //MessageBox.Show(e.KeyValue.ToString());   
        }

        private void frm_manageCheques_Load(object sender, EventArgs e)
        {           
            try
            {
                refreshThePersonsDataset();
                
                sReminderText = "";

                refreshBanksDataset();

                refreshAccountsDataset();

                upGradeTheChequesDataset();

                tbx_chequesTotal.Text = calculateSumOfCheques().ToString();

                upGradeTheChequePositionLabel();

                upDateAccountsList();

                if (chequesTableBindingSource.Count == 0)
                {
                    enableControls(false);
                }

                if (theChequeIsMine)
                {                    
                    //lbl_bankPrompt.Text = "شماره حسابی که قصد دارید از آن برداشت کنید";
                    this.Text = "چــــــک پــــرداخــــتــی";
                    
                    cmb_accountNumber.Visible = true;
                    tbx_account_number.Visible = false;

                    personsTableBindingSource.Position = personsTableBindingSource.Find("personID", this.currentPersonID);
                    personsTableBindingSource1.Position = personsTableBindingSource1.Find("personPhone1", "06323229522");
                }
                else
                {
                    this.Text = "چـــــــک دریــــافــــتـــی";

                    cmb_accountNumber.Visible = false;
                    tbx_account_number.Visible = true;
                    
                    personsTableBindingSource1.Position = personsTableBindingSource1.Find("personID", this.currentPersonID);
                    personsTableBindingSource.Position = personsTableBindingSource.Find("personPhone1", "06323229522");
                }

                bChequeSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void num_price_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_newCheque_Click(object sender, EventArgs e)
        {
            try
            {
                if (bChequeSaved)//prevent the END-USER to add cheques quickly
                {
                    mTbx_issuanceDate.Text = numberConvertor.nowDateInAppropriateFormat();
                    mTbx_usanceDate.Text = numberConvertor.nowDateInAppropriateFormat();                    

                    enableControls(true);                    

                    chequesTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();                    
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPersonID", currentPersonID);
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@accDoc_id", accDoc_id);                                        
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sChequeNumber", "");
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sIssuanceDate", mTbx_issuanceDate.Text);
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sUsanceDate", mTbx_usanceDate.Text);
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nAccountID", DBNull.Value);                    
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nBankID", DBNull.Value);
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@IsTO", "");
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@cChequePrice", 0);
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sChequeState", "cur");
                    chequesTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@bChequeIsMine", theChequeIsMine);

                    if (theChequeIsMine)//mine
                    {
                        runSQLCommand("INSERT INTO chequesTable(personID, accDoc_id, chequeNumber, issuanceDate, usanceDate, accountID, bankID,isTo, chequePrice, chequeState, chequeIsMine) " +
                                        "VALUES(@nPersonID, @accDoc_id, @sChequeNumber, @sIssuanceDate, @sUsanceDate, @nAccountID, @nBankID,@isTo, @cChequePrice, @sChequeState, @bChequeIsMine);");
                    }
                    else//his
                    {
                        runSQLCommand("INSERT INTO chequesTable(personID, accDoc_id, chequeNumber, issuanceDate, usanceDate, bankID, isTo, chequePrice, chequeState, chequeIsMine) " +
                                     "VALUES(@nPersonID, @accDoc_id, @sChequeNumber, @sIssuanceDate, @sUsanceDate, @nBankID, @IsTO, @cChequePrice, @sChequeState, @bChequeIsMine);");
                    }
                    
                    upGradeTheChequesDataset();

                    chequesTableBindingSource.MoveLast();
                    //chequesTableBindingSource.Position = chequesTableBindingSource.Find("chequeNumber", );

                    upGradeTheCurrentCheque();

                    tbx_chequesTotal.Text = calculateSumOfCheques().ToString();

                    upGradeTheChequePositionLabel();

                    upDateAccountsList();

                    bChequeSaved = false;

                    btn_saveChanges_Click(sender, e);

                    tbx_chequeNumber.Focus();

                    //save for help
                    try
                    {
                        File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"cheques_new\"");
                    }
                    catch
                    {
                    }
                }
                else//if cheque was'nt seaved and the END-USER attempt to add another one 
                {
                    btn_saveChanges_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (grp_properties.Enabled)
            {
                if (upGradeTheCurrentCheque())
                {
                    giveItToReminder();
                    if (chequesTableBindingSource.Count == 0)
                    {
                        tbx_chequesTotal.Text = "0";
                    }
                    //save for help
                    try
                    {
                        File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"cheques_ok\"");
                    }
                    catch
                    {
                    }
                    this.Close();
                }
            }
            else
            {
                giveItToReminder();
                if (chequesTableBindingSource.Count == 0)
                {
                    tbx_chequesTotal.Text = "0";
                }
                //save for help
                try
                {
                    File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"cheques_ok\"");
                }
                catch
                {
                }
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nextCheque_Click(object sender, EventArgs e)
        {
            chequesTableBindingSource.MoveNext();

            upGradeTheChequePositionLabel();

            upDateAccountsList();
        }

        private void btn_priorCheque_Click(object sender, EventArgs e)
        {
            chequesTableBindingSource.MovePrevious();

            upGradeTheChequePositionLabel();

            upDateAccountsList();
        }

        private void btn_deleteCheque_Click(object sender, EventArgs e)
        {            
            try
            {
                if (MessageBox.Show("آیا چک حذف شود ؟", "حذف چک", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {                        
                        sReminderText += "[delete]\r\n";
                        sReminderText += "id=\"" + pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeID"].ToString() + "\"\r\n";
                        sReminderText += ";\r\n";                        
                    }
                    catch
                    {
                    }

                    int nDeletedChequePosition = chequesTableBindingSource.Position;
                    int nChequeID = int.Parse(pSDatabase5DataSet.chequesTable.Rows[chequesTableBindingSource.Position]["chequeID"].ToString());

                    chequesTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nChequeID", nChequeID);

                    runSQLCommand("DELETE FROM chequesTable WHERE chequeID = @nChequeID;");

                    upGradeTheChequesDataset();

                    //go back to deleted position
                    if (nDeletedChequePosition <= chequesTableBindingSource.Count - 1)
                        chequesTableBindingSource.Position = nDeletedChequePosition;
                    else
                        chequesTableBindingSource.Position = nDeletedChequePosition - 1;

                    upGradeTheChequePositionLabel();

                    upDateAccountsList();

                    if (chequesTableBindingSource.Count == 0)
                    {
                        enableControls(false);
                    }

                    bChequeSaved = true;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (!grp_properties.Enabled)
            {
                grp_properties.Enabled = true;

                btn_saveChanges.Text = "ثبت اصلاحات";

                pnl_navigation.Enabled = false;

                btn_newCheque.Enabled = false;                
            }
            else
            {
                btn_newCheque.Enabled = true;                

                grp_properties.Enabled = false;

                pnl_navigation.Enabled = true;

                btn_saveChanges.Text = "اصلاح مشخصات";

                upGradeTheCurrentCheque();

                tbx_chequesTotal.Text = calculateSumOfCheques().ToString();

                upGradeTheChequePositionLabel();

                upDateAccountsList();
            }            
        }

        private void tbx_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_price.Text == "") tbx_price.Text = "0";                

                lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_price.Text) + " ریال ";

            }
            catch
            {
            }
        }

        private void mTbx_usanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                mTbx_usanceDate.Text = numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void mTbx_issuanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                mTbx_issuanceDate.Text = numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void cmb_banksName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_banksName_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        private void cmb_banksName_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_manageCheques_Shown(object sender, EventArgs e)
        {
            btn_newCheque.Focus();
        }

        private void tbx_price_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_price.Text = defaultPrice.ToString();
            }
        }

        private void frm_manageCheques_FormClosing(object sender, FormClosingEventArgs e)
        {

            //delete the cheques witch they dont have Price Or Number 
            chequesTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            runSQLCommand("DELETE FROM chequesTable WHERE chequeNumber = '' OR chequePrice = 0;");

            //........................
            //if (!subtractCurrentChequePriceToCurrentaccount_amount() && chequesTableBindingSource.Count > 0)
            //{
            //    MessageBox.Show("مبلغ چک ها بیشتر از موجودی حساب می باشد");
            //    e.Cancel = true;
            //}
        }

        private void lbl_bankID_TextChanged(object sender, EventArgs e)
        {
            refreshAccountsTableDataset();
        }

        private void mTbx_issuanceDate_Leave(object sender, EventArgs e)
        {
            mTbx_issuanceDate.Text = numberConvertor.makeChangeToDateString(mTbx_issuanceDate.Text);
            if (mTbx_issuanceDate.Text.Length < 9)
            {
                MessageBox.Show("تاریخ را درست وارد کنید");
                mTbx_issuanceDate.Focus();
            }
            if (numberConvertor.findDateError(1370, mTbx_issuanceDate.Text) == "d")
            {
                MessageBox.Show("روز را درست وارد کنید");
                mTbx_issuanceDate.Focus();
                mTbx_issuanceDate.Select(8, 2);
            }
            if (numberConvertor.findDateError(1370, mTbx_issuanceDate.Text) == "m")
            {
                MessageBox.Show("ماه را درست وارد کنید");
                mTbx_issuanceDate.Focus();
                mTbx_issuanceDate.Select(5, 2);
            }
        }

        private void mTbx_usanceDate_Leave(object sender, EventArgs e)
        {
            mTbx_usanceDate.Text = numberConvertor.makeChangeToDateString(mTbx_usanceDate.Text);
            if (mTbx_usanceDate.Text.Length < 9)
            {
                MessageBox.Show("تاریخ را درست وارد کنید");
                mTbx_usanceDate.Focus();
            }
            if (numberConvertor.findDateError(1370, mTbx_usanceDate.Text) == "d")
            {
                MessageBox.Show("روز را درست وارد کنید");
                mTbx_usanceDate.Focus();
                mTbx_usanceDate.Select(8, 2);
            }
            if (numberConvertor.findDateError(1370, mTbx_usanceDate.Text) == "m")
            {
                MessageBox.Show("ماه را درست وارد کنید");
                mTbx_usanceDate.Focus();
                mTbx_usanceDate.Select(5, 2);
            }
        }

    }
}
