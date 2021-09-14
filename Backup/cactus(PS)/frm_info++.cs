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
    public partial class frm_info : Form
    {
        private string filterString;
        private DataSet dSet = new DataSet();
        private BindingSource bindingSource = new BindingSource();

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }


        public frm_info()
        {
            filterString = "";
            connectionString = "";

            InitializeComponent();
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
                    //personsTableTableAdapter.Adapter.UpdateCommand.Connection = connection;
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
                    //personsTableTableAdapter.Adapter.InsertCommand.Connection = connection;
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
                try
                {
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection = new SqlConnection(connectionString);
                    //personsTableTableAdapter.Adapter.DeleteCommand.Connection = connection;
                    personsTableTableAdapter.Adapter.DeleteCommand.CommandText = sqlStatment;
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection.Open();
                    personsTableTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    pSDatabase5DataSet.personsTable.Clear();
                    personsTableTableAdapter.Adapter.Fill(pSDatabase5DataSet.personsTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    personsTableTableAdapter.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        private void refreshAndViewThePersonsTable(string sWhere)
        {
            string sFilterString = "SELECT * FROM personsTable";

            if (sWhere.Length > 0)
                sFilterString += " WHERE " + sWhere + ";";
            else
                sFilterString += ";";

            personsTableTableAdapter.Adapter.SelectCommand = new SqlCommand();
            personsTableTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            runSQLCommand(sFilterString);            
        }

        private void frm_info_Load(object sender, EventArgs e)
        {            
            refreshAndViewThePersonsTable("");
            
            //select the first item in the combobox
            cmb_searchBy.SelectedIndex = 0;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int nPersonID = 0, nOldPos = 0;

            frm_InfoAddOrModify frmINFOAdd = new frm_InfoAddOrModify(true);

            nOldPos = personsTableBindingSource.Position;

            // ... insert Record in the persons Table
            personsTableTableAdapter.Adapter.InsertCommand = new SqlCommand();
            personsTableTableAdapter.Adapter.InsertCommand.Parameters.Clear();
            personsTableTableAdapter.Adapter.InsertCommand.Parameters.AddWithValue("@sFamilyAndName", "طرف حساب جدید");
            runSQLCommand("INSERT INTO personsTable(personFamilyAndName, personForInfoPP) VALUES(@sFamilyAndName, 1);");

            refreshAndViewThePersonsTable("");

            personsTableBindingSource.MoveLast();

            nPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];

            frmINFOAdd.Text = "طرف حساب جدید";
            frmINFOAdd.connectionString = connectionString;
            frmINFOAdd.ShowDialog();

            if (frmINFOAdd.okClicked)
            {
               
                personsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();

                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPersonID", nPersonID);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sFamilyAndName", frmINFOAdd.tbx_familyAndNAme.Text);                
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone1", frmINFOAdd.tbx_phone1.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone2", frmINFOAdd.tbx_phone2.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sVehicleKind", frmINFOAdd.tbx_vehicleKind.Text);
                personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sAddress1", frmINFOAdd.tbx_address1.Text);

                runSQLCommand("UPDATE personsTable SET personFamilyAndName = @sFamilyAndName, personPhone1 = @sPhone1, personPhone2 = @sPhone2, vehicleKind = @sVehicleKind, personAddress1 = @sAddress1 WHERE personID = @nPersonID;");

                refreshAndViewThePersonsTable("");

                personsTableBindingSource.MoveLast();
            }
            else
            {
                personsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nPersonID", nPersonID);

                runSQLCommand("DELETE FROM personsTable WHERE personID = @nPersonID;");

                personsTableBindingSource.Position = nOldPos;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید ؟", "حذف طرف حساب", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if ((bool)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personForInfoPP"] == false)
                {
                    MessageBox.Show("کاربر گرامی این طرف حساب را نمی توانید از برنامه دفترچه تلفن حذف کنید");
                    return;
                }
                int nPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
                
                personsTableTableAdapter.Adapter.DeleteCommand = new SqlCommand();
                personsTableTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                personsTableTableAdapter.Adapter.DeleteCommand.Parameters.AddWithValue("@nPersonID", nPersonID);

                runSQLCommand("DELETE FROM personsTable WHERE personID = @nPersonID AND personForInfoPP = 1;");
            }
        }

        private void btn_doSearch_Click(object sender, EventArgs e)
        {
            filterString = "";
            if (cmb_searchBy.SelectedIndex == 0)//نام و نام خانوادگی
            {
                filterString = "personFamilyAndName LIKE '%" + tbx_key.Text + "%'";
            }
            else if (cmb_searchBy.SelectedIndex == 1)//شماره تلفن
            {
                filterString = "personPhone1 LIKE '%" + tbx_key.Text + "%'";
            }
            else if (cmb_searchBy.SelectedIndex == 2)//همراه
            {
                filterString = "personPhone2 LIKE '%" + tbx_key.Text + "%'";
            }
            else if (cmb_searchBy.SelectedIndex == 3)//سمت
            {
                filterString = "job LIKE '%" + tbx_key.Text + "%'";
            }
            else if (cmb_searchBy.SelectedIndex == 4)//آدرس
            {
                filterString = "personAddress1 LIKE '%" + tbx_key.Text + "%'";
            }
            if (tbx_key.Text == "")
                filterString = "";

            refreshAndViewThePersonsTable(filterString);
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            refreshAndViewThePersonsTable("");
        }

        private void cmb_searchBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_searchBy.SelectedIndex == 0)//نام و نام خانوادگی
            {
                tbx_key.RightToLeft = RightToLeft.Yes;
            }
            else if (cmb_searchBy.SelectedIndex == 1)//شماره تلفن
            {
                tbx_key.RightToLeft = RightToLeft.No;
            }
            else if (cmb_searchBy.SelectedIndex == 2)//همراه
            {
                tbx_key.RightToLeft = RightToLeft.No;
            }
            else if (cmb_searchBy.SelectedIndex == 3)//سمت
            {
                tbx_key.RightToLeft = RightToLeft.Yes;
            }
            else if (cmb_searchBy.SelectedIndex == 4)//آدرس
            {
                tbx_key.RightToLeft = RightToLeft.Yes;
            }
        }

        private void tbx_key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_doSearch_Click(sender, e);
            }
        }

        private void tbx_key_TextChanged(object sender, EventArgs e)
        {
            //these items will filter on text changed
            if (cmb_searchBy.SelectedIndex == 0 || cmb_searchBy.SelectedIndex == 3)//نام و نام خانوادگی و وسیله نقلیه
            {
                btn_doSearch_Click(sender, e);
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if ((bool)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personForInfoPP"] == false)
                {
                    MessageBox.Show("کاربر گرامی این طرف حساب را نمی توانید از برنامه دفترچه تلفن اصلاح کنید");
                    return;
                }

                frm_InfoAddOrModify frmINFOModify = new frm_InfoAddOrModify(false);
                frmINFOModify.connectionString = connectionString;
                frmINFOModify.currentPersonID = (int)pSDatabase5DataSet.personsTable.Rows[personsTableBindingSource.Position]["personID"];
                frmINFOModify.Text = "اصلاح مشخصات طرف حساب";
                frmINFOModify.ShowDialog();
                if (frmINFOModify.okClicked)
                {
                    int nOldPos = personsTableBindingSource.Position;

                    personsTableTableAdapter.Adapter.UpdateCommand = new SqlCommand();
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.Clear();

                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@nPersonID", frmINFOModify.currentPersonID);
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sFamilyAndName", frmINFOModify.tbx_familyAndNAme.Text);
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone1", frmINFOModify.tbx_phone1.Text);
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sPhone2", frmINFOModify.tbx_phone2.Text);
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sJob", frmINFOModify.tbx_vehicleKind.Text);
                    personsTableTableAdapter.Adapter.UpdateCommand.Parameters.AddWithValue("@sAddress1", frmINFOModify.tbx_address1.Text);

                    runSQLCommand("UPDATE personsTable SET personFamilyAndName = @sFamilyAndName, personPhone1 = @sPhone1, personPhone2 = @sPhone2, Job = @sJob, personAddress1 = @sAddress1 WHERE personID = @nPersonID AND personForInfoPP = 1;");

                    refreshAndViewThePersonsTable("");

                    personsTableBindingSource.Position = nOldPos;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)//this means Add new record
            {
                btn_new_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void grid_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_saveChanges_Click(sender,e);
        }

        private void grid_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btn_saveChanges_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_delete_Click(sender, e);
            }
        }
    }
}
