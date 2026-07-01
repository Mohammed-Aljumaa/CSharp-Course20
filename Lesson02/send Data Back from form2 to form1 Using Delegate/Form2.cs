using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace send_Data_Back_from_form2_to_form1_Using_Delegate
{
    public partial class Form2 : Form
    {

        public delegate void dataBackEventHandler(object Sender, int PersonID);

        public event dataBackEventHandler DataBack;





        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSendDataBack_Click(object sender, EventArgs e)
        {

            int personID=Convert.ToInt32(txtPersonID.Text);
           
            DataBack?.Invoke(this, personID);

            this.Close();


        }
    }
}
