using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_4.Models;
using System.Data.SqlClient;
using System.Data;
namespace Exam_4.Repository
{
    class MobileRepositiry
    {
        public bool AddMobile(Mobile mobile)
        {
            bool isAdded = false;
            try
            {
                string connection = @"Server=PC-301-13\SQLEXPRESS;Database=Exam_2;Trusted_Connection=True";
                string insert = @"INSERT INTO [dbo].[Mobile]([ModelName],[IMEI],[Price])VALUES('"+mobile.ModelName+ "','" + mobile.IMEI + "','" + mobile.Price + "')";
                SqlConnection conn=new SqlConnection(connection);
                SqlCommand sqlCommand=new SqlCommand(insert,conn);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                isAdded = true;
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isAdded;
        }

        public bool IsImeiExists(Mobile mobile)
        {
            bool exists = false;
            try
            {
                string commandString = @"SELECT * FROM Mobile WHERE IMEI='" + mobile.IMEI + "'";
                string connection = @"Server=PC-301-13\SQLEXPRESS;Database=Exam_2;Trusted_Connection=True";
                //string insert = @"INSERT INTO [dbo].[Mobile]([ModelName],[IMEI],[Price])VALUES('" + mobile.ModelName + "','" + mobile.IMEI + "','" + mobile.Price + "')";
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);
                conn.Open();
                SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlCommand);  
                DataTable data=new DataTable();
                sqlDataAdapter.Fill(data);
                conn.Close();
                if (data.Rows.Count>0)
                {
                    exists = true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show();
            }

            return exists;
        }

        public Mobile GetByImei(string imei)
        {
            Mobile mobile=new Mobile();
            try
            {
                string commandString = @"SELECT * FROM Mobile WHERE IMEI='" + imei + "'";
                string connection = @"Server=PC-301-13\SQLEXPRESS;Database=Exam_2;Trusted_Connection=True";
                //string insert = @"INSERT INTO [dbo].[Mobile]([ModelName],[IMEI],[Price])VALUES('" + mobile.ModelName + "','" + mobile.IMEI + "','" + mobile.Price + "')";
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    mobile.ModelName = sqlDataReader["ModelName"].ToString();
                    mobile.IMEI = sqlDataReader["IMEI"].ToString();
                    mobile.Price = Convert.ToDouble(sqlDataReader["Price"]);
                }
                conn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show();
            }
            return mobile;
        }
        public List<Mobile> GetByPriceRange(string range1,string range2)
        {
            List<Mobile> mobiles = new List<Mobile>();
            try
            {
                string commandString = @"Select * from Mobile where price  BETWEEN '"+range1+ "' and '" + range2 + "'";
                string connection = @"Server=PC-301-13\SQLEXPRESS;Database=Exam_2;Trusted_Connection=True";
                //string insert = @"INSERT INTO [dbo].[Mobile]([ModelName],[IMEI],[Price])VALUES('" + mobile.ModelName + "','" + mobile.IMEI + "','" + mobile.Price + "')";
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Mobile mobile = new Mobile();
                    mobile.ModelName = sqlDataReader["ModelName"].ToString();
                    mobile.IMEI = sqlDataReader["IMEI"].ToString();
                    mobile.Price = Convert.ToDouble(sqlDataReader["Price"]);
                    mobiles.Add(mobile);
                }
                conn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show();
            }
            return mobiles;
        }
    }
}
