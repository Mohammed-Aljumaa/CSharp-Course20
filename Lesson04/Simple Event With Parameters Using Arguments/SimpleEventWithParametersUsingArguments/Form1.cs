using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithParametersUsingArguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlSum2_OnCalculationComplete(object sender, ctrlSum.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"Result={e.Result},val1={e.val1},val2={e.val2}");
        }
    }
}
