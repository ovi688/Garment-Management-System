using GMS.DAL;
using GMS.UI;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            if (!pass_show.Checked)
            {
                metroTextBox2.UseSystemPasswordChar = true;
            }
            else
                metroTextBox2.UseSystemPasswordChar = false;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            metroComboBox1.Items.Add("Admin");
            metroComboBox1.Items.Add("Manager");
          

        }
        
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Admin")
            {
                AdminData ad = new AdminData();

                if (ad.checkAdmin(metroTextBox1.Text, metroTextBox2.Text) == true)
                {

                    adminForm af = new adminForm(metroTextBox1.Text);
                  

                    af.Show(this);
         
                    
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Check ID and Password again.", "Error");
                }

            }

           else if (metroComboBox1.Text == "Manager")
            {
                ManagerData md = new ManagerData();

                if (md.checkManager(metroTextBox1.Text, metroTextBox2.Text) == true)
                {

                    ManagerForm mf = new ManagerForm(metroTextBox1.Text);
                    mf.Show(this);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Check ID and Password again.", "Error");
                }

            }
        }

                 
           
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }



        private void pass_show_CheckedChanged(object sender, EventArgs e)
        {
            if (!pass_show.Checked)
            {
                metroTextBox2.UseSystemPasswordChar = true;
            }
            else
                metroTextBox2.UseSystemPasswordChar = false;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Admin")
            {
                AdminData ad = new AdminData();

                if (ad.checkAdmin(metroTextBox1.Text, metroTextBox2.Text) == true)
                {

                    adminForm af = new adminForm(metroTextBox1.Text);


                    af.Show(this);


                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Check ID and Password again.", "Error");
                }


            }

          

            else if (metroComboBox1.Text == "Manager")
            {
                ManagerData md = new ManagerData();

                if (md.checkManager(metroTextBox1.Text, metroTextBox2.Text) == true)
                {

                    ManagerForm mf = new ManagerForm(metroTextBox1.Text);
                    mf.Show(this);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Check ID and Password again.", "Error");
                }

            }
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

