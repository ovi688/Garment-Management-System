using GMS.Entity;
using GMS.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.DAL
{
    public class PaymentData
    {
        
        List<Payment2> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Payment2> Payment2 = new List<Payment2>();
            using (reader)
            {
                while (reader.Read())
                {
                    Payment2 ord = new Payment2();
                    ord.EmployeeId = reader.GetInt32(0);
                    ord.EmployeeName = reader.GetString(1);
                    ord.EmployeeSalary = reader.GetInt32(2);
                    ord.EmployeeEmail = reader.GetString(3);
                    ord.Bomus = reader.GetInt32(4);
                    ord.OverTime = reader.GetInt32(5);
                    ord.Total = reader.GetInt32(6);
                    ord.Date = reader.GetString(7);
                 

                    Payment2.Add(ord);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return Payment2;
        }

        public List<Payment2> GetOrderList()
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from Payment2");
            List<Payment2> Payment2 = GetData(cmd);
            return Payment2;
        }

        public DataTable GetPaymentList()
        {
            DataTable dt = new DataTable();
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Select * From Payment");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
        public bool InsertEmployee(string eN, int eS, string eE) {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [dbo].[Payment] ([EmployeeName],[EmployeeSalary],[EmployeeEmail])" + "VALUES (@eName, @eSal, @eEmail)");
            SqlParameter p = new SqlParameter("@eName", SqlDbType.VarChar, 20); p.Value = eN;  
            SqlParameter p1 = new SqlParameter("@eSal", SqlDbType.Int); p1.Value = eS;
            SqlParameter p2 = new SqlParameter("@eEmail", SqlDbType.VarChar, 20); p2.Value = eE;

            cmd.Parameters.Add(p); 
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
        public Boolean DeleteEmployeePayment(string eId)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Delete From [dbo].[Payment] where EmployeeEmail= '" + eId + "'");

            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

        public Boolean UpdateEmployeePayment(string eI, string eN, int eS, string eE)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Update [dbo].[Payment] Set EmployeeName='" + eN + "', EmployeeSalary='" + eS + "',EmployeeEmail='" + eE + "' where EmployeeEmail= '" + eI + "'");

            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

        public Boolean UpPayList(int eI, int eN, int eS, string eE,string eM)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Update [dbo].[Payment] Set Bonus='" + eI + "',   OverTime='" + eN + "', Date='" + eE + "' ,Total='" + eS + "' where EmployeeEmail= '" + eM + "'");

            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

    }
}
