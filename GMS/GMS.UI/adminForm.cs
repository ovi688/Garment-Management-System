using GMS.DAL;
using GMS.Entity;
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
    
    public partial class adminForm : Form
    {
        public string admId;
        public string clickId=null;
        public string clickDep=null;
        public adminForm(string a)
        {
            InitializeComponent();
            this.admId = a;
        }


   
    private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            Init(admId);

            AdminData ad = new AdminData();
            Admin_info.DataSource = ad.GetAdminOwnInfo(admId);
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

        public void Init(string ae)
        { 

            new_name.Clear();
            new_mail.Clear();
            AdminData ad = new AdminData();
            Admin_info.DataSource = ad.GetAdminOwnInfo(admId);
        }


        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

    private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!bunifuGradientPanel2.Controls.Contains(EmployeeList.Instance))
            {
                bunifuGradientPanel2.Controls.Add(EmployeeList.Instance);
                EmployeeList.Instance.Dock = DockStyle.Fill;
                EmployeeList.Instance.BringToFront();
            }
            else
            {
                EmployeeList.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            mf.Show(this);
            this.Hide();
        }

 
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            AdminData ad = new AdminData();
            if (ad.ChangePass(this.admId, new_name.Text, new_mail.Text) == true)
            {
                MessageBox.Show("Update successfully", "Success");
                Init(new_mail.Text);
            }
            else
            {
                MessageBox.Show("Sorry there is a problem.Please check again", "Error");
            }

          

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if (bunifuGradientPanel2.Controls.Contains(UpdateEmployee.Instance) || bunifuGradientPanel2.Controls.Contains(EmployeeList.Instance) || bunifuGradientPanel2.Controls.Contains(AdminHome.Instance))
            {
                bunifuGradientPanel2.Controls.Remove(UpdateEmployee.Instance);
                bunifuGradientPanel2.Controls.Remove(EmployeeList.Instance);
                bunifuGradientPanel2.Controls.Remove(AdminHome.Instance);
                UpdateEmployee.Instance.Dock = DockStyle.Fill;
                UpdateEmployee.Instance.BringToFront();

            }
            else
            {
                UpdateEmployee.Instance.BringToFront();
            }
        }

        

        private void new_name_Click(object sender, EventArgs e)
        {

        }

     
    }
    }

