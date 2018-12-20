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
    public class AdminData
    {
        List<Admin>GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Admin> adminList = new List<Admin>();
            using (reader)
            {
                while (reader.Read())
                {
                    Admin adm = new Admin();
                    adm.AdminId = reader.GetInt32(0);
                    adm.AdminName = reader.GetString(1);
                    adm.AdminPassword = reader.GetString(2);
                    adm.AdminEmail = reader.GetString(3);
                    adminList.Add(adm);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return adminList;
        }
        public List<Admin> GetAdminList()
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Select * From Admin");
            List<Admin> adminList = GetData(cmd);
            return adminList;
        }
        public DataTable GetAdminShowList()
        {
            DataTable dt = new DataTable();
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Select AdminId as Id,AdminName as Name,AdminEmail as Email From Admin");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetAdminOwnInfo(string a)
        {
            DataTable dt = new DataTable();
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Select AdminId as Id,AdminName as Name,AdminEmail as Email From Admin where AdminEmail ='" + a+"'");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public Boolean checkAdmin(string aId, string aPass)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Select Count(*) From Admin where AdminEmail='" + aId + "'and AdminPassword = '" + aPass + "'");

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertAdmin(string aN,string aP,string aE)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [dbo].[Admin] ([AdminName],[AdminPassword],[AdminEmail])" + "VALUES (@aName,  @aPass, @aEmail)");
            SqlParameter p = new SqlParameter("@aName", SqlDbType.VarChar, 20); p.Value = aN;
            SqlParameter p1 = new SqlParameter("@aPass", SqlDbType.VarChar, 20); p1.Value = aP;
            SqlParameter p2 = new SqlParameter("@aEmail", SqlDbType.VarChar, 20); p2.Value = aE;

            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
        public Boolean ChangePass(string aid,string an,string ae)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Update [dbo].[Admin] Set AdminName='" + an + "',AdminEmail='" + ae + "' where AdminEmail= '" + aid + "' ");
 
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }



        public Boolean DeleteAdmin(string aid)
        {
            SqlDataAccess da = new SqlDataAccess();
            SqlCommand cmd = da.GetCommand("Delete From [dbo].[Admin] where AdminId= '" + aid + "'");

            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
        public Boolean UpdateAdmin(string aI,string aN,string aE)
        {
            if(aN!=null && aE!=null)
            {
                SqlDataAccess da = new SqlDataAccess();
                SqlCommand cmd = da.GetCommand("Update [dbo].[Admin] Set AdminName='" + aN + "',AdminEmail='"+aE+"' where AdminId= '" + aI + "'");

                cmd.Connection.Open();
                int val = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return val > 0;
            }
            else
            {
                return false;
            }

        }
    }
}
