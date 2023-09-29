using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UTextBox.Clear();
            PTextBox.Clear();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UTextBox.Text == "Admin" && PTextBox.Text == "Admin")
        
            {
                MessageBox.Show("Login Succesfully");
                Mdiform obj = new Mdiform();
                obj.Show();
                this.Hide();//This Refer to login form

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
