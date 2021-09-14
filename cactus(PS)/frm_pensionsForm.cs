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
    public partial class frm_pensionsForm : Form
    {
        public frm_pensionsForm()
        {
            InitializeComponent();
        }

        private SunDate shamsiDate = new SunDate();

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

        private int n_currentPensionID;
        public int currentPensionID
        {
            get { return n_currentPensionID; }
            set { n_currentPensionID = value; }
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
            set { n_currentPersonID = value; }
        }

        private void enableControls(bool bEnable)
        {
            try
            {
                pnl_wholeForm.Enabled = bEnable;
                btn_saveChanges.Enabled = bEnable;
                btn_printForm.Enabled = bEnable;
                btn_deletePensionForm.Enabled = bEnable;
                btn_nextPensionForm.Enabled = bEnable;
                btn_priorPensionForm.Enabled = bEnable;
                mTbx_pensionDate.Enabled = bEnable;
            }
            catch
            {
            }
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
                int pos = bs.Find("pensionID", currentPensionID);
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
                    frm_issuseAccDoc frmAccDoc = new frm_issuseAccDoc();
                    frmAccDoc.Text = "اصلاح سند حسابداری";
                    frmAccDoc.additionalComment = " -- فیش حقوق شماره " + tbx_pensionFormID.Text;
                    frmAccDoc.connectionString = connectionString;
                    frmAccDoc.currentProjectID = currentPrjectID;
                    frmAccDoc.currentPersonID = currentPersonID;                    
                    frmAccDoc.theChequeIsMine = true;
                    frmAccDoc.indebtedPrice = int.Parse(lbl_purePensionINDigit.Text);
                    frmAccDoc.num_accDocNumber.Value = nAvilableDocNumber;                    
                    frmAccDoc.ShowDialog();

                }
                else//create a new accDoc
                {
                    nAvilableDocNumber = getAvilableAccountingDocumentNumber();
                    string sComment = "طی چک";

                    SqlCommand sqlCmd = new SqlCommand("insert into accountingDocs(accDoc_id, pensionID, accDoc_date, accDoc_comment) " +
                                                      "values(@accDoc_id, @pensionID, @accDoc_date, @accDoc_comment)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);                    
                    sqlCmd.Parameters.AddWithValue("@pensionID", tbx_pensionFormID.Text);                    
                    sqlCmd.Parameters.AddWithValue("@accDoc_date", numberConvertor.nowDateInAppropriateFormat());
                    sqlCmd.Parameters.AddWithValue("@accDoc_comment", sComment);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();

                    int nSpentMasterID = numberConvertor.getSpentMasterID("حقوق", connectionString);
                    int nDetailID = numberConvertor.getDetailID(nSpentMasterID, currentPrjectID, "prj", this.connectionString);

                    //insert into the docEvent table 
                    //first of all insert the 'هزینه حقوق' text
                    sqlCmd = new SqlCommand("insert into accDocEventsTable(accDoc_id, detailID, accDocEvent_row, accDocEvent_itIsIndebted, accDocEvent_itIsBank) " +
                                                         "values(@accDoc_id, @detailID, @accDocEvent_row, 1, 0)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@accDocEvent_row", 1);
                    sqlCmd.Parameters.AddWithValue("@detailID", nDetailID);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();                    
                    
                    frm_issuseAccDoc frmAccDoc = new frm_issuseAccDoc();
                    frmAccDoc.Text = "صدور سند حسابداری برای فیش حقوق";
                    frmAccDoc.additionalComment = "--فیش حقوق شماره " + tbx_pensionFormID.Text;
                    frmAccDoc.connectionString = connectionString;
                    frmAccDoc.currentProjectID = currentPrjectID;
                    frmAccDoc.currentPersonID = currentPersonID;
                    frmAccDoc.theChequeIsMine = true;
                    frmAccDoc.indebtedPrice = int.Parse(lbl_purePensionINDigit.Text);
                    frmAccDoc.num_accDocNumber.Value = nAvilableDocNumber;
                    frmAccDoc.mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
                    if (frmAccDoc.ShowDialog() == DialogResult.Cancel)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void selectActiveProject_Persons()
        {
            try
            {
                //  SELECT Active Project... 
            
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                //personsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable, projectsPersons WHERE projectsPersons.personID = personsTable.personID AND projectsPersons.projectID = " + currentPrjectID.ToString() + " AND personsTable.personPhone1 <> '06323229522'  order by personFamilyAndName;";
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.personsTable.Clear();
                personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }

        }

        private void runSQLCommandToPensionDefTable(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    pensionDefTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    //pensionDefTableAdapter.Adapter.SelectCommand.Connection = connection;
                    pensionDefTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                    pensionDefTableAdapter.Adapter.SelectCommand.Connection.Open();
                    pSDatabase5DataSet.pensionDef.Clear();
                    pensionDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionDef);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pensionDefTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    pensionDefTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    //pensionDefTableAdapter.Adapter.UpdateCommand.Connection = connection;
                    pensionDefTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    pensionDefTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.pensionDef.Clear();
                    pensionDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionDef);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    pensionDefTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    //pensionDefTableAdapter.Adapter.InsertCommand.Connection = connection;
                    pensionDefTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    pensionDefTableAdapter.Adapter.InsertCommand.Connection.Open();
                    pensionDefTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.pensionDef.Clear();
                    pensionDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionDef);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pensionDefTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                try
                {
                    pensionDefTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //pensionDefTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    pensionDefTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    pensionDefTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    pensionDefTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.pensionDef.Clear();
                    pensionDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionDef);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                pensionDefTableAdapter.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        private void runSQLCommandToPensionsTable(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    pensionsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    //pensionsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                    pensionsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                    if (pensionsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Closed)
                        pensionsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                    else if (pensionsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Open)
                        pensionsTableTableAdapter.Adapter.SelectCommand.Connection.Close();

                    pSDatabase5DataSet.pensionsTable.Clear();
                    pensionsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (pensionsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Closed)
                        pensionsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                    else if (pensionsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Open)
                        pensionsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    pensionsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    //pensionsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                    pensionsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    pensionsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    pensionsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.pensionsTable.Clear();
                    pensionsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pensionsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    pensionsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    //pensionsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
                    pensionsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    pensionsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    pensionsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.pensionsTable.Clear();
                    pensionsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionsTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pensionsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                //try
                //{
                pensionsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                //pensionsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                pensionsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                pensionsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                pensionsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                pSDatabase5DataSet.pensionsTable.Clear();
                pensionsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.pensionsTable);

                //}
                ////catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                pensionsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                //}
            }
        }

        private void refreshPensionDefDataset()
        {
            pensionDefTableAdapter.Adapter.SelectCommand = new SqlCommand();
            pensionDefTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            pensionDefTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nPensionID", currentPensionID);
            runSQLCommandToPensionDefTable("SELECT * FROM pensionDef WHERE pensionID = @nPensionID;");

            setPensionGridRowsHeight();

            if (pensionsTableBindingSource.Count > 0)
            {
                enableControls(true);
            }
            else if (pensionsTableBindingSource.Count == 0)
            {
                enableControls(false);
            }
        }
        
        private void refreshPensionsTableDataset()
        {
            pensionsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
            pensionsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            pensionsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nPersonID", currentPersonID);
            pensionsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);

            runSQLCommandToPensionsTable("SELECT * FROM pensionsTable WHERE personID = @nPersonID AND projectID = @nProjectID;");
            
            refreshPensionDefDataset();            
        }

        private void setPensionGridRowsHeight()
        {
            for (int i = 0; i <= grid_Pension.Rows.Count - 1; i++)
            {
                grid_Pension.Rows[i].Height = 40;
                grid_Detractions.Rows[i].Height = 40;
            }
        }
        private void setDetractGridRowsHeight()
        {
            
        }

        private void upDateCurrentPositionLabel()
        {
            lbl_pensionsTotal.Text = "0";
            lbl_detractionsTotal.Text = "0";
            lbl_purePensionINChars.Text = "";
            lbl_purePensionINDigit.Text = "0";

            if (pensionsTableBindingSource.Count > 0)
            {
                

                lbl_currentPosition.Text = "فیش " + (pensionsTableBindingSource.Position + 1).ToString() + " از " + pensionsTableBindingSource.Count.ToString();

                lbl_pensionsTotal.Text = getTotalPension().ToString();
                lbl_detractionsTotal.Text = getTotalDetract().ToString();
                lbl_purePensionINDigit.Text = (long.Parse(lbl_pensionsTotal.Text) - long.Parse(lbl_detractionsTotal.Text)).ToString();
                lbl_purePensionINChars.Text = numberConvertor.convertToChars(lbl_purePensionINDigit.Text) + " ریال";

                tbx_taxDetractPrice.Text = (long.Parse(lbl_pensionsTotal.Text) * 5 / 100).ToString();
                tbx_insuranceDetractPrice.Text = (long.Parse(lbl_pensionsTotal.Text) * 7 / 100).ToString();
            }
            else if (pensionsTableBindingSource.Count <= 0)
            {
                lbl_currentPosition.Text = "*****";
            }
        }

        private void upDatePensionDefTable()
        {
            
            if (pensionDefBindingSource.Position <= -1) return;

            pensionDefTableAdapter.Adapter.UpdateCommand = new SqlCommand();

            pensionDefBindingSource.MoveFirst();

            while (pensionDefBindingSource.Position < (pensionDefBindingSource.Count - 1))
            {
                
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPensionDefID", (int)pSDatabase5DataSet.pensionDef.Rows[pensionDefBindingSource.Position]["pensionDefID"]);

                if (grid_Pension.Rows[pensionDefBindingSource.Position].Cells[0].Value != DBNull.Value)
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionName", (string)grid_Pension.Rows[pensionDefBindingSource.Position].Cells[0].Value);
                else
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionName", "");

                if(grid_Pension.Rows[pensionDefBindingSource.Position].Cells[1].Value != DBNull.Value)
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionValue", grid_Pension.Rows[pensionDefBindingSource.Position].Cells[1].Value.ToString());
                else
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionValue", "");

                if (grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[0].Value != DBNull.Value)
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractName", (string)grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[0].Value);
                else
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractName", "");

                if (grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[1].Value != DBNull.Value)
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractValue", grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[1].Value.ToString());
                else
                    pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractValue", "");

                pensionDefTableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE pensionDef SET pensionName = @sUpdatedPensionName, pensionValue = @sUpdatedPensionValue, detractName = @sUpdatedDetractName, detractValue = @sUpdatedDetractValue WHERE pensionDefID = @nPensionDefID;";
                pensionDefTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Open();
                pensionDefTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Close();

                if (pensionDefBindingSource.Position == (pensionDefBindingSource.Count - 1))
                    pensionDefBindingSource.MoveLast();
                else if (pensionDefBindingSource.Position < (pensionDefBindingSource.Count - 1))
                    pensionDefBindingSource.MoveNext();
            }
            //update last record
            pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
            pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPensionDefID", (int)pSDatabase5DataSet.pensionDef.Rows[pensionDefBindingSource.Position]["pensionDefID"]);

            if (grid_Pension.Rows[pensionDefBindingSource.Position].Cells[0].Value != DBNull.Value)
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionName", (string)grid_Pension.Rows[pensionDefBindingSource.Position].Cells[0].Value);
            else
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionName", "");

            if (grid_Pension.Rows[pensionDefBindingSource.Position].Cells[1].Value != DBNull.Value)
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionValue", grid_Pension.Rows[pensionDefBindingSource.Position].Cells[1].Value.ToString());
            else
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedPensionValue", "");

            if (grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[0].Value != DBNull.Value)
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractName", (string)grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[0].Value);
            else
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractName", "");

            if (grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[1].Value != DBNull.Value)
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractValue", grid_Detractions.Rows[pensionDefBindingSource.Position].Cells[1].Value.ToString());
            else
                pensionDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedDetractValue", "");

            pensionDefTableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE pensionDef SET pensionName = @sUpdatedPensionName, pensionValue = @sUpdatedPensionValue, detractName = @sUpdatedDetractName, detractValue = @sUpdatedDetractValue WHERE pensionDefID = @nPensionDefID;";
            pensionDefTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
            pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Open();
            pensionDefTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
            pensionDefTableAdapter.Adapter.UpdateCommand.Connection.Close();
        }

        private long getTotalPension()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "getPensionsSUM";
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@pensionID", long.Parse(tbx_pensionFormID.Text));
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

            return (long)c.Parameters["@result"].Value;
        }
        private long getTotalDetract()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "getDetractionsSUM";
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@pensionID", long.Parse(tbx_pensionFormID.Text));
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

            return (long)c.Parameters["@result"].Value;
        }

        private void frm_pensionsForm_Load(object sender, EventArgs e)
        {            
            shamsiDate = Calendar.ConvertToPersian(DateTime.Now);                      

            // TODO: This line of code loads data into the 'pSDatabase5DataSet.pensionsTable' table. You can move, or remove it, as needed.
            this.pensionsTableTableAdapter.Fill(this.pSDatabase5DataSet.pensionsTable);
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.pensionDef' table. You can move, or remove it, as needed.
            this.pensionDefTableAdapter.Fill(this.pSDatabase5DataSet.pensionDef);
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.projectsTable' table. You can move, or remove it, as needed.
            this.projectsTableTableAdapter.Fill(this.pSDatabase5DataSet.projectsTable);            
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.personsTable' table. You can move, or remove it, as needed.
            this.personsTableTableAdapter.Fill(this.pSDatabase5DataSet.personsTable);            

            selectActiveProject_Persons();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_addPension_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[2] == allow enter data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pensionsTableBindingSource.Count > 0)
            {

                pensionDefTableAdapter.Adapter.InsertCommand = new SqlCommand();
                pensionDefTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                pensionDefTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPensionID", long.Parse(tbx_pensionFormID.Text));
                runSQLCommandToPensionDefTable("INSERT INTO pensionDef(pensionID, pensionName, pensionValue) VALUES(@nPensionID, 'گزینه جدید', 0);");

                refreshPensionDefDataset();
            }
        }

        private void btn_newPensionForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[0] == '0')//limitString[2] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (personsTableBindingSource.Count == 0)
                {
                    MessageBox.Show("هیچ طرف حسابی به برنامه معرفی نشده است");
                    return;
                }

                mTbx_pensionDate.Text = numberConvertor.nowDateInAppropriateFormat();

                pensionsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPersonID", currentPersonID);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@dDate", mTbx_pensionDate.Text);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nBasePension", long.Parse(tbx_basePensionPrice.Text));
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nOvertimePension", 0);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nTaxDetraction", 0);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nInsuranceDetraction", 0);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nWorkedDays", 0);
                pensionsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nOvertimeHours", 0);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            runSQLCommandToPensionsTable("INSERT INTO pensionsTable(personID, projectID, dDate, basePension, overtimePension, taxDetraction, insuranceDetraction, workedDays, overtimeHours) " + 
                                          "VALUES(@nPersonID, @nProjectID, @dDate, @nBasePension, @nOvertimePension, @nTaxDetraction, @nInsuranceDetraction, @nWorkedDays, @nOvertimeHours);");

            refreshPensionsTableDataset();
            
            pensionsTableBindingSource.MoveLast();
            
            refreshPensionDefDataset();

            upDateCurrentPositionLabel();
            
            tbx_basePensionPrice.Focus();

            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"pensions_new\"");
            }
            catch
            {
            }
        }

        private void btn_deletePensionDef_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pensionDefBindingSource.Position <= -1) return;
            int nPensionDefID = (int) pSDatabase5DataSet.pensionDef.Rows[pensionDefBindingSource.Position]["pensionDefID"];

            pensionDefTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            pensionDefTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            pensionDefTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nPensionDefID", nPensionDefID);
            runSQLCommandToPensionDefTable("DELETE FROM pensionDef WHERE pensionDefID = @nPensionDefID;");

            refreshPensionDefDataset();
        }

        private void btn_addDetractDef_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[2] == allow enter data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pensionsTableBindingSource.Count > 0)
            {
                pensionDefTableAdapter.Adapter.InsertCommand = new SqlCommand();
                pensionDefTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                pensionDefTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPensionID", long.Parse(tbx_pensionFormID.Text));
                runSQLCommandToPensionDefTable("INSERT INTO pensionDef(pensionID, detractName, detractValue) VALUES(@nPensionID, 'گزینه جدید', 0);");

                refreshPensionDefDataset();

                //detractDefTableAdapter.Adapter.InsertCommand = new SqlCommand();
                //detractDefTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                //detractDefTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nPensionID", long.Parse(tbx_pensionFormID.Text));
                //runSQLCommandToDetractDefTable("INSERT INTO detractDef(pensionID, defName, defValue) VALUES(@nPensionID, 'گزینه جدید', 0);");

                //refreshDetractDefDataset();
            }
        }

        private void btn_deleteDetractDef_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pensionDefBindingSource.Position <= -1) return;
            int nPensionDefID = (int)pSDatabase5DataSet.pensionDef.Rows[pensionDefBindingSource.Position]["pensionDefID"];

            pensionDefTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            pensionDefTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            pensionDefTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nPensionDefID", nPensionDefID);
            runSQLCommandToPensionDefTable("DELETE FROM pensionDef WHERE pensionDefID = @nPensionDefID;");

            refreshPensionDefDataset();
            //if (detractDefBindingSource.Position <= -1) return;
            //int nDetractDefID = (int)pSDatabase5DataSet.detractDef.Rows[detractDefBindingSource.Position]["detractDefID"];

            //detractDefTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            //detractDefTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            //detractDefTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nDetractDefID", nDetractDefID);
            //runSQLCommandToDetractDefTable("DELETE FROM detractDef WHERE detractDefID = @nDetractDefID;");

            //refreshDetractDefDataset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nOldPos = pensionsTableBindingSource.Position;

                if (nOldPos <= -1) return;

                upDatePensionDefTable();

                pensionsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();                
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPensionID", long.Parse(tbx_pensionFormID.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@dDate", mTbx_pensionDate.Text);
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nBasePension", long.Parse(tbx_basePensionPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nOvertimePension", long.Parse(tbx_overtimePensionPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nTaxDetraction", long.Parse(tbx_taxDetractPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nInsuranceDetraction", long.Parse(tbx_insuranceDetractPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nWorkedDays", long.Parse(tbx_workedDays.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nOvertimeHours", long.Parse(tbx_overtimeHours.Text));

                runSQLCommandToPensionsTable("UPDATE pensionsTable SET dDate = @dDate, basePension = @nBasePension, overtimePension = @nOvertimePension, taxDetraction = @nTaxDetraction, insuranceDetraction = @nInsuranceDetraction, workedDays = @nWorkedDays, overtimeHours = @nOvertimeHours WHERE pensionID = @nPensionID;");

                refreshPensionsTableDataset();

                pensionsTableBindingSource.Position = nOldPos;

                refreshPensionDefDataset();

                upDateCurrentPositionLabel();
                //********************************************again
                upDatePensionDefTable();

                pensionsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPensionID", long.Parse(tbx_pensionFormID.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@dDate", mTbx_pensionDate.Text);
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nBasePension", long.Parse(tbx_basePensionPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nOvertimePension", long.Parse(tbx_overtimePensionPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nTaxDetraction", long.Parse(tbx_taxDetractPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nInsuranceDetraction", long.Parse(tbx_insuranceDetractPrice.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nWorkedDays", long.Parse(tbx_workedDays.Text));
                pensionsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nOvertimeHours", long.Parse(tbx_overtimeHours.Text));

                runSQLCommandToPensionsTable("UPDATE pensionsTable SET dDate = @dDate, basePension = @nBasePension, overtimePension = @nOvertimePension, taxDetraction = @nTaxDetraction, insuranceDetraction = @nInsuranceDetraction, workedDays = @nWorkedDays, overtimeHours = @nOvertimeHours WHERE pensionID = @nPensionID;");

                refreshPensionsTableDataset();

                pensionsTableBindingSource.Position = nOldPos;

                refreshPensionDefDataset();

                upDateCurrentPositionLabel();
                //***********************************************

                //save for help
                try
                {
                    File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"pensions_ok\"");
                }
                catch
                {
                }

                saveAccountingDocument();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nextPensionForm_Click(object sender, EventArgs e)
        {
            pensionsTableBindingSource.MoveNext();

            //refreshDetractDefDataset();
            refreshPensionDefDataset();

            upDateCurrentPositionLabel();
        }

        private void btn_priorPensionForm_Click(object sender, EventArgs e)
        {
            pensionsTableBindingSource.MovePrevious();

            //refreshDetractDefDataset();
            refreshPensionDefDataset();

            upDateCurrentPositionLabel();

            lbl_pensionsTotal.Text = getTotalPension().ToString();
            lbl_detractionsTotal.Text = getTotalDetract().ToString();
        }

        private void cmb_familyAndName_SelectedValueChanged(object sender, EventArgs e)
        {
            //if(personsTableBindingSource.Position > -1)
              //  currentPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
        }

        private void lbl_personID_TextChanged(object sender, EventArgs e)
        {
            currentPersonID = int.Parse(lbl_personID.Text);

            refreshPensionsTableDataset();

            upDateCurrentPositionLabel();


        }

        private void tbx_basePensionPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_basePensionPrice.Text == "")
            {
                tbx_basePensionPrice.Text = "0";
            }
        }

        private void tbx_overtimePensionPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_overtimePensionPrice.Text == "")
            {
                tbx_overtimePensionPrice.Text = "0";
            }
        }

        private void tbx_taxDetractPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_taxDetractPrice.Text == "")
            {
                tbx_taxDetractPrice.Text = "0";
            }
        }

        private void tbx_insuranceDetractPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_insuranceDetractPrice.Text == "")
            {
                tbx_insuranceDetractPrice.Text = "0";
            }
        }

        private void lbl_personID_Click(object sender, EventArgs e)
        {

        }

        private void grid_Pension_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_deletePensionForm_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pensionsTableBindingSource.Count <= 0) return;

            if (MessageBox.Show("آیا از حذف این فیش حقوق مطمئنید ؟", "حذف فیش حقوق", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {                
                pensionsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                pensionsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                pensionsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nPensionID", currentPensionID);
                runSQLCommandToPensionsTable("DELETE FROM pensionsTable WHERE pensionID = @nPensionID;");

                refreshPensionsTableDataset();

                upDateCurrentPositionLabel();
            }
        }

        private void tbx_pensionFormID_TextChanged(object sender, EventArgs e)
        {
            if (tbx_pensionFormID.Text == "")
                tbx_pensionFormID.Text = "0";
            currentPensionID = int.Parse(tbx_pensionFormID.Text);
        }

        private void grid_Detractions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mTbx_pensionDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                mTbx_pensionDate.Text = numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void frm_pensionsForm_Shown(object sender, EventArgs e)
        {
            selectActiveProject_Persons();

            setPensionGridRowsHeight();
            setDetractGridRowsHeight();

            upDateCurrentPositionLabel();

            tbx_currentProjectTitle.Text = currentProjectTitle;
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {            
        }

        private void btn_printForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (pensionsTableBindingSource.Count == 0) return;
                string sMonth="";
                string sYear="";
                try
                {
                    string sFormDate = (string)pSDatabase5DataSet.pensionsTable.Rows[pensionsTableBindingSource.Position]["dDate"];
                    sMonth = sFormDate.Substring(sFormDate.Length - 2, 2);
                    sYear = sFormDate.Substring(0, sFormDate.IndexOf("/"));
                }
                catch
                {
                    MessageBox.Show("لطفا تاریخ را تصحیح کنید");
                }
                //frm_printPension frmPrint = new frm_printPension();
                //frmPrint.formDate = numberConvertor.convertToMonthName(sMonth) + " " + sYear;
                //frmPrint.currentProjectTitle = currentProjectTitle;
                //frmPrint.connectionString = connectionString;
                //frmPrint.currentPensionID = currentPensionID;
                //frmPrint.currentPersonID = currentPersonID;
                //frmPrint.currentPrjectID = currentPrjectID;
                //frmPrint.s_pensionTotal = lbl_pensionsTotal.Text;
                //frmPrint.s_detractTotal = lbl_detractionsTotal.Text;
                //frmPrint.s_pensionInChar = lbl_purePensionINChars.Text;
                //frmPrint.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void tbx_personalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_pensionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pensionsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
            pensionsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
            runSQLCommandToPensionsTable("DELETE FROM pensionsTable WHERE basePension = 0;");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbx_pensionFormID_Click(object sender, EventArgs e)
        {
            if (tbx_pensionFormID.Text != "")
            {
                int n = int.Parse(tbx_pensionFormID.Text);
            }
        }

        private void grid_Pension_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_saveDocumentAndExit_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_pensionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"pensions_closed\"");
            }
            catch
            {
            }
        }
    }
}
