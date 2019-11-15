using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class AAAAAAAAAA : Form
    {
        public AAAAAAAAAA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            if (txtBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("AAAAA " + txtBox.Text, " " + "Fancy message box");
            }
            else
            {
                MessageBox.Show("You must enter text", " " + "You are a failure");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
