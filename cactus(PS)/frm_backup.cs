using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;
using System.Diagnostics;

namespace cactus_PS_
{
    public partial class frm_backup : Form
    {
        private string sBankPath = "", sBackupPath = "";
        public bool dontStartAgain = false;

        public frm_backup()
        {
            InitializeComponent();
        }

        private string s_limitString;
        public string limitString
        {
            get { return s_limitString; }
            set { s_limitString = value; }
        }

        private string buildTheBackupName()
        {
            string sZipFileName = "";
            try
            {
                sZipFileName = numberConvertor.nowDateInAppropriateFormat().Substring(2);
                sZipFileName = sZipFileName.Replace("/", "_");
                sZipFileName = sZipFileName.Replace(":", ";");
                sZipFileName += ".zip";                
            }
            catch
            {
            }
            return sZipFileName;
        }

        private void btn_saveBackup_Click(object sender, EventArgs e)
        {
            sfd_backup.InitialDirectory = sBackupPath;
            sfd_backup.Filter = "only zip files(*.zip)|*.zip";
            sfd_backup.FileName = buildTheBackupName();
            if (sfd_backup.ShowDialog() != DialogResult.Cancel)
            {
                tbx_backup.Text = sfd_backup.FileName;
                tbx_backup.Text = tbx_backup.Text.ToLower();
                if (!tbx_backup.Text.EndsWith(".zip"))
                {
                    tbx_backup.Text += ".zip";
                }                
            }
        }

        private void frm_backup_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\Preference");

                //load the Backup settings
                if (key.GetValue("backupPath") != null)
                {
                    sBackupPath = (string)key.GetValue("backupPath");
                    tbx_backup.Text = sBackupPath;                    
                    tbx_backup.Text += buildTheBackupName();
                }
                //load the bank settings
                if (key.GetValue("bankPath") != null)
                {
                    sBankPath = (string)key.GetValue("bankPath");
                    if (sBankPath == "%app Path%")
                    {
                        sBankPath = Application.StartupPath;
                    }
                }
                key.Close();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_provideBackup_Click(object sender, EventArgs e)
        {
            try
            {                
                this.DialogResult = DialogResult.Cancel;
                if (limitString[0] == '0')//limitString[0] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbx_backup.Text != "")
                {
                    if (Directory.Exists(sBackupPath) || sBackupPath == "")
                    {
                        string sFileText = "";
                        sFileText = "[bak]" + "\r\nzip=\"" + tbx_backup.Text + "\"\r\npara=\"" + Application.StartupPath + "\\PSDb.mdf" + " " + Application.StartupPath + "\\PSDb_log.ldf\"\r\n";
                        if (!dontStartAgain)
                        {
                            sFileText += "run=\"" + Application.StartupPath + "\\cactus(ps).exe\"\r\n";
                        }

                        string sBackupName = tbx_backup.Text;

                        File.WriteAllText(Application.StartupPath + "\\bup.inf", sFileText);

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("مسیر وارد شده وجود ندارد");                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_browseBackup_Click(object sender, EventArgs e)
        {
            ofd_backup.InitialDirectory = sBackupPath;
            ofd_backup.Filter = "only zip files(*.zip)|*.zip";
            ofd_backup.FileName = sBackupPath;
            if (ofd_backup.ShowDialog() != DialogResult.Cancel)
            {
                tbx_restore.Text = ofd_backup.FileName;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            try
            {                
                this.DialogResult = DialogResult.Cancel;
                if (limitString[1] == '0')//limitString[1] == allow edit data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbx_restore.Text != "")
                {
                    if (File.Exists(tbx_restore.Text))
                    {
                        string sFileText = "";
                        sFileText = "[res]" + "\r\nzip=\"" + tbx_restore.Text + "\"\r\npara=\"" + Application.StartupPath + "\\ -o\"\r\n";
                        sFileText += "run=\"" + Application.StartupPath + "\\cactus(ps).exe\"\r\n";

                        string sBackupName = tbx_backup.Text;

                        File.WriteAllText(Application.StartupPath + "\\bup.inf", sFileText);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("فایل پشتیبانی موجود نمی باشد");                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     
        
    }
}
