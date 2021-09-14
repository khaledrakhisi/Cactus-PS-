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
    public partial class frm_splash : Form
    {
        private bool b_tryToHide;

        private bool b_openAsAboutDialog;
        public bool openAsAboutDialog
        {
            get { return b_openAsAboutDialog; }
            set { b_openAsAboutDialog = value; }
        }

        public frm_splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(! openAsAboutDialog)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_splash_Load(object sender, EventArgs e)
        {

        }

        private void frm_splash_Shown(object sender, EventArgs e)
        {
            if (!openAsAboutDialog)
            {
                btn_ok.Visible = false;
                //lbl_khaledRakhisi.Visible = false;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if(openAsAboutDialog)
                    this.Close();
            }
        }

        private void tmr_slideShow_Tick(object sender, EventArgs e)
        {
            try
            {
                tmr_smooth.Interval = 50;
                if (this.Opacity == 1)
                {
                    this.Opacity = this.Opacity - 0.0001;
                    b_tryToHide = true;
                    tmr_smooth.Interval = 1000;
                    return;
                }
                if (!b_tryToHide)//try to show
                {
                    this.Opacity = this.Opacity + 0.1;
                }
                else//try to hide
                {
                    if (!openAsAboutDialog)
                    {
                        this.Opacity = this.Opacity - 0.1;
                    }
                }
            }
            catch
            {
            }
        }
    }
}
