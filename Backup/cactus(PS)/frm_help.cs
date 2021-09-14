using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Win32;

namespace cactus_PS_
{
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
        }
        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }
        string[] sHelpLines;
        string sHelpText = "",sPrevFunc="";

        private string readTheFile()
        {
            try
            {
                string sText = File.ReadAllText(Application.StartupPath + "\\helpTool.inf");
                string[] sLines;
                string sFuncName = "";
                sLines = sText.Split('\n');

                foreach (string sLine in sLines)
                {
                    if (sLine.StartsWith("function"))
                    {
                        sFuncName = sLine.Substring(sLine.IndexOf('\"') + 1, sLine.LastIndexOf('\"') - sLine.IndexOf('\"') - 1);
                        return sFuncName;                        
                    }
                }
            }
            catch
            {
            }
            return "";
        }

        private void refreshTheDetailsDataset()
        {
            try
            {
                viw_detailsTableAdapter.Adapter.SelectCommand = new SqlCommand("SELECT        dbo.detailsTable.spentMasterID, dbo.detailsTable.detailID, dbo.spentMaster.spentMasterName + ' ' + dbo.detailsTable.detail_name AS fullDetailName FROM dbo.spentMaster INNER JOIN dbo.detailsTable ON dbo.spentMaster.spentMasterID = dbo.detailsTable.spentMasterID WHERE(spentMaster.spentMaster_detailType <> 0)");
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                viw_detailsTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.viw_details.Clear();
                viw_detailsTableAdapter.Adapter.Fill(pSDatabase5DataSet.viw_details);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                viw_detailsTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void frm_help_Load(object sender, EventArgs e)
        {
            refreshTheDetailsDataset();

            try
            {
                File.Delete(Application.StartupPath + "\\helpTool.inf");

                sHelpText = File.ReadAllText(Application.StartupPath + "\\help.inf");
                sHelpLines = sHelpText.Split('\n');

                this.WindowState = FormWindowState.Normal;
                this.Left = 0;
                this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20;
            }
            catch
            {
            }
        }

        private void tmr_move_Tick(object sender, EventArgs e)
        {
            string sFunc = readTheFile();
            try
            {
                if (sFunc == "" && sPrevFunc == "")
                {
                    lbl_hints.Text = sHelpLines[0];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accounts" && lbl_hints.Text != sHelpLines[1] && sPrevFunc == "")
                {
                    lbl_hints.Text = sHelpLines[1];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accounts_closed" && lbl_hints.Text != sHelpLines[2] && sPrevFunc == "accounts")
                {
                    lbl_hints.Text = sHelpLines[2];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "projects" && lbl_hints.Text != sHelpLines[3] && sPrevFunc == "accounts_closed")
                {
                    lbl_hints.Text = sHelpLines[3];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "projects_expand" && lbl_hints.Text != sHelpLines[4] && sPrevFunc == "projects")
                {
                    lbl_hints.Text = sHelpLines[4];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "projects_new" && lbl_hints.Text != sHelpLines[5] && sPrevFunc == "projects_expand")
                {
                    lbl_hints.Text = sHelpLines[5];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "projects_closed" && lbl_hints.Text != sHelpLines[6] && sPrevFunc == "projects_new")
                {
                    lbl_hints.Text = sHelpLines[6];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "persons" && lbl_hints.Text != sHelpLines[7] && sPrevFunc == "projects_closed")
                {
                    lbl_hints.Text = sHelpLines[7];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "persons_new" && lbl_hints.Text != sHelpLines[8] && sPrevFunc == "persons")
                {
                    lbl_hints.Text = sHelpLines[8];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "persons_ok" && lbl_hints.Text != sHelpLines[9] && sPrevFunc == "persons_new")
                {
                    lbl_hints.Text = sHelpLines[9];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "persons_closed" && lbl_hints.Text != sHelpLines[10] && sPrevFunc == "persons_ok")
                {
                    lbl_hints.Text = sHelpLines[10];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "smallLedger" && lbl_hints.Text != sHelpLines[11] && sPrevFunc == "persons_closed")
                {
                    lbl_hints.Text = sHelpLines[11];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "smallLedger_closed" && lbl_hints.Text != sHelpLines[12] && sPrevFunc == "smallLedger")
                {
                    lbl_hints.Text = sHelpLines[12];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "pensions" && lbl_hints.Text != sHelpLines[13] && sPrevFunc == "smallLedger_closed")
                {
                    lbl_hints.Text = sHelpLines[13];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "pensions_new" && lbl_hints.Text != sHelpLines[14] && sPrevFunc == "pensions")
                {
                    lbl_hints.Text = sHelpLines[14];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "pensions_ok" && lbl_hints.Text != sHelpLines[15] && sPrevFunc == "pensions_new")
                {
                    lbl_hints.Text = sHelpLines[15];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "cheques" && lbl_hints.Text != sHelpLines[16] && sPrevFunc == "pensions_ok")
                {
                    lbl_hints.Text = sHelpLines[16];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "cheques_ok" && lbl_hints.Text != sHelpLines[17] && sPrevFunc == "cheques")
                {
                    lbl_hints.Text = sHelpLines[17];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "issuse_ok" && lbl_hints.Text != sHelpLines[18] && sPrevFunc == "cheques_ok")
                {
                    lbl_hints.Text = sHelpLines[18];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "pensions_closed" && lbl_hints.Text != sHelpLines[19] && sPrevFunc == "issuse_ok")
                {
                    lbl_hints.Text = sHelpLines[19];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs" && lbl_hints.Text != sHelpLines[20] && sPrevFunc == "pensions_closed")
                {
                    lbl_hints.Text = sHelpLines[20];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_print" && lbl_hints.Text != sHelpLines[21] && sPrevFunc == "accDocs")
                {
                    lbl_hints.Text = sHelpLines[21];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_print_closed" && lbl_hints.Text != sHelpLines[22] && sPrevFunc == "accDocs_print")
                {
                    lbl_hints.Text = sHelpLines[22];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_new" && lbl_hints.Text != sHelpLines[23] && sPrevFunc == "accDocs_print_closed")
                {
                    lbl_hints.Text = sHelpLines[23];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_row" && lbl_hints.Text != sHelpLines[24] && sPrevFunc == "accDocs_new")
                {
                    lbl_hints.Text = sHelpLines[24];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_row_selected" && lbl_hints.Text != sHelpLines[25] && sPrevFunc == "accDocs_row")
                {
                    lbl_hints.Text = sHelpLines[25];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_row_closed" && lbl_hints.Text != sHelpLines[26] && sPrevFunc == "accDocs_row_selected")
                {
                    lbl_hints.Text = sHelpLines[26];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_ok" && lbl_hints.Text != sHelpLines[27] && sPrevFunc == "accDocs_row_closed")
                {
                    lbl_hints.Text = sHelpLines[27];
                    sPrevFunc = sFunc;
                }
                else if (sFunc == "accDocs_closed" && lbl_hints.Text != sHelpLines[28] && sPrevFunc == "accDocs_ok")
                {
                    lbl_hints.Text = sHelpLines[28];
                    sPrevFunc = sFunc;
                }
                else if (sPrevFunc == "accDocs_closed")
                {
                    chk_dontShowAgain.Checked = true;
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void chk_dontShowAgain_CheckedChanged(object sender, EventArgs e)
        {
            //Save The current Project ID To The Rigestry
            try
            {
                int stat = 0;
                if (chk_dontShowAgain.Checked)
                {
                    stat = 1;
                }
                // Open the key
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\Cactus_PS\\General", true);
                key.SetValue("noMoreHelp", stat, RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }
            
        }

        private void frm_help_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void frm_help_Activated(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = 1;
            }
            catch
            {
            }
        }

        private void frm_help_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = .80;
            }
            catch
            {
            }
        }
    }
}
