using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int PersonID = -1;

            PersonID =Convert.ToInt32(textBox1.Text);


            Form frm1 = new Form1(PersonID);
            frm1.ShowDialog();
        }
    }
}
