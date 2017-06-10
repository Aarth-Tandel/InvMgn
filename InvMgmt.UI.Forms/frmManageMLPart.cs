using InvMgmt.Common;
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
    public partial class frmManageMLPart : Form
    {
        Main _main;

        public frmManageMLPart(Main main)
        {
            InitializeComponent();

            _main = main;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var partTypeText = cbType.SelectedItem.ToString();

            Part part = null;
            if (partTypeText == "Weight")
            {
                double weight = 0.0f;
                System.Double.TryParse(txtWeightCount.Text, out weight);
                part = new PartWithWeight(txtName.Text, txtDescription.Text, (float) weight);
            }

            if (partTypeText == "Count")
            {
                int count = 0;
                System.Int32.TryParse(txtWeightCount.Text, out count);
                part = new PartWithCount(txtName.Text, txtDescription.Text, count);
            }

            if(part != null && _main != null)
            {
                _main.MLPart.Add(part);
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
