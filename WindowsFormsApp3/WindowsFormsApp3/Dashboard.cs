using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.All_User_Control;

namespace WindowsFormsApp3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btncusomterregester.Left;
            UC_customerregestration G = new UC_customerregestration();
            G.Show();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnaddroom.Left;
            UC__addroom D = new UC__addroom();
            D.Show();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btncheckout.Left;
        }

        private void btncutomerdetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btncutomerdetails.Left;
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnemployee.Left;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
