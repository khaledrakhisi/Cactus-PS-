using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cactus_PS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataSet dSet = new DataSet();
        private SqlDataAdapter dAdapter;
        private string strSQL, strCon;
        private SqlConnection con;
        string strPath;
        CrystalDecisions.CrystalReports.Engine.ReportDocument rptfullBook = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        private void Form1_Load(object sender, EventArgs e)
        {
            strCon = "Data Source=(local)\\SQLEXPRESS;AttachDbFilename =";
            strCon += "D:\\DEVELOP\\CSPROJECT\\CACTUS(PS)\\CACTUS(PS)\\PSDATABASE5.MDF;";
            strCon += "Integrated Security=True;Connect Timeout=30;User Instance=True";
            con = new SqlConnection(strCon);
            try
            {
                con.Open();
                strSQL = "SELECT * FROM View1";
                dAdapter = new SqlDataAdapter(strSQL, con);
                dAdapter.Fill(dSet, "View1");
                //
                strPath = "D:\\Develop\\CSProject\\cactus(PS)\\cactus(PS)\\CrystalReport3.rpt";
                rptfullBook.Load(strPath);
                rptfullBook.SetDataSource(dSet);
                //crystalReportViewer1.ReportSource = rptfullBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
