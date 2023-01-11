using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakDB
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }
        FRMHOME fRMHOME;
        FRMMUSTERI fRMMUSTERI;
        
        FRMDetails frmhomedetails;
        Login frmlogin;
        FRMPortfoy frmportfoy;
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMHOME == null || fRMHOME.IsDisposed)
            {
                fRMHOME = new FRMHOME();
                fRMHOME.MdiParent = this;
            }
            fRMHOME.Show();
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMMUSTERI == null || fRMMUSTERI.IsDisposed)
            {
                fRMMUSTERI = new FRMMUSTERI();
                fRMMUSTERI.MdiParent = this;
            }
            fRMMUSTERI.Show();

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void gORSELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hOMEDETAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmhomedetails == null || frmhomedetails.IsDisposed)
            {
                frmhomedetails = new FRMDetails();
                frmhomedetails.MdiParent = this;
            }
            frmhomedetails.Show();
        }

  

        private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmlogin == null || frmlogin.IsDisposed)
            {
                frmlogin = new Login();
                frmlogin.MdiParent = this;
            }
            frmlogin.Show();
        }

        private void fRMPORTFOYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmportfoy == null || frmportfoy.IsDisposed)
            {
                frmportfoy = new FRMPortfoy();
                frmportfoy.MdiParent = this;
            }
            frmportfoy.Show();
        }
    }
}
