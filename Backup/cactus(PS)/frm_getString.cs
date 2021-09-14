using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cactus_PS_
{
    public partial class frm_getString : Form
    {
        private bool b_OkClicked = false;
        public bool OkClicked
        {
            get { return b_OkClicked; }
            set { b_OkClicked = true; }
        }


        public frm_getString()
        {
            InitializeComponent();
        }

        private void frm_getString_Load(object sender, EventArgs e)
        {
            b_OkClicked = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            tbx_.Text = tbx_.Text.Trim();

            b_OkClicked = true;

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tbx_.Text = "";

            this.Close();
        }

        private void frm_getString_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!b_OkClicked)
            {
                b_OkClicked = false;
            }
        }
    }
}
