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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
 

namespace GMS.UI
{
    public partial class Payment : UserControl
    {
        public string email = null;
        public string salary = null;
        public int working_days = 0;
        public int attendence = 0;
        public int daily_wk_hr = 0;
        public int bonus = 0;
        public int OverTime = 0;



        private static Payment _instance;
        public static Payment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Payment();
                return _instance;
            }
        }

        public static Payment Instance1
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

        public Payment()
        {
            InitializeComponent();
            Init();
        }

         public void Init()
        {

            PaymentData pd = new PaymentData();
           
            up_pay.DataSource = pd.GetPaymentList();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Payment_Load(object sender, EventArgs e)
        {

            PaymentData pd = new PaymentData();
            
            up_pay.DataSource = pd.GetPaymentList();


            Init();
        }

      

     

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void up_payment_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void bonus_com_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

       

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }


       

        private void updatent_Click(object sender, EventArgs e)
        {
            attendence = Convert.ToInt32(Attd.Text);
            working_days = Convert.ToInt32(work_day.Text);
            daily_wk_hr = Convert.ToInt32(d_w_hr.Text);
            bonus = Convert.ToInt32(Bon_tk.Text);
            OverTime = Convert.ToInt32(Ov_hr.Text);

            int abs_day = working_days - attendence;
            int  t_salary = Convert.ToInt32(salary);
            int day_salary = t_salary / working_days;
            t_salary = t_salary - day_salary * abs_day;
            int s_with_b = t_salary + bonus;

            int hr_salary = day_salary / daily_wk_hr;
            int  OverTime_salary = OverTime * 2 * hr_salary;

             Over_tk.Text = Convert.ToString(OverTime_salary);

            int total_paying_salary = s_with_b + OverTime_salary;

            totalSalary.Text = Convert.ToString(total_paying_salary);
        }

        private void Ov_hr_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            PaymentData pd = new PaymentData();
            if (pd.UpPayList( Convert.ToInt32(Bon_tk.Text), Convert.ToInt32(Over_tk.Text), Convert.ToInt32(totalSalary.Text), this.DateTimeP.Text, metroTextBox4.Text) == true)
          
            {
                MessageBox.Show("Payment done");
            }
        
            else
            {
                MessageBox.Show("error");
            }

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("E:/Created.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("-----------------PayMent Slip Of Employees----------------");
            Paragraph p9 = new Paragraph(" ");

            Paragraph p2 = new Paragraph("Name Of Employee :");
            Paragraph p3 = new Paragraph(name.Text);
            Paragraph p4 = new Paragraph("Email Address/phn no :");
            Paragraph p5 = new Paragraph(metroTextBox4.Text);
            Paragraph p6 = new Paragraph("Total Calculated Salary :");
            Paragraph p7 = new Paragraph(totalSalary.Text);
            Paragraph p10 = new Paragraph(" ");
            Paragraph p8 = new Paragraph(DateTimeP.Text);

           
          
            doc.Add(p1);
            doc.Add(p9);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Add(p7);
            doc.Add(p10);
            doc.Add(p8);


            doc.Close();
            MessageBox.Show("pdf created");
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void d_w_hr_Click(object sender, EventArgs e)
        {

        }

        private void work_day_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void DateTimeP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void up_pay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.up_pay.Rows[e.RowIndex];
            this.email = row.Cells["EmployeeEmail"].Value.ToString();
            metroTextBox4.Text = row.Cells["EmployeeEmail"].Value.ToString();
            metroTextBox5.Text = row.Cells["EmployeeSalary"].Value.ToString();
            name.Text = row.Cells["EmployeeName"].Value.ToString();
            this.salary = row.Cells["EmployeeSalary"].Value.ToString();
        }
    }
}
