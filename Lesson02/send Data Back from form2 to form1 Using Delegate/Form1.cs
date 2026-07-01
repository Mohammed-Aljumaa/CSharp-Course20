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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.DataBack += Form2_DataBack;
            frm.ShowDialog();

        }


        private void Form2_DataBack(object sender,int PersonID)
        {


            txtPersonID.Text = PersonID.ToString();


        }
    }
}
