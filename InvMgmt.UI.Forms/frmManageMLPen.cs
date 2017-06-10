using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IN = InvMgmt.Common;

namespace InvMgmt.UI.Forms
{
    public partial class frmManageMLPen : Form
    {
        Main _main;

        public frmManageMLPen(Main main)
        {
            InitializeComponent();

            _main = main;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMLPen_Load(object sender, EventArgs e)
        {
            if (_main != null)
            {
                cbPart.Items.Clear();
                foreach(var part in _main.MLPart.Parts)
                {
                    cbPart.Items.Add(part.Name);
                }
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var text = cbPart.SelectedItem.ToString();
            lstPenParts.Items.Add(text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IN.Pen pen = new IN.Pen();

            pen.Name = txtName.Text;

            foreach(var item in lstPenParts.Items)
            {
                var partName = item.ToString();
                foreach (var partTemp in _main.MLPart.Parts)
                {
                    if (partTemp.Name == partName)
                    {
                        pen.Parts.Add(partTemp);
                        break;
                    }
                }
            }

            _main.MLPen.Add(pen);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
