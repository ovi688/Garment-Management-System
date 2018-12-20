using GMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS.UI
{
    public partial class ManagerForm : Form
    {
        public string manId;
        public string ordId = null;
        public string ordItem = null;
        public string ordDep = null;

        public ManagerForm(string a)
        {
            InitializeComponent();
            this.manId = a;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Init(manId);
        }

        public void Init(string me)
        {
            ManagerData md = new ManagerData();
            M_name.Clear();
            M_mail.Clear();
            dataGridView1.DataSource = md.GetManagerOwnInfo(me);

            if (!bunifuGradientPanel2.Controls.Contains(AdminHome.Instance))
            {
                bunifuGradientPanel2.Controls.Add(AdminHome.Instance);
                AdminHome.Instance.Dock = DockStyle.Fill;
                AdminHome.Instance.BringToFront();

            }
            else
            {
                AdminHome.Instance.BringToFront();
            }

        }


        private void manager_home_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel2.Controls.Contains(AdminHome.Instance))
            {
                bunifuGradientPanel2.Controls.Add(AdminHome.Instance);
                AdminHome.Instance.Dock = DockStyle.Fill;
                AdminHome.Instance.BringToFront();

            }
            else
            {
                AdminHome.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            mainForm mn = new mainForm();
            mn.Show();
            this.Hide();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            ManagerData md = new ManagerData();
            if (md.ChangePass(this.manId, M_name.Text, M_mail.Text) == true)
            {
                MessageBox.Show("Profile Updated", "Success");
                Init(M_mail.Text);
            }
            else
            {
                MessageBox.Show("Sorry there is a problem.Please check again", "Error");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if  (bunifuGradientPanel2.Controls.Contains(AdminHome.Instance) || bunifuGradientPanel2.Controls.Contains(order_delivey.Instance)|| bunifuGradientPanel2.Controls.Contains(Payment.Instance) || bunifuGradientPanel2.Controls.Contains(UpdateEmployee.Instance))
            {
                bunifuGradientPanel2.Controls.Remove(AdminHome.Instance);
                bunifuGradientPanel2.Controls.Remove(UpdateEmployee.Instance);
                bunifuGradientPanel2.Controls.Remove(Payment.Instance);
                bunifuGradientPanel2.Controls.Remove(order_delivey.Instance);
        
                AdminHome.Instance.Dock = DockStyle.Fill;
                AdminHome.Instance.BringToFront();

            }
            else
            {
                AdminHome.Instance.BringToFront();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel2.Controls.Contains(UpdateEmployee.Instance))
            {
                bunifuGradientPanel2.Controls.Add(UpdateEmployee.Instance);
                UpdateEmployee.Instance.Dock = DockStyle.Fill;
                UpdateEmployee.Instance.BringToFront();

            }
            else
            {
                UpdateEmployee.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel2.Controls.Contains(order_delivey.Instance))
            {
                bunifuGradientPanel2.Controls.Add(order_delivey.Instance);
                order_delivey.Instance.Dock = DockStyle.Fill;
                order_delivey.Instance.BringToFront();

            }
            else
            {
                order_delivey.Instance.BringToFront();
            }

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel2.Controls.Contains(Payment.Instance))
            {
                bunifuGradientPanel2.Controls.Add(Payment.Instance);
                Payment.Instance.Dock = DockStyle.Fill;
                Payment.Instance.BringToFront();

            }
            else
            {
                Payment.Instance.BringToFront();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
