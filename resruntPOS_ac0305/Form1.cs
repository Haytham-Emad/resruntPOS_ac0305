using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resruntPOS_ac0305
{
    public partial class frmLogin : Form
    {
        navigationform navigation = new navigationform();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "haytham", password = "1234";
            if (txtusername.Text == " ")
            {
                MessageBox.Show("user name is req");
            }
            else if (txtpassword.Text == " ")
            {
                MessageBox.Show("password is req");
            }
            else
            {
                if (txtusername.Text == username && txtpassword.Text == password)
                {
                    navigation.lblhello.Text = "hello:- " + txtusername.Text;
                    navigation.Show();
                }
                else
                {
                    MessageBox.Show("user name or password is filed");
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "EXIT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
