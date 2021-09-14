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
    public partial class frm_manageSpentDefs : Form
    {

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

        public frm_manageSpentDefs()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refreshDefSpentsDataset()
        {
            try
            {
                spentDefTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentDefTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);

                if (spentMasterBindingSource.Count == 0) return;

                int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[cmb_masterSpentName.SelectedIndex]["spentMasterID"];                

                spentDefTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentDef WHERE spentMasterID = @nSpentMasterID;";
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentDefTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);                
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Open();
                pSDatabase5DataSet.spentDef.Clear();
                spentDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentDef);                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentDefTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }
        private void refreshMasterSpentsDataset()
        {
            try
            {
                spentMasterTableAdapter.Adapter.SelectCommand = new SqlCommand();
                spentMasterTableAdapter.Adapter.SelectCommand.CommandText = "SELECT * FROM spentMaster;";
                spentMasterTableAdapter.Adapter.SelectCommand.Parameters.Clear();
                spentMasterTableAdapter.Adapter.SelectCommand.Connection = new SqlConnection(connectionString);                
                spentMasterTableAdapter.Adapter.SelectCommand.Connection.Open();

                int pos = spentMasterBindingSource.Position;

                pSDatabase5DataSet.spentMaster.Clear();
                spentMasterTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentMaster);

                spentMasterBindingSource.Position = pos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentMasterTableAdapter.Adapter.SelectCommand.Connection.Close();
            }
        }

        private void addSubSpent(string sDefName)
        {
            try
            {
                int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];

                spentDefTableAdapter.Adapter.InsertCommand = new SqlCommand();
                spentDefTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO spentDef(spentDefName, spentMasterID) VALUES(@sDefSpentName, @nSpentMasterID);";
                spentDefTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                spentDefTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sDefSpentName", sDefName);
                spentDefTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);
                spentDefTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);                
                spentDefTableAdapter.Adapter.InsertCommand.Connection.Open();
                spentDefTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                spentDefTableAdapter.Adapter.InsertCommand.Connection.Close();

                refreshDefSpentsDataset();

                spentDefBindingSource.MoveLast();
            }
        }

        private void frm_manageSpentDefs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSDatabase5DataSet.spentGroupsTable' table. You can move, or remove it, as needed.
            this.spentGroupsTableTableAdapter.Fill(this.pSDatabase5DataSet.spentGroupsTable);
            try
            {                
                refreshMasterSpentsDataset();
                refreshDefSpentsDataset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_newMasterSpent_Click(object sender, EventArgs e)
        {
            if (limitString[0] == '0')//limitString[0] == allow enter data
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            frm_getString frmGetString = new frm_getString();
            frmGetString.ShowDialog();

            if(frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    try
                    {
                        spentMasterTableAdapter.Adapter.InsertCommand = new SqlCommand();
                        spentMasterTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO spentMaster(spentMasterName, spentMaster_detailType, spentGroup_id, spentMaster_kind, spentMaster_required) VALUES(@sMasterSpentName, @spentMaster_detailType, @spentGroup_id, @spentMaster_kind, 0);";
                        spentMasterTableAdapter.Adapter.InsertCommand.Parameters.Clear();
                        spentMasterTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@spentMaster_detailType", 1);//1 = projects (default)
                        spentMasterTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@spentGroup_id", 1);
                        spentMasterTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@spentMaster_kind", 1);
                        spentMasterTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sMasterSpentName", frmGetString.tbx_.Text);
                        spentMasterTableAdapter.Adapter.InsertCommand.Connection = new SqlConnection(connectionString);                        
                        spentMasterTableAdapter.Adapter.InsertCommand.Connection.Open();
                        spentMasterTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        spentMasterTableAdapter.Adapter.InsertCommand.Connection.Close();
                        
                        refreshMasterSpentsDataset();

                        spentMasterBindingSource.MoveLast();

                        //addSubSpent(frmGetString.tbx_.Text);

                        ////////////////////s
                        int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];
                        numberConvertor.createDetailViaSpentMaster(nSpentMasterID, this.connectionString);

                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyMasterSpent_Click(object sender, EventArgs e)
        {
            
            if ((bool)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMaster_required"] && limitString[13] == '0')//limitString[13] == allow change spents data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            
            frm_getString frmGetString = new frm_getString();
            frmGetString.tbx_.Text = cmb_masterSpentName.Text;
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    int nSpentMasterID =(int) pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];

                    try
                    {
                        spentMasterTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                        spentMasterTableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE spentMaster SET spentMasterName = @sUpdatedSpentMasterName WHERE spentMasterID = @nSpentMasterID;";
                        spentMasterTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                        spentMasterTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedSpentMasterName", frmGetString.tbx_.Text);
                        spentMasterTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);
                        spentMasterTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                        
                        spentMasterTableAdapter.Adapter.UpdateCommand.Connection.Open();
                        spentMasterTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                        //pSDatabase5DataSet.spentMaster.Clear();
                        //spentMasterTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentMaster);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        spentMasterTableAdapter.Adapter.UpdateCommand.Connection.Close();
                        pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterNAme"] = frmGetString.tbx_.Text;
                        //refreshMasterSpentsDataset();
                    }
                }
            }
        }

        private void btn_deleteMasterSpent_Click(object sender, EventArgs e)
        {
            if ((bool)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMaster_required"] && limitString[13] == '0')//limitString[13] == allow change spents data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            if (MessageBox.Show("آیا از حذف این هزینه و تمام زیر هزینه ها مطمئنید ؟", "حذف هزینه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];                                        
                                        
                    spentMasterTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    spentMasterTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM spentMaster WHERE spentMasterID = @nSpentMasterID;";
                    spentMasterTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    spentMasterTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentMasterID", nSpentMasterID);
                    spentMasterTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //spentMasterTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    spentMasterTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    spentMasterTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    MessageBox.Show("نمی توانید این هزینه را حذف کنید زیرا این هزینه در سندی استفاده شده است");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    spentMasterTableAdapter.Adapter.DeleteCommand.Connection.Close();
                    refreshMasterSpentsDataset();
                }
            }
        }

        private void btn_defineNewSubSpent_Click(object sender, EventArgs e)
        {
            frm_getString frmGetString = new frm_getString();
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    addSubSpent(frmGetString.tbx_.Text);                    
                }
            }
        }

        private void btn_renameSubSpent_Click(object sender, EventArgs e)
        {
            frm_getString frmGetString = new frm_getString();
            frmGetString.tbx_.Text = lst_subSpents.Text;
            frmGetString.ShowDialog();

            if (frmGetString.OkClicked)
            {
                if (frmGetString.tbx_.Text != "")
                {
                    int nSpentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];

                    try
                    {
                        spentDefTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                        spentDefTableAdapter.Adapter.UpdateCommand.CommandText = "UPDATE spentDef SET spentDefName = @sUpdatedSpentDefName WHERE spentDefID = @nSpentDefID;";
                        spentDefTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
                        spentDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sUpdatedSpentDefName", frmGetString.tbx_.Text);
                        spentDefTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nSpentDefID", nSpentDefID);
                        spentDefTableAdapter.Adapter.UpdateCommand.Connection = new SqlConnection(connectionString);                        
                        spentDefTableAdapter.Adapter.UpdateCommand.Connection.Open();
                        spentDefTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                        //pSDatabase5DataSet.spentDef.Clear();
                        //spentDefTableAdapter.Adapter.Fill(pSDatabase5DataSet.spentDef);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        spentDefTableAdapter.Adapter.UpdateCommand.Connection.Close();
                        pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefNAme"] = frmGetString.tbx_.Text;
                        //refreshMasterSpentsDataset();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (spentDefBindingSource.Count == 1)
            {
                if (MessageBox.Show("شما نمی توانید این زیر گروه را حذف کنید ،آیا مایلید که این زیر گروه را تغییر نام دهید؟", "حذف زیر گروه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    btn_renameSubSpent_Click(sender, e);
                }
                return;
            }
            if (MessageBox.Show("آیا از حذف این زیر گروه مطمئنید ؟", "حذف زیر گروه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {

                    int nSpentDefID = (int)pSDatabase5DataSet.spentDef.Rows[spentDefBindingSource.Position]["spentDefID"];

                    spentDefTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                    spentDefTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM spentDef WHERE spentDefID = @nSpentDefID;";
                    spentDefTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                    spentDefTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nSpentDefID", nSpentDefID);
                    spentDefTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);                    
                    spentDefTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    spentDefTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    MessageBox.Show("این زیر گروه را نمی توانید حذف کنید");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    spentDefTableAdapter.Adapter.DeleteCommand.Connection.Close();
                    refreshDefSpentsDataset();
                }
            }
        }

        private void cmb_masterSpentName_SelectedValueChanged(object sender, EventArgs e)
        {
            
            refreshDefSpentsDataset();
        }

        private void cmb_masterSpentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_masterSpentName_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void cmb_masterSpentName_KeyUp(object sender, KeyEventArgs e)
        {
            refreshDefSpentsDataset();
        }

        private void spentMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_detailType.SelectedIndex = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMaster_detailType"];                
                cmb_spentKind.SelectedIndex = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMaster_kind"];

                if (cmb_spentGroupKind.SelectedIndex == 5)
                {
                    grp_spentsDefins.Enabled = true;
                }
                else
                {
                    grp_spentsDefins.Enabled = false;
                }
            }
            catch
            {                
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if ((bool)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMaster_required"] && limitString[13] == '0')//limitString[13] == allow change spents data
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            SqlCommand sql = new SqlCommand("update spentMaster set spentMaster_detailType = @detailType, spentGroup_id = @group_id, spentMaster_kind = @kind where spentMasterID = @spentMasterID;");
            try
            {
                int nSpentMasterID = (int)pSDatabase5DataSet.spentMaster.Rows[spentMasterBindingSource.Position]["spentMasterID"];
                int nGroupID = (int)pSDatabase5DataSet.spentGroupsTable.Rows[spentGroupsTableBindingSource.Position]["spentGroup_id"];

                sql.Connection = new SqlConnection(connectionString);
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);
                sql.Parameters.AddWithValue("@detailType", cmb_detailType.SelectedIndex);
                sql.Parameters.AddWithValue("@kind", cmb_spentKind.SelectedIndex);
                sql.Parameters.AddWithValue("@group_id", nGroupID);
                sql.Connection.Open();
                sql.ExecuteNonQuery();

                numberConvertor.createDetailViaSpentMaster(nSpentMasterID, connectionString);

                refreshMasterSpentsDataset();
            }
            catch
            {
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
