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
    public partial class EmployeeList : UserControl
    {
        private static EmployeeList _instance;

        public static EmployeeList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeList();
                return _instance;
            }
        }

        public static EmployeeList Instance1
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


        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

            Init();
        }

        public void Init()
        {

            OrderListData od = new OrderListData();
            dataGridView1.DataSource = od.GetOrderShowList();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
     
    
