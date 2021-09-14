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
    public partial class frm_spents : Form
    {
        frm_manageSpent frmManageSpent = new frm_manageSpent();
        DataSet dSet = new DataSet();
        BindingSource bindingSource = new BindingSource();

        private SqlConnection connection;

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
        private string s_spentType = "";
        public string spentType
        {
            get { return s_spentType; }
            set { s_spentType = value; }
        }
        private int n_spentDefID;
        public int spentDefID
        {
            get { return n_spentDefID; }
            set { n_spentDefID = value; }
        }
        private bool isShown;


        private void refreshMasterSpentsDataset()
        {
            spentMasterTableAdapter.Adapter.SelectCommand = new SqlCommand();
            spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster;";
            spentMasterTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
            //spentMasterTableAdapter.Adapter.SelectCommand.Connection = connection;
            spentMasterTableAdapter.Adapter.SelectCommand.Connection.Open();
            pSDatabase5DataSet.spentMaster.Clear();
            spentMasterTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentMaster);
            spentMasterTableAdapter.Adapter.SelectCommand.Connection.Close();
        }
        private void refreshDefSpentsDataset()
        {
            if (spentMasterBindingSource.Position <= -1) return;

            int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];

            spentDefTableAdapter.Adapter.SelectCommand = new SqlCommand();
            spentDefTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentDef WHERE spentMasterID = @nSpentMasterID;";
            spentDefTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            spentDefTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);
            spentDefTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
            //spentDefTableAdapter.Adapter.SelectCommand.Connection = connection;

            if (spentDefTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Closed)
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Open();
            else if (spentDefTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Open)
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();

            pSDatabase5DataSet.spentDef.Clear();
            spentDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentDef);

            if (spentDefTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Closed)
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Open();
            else if (spentDefTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Open)
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();
        }

        private void selectSubSpentGroup()
        {
            if (spentMasterBindingSource.Position <= -1) return;
            int nSpentMaster =(int) pSDatabase5DataSet.spentMaster.Rows[cmb_spentType.SelectedIndex]["spentMasterID"];
            try
            {
                spentDefTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentDefTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentDef WHERE spentDef.spentMasterID = @nSpentMasterID;";
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMaster);
                spentDefTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                //spentDefTableAdapter.Adapter.SelectCommand.Connection = connection;
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.spentDef.Clear();
                spentDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentDef);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private string getChequesNumbersOfSpent(long nSpentID)
        {
            SqlCommand c = new SqlCommand();
            string sNumbers = "";

            try
            {
                c.Connection = connection;
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@spentID", nSpentID);
                c.CommandText = "getChequesNumbers2";
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.NVarChar);
                p.Direction = ParameterDirection.ReturnValue;

                if(c.Connection.State == ConnectionState.Closed) 
                    c.Connection.Open();
                c.ExecuteNonQuery();
               
                sNumbers = c.Parameters["@result"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
                //if(c.Connection.State == ConnectionState.Open)
                    c.Connection.Close();
            //}

            return sNumbers;
        }

        private long calculateSumOfIndebtedColumn()
        {
            if (!chk_chooseSubSpent.Checked)
                spentDefID = -1;

            SqlCommand c = new SqlCommand();
            long r = 0;
            try
            {
                c.Connection = connection;
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@projectID", currentPrjectID);
                c.Parameters.AddWithValue("@spentDefID", spentDefID);
                c.CommandText = "calculateSUMOfIndebted";
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.BigInt);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();

                r = long.Parse(c.Parameters["@result"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                c.Connection.Close();
            }

            return r;
        }
        private long calculateSumOfCreditorColumn()
        {
            if (!chk_chooseSubSpent.Checked)
                spentDefID = -1;

            SqlCommand c = new SqlCommand();
            long r = 0;
            try
            {
                c.Connection = connection;
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Clear();
                c.Parameters.AddWithValue("@projectID", currentPrjectID);
                c.Parameters.AddWithValue("@spentDefID", spentDefID);
                c.CommandText = "calculateSUMOfCreditor";
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.BigInt);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();

                r = long.Parse(c.Parameters["@result"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                c.Connection.Close();
            }

            return r;
        }

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    spentsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    //spentsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                    spentsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                    spentsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                    pSDatabase5DataSet.spentsTable.Clear();
                    spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    spentsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    spentsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    //spentsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                    spentsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    spentsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.spentsTable.Clear();
                    spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                }
                finally
                {
                    spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    spentsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    //spentsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
                    spentsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    spentsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    spentsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.spentsTable.Clear();
                    spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                }
                finally
                {
                    spentsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                try
                {
                    spentsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //spentsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    spentsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    spentsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    spentsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.spentsTable.Clear();
                    spentsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentsTable);

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    spentsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        private void calculateRemainMoney()
        {
            try
            {
                spentsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                spentsTableTableAdapter.Adapter.UpdateCommand.CommandText = "makeIndebtedOrCreditor";
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@projectID", currentPrjectID);
                spentsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@spentDefID", spentDefID);
                spentsTableTableAdapter.Adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                //spentsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                spentsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                spentsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showAndCalculateTheSelectedSpentType()
        {
            try
            {
                calculateRemainMoney();

                if (spentDefBindingSource.Position == -1)
                    return;

                int nSpentDefID =(int) pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];

                //...filter the selected spent type and fill the datagridview with those...
                spentsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                //spentsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@sSpentType", spentType);
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentDefID", nSpentDefID);
                spentsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);

                if(chk_chooseSubSpent.Checked)
                    //spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (spentsTable.spentID)شناسه, (dDate)تاریخ, (event)شـــرح, (indebtedPrice)بدهکار, (CreditorPrice)بستانکار, (remainPrice)مانده, (detectID)تشخیص ,(byCheque)چک, (spentComment)ملاحضات FROM spentsTable WHERE (spentsTable.spentDefID = @nSpentDefID AND spentsTable.projectID = @nProjectID);";
                    spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (dbo.spentsTable.nRow)ردیف ,(dbo.spentsTable.dDate)تاریخ, (dbo.spentDef.spentDefName)هزینه, (dbo.spentsTable.event)شـــرح, (dbo.spentsTable.indebtedPrice)بدهکار," +
                                                                                "(dbo.spentsTable.creditorPrice)بستانکار, (dbo.spentsTable.remainPrice)مانده, " +
                                                                                "(dbo.detectsTable.detectText)تشخیص,(dbo.spentsTable.bycheque)چک," +
                                                                                "(dbo.spentsTable.spentComment)ملاحضات, (dbo.spentsTable.spentID)شناسه" +
                                                                                " FROM dbo.spentsTable INNER JOIN dbo.detectsTable ON dbo.spentsTable.detectID = dbo.detectsTable.detectID INNER JOIN dbo.spentDef ON dbo.spentsTable.spentDefID = dbo.spentDef.spentDefID INNER JOIN dbo.projectsTable ON dbo.spentsTable.projectID = dbo.projectsTable.projectID" +
                                                                                " WHERE (dbo.projectsTable.projectID = @nProjectID)AND(dbo.spentsTable.spentDefID = @nSpentDefID);";
                else
                    //spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (spentsTable.spentID)شناسه, (dDate)تاریخ, (event)شـــرح, (indebtedPrice)بدهکار, (CreditorPrice)بستانکار, (remainPrice)مانده, (detectID)تشخیص ,(byCheque)چک, (spentComment)ملاحضات FROM spentsTable WHERE (spentsTable.projectID = @nProjectID);";
                    spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (dbo.spentsTable.nRow)ردیف ,(dbo.spentsTable.dDate)تاریخ, (dbo.spentDef.spentDefName)هزینه, (dbo.spentsTable.event)شـــرح, (dbo.spentsTable.indebtedPrice)بدهکار," +
                                                                                "(dbo.spentsTable.creditorPrice)بستانکار, (dbo.spentsTable.remainPrice)مانده, " +
                                                                                "(dbo.detectsTable.detectText)تشخیص,(dbo.spentsTable.bycheque)چک," +
                                                                                "(dbo.spentsTable.spentComment)ملاحضات, (dbo.spentsTable.spentID)شناسه" +
                                                                                " FROM dbo.spentsTable INNER JOIN dbo.detectsTable ON dbo.spentsTable.detectID = dbo.detectsTable.detectID INNER JOIN dbo.spentDef ON dbo.spentsTable.spentDefID = dbo.spentDef.spentDefID INNER JOIN dbo.projectsTable ON dbo.spentsTable.projectID = dbo.projectsTable.projectID" +
                                                                                " WHERE (dbo.projectsTable.projectID = @nProjectID);";
                    
                //spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (spentsTable.spentID)شناسه, (dDate)تاریخ, (event)شـــرح, (indebtedPrice)بدهکار, (CreditorPrice)بستانکار, (remainPrice)مانده, (detect)تشخیص ,(byCheque)چک, (spentComment)ملاحضات FROM spentsTable WHERE (spentsTable.spentType LIKE @sSpentType AND spentsTable.projectID = @nProjectID);";
                //spentsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT (spentsTable.spentID)شناسه, (dDate)تاریخ, (event)شـــرح, (indebtedPrice)بدهکار, (CreditorPrice)بستانکار, (remainPrice)مانده,(chequeNumber)[ش.چک], (spentComment)ملاحضات FROM spentsTable, chequesTable JOIN spentsTable ON chequesTable.spentID = spentsTable.spentID;";
                spentsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection();
                spentsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                spentsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                dSet.Clear();
                spentsTableTableAdapter.Adapter.Fill(dSet);
                spentsTableTableAdapter.Adapter.SelectCommand.Connection.Close();

                bindingSource.DataSource = dSet;
                bindingSource.DataMember = "spentsTable";

                grid_spents.AutoGenerateColumns = true;
                grid_spents.AllowUserToAddRows = false;
                grid_spents.DataSource = bindingSource;
                if (grid_spents.Columns["شناسه"].Width != 60)
                {
                    grid_spents.Columns["ردیف"].Width = 45;
                    grid_spents.Columns["شناسه"].Width = 60;
                    grid_spents.Columns["چک"].Width = 50;
                    grid_spents.Columns["بدهکار"].Width = 80;
                    grid_spents.Columns["بستانکار"].Width = 80;
                    grid_spents.Columns["تشخیص"].Width = 80;
                    grid_spents.Columns["مانده"].Width = 80;
                    grid_spents.Columns["شـــرح"].Width = 500;
                    grid_spents.Columns["ملاحضات"].Width = 250;
                    //grid_spents.Columns["شـــرح"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                //grid_spents.DataMember = "spentsTable"; 
                //..............................................

                tbx_indebtedTotalPrice.Text = calculateSumOfIndebtedColumn().ToString();
                tbx_creditorTotalPrice.Text = calculateSumOfCreditorColumn().ToString();
                tbx_remainTotalPrice.Text = (long.Parse(tbx_indebtedTotalPrice.Text) - long.Parse(tbx_creditorTotalPrice.Text)).ToString();

                lbl_totalRemainINCHARS.Text = numberConvertor.convertToChars(tbx_remainTotalPrice.Text) + " ریال";

                if (long.Parse(tbx_remainTotalPrice.Text) > 0)
                    tbx_remainTotalPrice.Text += " بد";
                else if (long.Parse(tbx_remainTotalPrice.Text) < 0)
                    tbx_remainTotalPrice.Text += " بس";

                if (bindingSource.Position > -1)
                {
                    if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                    {
                        long nSpentID = 0;
                        nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                        lbl_chequesNumbers.Text = "مشخصات چکها : " + getChequesNumbersOfSpent(nSpentID);
                    }
                    else
                        lbl_chequesNumbers.Text = "بدون چک";
                }
                else
                    lbl_chequesNumbers.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public frm_spents()
        {
            InitializeComponent();
        }

  
        private void frm_spents_Resize(object sender, EventArgs e)
        {
            try
            {
                grid_spents.Width = this.Width - 32;
                grid_spents.Height = this.Height - 250;

                btn_ok.Top = this.Height - 100;
                //btn_ok.Left = this.Width - 262;
                grp_totals.Left = this.Width - grp_totals.Width-20;

                //btn_addRecord.Left = this.Width - btn_addRecord.Width - 20;
                pnl_buttons.Left = this.Width - pnl_buttons.Width - 20;

                //lbl_chequesNumbers.Left = pnl_buttons.Left;
                lbl_chequesNumbers.Left = pnl_spentSubGroup.Width+10;
                lbl_chequesNumbers.Width = this.Width-100;

                grp_totals.Top = grid_spents.Height + grp_totals.Height-20;

                //lbl_totalRemainINCHARS.Left = grp_totals.Left; ;
                //lbl_totalRemainINCHARS.Top = grp_totals.Height;

                if (this.Width <= 780)
                {
                    this.Width = 780;
                    SendKeys.Send("{ENTER}");
                }
            }
            catch
            {
            }
        }

        private void frm_spents_Load(object sender, EventArgs e)
        {
            isShown = false;    
            try
            {
                //connectionString = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
                //connectionString += "D:\\DEVELOP\\CSPROJECT\\CACTUS(PS)\\CACTUS(PS)\\PSDATABASE5.MDF;";
                //connectionString += "Integrated Security=True;Connect Timeout=30;User Instance=True";
                connection = new SqlConnection(connectionString);

                // TODO: This line of code loads data into the 'pSDatabase5DataSet.spentMaster' table. You can move, or remove it, as needed.
                this.spentMasterTableAdapter.Fill(this.pSDatabase5DataSet.spentMaster);
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.spentDef' table. You can move, or remove it, as needed.
                this.spentDefTableAdapter.Fill(this.pSDatabase5DataSet.spentDef);
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.chequesTable' table. You can move, or remove it, as needed.
                //this.chequesTableTableAdapter.Fill(this.pSDatabase5DataSet.chequesTable);
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.spentsTable' table. You can move, or remove it, as needed.
                this.spentsTableTableAdapter.Fill(this.pSDatabase5DataSet.spentsTable);

                refreshMasterSpentsDataset();
                refreshDefSpentsDataset();

                //select first Master group
                selectSubSpentGroup();
                showAndCalculateTheSelectedSpentType();
                if (spentDefBindingSource.Position == -1) return;
                spentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];
                //

                //cmb_spentType.SelectedIndex = 0;
                showAndCalculateTheSelectedSpentType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void cmb_spentType_SelectedValueChanged(object sender, EventArgs e)
        {
            
            /*string sSpentType = "";
            if (cmb_spentType.SelectedIndex == 0)
            {
                pnl_spentSubGroup.Visible = false;
                sSpentType = "f-";//مصالح st(f)
            }
            else if (cmb_spentType.SelectedIndex == 1)
            {
                sSpentType = "c-";//جاری (c)ur

                pnl_spentSubGroup.Visible = true;

                cmb_spentSubGroup.Items.Clear();
                cmb_spentSubGroup.Items.Add("حقوق");
                cmb_spentSubGroup.Items.Add("تلفن");
                cmb_spentSubGroup.Items.Add("آب");
                cmb_spentSubGroup.Items.Add("برق");
                cmb_spentSubGroup.Items.Add("گاز");
                cmb_spentSubGroup.SelectedIndex = 0;
            }
            else if (cmb_spentType.SelectedIndex == 2)
            {
                pnl_spentSubGroup.Visible = false;

                sSpentType = "t-";//اثاثه
            }
            else if (cmb_spentType.SelectedIndex == 3)
            {
                pnl_spentSubGroup.Visible = false;

                sSpentType = "m-";//هیئت مدیره (m)ng
            }
            else if (cmb_spentType.SelectedIndex == 4)
            {
                pnl_spentSubGroup.Visible = true;

                sSpentType = "o-";//پیمانکاری c(o)n

                cmb_spentSubGroup.Items.Clear();
                cmb_spentSubGroup.Items.Add("سوخت");
                cmb_spentSubGroup.Items.Add("خوراک کارگران");
                cmb_spentSubGroup.Items.Add("ایاب و ذهاب کارگران");
                
                cmb_spentSubGroup.SelectedIndex = 0;

            }
            else if (cmb_spentType.SelectedIndex == 5)
            {
                pnl_spentSubGroup.Visible = true;

                sSpentType = "s-";//متفرقه m(s)c
            }
            else if (cmb_spentType.SelectedIndex == 6)
            {
                pnl_spentSubGroup.Visible = false;

                sSpentType = "___";
            }


            if (cmb_spentType.SelectedIndex == 6)
            {
                btn_addRecord.Enabled = false;
            }
            else
            {
                btn_addRecord.Enabled = true;
            }

            spentType = sSpentType;

            try
            {
                showAndCalculateTheSelectedSpentType();

                if (bindingSource.Position > -1)
                {
                    if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                    {
                        long nSpentID = 0;
                        nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                        lbl_chequesNumbers.Text = "شماره چک : " + getChequesNumbersOfSpent(nSpentID);
                    }
                    else
                        lbl_chequesNumbers.Text = "بدون چک";
                }
                else
                    lbl_chequesNumbers.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageSpent.currentPrjectID = currentPrjectID;
                frmManageSpent.currentProjectTitle = currentProjectTitle;
                frmManageSpent.connectionString = connectionString;
                frmManageSpent.spentDefID = spentDefID;
                //frmManageSpent.currentSpentID = int.Parse(dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"].ToString());
                //frmManageSpent.spentType = spentType;
                frmManageSpent.openAsIndebted = true;
                frmManageSpent.openForModify = false;
                frmManageSpent.ShowDialog(this);

                if(frmManageSpent.okClicked)
                    showAndCalculateTheSelectedSpentType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_spents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modifyRecord_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > -1)
            {
                try
                {
                    long nOldPosition = bindingSource.Position;

                    frmManageSpent.currentPrjectID = currentPrjectID;
                    frmManageSpent.currentProjectTitle = currentProjectTitle;
                    frmManageSpent.connectionString = connectionString;
                    frmManageSpent.currentSpentID = int.Parse(dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"].ToString());
                    frmManageSpent.spentDefID = spentDefID;
                    //frmManageSpent.spentType = spentType;
                    frmManageSpent.openForModify = true;
                    frmManageSpent.openAsIndebted = true;
                    frmManageSpent.ShowDialog(this);

                    if (frmManageSpent.okClicked)
                        showAndCalculateTheSelectedSpentType();

                    bindingSource.Position = (int)nOldPosition;

                    if (bindingSource.Position > -1)
                    {
                        if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                        {
                            long nSpentID = 0;
                            nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                            lbl_chequesNumbers.Text = "مشخصات چکها : " + getChequesNumbersOfSpent(nSpentID);
                        }
                        else
                            lbl_chequesNumbers.Text = "بدون چک";
                    }
                    else
                        lbl_chequesNumbers.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_deleteRecord_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position <= -1) return;
            try
            {

                if (MessageBox.Show("آیا از حذف " + (grid_spents.SelectedRows.Count).ToString() + " سطر انتخاب شده مطمئنید ؟ ", "حذف سطر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int nIndex = 0;
                    string sWHERECondition = "WHERE";

                    while (nIndex <= grid_spents.Rows.Count -1)
                    {
                        if (grid_spents.Rows[nIndex].Selected)
                        {
                            if (sWHERECondition != "WHERE" && sWHERECondition != "") sWHERECondition += " OR ";
                            sWHERECondition = sWHERECondition + " spentID = " + grid_spents.Rows[nIndex].Cells["شناسه"].Value.ToString();
                        }
                        nIndex++;
                    }

                    //first delete the probably cheques defined before
                    chequesTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    //chequesTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentID", selectedSpentID[nIndex]);//int.Parse(dSet.Tables["spentsTable"].Rows[selectedSpentID[nIndex]]["شناسه"].ToString()));
                    chequesTableTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM chequesTable " + sWHERECondition;
                    chequesTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //chequesTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    chequesTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    chequesTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    chequesTableTableAdapter.Adapter.DeleteCommand.Connection.Close();

                    spentsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    spentsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    //spentsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentID", int.Parse(dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"].ToString()));
                    runSQLCommand("DELETE FROM spentsTable " + sWHERECondition);

                           
                    showAndCalculateTheSelectedSpentType();

                    if (bindingSource.Position > -1)
                    {
                        if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                        {
                            long nSpentID = 0;
                            nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                            lbl_chequesNumbers.Text = "مشخصات چکها : " + getChequesNumbersOfSpent(nSpentID);
                        }
                        else
                            lbl_chequesNumbers.Text = "بدون چک";
                    }
                    else
                        lbl_chequesNumbers.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grid_spents_SelectionChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void grid_spents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_spents_MouseUp(object sender, MouseEventArgs e)
        {
            if (bindingSource.Position > -1)
            {
                if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                {
                    long nSpentID = 0;
                    nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                    lbl_chequesNumbers.Text = "مشخصات چکها : " + getChequesNumbersOfSpent(nSpentID);
                }
                else
                    lbl_chequesNumbers.Text = "بدون چک";
            }
            else
                lbl_chequesNumbers.Text = "";
        }

        private void grid_spents_KeyUp(object sender, KeyEventArgs e)
        {
            if (bindingSource.Position > -1)
            {
                if ((bool)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["چک"])
                {
                    long nSpentID = 0;
                    nSpentID = (int)dSet.Tables["spentsTable"].Rows[bindingSource.Position]["شناسه"];
                    lbl_chequesNumbers.Text = "مشخصات چکها : " + getChequesNumbersOfSpent(nSpentID);
                }
                else
                    lbl_chequesNumbers.Text = "بدون چک";
            }
            else
                lbl_chequesNumbers.Text = "";
        }

        private void cmb_spentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_spentSubGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            //showAndCalculateTheSelectedSpentType();
            
        }

        private void lbl_chequesNumbers_Click(object sender, EventArgs e)
        {

        }

        private void cmb_spentSubGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmb_spentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectSubSpentGroup();
            showAndCalculateTheSelectedSpentType();
            spentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_subSpentID_Click(object sender, EventArgs e)
        {

        }

        private void lbl_subSpentID_TextChanged(object sender, EventArgs e)
        { 
            spentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];
            if (isShown)
                showAndCalculateTheSelectedSpentType();
        }

        private void frm_spents_Shown(object sender, EventArgs e)
        {
            isShown = true;
        }

        private void chk_chooseSubSpent_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chooseSubSpent.Checked)
            {
                //When spentsType checkBox Enabled
                cmb_spentType.Enabled = true;
                cmb_spentSubGroup.Enabled = true;
                spentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];

                btn_addRecord.Enabled = true;
                btn_modifyRecord.Enabled = true;
            }
            else
            {
                spentDefID = -1;
                //this code will invoke when the spentsType Checkbox is disabled 
                cmb_spentType.Enabled = false;
                cmb_spentSubGroup.Enabled = false;

                btn_addRecord.Enabled = false;
                btn_modifyRecord.Enabled = false;
            }

            
            showAndCalculateTheSelectedSpentType();
        }

        private void grid_spents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chk_chooseSubSpent.Checked)
            {
                btn_modifyRecord_Click(sender, e);
            }
        }

        private void grid_spents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (chk_chooseSubSpent.Checked)
                {
                    btn_modifyRecord_Click(sender, e);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_spentsReport frmR = new frm_spentsReport();
            frmR.spentDefID = spentDefID;
            frmR.connectionString = connectionString;
            frmR.currentPrjectID = currentPrjectID;
            frmR.currentProjectTitle = currentProjectTitle;
            frmR.ShowDialog();
        }

       
    }
}
