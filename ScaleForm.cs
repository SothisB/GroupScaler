using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupScaler
{
    public partial class ScaleForm : Form
    {
        public ScaleForm()
        {
            InitializeComponent();
        }

        public float ScaleFactor
        {
            get
            {
                return Convert.ToSingle(scaleFactorTextBox.Text);
            }
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            float scaleFactor;
            if (!float.TryParse(scaleFactorTextBox.Text, out scaleFactor))
            {
                errorProvider.SetError(scaleFactorTextBox, "Enter a valid factor");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
