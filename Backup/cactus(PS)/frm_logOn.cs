using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace cactus_PS_
{
    public partial class frm_logOn : Form
    {
        public frm_logOn()
        {
            InitializeComponent();
        }

        public int n_userID;

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }

        private void refreshTheUsersTableDataset()
        {
            try
            {
                usersTableTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from usersTable;");//select all users except 'Programmer'
                usersTableTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);
                usersTableTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.usersTable.Clear();
                usersTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.usersTable);
                usersTableTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadUsers()
        {
            try
            {
                listView_users.Clear();
                for (int i = 0; i < lbx_users.Items.Count; i++)
                {
                    if (pSDatabase5DataSet.usersTable.Rows[i]["user_limitType"].ToString() != "0")
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
                            listView_users.Items[i-1].ImageIndex = imageList1.Images.Count - 1;
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void frm_logOn_Load(object sender, EventArgs e)
        {
            refreshTheUsersTableDataset();
            loadUsers();
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count == 0)
                {                    
                    tbx_userName.Text = "";
                }
                else
                {
                    tbx_userName.Text = pSDatabase5DataSet.usersTable.Rows[listView_users.SelectedIndices[0]+1]["user_name"].ToString();                                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(2000);
            }
            catch
            {
            }
        }

        private void frm_logOn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    int pos = usersTableBindingSource.Find("user_name", tbx_userName.Text); 
                    if(pos > -1)
                    {
                        usersTableBindingSource.Position = pos;
                        if (pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_password"] != DBNull.Value)
                        {
                            if (tbx_password.Text != pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_password"].ToString())
                            {
                                e.Cancel = true;
                                tbx_password.Text = "";
                            }
                            else
                            {
                                n_userID = (int)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_id"];
                            }
                        }
                        else
                        {
                            n_userID = (int)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_id"];
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbx_userName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = usersTableBindingSource.Find("user_name", tbx_userName.Text);
                if (pos > -1)
                {
                    btn_ok.Enabled = true;
                    if (pSDatabase5DataSet.usersTable.Rows[pos]["user_password"] != DBNull.Value)
                    {
                        pnl_Password.Visible = true;
                    }
                    else
                    {
                        pnl_Password.Visible = false;
                    }
                }
                else
                {
                    btn_ok.Enabled = false;
                    pnl_Password.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_logOn_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
