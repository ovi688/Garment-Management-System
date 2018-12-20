using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMS.DAL;
using MetroFramework.Controls;

namespace GMS.UI
{
    public partial class UpdateEmployee : UserControl
    {
        public string admId = null;
        public string clickId = null;
        public string clickDep = null;
        private static UpdateEmployee _instance;

        public static UpdateEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateEmployee();
                return _instance;
            }
        }

        public static UpdateEmployee Instance1
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

            metroComboBox1.Items.Add("Manager");
            metroComboBox1.Items.Add("Employee");

            metroComboBox2.Items.Add("Cutting");
            metroComboBox2.Items.Add("Sewing");
            metroComboBox2.Items.Add("Dyeing");
            metroComboBox2.Items.Add("Packing");

            Init();
        }
        public void Init()
        {

            if (metroComboBox1.Text == "Manager")
            {
                ManagerData md = new ManagerData();
                 
                data11.DataSource = md.GetManagerShowList();
            }
            if (metroComboBox1.Text == "Employee")
            {
                EmployeeData ed = new EmployeeData();
             
                data11.DataSource = ed.GetEmployeeShowList();
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Manager")
            {
                if (metroComboBox2.Text != "")
                {
                    ManagerData md = new ManagerData();
                    if (md.UpdateManager(this.clickId, metroTextBox1.Text, Convert.ToInt32(metroTextBox4.Text), metroComboBox2.Text, metroTextBox3.Text) == true)
                    {
                        MessageBox.Show("Manager Updated", "Success");
                        Init();
                    }
                    else
                    {
                        MessageBox.Show("Please check again.", "Error");
                        Init();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Department", "Error");
                    Init();
                }
            }
            if (metroComboBox1.Text == "Employee")
            {
                if (metroComboBox2.Text != "")
                {
                    EmployeeData ed = new EmployeeData();
                    PaymentData pd = new PaymentData();
                    if (ed.UpdateEmployee(this.clickId, metroTextBox1.Text, Convert.ToInt32(metroTextBox4.Text), metroComboBox2.Text, metroTextBox3.Text) == true)
                    {
                        if (pd.UpdateEmployeePayment(this.clickId, metroTextBox1.Text, Convert.ToInt32(metroTextBox4.Text), metroTextBox3.Text) == true)
                        {
                            MessageBox.Show("Employee Updated", "Success");
                            Init();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check again.", "Error");
                        Init();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Department", "Error");
                    Init();
                }
                

            }


        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }

       
  

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
           if (metroComboBox1.SelectedIndex.ToString() == "0")
            {
                ManagerData md = new ManagerData();
                if (md.InsertManager(metroTextBox1.Text, metroTextBox2.Text, Convert.ToInt32(metroTextBox4.Text), metroComboBox2.Text, metroTextBox3.Text) == true)
                {
                    MessageBox.Show("Manager Added", "Success");
                    Init();
                }
                else
                {
                    MessageBox.Show("Please Check All The Info Was Correct", "Error");
                }
            }
            if (metroComboBox1.SelectedIndex.ToString() == "1")
            {
                PaymentData pd = new PaymentData();
                EmployeeData ed = new EmployeeData();

                if (ed.InsertEmployee(metroTextBox1.Text,metroComboBox2.Text, Convert.ToInt32(metroTextBox4.Text), metroComboBox2.Text, metroTextBox3.Text) == true)
                {
                    if (pd.InsertEmployee(metroTextBox1.Text, Convert.ToInt32(metroTextBox4.Text), metroTextBox3.Text) == true)
                    {
                        MessageBox.Show("Employee Added", "Success");
                        Init();
                    }
                }
                else
                {
                    MessageBox.Show("Please Check All The Info Was Correct", "Error");
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            PaymentData pd = new PaymentData();
            EmployeeData ed = new EmployeeData();

            if ((ed.DeleteEmployee(metroTextBox3.Text) == true) && (pd.DeleteEmployeePayment(metroTextBox3.Text)==true))
            {
                MessageBox.Show("Employee info deleted");
                Init();
            }
            else
            {
                MessageBox.Show("Something wrong");
            }
        }

        private void data11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroComboBox1.Text == "Manager")
            {
                var row = this.data11.Rows[e.RowIndex];
                this.clickId = row.Cells["Id"].Value.ToString();
                metroTextBox1.Text = row.Cells["Name"].Value.ToString();
                metroTextBox4.Text = row.Cells["Salary"].Value.ToString();
                this.clickDep = row.Cells["Department"].Value.ToString();
                metroTextBox3.Text = row.Cells["Email"].Value.ToString();
            }

            if (metroComboBox1.Text == "Employee")
            {
                var row = this.data11.Rows[e.RowIndex];
                this.clickId = row.Cells["Email"].Value.ToString();
                metroTextBox1.Text = row.Cells["Name"].Value.ToString();
                metroTextBox4.Text = row.Cells["Salary"].Value.ToString();
                this.clickDep = row.Cells["Department"].Value.ToString();
                metroTextBox3.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
