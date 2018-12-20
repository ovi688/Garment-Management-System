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
using Bunifu.Framework.UI;

namespace GMS.UI
{
    public partial class AdminHome : UserControl
    {
        private static AdminHome _instance;

 
        public static AdminHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminHome();
                return _instance;
            }
        }

        public static AdminHome Instance1
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

        public AdminHome()
        {
            InitializeComponent();
            Init();
        }

        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

     

       
        public void Init()
        {
           
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            {
                Time.Text = DateTime.Now.ToString("HH:mm");
                Seconds.Text = DateTime.Now.ToString("ss");
                Date.Text = DateTime.Now.ToString("dd  mm  yyyy");
                Day.Text = DateTime.Now.ToString("dddd");
            }
        }

        private void Day_Click(object sender, EventArgs e)
        {

        }
    }
}

