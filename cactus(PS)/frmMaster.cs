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
using Persia;
using System.Diagnostics;
using System.IO;

namespace cactus_PS_
{
    
    public partial class frm_Master : Form
    {
        private SunDate shamsiDate = new SunDate();
        private frm_projects frmProject = new frm_projects();                        
        private frm_exploreAccDocs frmExplorer = new frm_exploreAccDocs();

        private int n_userID;

        private string sPassword, s_backupCommand;

        private bool b_unwanterUser, b_showHelp;

        private string sBGPath = "";
        string[] files;
        int nPicIndex = 0;

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
        public int currentProjectID
        {
            get { return n_currentProjectID; }
            set { n_currentProjectID = value; }
        }

        private void refreshTheUsersTableDataset()
        {
            try
            {
                usersTableTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from usersTable;");
                usersTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                usersTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.usersTable.Clear();
                usersTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.usersTable);
                usersTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showLogForm()
        {
            refreshTheUsersTableDataset();

            if (usersTableBindingSource.Count == 2)
            {
                if (pSDatabase5DataSet.usersTable.Rows[1]["user_password"] != DBNull.Value)
                {
                    frm_logOn frmLog = new frm_logOn();
                    frmLog.connectionString = this.connectionString;
                    if (frmLog.ShowDialog() == DialogResult.Cancel)
                    {
                        b_unwanterUser = true;
                    }
                    else
                    {
                        n_userID = frmLog.n_userID;
                        usersTableBindingSource.Position = usersTableBindingSource.Find("user_id", n_userID);                    
                        limitString = (string)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_limitString"];
                        limitString = limitString.Replace(";", "");
                    }
                }
                else
                {
                    n_userID = (int)pSDatabase5DataSet.usersTable.Rows[1]["user_id"];                                        
                    limitString = (string)pSDatabase5DataSet.usersTable.Rows[1]["user_limitString"];
                    limitString = limitString.Replace(";", "");
                }
            }
            else if (usersTableBindingSource.Count > 2 || usersTableBindingSource.Count == 1)
            {
                frm_logOn frmLog = new frm_logOn();
                frmLog.connectionString = this.connectionString;
                if (frmLog.ShowDialog() == DialogResult.Cancel)
                {
                    b_unwanterUser = true;
                }
                else
                {
                    n_userID = frmLog.n_userID;
                    usersTableBindingSource.Position = usersTableBindingSource.Find("user_id", n_userID);                    
                    limitString = (string)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_limitString"];
                    limitString = limitString.Replace(";", "");
                }
            }            
        }


        private void refreshTheProjectDataset()
        {
            try
            {
                projectsTableTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from projectsTable;");
                projectsTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                projectsTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.projectsTable.Clear();
                projectsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.projectsTable);
                projectsTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            catch
            {
            }
        }

        public frm_Master()
        {
            string sBankPath = loadBankPath();
            if (sBankPath == "no")
            {
                sBankPath = Application.StartupPath;
            }
            //build the connection string
            s_connectionString = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
            s_connectionString += sBankPath + "\\PSDb.mdf;";
            s_connectionString += "Integrated Security=True;User Instance=True";

            s_backupCommand = "";

            b_showHelp = true;

            InitializeComponent();

            //first of all i should display the SPLASH-SCREEN
            frm_splash frmSplash = new frm_splash();
            frmSplash.openAsAboutDialog = false;
            frmSplash.ShowDialog();

            checkTheRegistryKeysAndValues();

            //********Change the current Input Language to the farsi (Persian)*************\\
            try
            {
                // Gets the list of installed languages.
                foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
                {
                    if ((lang.Culture.EnglishName.IndexOf("Iran") > -1) || lang.Culture.EnglishName.IndexOf("Farsi") > -1 || lang.Culture.EnglishName.IndexOf("Persian") > -1)
                    {
                        InputLanguage.CurrentInputLanguage = lang;
                        break;
                    }
                }
            }
            catch
            {
            }
            //.................................................................................        

            showLogForm();
        }

        private void expandTheMainMenu()
        {
            try
            {
                grp_MainMenu.Left = this.Width - grp_MainMenu.Width;
            }
            catch
            {
            }
        }
        private void collapseTheMainMenu()
        {
            try
            {
                grp_MainMenu.Left = this.Width - lbl_HERE.Width - 7;
            }
            catch
            {
            }
        }

        private string loadBankPath()
        {
            try
            {
                //-- make sure that PREFERENCE sub keys is exist...
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\cactus_ps\\Preference");
                // If the return value is null, the key doesn't exist and that mean the bank is in the current program path
                if (key != null)
                {
                    if ((key.GetValue("bankPath") != null) && ((string)key.GetValue("bankPath") != "") && ((string)key.GetValue("bankPath") != "%app Path%"))
                    {
                        return (string)key.GetValue("bankPath");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "no";
        }

        private void validateProjectID()
        {
            //First of all ,the program validates the ProjectID;
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM projectsTable WHERE projectID = @nProjectID;");
            try
            {
                sqlCmd.Connection = new SqlConnection(connectionString);
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@nProjectID", currentProjectID);
                sqlCmd.Connection.Open();
                int nResult = (int)sqlCmd.ExecuteScalar();
            }
            catch
            {
                currentProjectTitle = "";
                currentProjectID = -1;
            }
            finally
            {
                sqlCmd.Connection.Close();
            }
        }

        private void upDateCactusTitle()
        {
            try
            {
                if (currentProjectTitle != null && currentProjectTitle.Length > 0)
                {
                    lbl_activeProjectTitle.Text = currentProjectTitle;
                }
                else
                    lbl_activeProjectTitle.Text = "پروژه ای انتخاب نشده است";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadBGSettings()
        {
            try
            {
                //load current user info
                try
                {
                    refreshTheUsersTableDataset();
                    usersTableBindingSource.Position = usersTableBindingSource.Find("user_id", n_userID);
                    if (pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_picPath"] != DBNull.Value)
                    {
                        try
                        {
                            pic_user.Image = Image.FromFile(pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_picPath"].ToString());
                        }
                        catch
                        {
                            pic_user.Image = imageList1.Images[8];
                        }
                    }
                    else
                    {
                        pic_user.Image = imageList1.Images[(int)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_picIndex"]];
                    }
                    lbl_userName.Text = pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_name"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //-- make sure that PREFERENCE sub keys is exist...
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference\\" + n_userID.ToString());
                // If the return value is null, the key doesn't exist
                if (key == null)
                {
                    // The key doesn't exist; create it / open it
                    key = Registry.CurrentUser.CreateSubKey("Software\\coreCodes\\Cactus_PS\\Preference\\" + n_userID.ToString());
                }
                if (key.GetValue("BGImagePath") != null)
                {
                    try
                    {
                        // The value exists; load the data that stored in the registry.                    
                        sBGPath = (string)key.GetValue("BGImagePath");
                        pic_bg.Image = Image.FromFile(sBGPath);
                    }
                    catch
                    {
                    }
                }
                if (key.GetValue("BGImagePosition") != null)
                {
                    // The value exists; load the data that stored in the registry.
                    int nPosition = 0;

                    nPosition = (int)key.GetValue("BGImagePosition");
                    if (nPosition == 0)
                    {
                        pic_bg.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else if (nPosition == 1)
                    {
                        pic_bg.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (nPosition == 2)
                    {
                        pic_bg.SizeMode = PictureBoxSizeMode.CenterImage;
                    }

                }

                //load the main menu settings
                if (key.GetValue("noMainMenu") != null)
                {
                    // The value exists; load the data that stored in the registry.
                    int nState = 0;

                    nState = (int)key.GetValue("noMainMenu");
                    if (nState == 1)
                    {
                        grp_MainMenu.Visible = false;
                    }
                    else
                    {
                        grp_MainMenu.Visible = true;
                    }

                }

                //load the showSamePathPics state
                if (key.GetValue("delaySeconds") != null)
                {
                    tmr_showDelay.Enabled = false;
                    // The value exists; load the data that stored in the registry.
                    int nSeconds = 0;

                    nSeconds = (int)key.GetValue("delaySeconds");
                    if (nSeconds > 1)
                    {
                        string sPath = sBGPath;
                        sPath = sPath.Substring(0, sPath.LastIndexOf("\\"));
                        //Load the fiels path into the Array
                        files = Directory.GetFiles(sPath, "*.jpg");
                        nPicIndex = 0;

                        tmr_showDelay.Interval = nSeconds * 1000;
                        tmr_showDelay.Enabled = true;
                    }                    
                }
            }
            catch
            {
            }
        }

        private void checkTheRegistryKeysAndValues()
        {            
            //-- make sure that GENERAL sub keys is exist...
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\General");
            // If the return value is null, the key doesn't exist
            if (key == null)
            {
                // The key doesn't exist; create it / open it
                key = Registry.CurrentUser.CreateSubKey("Software\\coreCodes\\Cactus_PS\\General");
            }

            if (key.GetValue("activeProjectID") != null)
            {
                // The value exists; load the data that stored in the registry.
                currentProjectID = (int)key.GetValue("activeProjectID");
                if (currentProjectID != 0)
                {
                    int pos = projectsTableBindingSource.Find("projectID", currentProjectID);
                    projectsTableBindingSource.Position = pos;

                }
            }
            if (key.GetValue("activeProjectTitle") != null)
            {
                // The value exists; load the data that stored in the registry.
                currentProjectTitle = (string)key.GetValue("activeProjectTitle");
            }

            if (key.GetValue("noMoreHelp") != null)
            {
                // The value exists; load the data that stored in the registry.
                int bNoMoreHelp = (int)key.GetValue("noMoreHelp");
                if (bNoMoreHelp == 1)
                {
                    b_showHelp = false;
                }
            }            
            key.Close();


            //-- make sure that x120c(it means password) sub keys is exist...
            key = Registry.LocalMachine.OpenSubKey("Software\\x120c");
            // If the return value is null, the key doesn't exist
            if (key == null)
            {
                // The key doesn't exist; create it / open it
                key = Registry.LocalMachine.CreateSubKey("Software\\x120c");
            }

            if (key.GetValue("local") != null)
            {
                // The value exists; load the data that stored in the registry.
                sPassword = (string)key.GetValue("local");
            }
        }

        private void btn_Projects_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_persons_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"persons\"");
            }
            catch
            {
            }

            collapseTheMainMenu();
            if (currentProjectID > -1)
            {
                frm_persons frmPersons = new frm_persons();
                frmPersons.currentPrjectID = currentProjectID;
                frmPersons.currentProjectTitle = frmProject.currentProjectTitle;
                frmPersons.connectionString = connectionString;
                frmPersons.limitString = this.limitString;
                frmPersons.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("لطفاً قبل هر چیز پروژه ای را تعریف کنید .برای این کار از منوی عملیات پایه گزینه پروژه ها را انتخاب کنید");
            }
        }

        private void frm_Master_Load(object sender, EventArgs e)
        {   
            try
            {
                if (b_unwanterUser)
                {
                    this.Close();
                }

                // TODO: This line of code loads data into the 'pSDatabase5DataSet.projectsTable' table. You can move, or remove it, as needed.
                this.projectsTableTableAdapter.Fill(this.pSDatabase5DataSet.projectsTable);

                if (projectsTableBindingSource.Count > 0)
                {
                    projectsTableBindingSource.Position = projectsTableBindingSource.Find("projectID", currentProjectID);
                }                

                b_unwanterUser = false;

                shamsiDate = Calendar.ConvertToPersian(DateTime.Now);                

                validateProjectID();

                upDateCactusTitle();

                loadBGSettings();

                //originalIconX = pic_companyIcon.Left;
                //originalIconY = pic_companyIcon.Top;

                if (b_showHelp)
                {
                    frm_help frmHelp = new frm_help();
                    frmHelp.connectionString = this.connectionString;
                    frmHelp.Show(this);
                }

                if (b_unwanterUser)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        
        private void btn_financialActions_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"financials\"");
            }
            catch
            {
            }

            collapseTheMainMenu();

            frm_financialActions frmFinancialActions = new frm_financialActions();
            frmFinancialActions.connectionString = connectionString;
            frmFinancialActions.limitString = this.limitString;
            frmFinancialActions.currentPrjectID = currentProjectID;
            frmFinancialActions.currentProjectTitle = currentProjectTitle;
            frmFinancialActions.openForModify = false;
            frmFinancialActions.ShowDialog();
        }

        private void btn_INFOpp_Click(object sender, EventArgs e)
        {
            collapseTheMainMenu();            
            try
            {   
                frm_info frmInfo = new frm_info();
                frmInfo.connectionString = this.connectionString;
                frmInfo.ShowDialog();                
            }
            catch
            {                
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewPensionForm_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"pensions\"");
            }
            catch
            {
            }

            collapseTheMainMenu();

            frm_pensionsForm frmPensions = new frm_pensionsForm();        
            frmPensions.currentPrjectID = currentProjectID;
            frmPensions.currentProjectTitle = currentProjectTitle;
            frmPensions.connectionString = connectionString;
            frmPensions.limitString = this.limitString;
            frmPensions.ShowDialog();            
        }

       
        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"accounts\"");
            }
            catch
            {
            }

            frm_manageAccounts frmManageAccounts = new frm_manageAccounts();
            frmManageAccounts.currentPrjectID = this.currentProjectID;
            frmManageAccounts.connectionString = connectionString;
            frmManageAccounts.limitString = this.limitString;
            frmManageAccounts.ShowDialog();
        }

        private void spentsGroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manageSpentDefs frmManageSpentDef = new frm_manageSpentDefs();
            frmManageSpentDef.limitString = this.limitString;
            frmManageSpentDef.connectionString = connectionString;
            frmManageSpentDef.ShowDialog();
        }

        private void ToolStripMenuItem_backup_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"backup\"");
            }
            catch
            {
            }

            frm_backup frmBackup = new frm_backup();
            frmBackup.limitString = this.limitString;
            if (frmBackup.ShowDialog() == DialogResult.OK)
            {
                s_backupCommand = "bak";
                this.Close();    
            }
        }

