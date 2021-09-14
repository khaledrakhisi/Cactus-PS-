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
    public partial class frm_manageSpent : Form
    {
        frm_manageCheques frmManageCheques = new frm_manageCheques();
        private SqlConnection connection;

        private SunDate shamsiDate = new SunDate();
        private string sNowDate;

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
        private bool b_openAsindebted = true;
        public bool openAsIndebted
        {
            get { return b_openAsindebted; }
            set { b_openAsindebted = value; }
        }
        private string s_spentType = "";
        public string spentType
        {
            get { return s_spentType; }
            set { s_spentType = value; }
        }
        private bool b_openForModify = false;
        public bool openForModify
        {
            get { return b_openForModify; }
            set { b_openForModify = value; }
        }
        private int n_currentSpentID;
        public int currentSpentID
        {
            get { return n_currentSpentID; }
            set { n_currentSpentID = value; }
        }
        private bool b_okClicked;
        public bool okClicked
        {
            get { return b_okClicked; }
        }
        private int n_spentDefID;
        public int spentDefID
        {
            get { return n_spentDefID; }
            set { n_spentDefID = value; }
        }

        //private string giveMeNowDateInAppropriateFormat()
        //{
        //    try
        //    {
        //        int nFirstSlashPos = 0, nSecondSlashPos = 0;
        //        string sNowDate = shamsiDate.Simple;
        //        nFirstSlashPos = sNowDate.IndexOf('/', 1);
        //        nSecondSlashPos = sNowDate.IndexOf('/', nFirstSlashPos + 1);
        //        string sYear = sNowDate.Substring(0, nFirstSlashPos);
        //        string sMonth = sNowDate.Substring(nFirstSlashPos + 1, nSecondSlashPos - nFirstSlashPos - 1);
        //        string sDay = sNowDate.Substring(nSecondSlashPos + 1, sNowDate.Length - nSecondSlashPos - 1);
        //        if (sMonth.Length == 1)
        //            sMonth = "0" + sMonth;
        //        if (sDay.Length == 1)
        //            sDay = "0" + sDay;

        //        return sYear + "/" + sMonth + "/" + sDay;
        //    }
        //    catch
        //    {
        //        return shamsiDate.Simple;
        //    }

        //}

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {

                spentsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection();
                spentsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                spentsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.spentsTable.Clear();
                spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);
                spentsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            else if (sTemp.Contains("UPDATE"))
            {

                spentsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection();
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                spentsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                pSDatabase5DataSet.spentsTable.Clear();
                spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
            }
            else if (sTemp.Contains("INSERT"))
            {

                spentsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection();
                spentsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                spentsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                spentsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                pSDatabase5DataSet.spentsTable.Clear();
                spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);
                spentsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
            }
            else if (sTemp.Contains("DELETE"))
            {

                spentsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection();
                spentsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                spentsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                spentsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                pSDatabase5DataSet.spentsTable.Clear();
                spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);
                spentsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
            }
        }

        public frm_manageSpent()
        {
            InitializeComponent();
            //openForModify = false;
        }

        private void refreshTheDataset()
        {
            try
            {
                //refresh the dataset
                spentsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentDefID", spentDefID);
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
                runSQLCommand("SELECT * FROM spentsTable WHERE spentDefID = @nSpentDefID AND spentsTable.projectID = @nProjectID;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifyTheSpent()
        {
            try
            {
                spentsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sSpentID", currentSpentID);
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sProjectID", currentPrjectID);
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sDate", mTbx_Date.Text);
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sEvent", tbx_Event.Text);
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@bByCheque", chk_byCheque.Checked);

                //spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sSpentType", spentType);
                if (openAsIndebted)
                {
                    spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@cIndebtedPrice", tbx_indebtedOrCreditorPrice.Text);
                    spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@cCreditorPrice", "0");
                }
                else
                {
                    spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@cCreditorPrice", tbx_indebtedOrCreditorPrice.Text);
                    spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@cIndebtedPrice", "0");
                }
                //spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sDetect", "بیحساب");
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sSpentComment", tbx_comment.Text);

                runSQLCommand("UPDATE spentsTable SET projectID = @sProjectID, dDate = @sDate, event =@sEvent, byCheque = @bByCheque, indebtedPrice = @cIndebtedPrice, creditorPrice = @cCreditorPrice, spentComment = @sSpentComment WHERE spentID = @sSpentID;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewSpent()
        {
            try
            {
                spentsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sProjectID", currentPrjectID);
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sDate", mTbx_Date.Text);
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sEvent", tbx_Event.Text);
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@bByCheque", chk_byCheque.Checked);
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nSpentDefID", spentDefID);
                if (openAsIndebted)
                {
                    spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@cIndebtedPrice", tbx_indebtedOrCreditorPrice.Text);
                    spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@cCreditorPrice", "0");
                }
                else
                {
                    spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@cCreditorPrice", tbx_indebtedOrCreditorPrice.Text);
                    spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@cIndebtedPrice", "0");
                }

                //spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sDetect", "بیحساب");
                spentsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sSpentComment", tbx_comment.Text);

                runSQLCommand("INSERT INTO spentsTable(projectID, spentDefID, dDate, event, byCheque, indebtedPrice, creditorPrice, remainPrice, detectID, spentType, spentComment) VALUES(@sProjectID, @nSpentDefID, @sDate, @sEvent, @bByCheque, @cIndebtedPrice, @cCreditorPrice, 0, 2, '0',  @sSpentComment);");

                refreshTheDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_manageSpent_Load(object sender, EventArgs e)
        {
            try
            {
                //connectionString = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
                //connectionString += "D:\\DEVELOP\\CSPROJECT\\CACTUS(PS)\\CACTUS(PS)\\PSDATABASE5.MDF;";
                //connectionString += "Integrated Security=True;Connect Timeout=30;User Instance=True";
                connection = new SqlConnection(connectionString);

                // TODO: This line of code loads data into the 'pSDatabase5DataSet.spentsTable' table. You can move, or remove it, as needed.
                this.spentsTableTableAdapter.Fill(this.pSDatabase5DataSet.spentsTable);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (tbx_Event.Text == "")
            {
                tbx_Event.Focus();
                return;
            }
            if (long.Parse(tbx_indebtedOrCreditorPrice.Text) <= 0 && !chk_byCheque.Checked)
            {
                tbx_indebtedOrCreditorPrice.Focus();
                return;
            }
            else if (long.Parse(tbx_indebtedOrCreditorPrice.Text) <= 0 && chk_byCheque.Checked)
            {
                MessageBox.Show("...چک را وارد کنید...");
                btn_defineCheque.Focus();
                return;
            }

            try
            {
                modifyTheSpent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                b_okClicked = true;
                this.Close();
            }
        }

        private void chk_byCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_byCheque.Checked)
            {
                btn_defineCheque.Visible = true;
                tbx_indebtedOrCreditorPrice.ReadOnly = true;

                tbx_indebtedOrCreditorPrice.Text = "0";
            }
            else
            {
                btn_defineCheque.Visible = false;
                tbx_indebtedOrCreditorPrice.ReadOnly = false;
            }
        }

        private void tbx_indebtedOrCreditorPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbx_indebtedOrCreditorPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                tbx_indebtedOrCreditorPrice.Text = tbx_indebtedOrCreditorPrice.Text.Replace(" ", "");
                tbx_indebtedOrCreditorPrice.Text = long.Parse(tbx_indebtedOrCreditorPrice.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_defineCheque_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageCheques.theChequeIsMine = true;
                frmManageCheques.currentPersonID = 1;//this Company ID
                frmManageCheques.currentSpentID = currentSpentID;
                frmManageCheques.currentPrjectID = currentPrjectID;
                frmManageCheques.currentProjectTitle = currentProjectTitle;
                frmManageCheques.connectionString = connectionString;
                frmManageCheques.ShowDialog(this);
                tbx_indebtedOrCreditorPrice.Text = frmManageCheques.tbx_chequesTotal.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbx_indebtedOrCreditorPrice_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void tbx_indebtedOrCreditorPrice_MouseMove(object sender, MouseEventArgs e)
        {
            //tbx_indebtedOrCreditorPrice.SelectAll();
        }

        private void tbx_indebtedOrCreditorPrice_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void tbx_indebtedOrCreditorPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_indebtedOrCreditorPrice.Text == "")
            {
                tbx_indebtedOrCreditorPrice.Text = "0";
            }
            lbl_priceInChars.Text = numberConvertor.convertToChars(tbx_indebtedOrCreditorPrice.Text) + " ریال";

        }

        private void mTbx_Date_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void frm_manageSpent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!b_okClicked)
            {
                //delete the probably cheques defined for this spent
                if (!openForModify)
                {
                    try
                    {

                        //delete the probably cheques defined for this spent
                        chequesTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                        chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                        chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentID", currentSpentID);
                        chequesTableTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM chequesTable WHERE spentID = @nSpentID;";

                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection();
                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                        chequesTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                        chequesTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
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

                try
                {
                    if (!openForModify)//that mean 'open for Add'
                    {
                        //delete the appended spent record on 'form_load' event
                        spentsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                        spentsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                        spentsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentID", currentSpentID);
                        runSQLCommand("DELETE FROM spentsTable WHERE spentID = @nSpentID;");
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
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            b_okClicked = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_indebtedOrCreditorPrice_Leave_1(object sender, EventArgs e)
        {
            if (tbx_indebtedOrCreditorPrice.Text == "")
            {
                tbx_indebtedOrCreditorPrice.Text = "0";
            }
        }

        private void frm_manageSpent_Shown(object sender, EventArgs e)
        {
            //match the information from the table to the controls

            try
            {
                shamsiDate = Calendar.ConvertToPersian(DateTime.Now);
                if (!openForModify)
                {
                    sNowDate = numberConvertor.nowDateInAppropriateFormat();

                    mTbx_Date.Text = sNowDate;

                    tbx_comment.Text = "";
                    tbx_Event.Text = "";
                    tbx_indebtedOrCreditorPrice.Text = "0";
                    chk_byCheque.Checked = false;

                    addNewSpent();

                    spentsTableBindingSource.MoveLast();
                    currentSpentID = (int)pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["spentID"];
                }
                else//if open to modify
                {
                    refreshTheDataset();

                    //load the data
                    int pos = spentsTableBindingSource.Find("spentID", currentSpentID);

                    spentsTableBindingSource.Position = pos;
                    mTbx_Date.Text = pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["dDate"].ToString();
                    tbx_Event.Text = pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["event"].ToString();
                    chk_byCheque.Checked = (bool)pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["byCheque"];
                    if (openAsIndebted)
                        tbx_indebtedOrCreditorPrice.Text = pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["indebtedPrice"].ToString();
                    else
                        tbx_indebtedOrCreditorPrice.Text = pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["creditorPrice"].ToString();

                    tbx_comment.Text = pSDatabase5DataSet.spentsTable.Rows[spentsTableBindingSource.Position]["spentComment"].ToString();

                    //
                }
                b_okClicked = false;
            }
            catch
            {
            }


        }
    }
}
