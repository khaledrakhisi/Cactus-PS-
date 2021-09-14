using System;
using System.IO;
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
    public partial class frm_persons : Form
    {
        
        private SqlCommand sqlCommand;
        private string SQLStatment;
        private string sBeforeType;

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

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();
            
            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);                    
                    personsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
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
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    personsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                    
                    personsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    personsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    personsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.personsTable.Clear();
                    personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    personsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    personsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);                    
                    personsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    personsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    personsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.personsTable.Clear();
                    personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    personsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                //try
                //{
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);                    
                    personsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    personsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.personsTable.Clear();
                    personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                    
                //}
                ////catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                //}
            }
        }

        private void selectActiveProject_Persons()
        {
            try
            {
                //  SELECT Active Project... 
                SQLStatment = "SELECT * FROM personsTable, projectsPersons WHERE projectsPersons.personID = personsTable.personID AND projectsPersons.projectID = " + currentPrjectID.ToString() + " AND (personPhone1 <> '06323229522') order by personFamilyAndName ;";                
                personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();                
                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);                
                personsTableTableAdapter.Adapter.SelectCommand.CommandText = SQLStatment;
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
        private void selectAllPersons()
        {
            try
            {
                personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable WHERE(personPhone1 <> '06323229522' AND personForInfoPP = 0);";
                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);               
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.personsTable.Clear();
                personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                personsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upDateRadioButtonControls()
        {
            try
            {
                sBeforeType = loadBeforeMoneyStateOfCurrentReocrd(false);
               
                switch (sBeforeType)
                {
                    case "non":
                        {
                            rdu_NoBeforeMoney.Checked = true;

                            break;
                        }
                    case "cre":
                        {
                            rdu_creditorBefore.Checked = true;

                            break;
                        }
                    case "ind":
                        {
                            rdu_indebtedBefore.Checked = true;

                            break;
                        }
                    default:
                        {
                            rdu_NoBeforeMoney.Checked = true;

                            break;
                        }
                }
                //loadBeforeMoneyStateOfCurrentReocrd(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
            
        }

        private string loadBeforeMoneyStateOfCurrentReocrd(bool bCancel)
        {
            try
            {
                /*personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();

                personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@sPersonID", tbx_personID.Text);

                if (!bCancel)
                    personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable WHERE personID = @sPersonID;";
                else
                    personsTableTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM personsTable;";

                personsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection();
                personsTableTableAdapter.Adapter.SelectCommand.Connection = connection;

                if(personsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Closed)
                    personsTableTableAdapter.Adapter.SelectCommand.Connection.Open();

                pSDatabase5DataSet.Tables["personsTable"].Clear();
                personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.Tables["personsTable"]);

                if(personsTableTableAdapter.Adapter.SelectCommand.Connection.State == ConnectionState.Open)
                    personsTableTableAdapter.Adapter.SelectCommand.Connection.Close();*/
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close();
            }
            //return pSDatabase5DataSet.Tables["personsTable"].Rows[0]["beforeType"].ToString();
            if (personsTableBindingSource.Position != -1)
                return pSDatabase5DataSet.Tables["personsTable"].Rows[personsTableBindingSource.Position]["beforeType"].ToString();
            else
            {
                return "non";
            }
        }

        private void setReadOnly(bool enable)
        {
            tbx_address1.ReadOnly = enable;
            tbx_address2.ReadOnly = enable;
            tbx_Born.ReadOnly = enable;
            tbx_fatherName.ReadOnly = enable;
            tbx_job.ReadOnly = enable;
            tbx_nationalNumber.ReadOnly = enable;
            tbx_NO.ReadOnly = enable;
            tbx_personelNumber.ReadOnly = enable;
            tbx_phone1.ReadOnly = enable;
            tbx_phone2.ReadOnly = enable;
            tbx_indebtedOrCreditorPrice.ReadOnly = enable;

            grp_RadioButtons.Enabled = !enable;

            cmb_projectsTitle.Enabled = !enable;

            btn_choosePic.Enabled = !enable;
            btn_deletePic.Enabled = !enable;
        }


        private void upDateProperties()
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                byte[] arrPic = ms.GetBuffer();
                try
                {                    
                    pic_personFace.Image.Save(ms, pic_personFace.Image.RawFormat);
                    arrPic = ms.GetBuffer();
                }
                catch
                {
                }
                finally
                {
                    ms.Close();
                }

                personsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();

                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.Add("@personPic", SqlDbType.VarBinary).Value = arrPic;
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sAddress1", tbx_address1.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sAddress2", tbx_address2.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sBorn", tbx_Born.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sFather", tbx_fatherName.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sJob", tbx_job.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sNationalNumber", tbx_nationalNumber.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sNO", tbx_NO.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPersonelNumber", tbx_personelNumber.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone1", tbx_phone1.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone2", tbx_phone2.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPersonID", tbx_personID.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sBeforeType", sBeforeType);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sBeforeRemainMoney", tbx_indebtedOrCreditorPrice.Text);               
                personsTableTableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE personsTable SET personAddress1 = @sAddress1, personAddress2 = @sAddress2, personBorn = @sBorn, fatherName = @sFather, job = @sJob, personelNumber = @sPersonelNumber, nationalNumber = @sNationalNumber, personNO = @sNO, personPhone1 = @sPhone1, personPhone2 = @sPhone2, beforeType = @sBeforeType, beforeRemainMoney = @sBeforeRemainMoney, personPic = @personPic WHERE personID = @sPersonID;";
                personsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                
                personsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                personsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                
                //updating the PSDataset
                pSDatabase5DataSet.personsTable.Clear();
                personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                personsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
            }

        }

        public frm_persons()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                upDateProperties();
                setReadOnly(false);

                //save for help
                try
                {
                    File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"persons_closed\"");
                }
                catch
                {
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                setReadOnly(false);
            }
            finally
            {
                setReadOnly(false);
                Close();
            }
        }

        private void frm_persons_Load(object sender, EventArgs e)
        {
            try  
            {
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.projectsPersons' table. You can move, or remove it, as needed.
                this.projectsPersonsTableAdapter.Fill(this.pSDatabase5DataSet.projectsPersons);
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.projectsTable' table. You can move, or remove it, as needed.
                this.projectsTableTableAdapter.Fill(this.pSDatabase5DataSet.projectsTable);
                // TODO: This line of code loads data into the 'pSDatabase5DataSet.personsTable' table. You can move, or remove it, as needed.
                this.personsTableTableAdapter.Fill(this.pSDatabase5DataSet.personsTable);
              
                setReadOnly(true);

                upDateRadioButtonControls();

                selectActiveProject_Persons();

                int nPosition = projectsTableBindingSource.Find("projectID", currentPrjectID.ToString());
                projectsTableBindingSource.Position = nPosition;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //connection.Close();
            }
        }

        private void btn_newPerson_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[2] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"persons_new\"");
            }
            catch
            {
            }

            frm_getString frmGetString = new frm_getString();
            frmGetString.Text = "نام خانوادگی سپس نام طرف حساب را وارد کنید";
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    try
                    {
                        // ... insert Record in the persons Table
                        personsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                        personsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                        personsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sFamilyAndName", frmGetString.tbx_.Text);
                        runSQLCommand("INSERT INTO personsTable(personFamilyAndName, personPhone1, personForInfoPP) VALUES(@sFamilyAndName, '', 0);");

                        //...Update personTableAdapter
                        runSQLCommand("SELECT * FROM personsTable;");

                        //enable Controls to collect information
                        btn_modifyPersonProperties_Click(sender, e);

                        //goto the last added record
                        personsTableBindingSource.Position = personsTableBindingSource.Find("personFamilyAndName", frmGetString.tbx_.Text);
                        //personsTableBindingSource.MoveLast();

                        //move the focus to the first textbox
                        tbx_personelNumber.Focus();

                        
                        //string sProjectID = pSDatabase5DataSet.projectsTable.Rows[projectsTableBindingSource.Position]["projectID"].ToString()
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        //.... insert record into projectsPersons Table
                        SQLStatment = "INSERT INTO projectsPersons(projectID, personID) VALUES(@sProjectID, @sPersonID);";

                        sqlCommand = new SqlCommand();
                        sqlCommand.CommandText = SQLStatment;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddWithValue("@sProjectID", currentPrjectID);
                        sqlCommand.Parameters.AddWithValue("@sPersonID", tbx_personID.Text);

                        sqlCommand.Connection = new SqlConnection(connectionString);
                        
                        sqlCommand.Connection.Open();
                        sqlCommand.ExecuteNonQuery();

                        if (numberConvertor.createDetailViaDetail(int.Parse(tbx_personID.Text), "prs", this.connectionString) == -1)
                        {
                            MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                        }

                        //save for help
                        try
                        {
                            File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"persons_ok\"");
                        }
                        catch
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlCommand.Connection.Close();
                    }
                    selectActiveProject_Persons();

                    //goto the last added record
                    personsTableBindingSource.Position = personsTableBindingSource.Find("personFamilyAndName", frmGetString.tbx_.Text);

                    pic_personFace.Image = null;                    
                }
            }
        }

        private void btn_renamePerosn_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (personsTableBindingSource.Count == 0) return;

                //if ((string)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personPhone1"] == "06323229522")
                //{
                //    MessageBox.Show("کاربر گرامی شما نمی توانید نام این طرف حساب را تغییر دهید");
                //    return;
                //}

                string sOldVlaue = "";

                frm_getString frmGetString = new frm_getString();
                sOldVlaue = cmb_familyAndName.Text;
                frmGetString.tbx_.Text = sOldVlaue;
                frmGetString.ShowDialog();

                if (frmGetString.OkClicked)
                {
                    if (frmGetString.tbx_.Text != "")
                    {
                        try
                        {
                            //store the original position
                            int nOriginalPosition = nOriginalPosition = personsTableBindingSource.Position;
                             
                            //................
                            SQLStatment = "UPDATE personsTable SET personFamilyAndName = @sUpdatedValue WHERE personID = @nPersonID;";

                            personsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                            personsTableTableAdapter.Adapter.UpdateCommand.CommandText = SQLStatment;
                            personsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                            personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPersonID", int.Parse(tbx_personID.Text));
                            personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedValue", frmGetString.tbx_.Text);
                            //personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sOldValue", sOldVlaue);

                            personsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                            
                            personsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                            personsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                            
                            //updating the PSDataset
                            pSDatabase5DataSet.personsTable.Clear();
                            personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);

                            //goto the original position that the END-USER was
                            personsTableBindingSource.Position = nOriginalPosition;

                            if (numberConvertor.createDetailViaDetail(int.Parse(tbx_personID.Text), "prs", this.connectionString) == -1)
                            {
                                MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            personsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("این نام قابل قبول نیست");
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

        private void btn_modifyPersonProperties_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (personsTableBindingSource.Count == 0) return;

                //if ((string)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personPhone1"] == "06323229522")
                //{
                //    MessageBox.Show("کاربر گرامی شما نمی توانید مشخصات این طرف حساب را اصلاح کنید");
                //    return;
                //}

                if (tbx_phone1.ReadOnly)//tbx_phone1 is only an instance, could be any other textbox
                {
                    btn_modifyPersonProperties.Text = "ثبت اصلاحات";
                    setReadOnly(false);
                }
                else
                {
                    int nOriginalPosition = personsTableBindingSource.Position;

                    upDateProperties();
                    setReadOnly(true);

                    personsTableBindingSource.Position = nOriginalPosition;

                    btn_modifyPersonProperties.Text = "اصلاح مشخصات";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void btn_deletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (personsTableBindingSource.Count == 0) return;
                //if (personsTableBindingSource.Position == 0)
                //{
                //    MessageBox.Show("کاربر گرامی ، شما نمی توانید این طرف حساب را از لیست طرفهای حساب حذف کنید");
                //    return;
                //}

                if (MessageBox.Show("طرف حساب حذف شود ؟", "حذف طرف حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //........................delete the added record in projectPersonTable............
                    SQLStatment = "DELETE FROM projectsPersons WHERE personID = @sPersonID AND projectID = @nProjectID;";

                    projectsPersonsTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.CommandText = SQLStatment;
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@sPersonID", tbx_personID.Text);
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);

                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    
                    //updating the PSDataset
                    pSDatabase5DataSet.projectsPersons.Clear();
                    projectsPersonsTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsPersons);

                    //..........delete from personsTable..............................
                    personsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    personsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    personsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@sPersonID" ,tbx_personID.Text);
                    runSQLCommand("DELETE FROM personsTable WHERE personID = @sPersonID;");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("این طرف حساب را نمی توانید حذف کنید .ممکن است که این طرف حساب را در پروژه ای دیگر تعریف کرده باشید.");
                projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection.Close();
            }
            finally
            {
                
            }
        }

        private void frm_persons_Shown(object sender, EventArgs e)
        {
            
        }

        private void rdu_NoBeforeMoney_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rdu_NoBeforeMoney.Checked)
                {
                    sBeforeType = "non";

                    tbx_indebtedOrCreditorPrice.Visible = false;
                    lbl_beforeRemainMoneyPrompt.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void rdu_indebtedBefore_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_indebtedBefore.Checked)
                {
                    sBeforeType = "ind";

                    tbx_indebtedOrCreditorPrice.Visible = true;
                    lbl_beforeRemainMoneyPrompt.Visible = true;

                    lbl_beforeRemainMoneyPrompt.Text = "مبلغ بدهکاری";

                    //tbx_indebtedOrCreditorPrice.DataBindings.Clear();
                    //tbx_indebtedOrCreditorPrice.DataBindings.Add("Text", personsTableBindingSource, "indebtedPrice");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void rdu_creditorBefore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdu_creditorBefore.Checked)
            {
                try
                {
                    sBeforeType = "cre";

                    tbx_indebtedOrCreditorPrice.Visible = true;
                    lbl_beforeRemainMoneyPrompt.Visible = true;

                    lbl_beforeRemainMoneyPrompt.Text = "مبلغ بستانکاری";

                    //tbx_indebtedOrCreditorPrice.DataBindings.Clear();
                    //tbx_indebtedOrCreditorPrice.DataBindings.Add("Text", personsTableBindingSource, "creditorPrice");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                }
            }
        }

        private void tbx_beforeType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_beforeType.Text == "ind")
                {
                    rdu_indebtedBefore.Checked = true;
                }
                else if (tbx_beforeType.Text == "cre")
                {
                    rdu_creditorBefore.Checked = true;
                }
                else if (tbx_beforeType.Text == "" || tbx_beforeType.Text == "non")
                {
                    rdu_NoBeforeMoney.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
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

        private void btn_viewAllPersons_Click(object sender, EventArgs e)
        {
            //int nPosition = 0;
            try
            {

                selectAllPersons();

                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = personsTableBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = personsTableBindingSource.DataMember;
                frmFindRecords.listDisplayMember = "personFamilyAndName";
                frmFindRecords.listValueMember = "personID";
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    if (MessageBox.Show("آیا مایلید که طرف حساب را به پروژه فعلی اضافه کنید ؟", "اضافه کردن طرف حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //nPosition = personsTableBindingSource.Find("personID", frmFindRecords.foundRecordID);
                        
                        try
                        {
                            //.... insert record into projectsPersons Table
                            SQLStatment = "INSERT INTO projectsPersons(projectID, personID) VALUES(@sProjectID, @sPersonID);";

                            sqlCommand = new SqlCommand();
                            sqlCommand.CommandText = SQLStatment;
                            sqlCommand.Parameters.Clear();
                            sqlCommand.Parameters.AddWithValue("@sProjectID", currentPrjectID);
                            sqlCommand.Parameters.AddWithValue("@sPersonID", frmFindRecords.foundRecordID);

                            sqlCommand.Connection = new SqlConnection(connectionString);                            

                            sqlCommand.Connection.Open();
                            sqlCommand.ExecuteNonQuery();

                            if (numberConvertor.createDetailViaDetail(int.Parse(tbx_personID.Text), "prs", this.connectionString) == -1)
                            {
                                MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                            }
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("این طرف حساب قبلاً به این پروژه اضافه شده است.");
                        }
                        catch (Exception ex)
                        {
                            // An unknown error is happened
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sqlCommand.Connection.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                selectActiveProject_Persons();
                //personsTableBindingSource.Position = nPosition;
            }

        }

        private void btn_ejectPersonFromCurrentProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (personsTableBindingSource.Count == 0) return;
                //if (personsTableBindingSource.Position == 0)
                //{
                //    MessageBox.Show("شما نمی توانید شرکت پایدار صنعت شادگان را از لیست طرف های حساب حذف کنید");
                //    return;
                //}

                if (MessageBox.Show("آیا مطمئنید که می خواهید طرف حساب را از پروژه فعلی حذف کنید ؟", "حذف طرف حساب از پروژه فعلی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //........................delete the added record in projectPersonTable............
                    SQLStatment = "DELETE FROM projectsPersons WHERE personID = @sPersonID AND projectID = @nProjectID;";

                    projectsPersonsTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.CommandText = SQLStatment;
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@sPersonID", tbx_personID.Text);
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nProjectID", currentPrjectID);

                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);                    
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    projectsPersonsTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();

                    //updating the PSDataset
                    pSDatabase5DataSet.projectsPersons.Clear();
                    projectsPersonsTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsPersons);

                }
            }
            catch (SqlException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                projectsPersonsTableAdapter.Adapter.DeleteCommand.Connection.Close();
                selectActiveProject_Persons();
            }
        }

        private void tbx_indebtedOrCreditorPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_indebtedOrCreditorPrice.Text == "")
                tbx_indebtedOrCreditorPrice.Text = "0";
        }

        private void frm_persons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_newPerson_Click(sender, e);
            }
        }

        private void personsTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] arrPic = (byte[])(pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personPic"]); //(ds.Tables["Persons"].Rows[0]["Photo"]);

                MemoryStream ms = new MemoryStream(arrPic);

                pic_personFace.Image = Image.FromStream(ms);
            }
            catch
            {
                pic_personFace.Image = null;
            }
        }

        private void btn_choosePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pic_personFace.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                }
            }
        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {
            pic_personFace.Image = null;
        }
    }
}
