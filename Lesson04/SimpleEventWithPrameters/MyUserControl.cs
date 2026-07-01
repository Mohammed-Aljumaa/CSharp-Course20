using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithPrameters
{
    public partial class MyUserControl : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnCalculationComplete;
        // Create a protected method to raise the event with a parameter
        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> handler = OnCalculationComplete;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public MyUserControl()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Result =  Convert.ToInt32 ( txtNumber1.Text) + Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Result.ToString();

            if (OnCalculationComplete != null)
                // Raise the event with a parameter
                CalculationComplete(Result);

        }
    }
}
