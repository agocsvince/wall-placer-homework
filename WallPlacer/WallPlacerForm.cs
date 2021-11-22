using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace WallPlacer
{
    public partial class WallForm : System.Windows.Forms.Form
    {

        public XYZ _startValue;
        public XYZ _endValue;

        public WallForm(ExternalCommandData commandData)
        {
            InitializeComponent();

        }

        private void PlaceButton_Click(object sender, EventArgs e)
        {
            _startValue = new XYZ((double)startValueX.Value, (double)startValueY.Value, (double)startValueZ.Value);
            _endValue = new XYZ((double)endValueX.Value, (double)endValueY.Value, (double)endValueZ.Value);

            submit.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
