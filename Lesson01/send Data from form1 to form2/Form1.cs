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



   
    public partial class Form1 : Form
    {

        int _PersonID;

        public Form1(int personid)
        {
            InitializeComponent();
            _PersonID = personid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPersonID.Text = _PersonID.ToString();
        }
    }
}
