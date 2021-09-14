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
    public partial class frm_buyInvoices : Form
    {
        public frm_buyInvoices()
        {
            InitializeComponent();
        }

        private long n_orig_invoice_id;
        private bool invoiceHasChanged;

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

        private void refreshPersonsDataset()
        {
            SqlDataAdapter a = new SqlDataAdapter();
            try
            {
                a.SelectCommand = new SqlCommand("select * from personsTable order by personFamilyAndName;");
                a.SelectCommand.Connection = new SqlConnection(connectionString);
                a.SelectCommand.Connection.Open();
                pSDatabase5DataSet.personsTable.Clear();
                a.Fill(pSDatabase5DataSet.personsTable);
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

        private void buildEventForThisAccDoc(long accDoc_id,long invoice_id)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@accDoc_id", accDoc_id);
                c.Parameters.AddWithValue("@invoice_id", invoice_id);
                c.CommandText = "makeAccDocEventForAnInvoice";                                
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
                int pos = bs.Find("invoice_id", tbx_ID.Text);
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
                    frmAccDoc.additionalComment = "--فاکتور خرید شماره " + tbx_ID.Text;
                    frmAccDoc.Text = "اصلاح سند حسابداری";
                    frmAccDoc.b_dontUpdateIndebted = true;
                    frmAccDoc.connectionString = connectionString;
                    frmAccDoc.currentProjectID = currentPrjectID;
                    frmAccDoc.currentPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
                    frmAccDoc.theChequeIsMine = true;
                    frmAccDoc.indebtedPrice = int.Parse(tbx_invoiceTotal.Text);
                    frmAccDoc.num_accDocNumber.Value = nAvilableDocNumber;
                    frmAccDoc.ShowDialog();

                }
                else//create a new accDoc
                {
                    nAvilableDocNumber = getAvilableAccountingDocumentNumber();
                    //string sTopEvent = "هزینه حقوق", sBottomEvent = "بانک", 
                    string sComment = "";

                    SqlCommand sqlCmd = new SqlCommand("insert into accountingDocs(accDoc_id, projectID, invoice_id, accDoc_date, accDoc_comment) " +
                                                      "values(@accDoc_id, @projectID, @invoice_id, @accDoc_date, @accDoc_comment)");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@accDoc_id", nAvilableDocNumber);
                    sqlCmd.Parameters.AddWithValue("@projectID", currentPrjectID);
                    sqlCmd.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                    sqlCmd.Parameters.AddWithValue("@accDoc_date", numberConvertor.nowDateInAppropriateFormat());
                    sqlCmd.Parameters.AddWithValue("@accDoc_comment", sComment);

                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();
                   
                    buildEventForThisAccDoc(nAvilableDocNumber, long.Parse(tbx_ID.Text));
                   
                    frm_issuseAccDoc frmAccDoc = new frm_issuseAccDoc();
                    frmAccDoc.additionalComment = "--فاکتور خرید شماره " + tbx_ID.Text;
                    frmAccDoc.Text = "صدور سند حسابداری";
                    frmAccDoc.b_dontUpdateIndebted = true;
                    frmAccDoc.connectionString = connectionString;
                    frmAccDoc.currentProjectID = currentPrjectID;
                    frmAccDoc.currentPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
                    frmAccDoc.theChequeIsMine = true;
                    frmAccDoc.indebtedPrice = long.Parse(tbx_invoiceTotal.Text);
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

        private int getSpentDefID(string sSpentDefName)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnSpentDefID";
                c.Parameters.AddWithValue("@spentDefName", sSpentDefName);
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

        private int getAvailableRowNumberOfThisInvoice()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                long nInvoice_id = 0;
                if (tbx_ID.Text != "")
                {
                    nInvoice_id = long.Parse(tbx_ID.Text);
                }

                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "resortAnInvoiceItemsRows";
                c.Parameters.AddWithValue("@invoice_id", nInvoice_id);
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

        private long getSumTotalThisInvoice()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                long nInvoice_id = 0;
                if(tbx_ID.Text != "")
                {
                    nInvoice_id = long.Parse(tbx_ID.Text);
                }

                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnTotalSumOfAnInvoice";                
                c.Parameters.AddWithValue("@invoice_id", nInvoice_id);
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

        private long getAvilableInvoiceNumber()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnAvilableInvoiceNumber";
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

        private void enableControls(bool bEnable)
        {
            try
            {
                pnl_public.Enabled = bEnable;
                dataGridView1.Enabled = bEnable;
                pnl_addRemove.Enabled = bEnable;
                pnl_total.Enabled = bEnable;
                pnl_comment.Enabled = bEnable;

                btn_saveChanges.Enabled = bEnable;
                btn_print.Enabled = bEnable;
                btn_delete.Enabled = bEnable;

                pnl_persons.Enabled = bEnable;
            }
            catch
            {
            }
        }

        private void upDateCurrentPositionLabel()
        {
            try
            {
                if (invoicesTableBindingSource.Count > 0)
                {
                    lbl_currentPosition.Text = "فاکتور " + (invoicesTableBindingSource.Position + 1).ToString() + " از " + invoicesTableBindingSource.Count.ToString();
                    enableControls(true);

                    n_orig_invoice_id = long.Parse(tbx_ID.Text);
                }
                else
                {
                    lbl_currentPosition.Text = "*****";
                    enableControls(false);
                }               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void refreshInvoicesDataset()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = new SqlConnection(connectionString);
            try
            {
                adapter.SelectCommand.CommandText = "select * from invoicesTable;";                
                adapter.SelectCommand.Connection.Open();

                int pos = invoicesTableBindingSource.Position;

                pSDatabase5DataSet.invoicesTable.Clear();
                adapter.Fill(pSDatabase5DataSet.invoicesTable);

                invoicesTableBindingSource.Position = pos;

                upDateCurrentPositionLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.SelectCommand.Connection.Close();
            }
        }

        private void refreshInvoiceItemsDataset()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = new SqlConnection(connectionString);
            try
            {                                
                adapter.SelectCommand.CommandText = "SELECT        dbo.invoiceItemsTable.invoiceItem_row, dbo.spentDef.spentDefName, dbo.projectsTable.projectTitle, dbo.invoiceItemsTable.invoiceItem_amount, " +
                                                    "dbo.invoiceItemsTable.invoiceItem_phi, dbo.invoiceItemsTable.invoiceItem_total, dbo.invoiceItemsTable.invoiceItem_comment " +
                                                    "FROM            dbo.invoiceItemsTable INNER JOIN " +
                                                    "dbo.spentDef ON dbo.invoiceItemsTable.spentDefID = dbo.spentDef.spentDefID INNER JOIN " +
                                                    "dbo.projectsTable ON dbo.invoiceItemsTable.projectID = dbo.projectsTable.projectID " +
                                                    "WHERE dbo.invoiceItemsTable.invoice_id = @invoice_id;";
                adapter.SelectCommand.Parameters.Clear();
                if (tbx_ID.Text == "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@invoice_id", 0);
                }
                else
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                }

                int pos = viwinvoiceItemsBindingSource.Position;

                adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.viw_invoiceItems.Clear();
                adapter.Fill(pSDatabase5DataSet.viw_invoiceItems);

                viwinvoiceItemsBindingSource.Position = pos;

                tbx_invoiceTotal.Text = getSumTotalThisInvoice().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.SelectCommand.Connection.Close();
            }            
        }

        private void frm_buyInvoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.personsTable' table. You can move, or remove it, as needed.
            this.personsTableTableAdapter.Fill(this.pSDatabase5DataSet.personsTable);
            refreshInvoicesDataset();
            refreshInvoiceItemsDataset();            
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            frm_addInvoiceItems frmAdd = new frm_addInvoiceItems();
            frmAdd.connectionString = this.connectionString;
            frmAdd.currentProjectTitle = "";
            frmAdd.currentPrjectID = this.currentPrjectID;
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                SqlCommand sql = new SqlCommand("insert into invoiceItemsTable(projectID, invoice_id, invoiceItem_row, spentDefID, invoiceItem_amount, invoiceItem_phi, invoiceItem_total, invoiceItem_comment) values(@projectID, @invoice_id, @invoiceItem_row, @spentDefID, @invoiceItem_amount, @invoiceItem_phi, @invoiceItem_total, @invoiceItem_comment);");
                try
                {
                    int nAvilableRow = getAvailableRowNumberOfThisInvoice();

                    sql.Connection = new SqlConnection(connectionString);
                    sql.Parameters.Clear();
                    sql.Parameters.AddWithValue("@projectID", frmAdd.lbl_projectID.Text);
                    sql.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                    sql.Parameters.AddWithValue("@invoiceItem_row", nAvilableRow);
                    sql.Parameters.AddWithValue("@spentDefID", frmAdd.lbl_spentDefID.Text);
                    sql.Parameters.AddWithValue("@invoiceItem_amount", frmAdd.tbx_amount.Text);
                    sql.Parameters.AddWithValue("@invoiceItem_phi", frmAdd.tbx_phi.Text);
                    sql.Parameters.AddWithValue("@invoiceItem_total", long.Parse(frmAdd.tbx_phi.Text) * long.Parse(frmAdd.tbx_amount.Text));
                    sql.Parameters.AddWithValue("@invoiceItem_comment", "");
                    sql.Connection.Open();
                    sql.ExecuteNonQuery();

                    refreshInvoiceItemsDataset();

                    invoiceHasChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Connection.Close();
                }                
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("insert into invoicesTable(invoice_id, personID, invoice_date, invoice_total, invoice_comment) values(@invoice_id, @personID, @invoice_date, @invoice_total, @invoice_comment);");
            try
            {
                long nAvilInvoice_id = getAvilableInvoiceNumber();
                int nPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
                
                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@invoice_id", nAvilInvoice_id);
                sql.Parameters.AddWithValue("@personID", nPersonID);
                sql.Parameters.AddWithValue("@invoice_date", numberConvertor.nowDateInAppropriateFormat());
                sql.Parameters.AddWithValue("@invoice_total", 0);
                sql.Parameters.AddWithValue("@invoice_comment", "");                
                sql.Connection.Open();
                sql.ExecuteNonQuery();                

                refreshInvoicesDataset();                

                //show the new created invoice
                invoicesTableBindingSource.Position = invoicesTableBindingSource.Find("invoice_id", nAvilInvoice_id);

                refreshInvoiceItemsDataset();

                upDateCurrentPositionLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        private void tbx_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_ID.Text == "")
                {
                    tbx_ID.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void btn_goNext_Click(object sender, EventArgs e)
        {
            try
            {
                invoicesTableBindingSource.MoveNext();

                upDateCurrentPositionLabel();

                refreshInvoiceItemsDataset();
            }
            catch
            {
            }
        }

        private void btn_returnPrior_Click(object sender, EventArgs e)
        {
            try
            {
                invoicesTableBindingSource.MovePrevious();

                upDateCurrentPositionLabel();

                refreshInvoiceItemsDataset();
            }
            catch
            {
            }
        }

        private void tbx_invoiceTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_invoiceTotal.Text == "")
                {
                    tbx_invoiceTotal.Text = "0";
                }

                lbl_invoiceTotalInChars.Text = numberConvertor.convertToChars(tbx_invoiceTotal.Text) + " ریال";
            }
            catch
            {
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("update invoicesTable set invoice_id = @new_invoice_id, personID = @personID, invoice_date = @invoice_date, invoice_total = @invoice_total, invoice_comment = @invoice_comment where invoice_id = @old_invoice_id;");
            try
            {
                int nPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];

                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@new_invoice_id", tbx_ID.Text);
                sql.Parameters.AddWithValue("@old_invoice_id", n_orig_invoice_id);
                sql.Parameters.AddWithValue("@personID", nPersonID);
                sql.Parameters.AddWithValue("@invoice_date", mTbx_Date.Text);
                sql.Parameters.AddWithValue("@invoice_total", tbx_invoiceTotal.Text);
                sql.Parameters.AddWithValue("@invoice_comment", tbx_invoiceComment.Text);
                sql.Connection.Open();
                sql.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("شماره فاکتور تکراری می باشد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }


            try
            {
                if (invoiceHasChanged)
                {
                    //delete the uncompleted accounting document
                    SqlCommand sqlCmd = new SqlCommand("delete from accountingDocs where invoice_id = @invoice_id;");
                    sqlCmd.Connection = new SqlConnection(connectionString);
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Connection.Close();
                }
                
                saveAccountingDocument();

                invoiceHasChanged = false;
            }
            catch
            {
            }
            finally
            {
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {            
            if (invoicesTableBindingSource.Count == 0 || MessageBox.Show("آیا از حذف این فاکتور مطمئنید ؟", "حذف فاکتور", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;       
            }
       
            SqlCommand sql = new SqlCommand("delete from invoicesTable where invoice_id = @invoice_id;");
            try
            {
                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);                
                sql.Connection.Open();
                sql.ExecuteNonQuery();

                refreshInvoicesDataset();
                refreshInvoiceItemsDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (viwinvoiceItemsBindingSource.Count == 0) return;
            
            SqlCommand sql = new SqlCommand("delete from invoiceItemsTable where invoiceItem_row = @invoiceItem_row AND invoice_id = @invoice_id;");
            try
            {
                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                sql.Parameters.AddWithValue("@invoiceItem_row", (int)pSDatabase5DataSet.viw_invoiceItems.Rows[viwinvoiceItemsBindingSource.Position]["invoiceItem_row"]);
                sql.Connection.Open();
                sql.ExecuteNonQuery();

                //resort rows
                getAvailableRowNumberOfThisInvoice();

                refreshInvoiceItemsDataset();

                invoiceHasChanged = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sSpentDefName = dataGridView1.Rows[viwinvoiceItemsBindingSource.Position].Cells[1].Value.ToString();

                string projectName = dataGridView1.Rows[viwinvoiceItemsBindingSource.Position].Cells[2].Value.ToString();

                frm_addInvoiceItems frmEdit = new frm_addInvoiceItems();
                frmEdit.connectionString = this.connectionString;
                frmEdit.currentProjectTitle = projectName;
                frmEdit.currentPrjectID = this.currentPrjectID;
                frmEdit.tbx_amount.Text = (pSDatabase5DataSet.viw_invoiceItems.Rows[viwinvoiceItemsBindingSource.Position]["invoiceItem_amount"]).ToString();
                frmEdit.tbx_phi.Text = (pSDatabase5DataSet.viw_invoiceItems.Rows[viwinvoiceItemsBindingSource.Position]["invoiceItem_phi"]).ToString();
                frmEdit.defaultSpentDefID = getSpentDefID(sSpentDefName);
                //frmEdit.currentPrjectID =                 
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand sql = new SqlCommand("update invoiceItemsTable set projectID = @projectID, spentDefID = @spentDefID, invoiceItem_amount = @invoiceItem_amount, invoiceItem_phi = @invoiceItem_phi, invoiceItem_total = @invoiceItem_phi * @invoiceItem_amount where invoice_id = @invoice_id AND invoiceItem_row = @invoiceItem_row;");
                    try
                    {
                        sql.Connection = new SqlConnection(connectionString);
                        sql.Parameters.Clear();
                        sql.Parameters.AddWithValue("@projectID", frmEdit.lbl_projectID.Text);
                        sql.Parameters.AddWithValue("@invoice_id", tbx_ID.Text);
                        sql.Parameters.AddWithValue("@invoiceItem_row", (int)pSDatabase5DataSet.viw_invoiceItems.Rows[viwinvoiceItemsBindingSource.Position]["invoiceItem_row"]);
                        sql.Parameters.AddWithValue("@spentDefID", frmEdit.lbl_spentDefID.Text);
                        sql.Parameters.AddWithValue("@invoiceItem_amount", long.Parse(frmEdit.tbx_amount.Text));
                        sql.Parameters.AddWithValue("@invoiceItem_phi", long.Parse(frmEdit.tbx_phi.Text));
                        
                        sql.Connection.Open();
                        sql.ExecuteNonQuery();

                        refreshInvoiceItemsDataset();

                        invoiceHasChanged = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sql.Connection.Close();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_persons_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }
}
