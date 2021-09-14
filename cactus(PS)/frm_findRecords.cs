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
    public partial class frm_findRecords : Form
    {

        private string s_displayMember;
        public string listDisplayMember
        {
            get { return s_displayMember; }
            set { s_displayMember = value; }
        }
        private string s_valueMember;
        public string listValueMember
        {
            get { return s_valueMember; }
            set { s_valueMember = value; }
        }
        private string  s_foundRecordID;
        public string foundRecordID
        {
            get { return s_foundRecordID; }
            set { s_foundRecordID = value; }
        }
        private string s_originalRecordID;
        public string originalRecordID
        {
            get { return s_originalRecordID; }
            set { s_originalRecordID = value; }
        }
        private string s_firstCharPressed;
        public string firstCharPressed
        {
            get { return s_firstCharPressed; }
            set { s_firstCharPressed = value; }
        }
        private bool b_okClicked;
        public bool okClicked
        {
            get { return b_okClicked; }
            set { b_okClicked = value; }
        }

        public frm_findRecords()
        {
            InitializeComponent();
        }

        private void tbx_Key_TextChanged(object sender, EventArgs e)
        {
            string sStar = "";
            if(chk_doInnerSearch.Checked)
                sStar = "*";
            else
                sStar = "";

            try
            {
                bindingSource1.Filter = listDisplayMember + " LIKE '" + sStar + tbx_Key.Text + "*'";
                bindingSource1.MoveFirst();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void frm_findRecords_Load(object sender, EventArgs e)
        {
            lst_FoundRecords.DataSource = bindingSource1;
            lst_FoundRecords.DisplayMember = listDisplayMember;
            lst_FoundRecords.ValueMember = listValueMember;

            tbx_ID.DataBindings.Add("Text", bindingSource1, listValueMember);

            //originalRecordID = tbx_ID.Text;
            okClicked = false;

            if (firstCharPressed != "")
            {
                tbx_Key.Text = firstCharPressed;
                tbx_Key.SelectionStart = tbx_Key.Text.Length;
                //bindingSource1.Filter = listDisplayMember + " LIKE '" + firstCharPressed + "*'";
                bindingSource1.MoveFirst();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            okClicked = true;

            foundRecordID = tbx_ID.Text;

            Close();
        }

        private void frm_findRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(! okClicked)
                this.foundRecordID = "-1";
        }

        private void tbx_Key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lst_FoundRecords.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lst_FoundRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(lst_FoundRecords.SelectedIndex > -1)
            tbx_Key.Text = lst_FoundRecords.Items[lst_FoundRecords.SelectedIndex].ToString();*/
        }       

        private void lst_FoundRecords_DoubleClick(object sender, EventArgs e)
        {
            btn_ok_Click(sender, e);
        }

        private void chk_doInnerSearch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tbx_Key_TextChanged(sender, e);
            }
            catch
            {
            }
        }

        private void chk_doInnerSearch_Click(object sender, EventArgs e)
        {
            tbx_Key.Focus();
        }

        private void frm_findRecords_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2)
                {
                    chk_doInnerSearch.Checked = !chk_doInnerSearch.Checked;        
                }
            }
            catch
            {
            }
        }

     }
}
