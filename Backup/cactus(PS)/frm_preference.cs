using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;

namespace cactus_PS_
{
    public partial class frm_preference : Form
    {
        private System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
        private Process myProcess = new Process();

        private string sOldPassword, sBankPath;
        public int n_userID;

        public frm_preference()
        {
            InitializeComponent();

            sBankPath = "";
        }

        private string s_limitString;
        public string limitString
        {
            get { return s_limitString; }
            set { s_limitString = value; }
        }

        private void applayTheLimitString()
        {
            try
            {
                string limitString = (string)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitString"];
                string[] limits = limitString.Split(';');
                for (int i = 0; i < limits.Length; i++)
                {
                    bool bValue = false;
                    if (limits[i] == "1")
                    {
                        bValue = true;
                    }
                    chkLst_Allocations.SetItemChecked(i, bValue);

                    Application.DoEvents();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string buildTheLimitString()
        {
            string sLimitString = "";
            try
            {
                for (int i = 0; i < chkLst_Allocations.Items.Count; i++)
                {
                    if (sLimitString.Length > 0)
                    {
                        sLimitString += ";";
                    }
                    if (chkLst_Allocations.GetItemChecked(i) == true)
                    {                        
                        sLimitString += "1";
                    }
                    else
                    {                        
                        sLimitString += "0";
                    }
                }
                return sLimitString;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
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
            catch
            {
            }            
        }

        private void loadUsers()
        {
            try
            {
                listView_users.Clear();
                for (int i = 0; i < lbx_users.Items.Count; i++)
                {
                    listView_users.Items.Add(pSDatabase5DataSet.usersTable.Rows[i]["user_name"].ToString(), (int)pSDatabase5DataSet.usersTable.Rows[i]["user_PicIndex"]);

                    if (pSDatabase5DataSet.usersTable.Rows[i]["user_PicPath"] != DBNull.Value)
                    {
                        string sPicPath = pSDatabase5DataSet.usersTable.Rows[i]["user_PicPath"].ToString();

                        try
                        {
                            imageList1.Images.Add(Image.FromFile(sPicPath));
                        }
                        catch
                        {
                        }
                        listView_users.Items[i].ImageIndex = imageList1.Images.Count - 1;                        
                    }
                    else
                    {
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private void showMessageOnBankTextBox()
        {
            tbx_bankPath.Text = tbx_bankPath.Text.Trim();
            if (tbx_bankPath.Text == "")
            {
                tbx_bankPath.Text = "%app Path%";

                tbx_bankPath.ForeColor = Color.Silver;
            }
        }

        private void hideMessageOnBankTextBox()
        {
            if (tbx_bankPath.Text == "%app Path%")
            {
                tbx_bankPath.Text = "";

                tbx_bankPath.ForeColor = Color.Black;
            }
        }

        private void saveBankSettings()
        {
            try
            {
                //Save The bank settings INTo The Rigestry
                // Open the key
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\cactus_ps\\Preference", true);
                key.SetValue("bankPath", tbx_bankPath.Text, RegistryValueKind.String);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBGSettings()
        {
            //Save The BG settings INTo The Rigestry
            int nState = 0, min = 0;
            if (! chk_showMainMenu.Checked)
            {
                nState = 1;
            }
            if (!chk_showSamePathPic.Checked)
            {
                min = 1;
            }
            else
            {
                min = (int)num_seconds.Value;
            }
            // Open the key
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference\\" + n_userID.ToString(), true);
            key.SetValue("BGImagePath", tbx_path.Text, RegistryValueKind.String);
            key.SetValue("BGImagePosition", cmb_picPosition.SelectedIndex, RegistryValueKind.DWord);
            key.SetValue("noMainMenu", nState, RegistryValueKind.DWord);
            key.SetValue("delaySeconds", min, RegistryValueKind.DWord);
            key.Close();
        }
        private bool savePasswordSettings()
        {
            try
            {
                for (int i = 0; i < lbx_users.Items.Count; i++)
                {
                    string sUserID = pSDatabase5DataSet.usersTable.Rows[i]["user_id"].ToString();
                    string sLimitString = pSDatabase5DataSet.usersTable.Rows[i]["user_limitString"].ToString();
                    int picIndex = (int)pSDatabase5DataSet.usersTable.Rows[i]["user_picIndex"];
                    Object picPath = pSDatabase5DataSet.usersTable.Rows[i]["user_picPath"];                    
                    int limitType = (int)pSDatabase5DataSet.usersTable.Rows[i]["user_limitType"];
                    Object objPassword = pSDatabase5DataSet.usersTable.Rows[i]["user_password"];

                    SqlCommand sql = new SqlCommand();
                    sql.CommandText = "update usersTable set user_picIndex = @user_picIndex, user_picPath = @user_picPath, user_password = @user_password, user_limitType = @user_limitType, user_limitString = @user_limitString where user_id = @user_id;";
                    sql.Connection = new SqlConnection(connectionString);
                    sql.Parameters.AddWithValue("@user_id", sUserID);
                    sql.Parameters.AddWithValue("@user_password", objPassword);  
                    sql.Parameters.AddWithValue("@user_picIndex", picIndex);
                    sql.Parameters.AddWithValue("@user_picPath", picPath);
                    sql.Parameters.AddWithValue("@user_limitType", limitType);
                    sql.Parameters.AddWithValue("@user_limitString", sLimitString);

                    sql.Connection.Open();
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void saveBackupSettings()
        {
            //Save The Backup settings INTo The Rigestry
            // Open the key
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference", true);
            key.SetValue("backupPath", tbx_backupPath.Text, RegistryValueKind.String);
            key.Close();
        }
        private void saveReminderSettings()
        {
            if (!chk_playSoundOnTime.Checked)
            {
                tbx_reminderSoundPath.Text = "";
            }
            //Save reminder settings INTo The Rigestry

            // Open the key
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference", true);
            //save sound Path
            key.SetValue("reminderSoundPath", tbx_reminderSoundPath.Text, RegistryValueKind.String);
            key.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_preference_Load(object sender, EventArgs e)
        {
            refreshTheUsersTableDataset();

            sOldPassword = "";
            cmb_picPosition.SelectedIndex = 1;

            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\x120c");
            if (key.GetValue("local") != null)
            {
                sOldPassword = (string)key.GetValue("local");
            }
            key.Close();

            //LOAD APPREANCE SETTING
            key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference\\" + n_userID.ToString());

            if (key.GetValue("BGImagePath") != null)
            {
                // The value exists; load the data that stored in the registry.
                tbx_path.Text = (string)key.GetValue("BGImagePath");
            }

            try
            {

                pic_sampleScreen.Image = Image.FromFile(tbx_path.Text);
            }
            catch
            {
            }

            if (key.GetValue("BGImagePosition") != null)
            {
                // The value exists; load the data that stored in the registry.
                cmb_picPosition.SelectedIndex = (int)key.GetValue("BGImagePosition");
            }

            //load the main menu settings
            if (key.GetValue("noMainMenu") != null)
            {
                // The value exists; load the data that stored in the registry.
                int nState = 0;

                nState = (int)key.GetValue("noMainMenu");
                if (nState == 1)
                {
                    chk_showMainMenu.Checked = false;
                }
            }

            //load the Backup settings
            if (key.GetValue("backupPath") != null)
            {
                tbx_backupPath.Text =(string) key.GetValue("backupPath");                
            }

            //load the 'showPicsInTheSameDirectoryDelaySeconds' settings
            if (key.GetValue("delaySeconds") != null)
            {
                int seconds = (int)key.GetValue("delaySeconds");
                if (seconds == 1)
                {
                    num_seconds.Value = 10;
                    chk_showSamePathPic.Checked = false;
                }
                else if (seconds > 1)
                {
                    num_seconds.Value = seconds;
                    chk_showSamePathPic.Checked = true;
                }
            }
            key.Close();

            key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference");

            //load reminder settings
            if (key.GetValue("reminderSoundPath") != null && (string)key.GetValue("reminderSoundPath") != "")
            {
                tbx_reminderSoundPath.Text = (string)key.GetValue("reminderSoundPath");
            }
            else
            {
                chk_playSoundOnTime.Checked = false;
            }            

            //load the bank settings
            if (key.GetValue("bankPath") != null)
            {
                tbx_bankPath.Text = (string)key.GetValue("bankPath");
                sBankPath = tbx_bankPath.Text;
            }
            showMessageOnBankTextBox();

            //.................................................
            cmb_imagesNames.SelectedIndex = 0;

            loadUsers();
            //if (sOldPassword.Length > 0)
            //{
            //    tbx_newPass.Enabled = false;
            //    tbx_confirmPass.Enabled = false;
            //}
            //else
            //{
            //    tbx_oldPass.Enabled = false;
            //}
            ////..................................................
            //try
            //{
            //    // by changing the value of Keys.
            //    if (Control.IsKeyLocked(Keys.CapsLock))
            //        label7.Text = "دکمه کاپس لوک فشرده شد";
            //    else
            //        label7.Text = "لطفا سعی کنید گذرواژه را به زبان انگلیسی وارد کنید";
            //}
            //catch
            //{

            //}

        }

        private void cmb_picPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_picPosition.SelectedIndex == 0)
            {
                pictureBox2.Image = pic_sampleScreen.Image;
                pictureBox3.Image = pic_sampleScreen.Image;
                pictureBox4.Image = pic_sampleScreen.Image;
                pictureBox5.Image = pic_sampleScreen.Image;

                pnl_tile.Visible = true;

            }
            else if (cmb_picPosition.SelectedIndex == 1)
            {
                pnl_tile.Visible = false;
                pic_sampleScreen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (cmb_picPosition.SelectedIndex == 2)
            {
                pnl_tile.Visible = false;
                pic_sampleScreen.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (limitString[1] == '0')//limitString[1] == allow edit data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveBGSettings();
            saveBackupSettings();
            saveReminderSettings();
            saveBankSettings();
            if(savePasswordSettings())
                this.Close();
        }

        private void chk_showSamePathPic_CheckedChanged(object sender, EventArgs e)
        {
            if (limitString[12] == '0')//limitString[12] == allow change bg
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            num_seconds.Enabled = chk_showSamePathPic.Checked;
            pnl_delayGroup.Enabled = chk_showSamePathPic.Checked;
        }

        private void tbx_oldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_selectPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[12] == '0')//limitString[12] == allow change bg
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ofd_pic.InitialDirectory = Application.StartupPath + "\\pix";
                ofd_pic.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd_pic.FileName = "";
                if (ofd_pic.ShowDialog() == DialogResult.OK)
                {
                    pic_sampleScreen.Image = Image.FromFile(ofd_pic.FileName);
                    tbx_path.Text = ofd_pic.FileName;
                    cmb_picPosition.SelectedIndex = 1;//stretch
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_preference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                //try
                //{
                //    // by changing the value of Keys.
                //    if(Control.IsKeyLocked(Keys.CapsLock))
                //        label7.Text = "دکمه کاپس لوک فشرده شد";
                //    else
                //        label7.Text = "لطفا سعی کنید گذرواژه را به زبان انگلیسی وارد کنید";
                //}
                //catch
                //{
                    
                //}
            }
        }

        private void btn_browseBackupPath_Click(object sender, EventArgs e)
        {
            if (tbx_backupPath.Text != "")
            {
                fbd_.SelectedPath = tbx_backupPath.Text;
            }
            if (fbd_.ShowDialog() == DialogResult.OK)
            {
                    tbx_backupPath.Text = fbd_.SelectedPath;
            }

        }

        private void btn_runReminder_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_runReminder.Tag == null)
                {
                    myProcess.StartInfo.FileName = Application.StartupPath + "\\reminder.exe";
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    myProcess.Start();
                    btn_runReminder.Tag = "run";
                }
                else if ((string)btn_runReminder.Tag == "run")
                {
                    MessageBox.Show("برنامه یادآورنده در حال اجرا است");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chk_playSoundOnTime_CheckedChanged(object sender, EventArgs e)
        {
            pnl_playSound.Enabled = chk_playSoundOnTime.Checked;
        }

        private void btn_selectSound_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ofd_pic.FileName = "";
                ofd_pic.InitialDirectory = Application.StartupPath + "\\wav";                
                ofd_pic.Filter = "Wave Files only(*.WAV)|*.WAV";
                if (ofd_pic.ShowDialog() == DialogResult.OK)
                {
                    tbx_reminderSoundPath.Text = ofd_pic.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                sound = new System.Media.SoundPlayer(tbx_reminderSoundPath.Text);
                sound.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_preference_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                sound.Stop();
            }
            catch
            {
            }
            if (tbx_bankPath.Text != sBankPath && tbx_bankPath.Text != "%app Path%" && sBankPath != "")
            {
                MessageBox.Show("به علت تغییر مسیر بانک برنامه نیاز به بسته شدن دارد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chk_runReminderAtStartup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sound.Stop();
            }
            catch
            {
            }
        }

        private void btn_brosweTheBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbx_bankPath.Text != "")
                {
                    fbd_.SelectedPath = tbx_bankPath.Text;
                }
                if (fbd_.ShowDialog() == DialogResult.OK)
                {
                    tbx_bankPath.Text = fbd_.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_bankPath_TextChanged(object sender, EventArgs e)
        {
            tbx_bankPath.ForeColor = Color.Black;
            if (tbx_bankPath.Text == "%app Path%")
            {
                tbx_bankPath.ForeColor = Color.Silver;
            }                        
        }

        private void tbx_bankPath_Leave(object sender, EventArgs e)
        {
            showMessageOnBankTextBox();
        }

        private void tbx_bankPath_Enter(object sender, EventArgs e)
        {
            hideMessageOnBankTextBox();
        }

        private void btn_browseBackupPath_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbx_backupPath.Text != "")
                {
                    fbd_.SelectedPath = tbx_backupPath.Text;
                }
                if (fbd_.ShowDialog() == DialogResult.OK)
                {
                    tbx_backupPath.Text = fbd_.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void lnk_createUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sUserName = "";            
            try
            {
                if (limitString[0] == '0')//limitString[0] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frm_getString frmGet = new frm_getString();
                frmGet.tbx_.RightToLeft = RightToLeft.Yes;
                frmGet.ShowDialog();
                if (frmGet.tbx_.Text != "")
                {
                    sUserName = frmGet.tbx_.Text;

                    SqlCommand sql = new SqlCommand();
                    sql.CommandText = "insert into usersTable(user_name, user_picIndex, user_limitType, user_limitString) values(@user_name, @user_picIndex, @user_limitType, @user_limitString);";
                    sql.Connection = new SqlConnection(connectionString);
                    sql.Parameters.AddWithValue("@user_name", sUserName);
                    sql.Parameters.AddWithValue("@user_picIndex", cmb_imagesNames.SelectedIndex);
                    sql.Parameters.AddWithValue("@user_limitType", 2);//کاربر عادی
                    sql.Parameters.AddWithValue("@user_limitString", "1;0;0;1;1;1;1;1;1;1;1;0;1;0");

                    sql.Connection.Open();
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();

                    refreshTheUsersTableDataset();
                    loadUsers();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       

        private void chkLst_Allocations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                cmb_accountType.SelectedIndex = 3;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void cmb_accountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmb_accountType.SelectedIndex == 0)
                {
                    if (limitString[13] == '0')
                    {
                        MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_accountType.SelectedIndex = 1;
                        return;
                    }
                    for (int i = 0; i < chkLst_Allocations.Items.Count; i++)
                    {
                        chkLst_Allocations.SetItemChecked(i, true);
                        Application.DoEvents();
                    }
                    cmb_accountType.SelectedIndex = 0;
                }
                else if (cmb_accountType.SelectedIndex == 1)
                {
                    for (int i = 0; i < chkLst_Allocations.Items.Count; i++)
                    {
                        chkLst_Allocations.SetItemChecked(i, true);
                        Application.DoEvents();
                    }
                    chkLst_Allocations.SetItemChecked(11, false);
                    chkLst_Allocations.SetItemChecked(13, false);
                    cmb_accountType.SelectedIndex = 1;
                }
                else if (cmb_accountType.SelectedIndex == 2)
                {
                    for (int i = 0; i < chkLst_Allocations.Items.Count; i++)
                    {
                        chkLst_Allocations.SetItemChecked(i, true);
                        Application.DoEvents();
                    }
                    chkLst_Allocations.SetItemChecked(1, false);
                    chkLst_Allocations.SetItemChecked(2, false);
                    chkLst_Allocations.SetItemChecked(11, false);
                    chkLst_Allocations.SetItemChecked(13, false);
                    cmb_accountType.SelectedIndex = 2;
                }
                else if (cmb_accountType.SelectedIndex == 3)
                {
                }

                //Save The LimitString Into The Dataset
                if (listView_users.SelectedIndices.Count > 0)
                {
                    string sLimitString = buildTheLimitString();
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitString"] = sLimitString; ;
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitType"] = cmb_accountType.SelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count == 0)
                {
                    pnl_userProp.Enabled = false;
                    pnl_userManagment.Enabled = false;
                }
                else
                {
                    //select user properties
                    pnl_userProp.Enabled = true;
                    pnl_userManagment.Enabled = true;                    
                    
                    //if the 'programmer user' has selected
                    if (pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitType"].ToString() == "0" && limitString[13] == '0')
                    {
                        pnl_userProp.Enabled = false;
                        pnl_userManagment.Enabled = false;
                    }
                    
                    //if the 'current active user' selected
                    if (this.n_userID == (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_id"])
                    {
                        cmb_accountType.Enabled = false;
                        chkLst_Allocations.Enabled = false;
                    }
                    else
                    {
                        int nSelectedUserLimitType = (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitType"];
                        int nCurrentActiveUserLimitType = (int)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Find("user_id", this.n_userID)]["user_limitType"];

                        if (nSelectedUserLimitType >= nCurrentActiveUserLimitType || nSelectedUserLimitType == 3 || nCurrentActiveUserLimitType == 3)
                        {
                            cmb_accountType.Enabled = true;
                            chkLst_Allocations.Enabled = true;
                        }
                    }

                    if (pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picPath"] != DBNull.Value && (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] == cmb_imagesNames.Items.Count - 1)
                    {
                        cmb_imagesNames.SelectedIndex = cmb_imagesNames.Items.Count - 1;
                    }
                    else
                    {
                        cmb_imagesNames.SelectedIndex = (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picIndex"];
                    }

                    applayTheLimitString();

                    cmb_accountType.SelectedIndex = (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitType"];

                    if (pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_password"] != DBNull.Value)
                    {
                        lnk_managePassword.Text = "تغییر یا حذف گذرواژه";
                    }
                    else
                    {
                        lnk_managePassword.Text = "ایجاد گذرواژه";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_imagesNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count > 0)
                {
                    listView_users.Items[listView_users.SelectedIndices[0]].ImageIndex = cmb_imagesNames.SelectedIndex;
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] = cmb_imagesNames.SelectedIndex;
                    if (cmb_imagesNames.SelectedIndex < cmb_imagesNames.Items.Count - 1)
                    {
                        pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picPath"] = DBNull.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkLst_Allocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((chkLst_Allocations.GetItemChecked(11) || chkLst_Allocations.GetItemChecked(13)) && limitString[13] == '0')
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkLst_Allocations.SetItemChecked(11, false);
                chkLst_Allocations.SetItemChecked(13, false);
                return;
            }
            //Save The LimitString Into The Dataset
            if (listView_users.SelectedIndices.Count > 0)
            {
                string sLimitString = buildTheLimitString();
                pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitString"] = sLimitString; ;
                pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_limitType"] = 3;
            }
        }

        private void lnk_renameUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            try
            {
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (listView_users.SelectedIndices.Count > 0)
                {
                    string sUserID = pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_id"].ToString();

                    frm_getString frmGet = new frm_getString();
                    frmGet.tbx_.RightToLeft = RightToLeft.Yes;
                    frmGet.tbx_.Text = pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_name"].ToString();
                    frmGet.ShowDialog();
                    if (frmGet.tbx_.Text != "")
                    {                       
                        SqlCommand sql = new SqlCommand();
                        sql.CommandText = "update usersTable set user_name = @NewUser_name where user_id = @user_id;";
                        sql.Connection = new SqlConnection(connectionString);
                        sql.Parameters.AddWithValue("@user_id", sUserID);
                        sql.Parameters.AddWithValue("@NewUser_name", frmGet.tbx_.Text);                        
                        sql.Connection.Open();
                        sql.ExecuteNonQuery();
                        sql.Connection.Close();

                        refreshTheUsersTableDataset();
                        loadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_deleteUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (limitString[2] == '0')//limitString[2] == allow delete data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.n_userID == (int)pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_id"])
                {
                    MessageBox.Show("شما نمی توانید یک حساب کاربری را از خودش حذف کنید");
                    return;
                }

                if (listView_users.SelectedIndices.Count > 0)
                {
                    if (MessageBox.Show("آیا از حذف کردن حساب کاربری موردنظر مطمئنید ؟", "حذف کردن حساب کاربری", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string sUserID = pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_id"].ToString();

                        SqlCommand sql = new SqlCommand();
                        sql.CommandText = "delete from usersTable where user_id = @user_id;";
                        sql.Connection = new SqlConnection(connectionString);
                        sql.Parameters.AddWithValue("@user_id", sUserID);
                        sql.Connection.Open();
                        sql.ExecuteNonQuery();
                        sql.Connection.Close();

                        refreshTheUsersTableDataset();
                        loadUsers();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_managePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            frm_setPassword frmSetPass = new frm_setPassword();
            
            if (pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_password"] != DBNull.Value)
            {
                frmSetPass.s_oldPassword = pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_password"].ToString();
            }

            if (frmSetPass.ShowDialog() == DialogResult.OK)
            {
                if (frmSetPass.tbx_confirmNewPass.Text == "")
                {
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_password"] = DBNull.Value;
                    MessageBox.Show("گذرواژه حذف شد", "تنظیم گذرواژه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_password"] = frmSetPass.tbx_confirmNewPass.Text;
                }
            }
        }

        private void lnk_browseForPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ofd_pic.InitialDirectory = Application.StartupPath + "\\pix";
                ofd_pic.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
                ofd_pic.FileName = "";
                if (ofd_pic.ShowDialog() == DialogResult.OK)
                {
                    imageList1.Images.Add(Image.FromFile(ofd_pic.FileName));

                    cmb_imagesNames.SelectedIndex = cmb_imagesNames.Items.Count - 1;
                    listView_users.SelectedItems[0].ImageIndex = imageList1.Images.Count - 1;

                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picPath"] = ofd_pic.FileName;
                    pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] = cmb_imagesNames.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chk_showMainMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (limitString[12] == '0')//limitString[12] == allow change bg
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }       
    }
}
