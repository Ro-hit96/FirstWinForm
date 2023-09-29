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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> deptlist = new List<string>()
        {
            "HR","Admin","Sales","Development","Testing","Marketing"
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeptCmbx.DataSource = deptlist;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtbasicsal.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double grosssallbl = (bs + hra + ta + da) - pf;

            HRAtxt.Text = hra.ToString();
            TaTxt.Text = ta.ToString();
            DaTxt.Text = da.ToString();
            PFtxt.Text = pf.ToString();
            GSTxt.Text = grosssallbl.ToString();

            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
            string msg=Idtxt.Text+"\n"+nametxt.Text+"\n"+DeptCmbx.Text+"\n"+GSTxt.Text;
            lblmessage.Text = msg;
        }
    }
}
