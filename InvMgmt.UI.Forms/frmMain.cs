using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvMgmt.UI.Forms
{
    public partial class frmMain : Form
    {
        private Main _mainDataSource;

        public frmMain()
        {
            InitializeComponent();

            _mainDataSource = new Main();
            _mainDataSource.CreateMasterListOfParts(_mainDataSource.MLPart);
        }

        private void btnAddMLPart_Click(object sender, EventArgs e)
        {
            frmManageMLPart form = new frmManageMLPart(_mainDataSource);
            form.Show(this);
        }

        private void btnMLPen_Click(object sender, EventArgs e)
        {
            frmManageMLPen form = new frmManageMLPen(_mainDataSource);
            form.Show(this);
        }
    }
}
