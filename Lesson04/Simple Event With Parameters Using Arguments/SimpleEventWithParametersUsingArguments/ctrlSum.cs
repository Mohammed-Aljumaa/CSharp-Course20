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
    public partial class ctrlSum : UserControl
    {

        //public event Action<int> OnCalculationComplete;

        //protected virtual void calculationComplete(int Number)
        //{

        //    Action<int> handler = OnCalculationComplete;
        // if (handler != null)
        //    {
        //        handler(Number);
        //    }
        //}



        public class CalculationCompleteEventArgs: EventArgs
        {
            public  int Result { get;  }

            public int val1 { get;  }
            public int val2 { get; }

            public CalculationCompleteEventArgs(int Result,int val1,int val2)
            {
                this.Result = Result;
                this.val1 = val1;
                this.val2 = val2;


            }


        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void  RaiseOnCalculationComplete(int Result, int val1,int val2)
        {
            RaiseOnCalculationComplete(new CalculationCompleteEventArgs(Result,val1,val2));
        }

        protected virtual void RaiseOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        public ctrlSum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);

            int Result = val1 + val2;


            label3.Text=Result.ToString();
            if(OnCalculationComplete != null)
            {
                RaiseOnCalculationComplete(Result, val1, val2);

            }
        }
    }
}