        private void ToolStripMenuItem_projects_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"projects\"");
            }
            catch
            {
            }

            frmProject.currentPrjectID = currentProjectID;
            frmProject.connectionString = connectionString;
            frmProject.limitString = this.limitString;
            if (frmProject.ShowDialog(this) == DialogResult.OK)
            {
                currentProjectID = frmProject.currentPrjectID;
                currentProjectTitle = frmProject.currentProjectTitle;

                refreshTheProjectDataset();
                int pos = projectsTableBindingSource.Find("projectID", currentProjectID);
                projectsTableBindingSource.Position = pos;
            }

            upDateCactusTitle();            
        }

        private void frm_Master_Resize(object sender, EventArgs e)
        {
            lbl_cactusTitle.Width = this.Width - 40;

            //pnl_companyIcon.Left = lbl_cactusTitle.Width - pic_companyIcon.Width - 50;
            pnl_userInfo.Left = lbl_cactusTitle.Width - pnl_userInfo.Width - 50;

            pic_underline.Width = lbl_cactusTitle.Width;

            pic_bg.Width = lbl_cactusTitle.Width;
            pic_bg.Height = this.Height - lbl_cactusTitle.Height - 100;

            //pic_companyIcon.Left = lbl_cactusTitle.Width - pic_companyIcon.Width + 30;
            grp_MainMenu.Left = (this.Width / 2) - (grp_MainMenu.Width / 2);

            collapseTheMainMenu();
        }

        private void softwareConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_preference frmPreference = new frm_preference();
            frmPreference.connectionString = this.connectionString;
            frmPreference.limitString = this.limitString;
            frmPreference.n_userID = this.n_userID;
            if (frmPreference.ShowDialog() != DialogResult.Cancel)
            {
                loadBGSettings();
            }
        }

        private void pic_bg_DoubleClick(object sender, EventArgs e)
        {
            softwareConfigurationToolStripMenuItem_Click(sender, e);
        }

        private void tmr_showDelay_Tick(object sender, EventArgs e)
        {
            try
            {
                pic_bg.Image = Image.FromFile(files[nPicIndex++]);
                if (nPicIndex >= files.Length)
                {
                    nPicIndex = 0;
                }
            }
            catch
            {
            }
        }

        private void pic_companyIcon_MouseEnter(object sender, EventArgs e)
        {
            //pic_companyIcon.Left = pic_iconShadow.Left;
            //pic_companyIcon.Top = pic_iconShadow.Top;
        }

        private void pic_companyIcon_MouseLeave(object sender, EventArgs e)
        {
            
        }        

        private void tmr_dateUpdate_Tick(object sender, EventArgs e)
        {
            shamsiDate = Calendar.ConvertToPersian(DateTime.Now);
            lbl_nowDate.Text = shamsiDate.Weekday;
        }

        private void pnl_companyIcon_MouseEnter(object sender, EventArgs e)
        {
            //pic_companyIcon.Left = pic_iconShadow.Left;
            //pic_companyIcon.Top = pic_iconShadow.Top;
        }

        private void pnl_companyIcon_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void lbl_cactusTitle_MouseEnter(object sender, EventArgs e)
        {
            //pic_companyIcon.Left = originalIconX;
            //pic_companyIcon.Top = originalIconY;
            //pic_companyIcon.BringToFront();
        }

        private void frm_Master_MouseEnter(object sender, EventArgs e)
        {
            //pic_companyIcon.Left = originalIconX;
            //pic_companyIcon.Top = originalIconY;
            //pic_companyIcon.BringToFront();
        }

        private void pic_bg_MouseEnter(object sender, EventArgs e)
        {
            //pic_companyIcon.Left = originalIconX;
            //pic_companyIcon.Top = originalIconY;
            //pic_companyIcon.BringToFront();
        }

        private void lbl_activeProjectTitle_DoubleClick(object sender, EventArgs e)
        {
            ToolStripMenuItem_projects_Click(sender, e);
        }

        private void lbl_activeProjectTitle_MouseEnter(object sender, EventArgs e)
        {
            lbl_activeProjectTitle.ForeColor = Color.Red;
        }

        private void lbl_activeProjectTitle_MouseLeave(object sender, EventArgs e)
        {
            lbl_activeProjectTitle.ForeColor = Color.Black;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_splash frmSplash = new frm_splash();
            frmSplash.openAsAboutDialog = true;
            frmSplash.ShowDialog();
        }

        private void lbl_HERE_MouseHover(object sender, EventArgs e)
        {
            expandTheMainMenu();
        }

        private void pic_bg_MouseHover(object sender, EventArgs e)
        {
            collapseTheMainMenu();
        }

        private void lbl_cactusTitle_MouseHover(object sender, EventArgs e)
        {
            collapseTheMainMenu();
        }

        private void mnu_reports_showAccountingDocs_Click(object sender, EventArgs e)
        {
            try
            {                
                frmExplorer.connectionString = this.connectionString;
                frmExplorer.limitString = this.limitString;
                frmExplorer.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                collapseTheMainMenu();

                frm_buyInvoices frmInvoice = new frm_buyInvoices();
                frmInvoice.connectionString = this.connectionString;
                frmInvoice.currentPrjectID = this.currentProjectID;
                frmInvoice.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnu_reports_mainBook_Click(object sender, EventArgs e)
        {
            try
            {
                frm_books frmBooks = new frm_books();
                frmBooks.connectionString = this.connectionString;
                frmBooks.limitString = this.limitString;
                frmBooks.rdu_bigJournal.Checked = true;
                frmBooks.ShowDialog();
            }
            catch
            {
            }

        }

        private void mnu_reports_dailyBook_Click(object sender, EventArgs e)
        {
            try
            {
                frm_books frmBooks = new frm_books();
                frmBooks.connectionString = this.connectionString;
                frmBooks.limitString = this.limitString;
                frmBooks.rdu_journal.Checked = true;
                frmBooks.ShowDialog();
            }
            catch
            {
            }
        }

        private void mnu_reports_smallLedger_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"smallLedger\"");
            }
            catch
            {
            }

            try
            {
                frm_books frmBooks = new frm_books();
                frmBooks.connectionString = this.connectionString;
                frmBooks.limitString = this.limitString;
                frmBooks.rdu_smallJournal.Checked = true;
                frmBooks.ShowDialog();
            }
            catch
            {
            }
        }

        private void mnu_reports_personsSmallLedger_Click(object sender, EventArgs e)
        {            
        }

        private void mnu_advancedActions_manageAccDocs_Click(object sender, EventArgs e)
        {
            //save for help
            try
            {
                File.WriteAllText(Application.StartupPath + "\\helpTool.inf", "[option]\r\nfunction=\"accDocs\"");
            }
            catch
            {
            }

            try
            {
                //frm_manageAccDocs frmManageAccDocs = new frm_manageAccDocs();
                //frmManageAccDocs.limitString = this.limitString;
                //frmManageAccDocs.connectionString = this.connectionString;
                //frmManageAccDocs.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnu_reports_balance_twoCols_Click(object sender, EventArgs e)
        {
            frm_balance frmBalance = new frm_balance();
            frmBalance.rdu_TwoColumnsBalance.Checked = true;
            frmBalance.connectionString = this.connectionString;
            frmBalance.limitString = this.limitString;
            frmBalance.ShowDialog();
        }

        private void mnu_reports_balance_fourCols_Click(object sender, EventArgs e)
        {
            frm_balance frmBalance = new frm_balance();
            frmBalance.rdu_fourColumnsBalance.Checked = true;
            frmBalance.connectionString = this.connectionString;
            frmBalance.limitString = this.limitString;
            frmBalance.ShowDialog();
        }

        private void mnu_reports_taraznameh_Click(object sender, EventArgs e)
        {
            frm_taraznameh frmTaraz = new frm_taraznameh();
            frmTaraz.limitString = this.limitString;
            frmTaraz.connectionString = this.connectionString;
            frmTaraz.ShowDialog();
        }

        private void mnu_reports_free_Click(object sender, EventArgs e)
        {
            //frm_free frmFree = new frm_free();
            //frmFree.connectionString = this.connectionString;
            //frmFree.currentProjectID = this.currentProjectID;
            //frmFree.ShowDialog();
        }

        private void frm_Master_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (s_backupCommand == "bak")
            {
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = Application.StartupPath + "\\bankBack.exe";
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                myProcess.Start();
            }
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (s_backupCommand != "bak" && !b_unwanterUser)
                {
                    this.DialogResult = MessageBox.Show("آیا مایلید که از اطلاعات خود نسخه پشتیبان تهیه نمایید؟", "نسخه پشتیبان", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (this.DialogResult == DialogResult.Yes)
                    {
                        frm_backup frmBackup = new frm_backup();
                        frmBackup.dontStartAgain = true;
                        frmBackup.grp_restore.Enabled = false;
                        if (frmBackup.ShowDialog() == DialogResult.OK)
                        {
                            s_backupCommand = "bak";
                        }
                    }
                    else if (this.DialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_help frmHelp = new frm_help();
            frmHelp.connectionString = this.connectionString;
            frmHelp.chk_dontShowAgain.Visible = false;
            frmHelp.Show(this);
        }

        private void toolStripMenuItem73_Click(object sender, EventArgs e)
        {
            frm_projectsSmallLedger frmProjectSmallLedger = new frm_projectsSmallLedger();
            frmProjectSmallLedger.limitString = this.limitString;
            frmProjectSmallLedger.connectionString = this.connectionString;
            frmProjectSmallLedger.ShowDialog();
        }

        private void mnu_reports_remains_ledger_Click(object sender, EventArgs e)
        {
            frm_remains frmRemains = new frm_remains();
            frmRemains.connectionString = this.connectionString;
            frmRemains.limitString = this.limitString;
            frmRemains.rdu_showLedgerRemains.Checked = true;
            frmRemains.ShowDialog();
        }

        private void mnu_reports_remains_details_Click(object sender, EventArgs e)
        {
            frm_remains frmRemains = new frm_remains();
            frmRemains.connectionString = this.connectionString;
            frmRemains.limitString = this.limitString;
            frmRemains.rdu_showDetailRemains.Checked = true;
            frmRemains.ShowDialog();
        }

        private void mnu_reports_remains_projects_Click(object sender, EventArgs e)
        {
            frm_remains frmRemains = new frm_remains();
            frmRemains.connectionString = this.connectionString;
            frmRemains.limitString = this.limitString;
            frmRemains.rdu_showProjectsRemains.Checked = true;
            frmRemains.ShowDialog();
        }

        private void mnu_reports_showDetails_all_Click(object sender, EventArgs e)
        {
            frm_exploreDetails frmExploreDetails = new frm_exploreDetails();
            frmExploreDetails.connectionString = this.connectionString;
            frmExploreDetails.ShowDialog();
        }

        private void mnu_reports_showDetails_justLedger_Click(object sender, EventArgs e)
        {
            frm_exploreDetails frmExploreDetails = new frm_exploreDetails();
            frmExploreDetails.connectionString = this.connectionString;
            frmExploreDetails.rdu_ledgers.Checked = true;
            frmExploreDetails.ShowDialog();
        }

        private void mnu_reports_showDetails_justDetails_Click(object sender, EventArgs e)
        {
            frm_exploreDetails frmExploreDetails = new frm_exploreDetails();
            frmExploreDetails.connectionString = this.connectionString;
            frmExploreDetails.rdu_details.Checked = true;
            frmExploreDetails.ShowDialog();
        }

        private void mnu_reports_showDetails_justDetailsByFilter_Click(object sender, EventArgs e)
        {
            frm_exploreDetails frmExploreDetails = new frm_exploreDetails();
            frmExploreDetails.connectionString = this.connectionString;
            frmExploreDetails.rdu_detailsByFilter.Checked = true;
            frmExploreDetails.ShowDialog();
        }

        private void mnu_tools_bankManager_Click(object sender, EventArgs e)
        {
            frm_bankManager frmBankMgr = new frm_bankManager();
            frmBankMgr.connectionString = this.connectionString;
            frmBankMgr.ShowDialog();
        }

        

       
    }
}
