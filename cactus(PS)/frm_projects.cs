using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace cactus_PS_
{
    public partial class frm_projects : Form
    { 
        private SqlConnection connection;
        private SqlCommand sqlCommand = new SqlCommand();

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

        private bool b_expanded = false;
        public bool Expanded
        {
            get { return b_expanded; }
            set 
            { 
                b_expanded = value;
                if (b_expanded)//expand
                {
                    this.Height = 500;
                    groupBox1.Visible = true;

                    btn_cancel.Top = 409;
                    btn_ok.Top = 409;

                    btn_expandForm.Text = "- امکانات";
                }
                else//collapse
                {
                    this.Height = 180;
                    groupBox1.Visible = false;

                    btn_cancel.Top = cmb_projectsTitle.Top + cmb_projectsTitle.Height + 20;
                    btn_ok.Top = btn_cancel.Top;

                    btn_expandForm.Text = "+ امکانات";
                }
            }
        }
        private bool b_commentModified = false;

        private void runSQLCommand(string sqlStatment)
        {
            string sTemp;
            sTemp = sqlStatment.ToUpper();

            if (sTemp.Contains("SELECT"))
            {
                try
                {
                    projectsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                    //projectsTableTableAdapter.Adapter.SelectCommand.Connection = connection;
                    projectsTableTableAdapter.Adapter.SelectCommand.CommandText = sqlStatment;
                    projectsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                    pSDatabase5DataSet.projectsTable.Clear();
                    projectsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    projectsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("UPDATE"))
            {
                try
                {
                    projectsTableTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);
                    //projectsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
                    projectsTableTableAdapter.Adapter.UpdateCommand.CommandText = sqlStatment;
                    projectsTableTableAdapter.Adapter.UpdateCommand.Connection.Open();
                    projectsTableTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.projectsTable.Clear();
                    projectsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    projectsTableTableAdapter.Adapter.UpdateCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("INSERT"))
            {
                try
                {
                    projectsTableTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);
                    //projectsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
                    projectsTableTableAdapter.Adapter.InsertCommand.CommandText = sqlStatment;
                    projectsTableTableAdapter.Adapter.InsertCommand.Connection.Open();
                    projectsTableTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.projectsTable.Clear();
                    projectsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    projectsTableTableAdapter.Adapter.InsertCommand.Connection.Close();
                }
            }
            else if (sTemp.Contains("DELETE"))
            {
                try
                {
                    projectsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //projectsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    projectsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    projectsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    projectsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.projectsTable.Clear();
                    projectsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsTable);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
                finally
                {
                    projectsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        public frm_projects()
        {
            InitializeComponent();
        }

        private void refreshProjectTableDataset()
        {
            projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
            projectsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            runSQLCommand("SELECT * FROM projectsTable;");
        }
        private void frm_projects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.personsTable' table. You can move, or remove it, as needed.
            this.personsTableTableAdapter.Fill(this.pSDatabase5DataSet.personsTable);
            try
            {
                this.Expanded = false;

                // TODO: This line of code loads data into the 'pSDatabase5DataSet.projectsTable' table. You can move, or remove it, as needed.
                this.projectsTableTableAdapter.Fill(this.pSDatabase5DataSet.projectsTable);

                //connectionString = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
                //connectionString += "D:\\DEVELOP\\CSPROJECT\\CACTUS(PS)\\CACTUS(PS)\\PSDATABASE5.MDF;";
                //connectionString += "Integrated Security=True;Connect Timeout=30;User Instance=True";
                connection = new SqlConnection(connectionString);

                refreshProjectTableDataset();

                projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", currentPrjectID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_newProject_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[2] == allow enter data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frm_getString frmGetString = new frm_getString();
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    try
                    {
                        
                        int nThisCompanyID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Find("personPhone1", "06323229522")]["personID"];

                        //...insert record into projectsTable
                        projectsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
                        projectsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                        projectsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sProjectTitle", frmGetString.tbx_.Text);
                        runSQLCommand("INSERT INTO projectsTable(projectTitle) VALUES(@sProjectTitle);");

                        //...refresh added record
                        projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                        projectsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                        runSQLCommand("SELECT * FROM projectsTable;");

                        ////...goto the New added Record
                        int addedProjectID = projectsTableBindingSource.Find("projectTitle", frmGetString.tbx_.Text);
                        projectsTableBindingSource.Position = addedProjectID;                       

                        //...add thisCompanyRecord to the new project
                        SqlCommand sqlCmd = new SqlCommand("INSERT INTO projectsPersons(projectID, personID) VALUES(@nProjectID, @nPersonID);");
                        sqlCmd.Connection = new SqlConnection(connectionString);
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@nPersonID", nThisCompanyID);
                        sqlCmd.Parameters.AddWithValue("@nProjectID", int.Parse(tbx_projectID.Text));
                    
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Connection.Close();
                        //...............................................

                        if (numberConvertor.createDetailViaDetail(int.Parse(tbx_projectID.Text), "prj", this.connectionString) == -1)
                        {
                            MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
                        }

                        //save for help
                        try
                        {
                            File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"projects_new\"");
                        }
                        catch
                        {
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
            }
        }

        private void btn_expandForm_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"projects_expand\"");
            }
            catch
            {
            }

            this.Expanded = !this.Expanded;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Expanded)
                {
                    int nOldPosition = projectsTableBindingSource.Position;

                    if (nOldPosition > -1)
                    {
                        //...update current project Comment
                        projectsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@projectMaster", tbx_projectMaster.Text);
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@projectWorkroomNumber", tbx_projectWorkroomNumber.Text);
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@projectType", tbx_projectType.Text);
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedProjectComment", tbx_projectComment.Text);
                        runSQLCommand("UPDATE projectsTable SET projectMaster = @projectMaster, projectWorkroomNumber = @projectWorkroomNumber, projectType = @projectType, projectComment = @sUpdatedProjectComment WHERE projectID = " + tbx_projectID.Text + ";");

                        projectsTableBindingSource.Position = nOldPosition;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (projectsTableBindingSource.Position > -1)
                {
                    currentPrjectID = int.Parse(pSDatabase5DataSet.projectsTable.Rows[projectsTableBindingSource.Position]["projectID"].ToString());
                    currentProjectTitle = cmb_projectsTitle.Text;

                    MessageBox.Show("پروژه '" + currentProjectTitle + "' " + "به عنوان پروژه فعال انتخاب شد", "کاکتوس", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        //Save The current Project ID To The Rigestry

                        // Open the key
                        RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\General", true);
                        key.SetValue("activeProjectID", currentPrjectID, RegistryValueKind.DWord);
                        key.SetValue("activeProjectTitle", currentProjectTitle, RegistryValueKind.String);
                        key.Close();

                        //save for help
                        try
                        {
                            File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"projects_closed\"");
                        }
                        catch
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.Close();
            }

            
        }

        private void btn_renameProjectTitle_Click(object sender, EventArgs e)
        {
            if (limitString[1] == '0')//limitString[1] == allow edit data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sOldTitle="";
            
            frm_getString frmGetString = new frm_getString();
            sOldTitle= cmb_projectsTitle.Text;
            frmGetString.tbx_.Text = sOldTitle;
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    try
                    {
                        int nOldPosition = projectsTableBindingSource.Position;

                        //...update and modify the record
                        projectsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedTitle", frmGetString.tbx_.Text);
                        projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sOldTitle", sOldTitle);
                        runSQLCommand("UPDATE projectsTable SET projectTitle = @sUpdatedTitle WHERE projectTitle = @sOldTitle;");

                        //...refresh the dataset
                        projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                        projectsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                        runSQLCommand("SELECT * FROM projectsTable;");

                        //...go back to modified record position again
                        projectsTableBindingSource.Position = nOldPosition;

                        if (numberConvertor.createDetailViaDetail(int.Parse(tbx_projectID.Text), "prj", this.connectionString) == -1)
                        {
                            MessageBox.Show("an error just happend in the 'create Detail Via Detail' Function.");
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
                else
                {
                    MessageBox.Show("این نام قابل قبول نیست");
                }
            }

        }

        private void btn_deleteProject_Click(object sender, EventArgs e)
        {
            if (limitString[2] == '0')//limitString[2] == allow delete data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pSDatabase5DataSet.projectsTable.Rows.Count > 0)
            {
                if (MessageBox.Show("آیا پروژه فعلی با همه اطلاعات آن حذف شود ؟", "حذف پروژه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (MessageBox.Show("با حذف کردن پروژه فعلی تمامی اطلاعات ذخیره شده در این پروژه حذف می شوند ؟", "حذف پروژه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {
                            //delete the ThisCompanyRecord From the projectsPersons Table
                            SqlCommand sqlCmd = new SqlCommand("DELETE FROM projectsPersons WHERE projectID = @nProjectID AND personID = @nPersonID;");
                            sqlCmd.Connection = new SqlConnection(connectionString);
                            sqlCmd.Parameters.Clear();
                            sqlCmd.Parameters.AddWithValue("@nPersonID", numberConvertor.ThisComapnyID(connectionString));
                            sqlCmd.Parameters.AddWithValue("@nProjectID", int.Parse(tbx_projectID.Text));
                            sqlCmd.Connection.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Connection.Close();

                            //Delete Record
                            projectsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                            projectsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                            projectsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@sProjectTitle", cmb_projectsTitle.Text);
                            runSQLCommand("DELETE FROM projectsTable WHERE projectTitle = @sProjectTitle;");

                            //..reFill the Data set with new Records After Delete
                            projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                            projectsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                            runSQLCommand("SELECT * FROM projectsTable;");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
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
            }
        }

        private void cmb_projectsTitle_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (b_commentModified)
                {
                    int nOldPosition = projectsTableBindingSource.Position;

                    projectsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                    projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                    projectsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedProjectComment", tbx_projectComment.Text);
                    runSQLCommand("UPDATE projectsTable SET projectComment = @sUpdatedProjectComment WHERE projectID = " + tbx_projectID.Text + ";");

                    projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
                    projectsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                    runSQLCommand("SELECT * FROM projectsTable;");

                    projectsTableBindingSource.Position = nOldPosition;

                    b_commentModified = false;
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

        private void tbx_projectComment_Enter(object sender, EventArgs e)
        {
            b_commentModified = true;
        }

        private void cmb_projectsTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = projectsTableBindingSource.DataSource;
                frmFindRecords.bindingSource1.DataMember = projectsTableBindingSource.DataMember;
                frmFindRecords.listDisplayMember = "projectTitle";
                frmFindRecords.listValueMember = "projectID";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                frmFindRecords.ShowDialog();

                if (frmFindRecords.foundRecordID != "-1")
                {
                    int nPosition = projectsTableBindingSource.Find("personID", frmFindRecords.foundRecordID);
                    projectsTableBindingSource.Position = nPosition;
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
    }
}
