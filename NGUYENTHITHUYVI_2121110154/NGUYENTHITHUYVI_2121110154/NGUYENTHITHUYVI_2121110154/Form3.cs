using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGUYENTHITHUYVI_2121110154
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txtUser = txtUsername.Text.ToString();
            String txtPass = txtpassword.Text.ToString();
            if (txtUser == "VI" && txtPass == "2811")
            {
                Form2 objForm01 = new Form2();
                objForm01.ShowDialog();
            }
        }
    }
}
