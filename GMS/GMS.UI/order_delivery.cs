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

namespace GMS.UI
{
    public partial class order_delivey : UserControl
  {

        public string ordId = null;
        public string ordItem = null;
        public string ordDep = null;
        public string comp = null;

        private static order_delivey _instance;

    public static order_delivey Instance
    {
        get
        {
            if (_instance == null)
                _instance = new order_delivey();
            return _instance;
        }
    }

    public static order_delivey Instance1
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

    
        public order_delivey()
        {
            InitializeComponent();
        }

        private void order_delivey_Load(object sender, EventArgs e)
        {
            Item.Items.Add("Shirt(F)");
            Item.Items.Add("Shirt(H)");
            Item.Items.Add("T-Shirt");
            Item.Items.Add("Pant(G)");
            Item.Items.Add("Pant(J)");
            Item.Items.Add("Pant(3)");

            Dept.Items.Add("Cutting");
            Dept.Items.Add("Sewing");
            Dept.Items.Add("Dyeing");
            Dept.Items.Add("Packing");

            Init();
        }

        public void Init()
        {

            Quan.Clear();
            Comp_name.Clear();

            OrderListData od = new OrderListData();
            dataGridView1.DataSource = od.GetOrderShowList();

        }
 

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Assign_Click(object sender, EventArgs e)
        {
            OrderListData old = new OrderListData();
            old.InsertOrder(Item.Text, Convert.ToInt32(Quan.Text), "OrderListed",Comp_name.Text,this.DateTime1.Text);
            MessageBox.Show("Order Added", "Success");
            Init();
        }

      

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (this.ordId != null)
            {
                OrderListData oLd = new OrderListData();
                if (oLd.ChangeOrderStatus(this.ordId, "Cancelled") == true)
                {
                    MessageBox.Show("Order Cancelled", "Success");
                    Init();
                }
                else
                {
                    MessageBox.Show("Please Check Again", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please Click On An Order Data", "Error");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (this.ordId != null)
            {
                OrderListData oLd = new OrderListData();
                if (oLd.ChangeOrderStatus(this.ordId, "Delivered") == true)
                {
                    MessageBox.Show("Order Delivered", "Success");
                    Init();
                }
                else
                {
                    MessageBox.Show("Please Check Again", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please Click On An Order Data", "Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dataGridView1.Rows[e.RowIndex];
            this.ordId = row.Cells["Id"].Value.ToString();
            Quan.Text = row.Cells["OrderQuantity"].Value.ToString();

            Comp_name.Text = row.Cells["CompanyName"].Value.ToString();
            this.ordItem = row.Cells["OderType"].Value.ToString();
            this.ordDep = row.Cells["OrderStatus"].Value.ToString();

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
