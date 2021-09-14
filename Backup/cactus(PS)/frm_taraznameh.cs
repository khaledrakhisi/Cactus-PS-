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
    public partial class frm_taraznameh : Form
    {
        public frm_taraznameh()
        {
            InitializeComponent();
        }

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

        private void playTheSound()
        {
            try
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch
            {
            }
        }

        private void makeTaraznameh()
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "makeTaraznameh"; 
                c.Parameters.AddWithValue("@toDate", mTbx_Date.Text);                             
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }
        }

        private void btn_showTaraznameh_Click(object sender, EventArgs e)
        {
            if (limitString[9] == '0')//limitString[9] == allow show taraznameh
            {
                MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            makeTaraznameh();

            try
            {
                SqlDataAdapter dAdapter;
                dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = new SqlCommand();
                dAdapter.SelectCommand.Connection = new SqlConnection(connectionString);

                DataSet dSet = new DataSet();
                BindingSource bs = new BindingSource();

                dAdapter.SelectCommand.CommandText = "select * from taraznameh;";
                dAdapter.SelectCommand.Connection.Open();
                dAdapter.Fill(dSet, "taraznameh");
                dAdapter.SelectCommand.Connection.Close();

                bs.DataSource = dSet;
                bs.DataMember = "taraznameh";

                if (bs.Count == 0)
                {
                    MessageBox.Show("اطلاعاتی پیدا نشد، لطفاً مجدداً سعی کنید");
                }
                else
                {
                    playTheSound();

                    frm_printAccDoc frmPrintAccDoc = new frm_printAccDoc();
                    frmPrintAccDoc.dateString = "ترازنامه منتهی به تاریخ " + mTbx_Date.Text;
                    frmPrintAccDoc.connectionString = this.connectionString;
                    frmPrintAccDoc.crystalReportViewer1.DisplayGroupTree = false;
                    frmPrintAccDoc.sFilePath = Application.StartupPath + "\\rpt_advBalance.rpt";//@"D:\Develop\CSProject\cactus(PS)\cactus(PS)\rpt_advBalance.rpt";                
                    frmPrintAccDoc.dSet = dSet;
                    frmPrintAccDoc.ShowDialog();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_taraznameh_Load(object sender, EventArgs e)
        {
            try
            {
                mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
            }
            catch
            {
            }
        }

        private void mTbx_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void mTbx_Date_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    mTbx_Date.Text = numberConvertor.nowDateInAppropriateFormat();
                }
            }
            catch
            {
            }
        }

        private void mTbx_Date_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_Date.Text = numberConvertor.makeChangeToDateString(mTbx_Date.Text);
                if (mTbx_Date.Text.Length < 9)
                {
                    MessageBox.Show("تاریخ را درست وارد کنید");
                    mTbx_Date.Focus();
                }
                if (numberConvertor.findDateError(1370, mTbx_Date.Text) == "d")
                {
                    MessageBox.Show("روز را درست وارد کنید");
                    mTbx_Date.Focus();
                    mTbx_Date.Select(8, 2);
                }
                if (numberConvertor.findDateError(1370, mTbx_Date.Text) == "m")
                {
                    MessageBox.Show("ماه را درست وارد کنید");
                    mTbx_Date.Focus();
                    mTbx_Date.Select(5, 2);
                }
            }
            catch
            {
            }
        }
    }
}
