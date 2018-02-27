using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace App_Hospital.Models
{
    public class ADOConnection
    {
        //SqlConnection conn;
        //SqlCommand comm;
        //SqlDataReader dreader;
        string connstring =ConfigurationManager.ConnectionStrings["ConnectionADO"].ConnectionString.ToString();
        /// <summary>
        /// Insert Patient Data
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Address"></param>
        /// <param name="DateOfBirth"></param>
        /// <returns></returns>
        public  bool RunInsert(string FirstName, string LastName, string Address, DateTime DateOfBirth)
        {
            //string result = "false";
            StringBuilder sql = new StringBuilder("");
            SqlCommand com = new SqlCommand();
            sql.AppendFormat(@"insert into tbl_Patients(Patient_Fanme,Patient_Lname,Patient_Address,Patient_Date,Patient_InsertionDateTime)  ");
            sql.AppendFormat(@"values(@fname,@lname,@address,@dateBirth,@insertionDate)");
            com.CommandText = sql.ToString();
            com.Parameters.AddWithValue("@fname",FirstName);
            com.Parameters.AddWithValue("@lname",LastName);
            com.Parameters.AddWithValue("@address",Address);
            com.Parameters.AddWithValue("@dateBirth", DateOfBirth);
            com.Parameters.AddWithValue("@insertionDate",DateTime.Now);
            return  SaveToDB(com);
                
        }

        /// <summary>
        /// Using ADO Connection DataBase 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool SaveToDB(SqlCommand command)
        {
            bool save = false;
            string _constring = ConfigurationManager.ConnectionStrings["ConnectionADO"].ConnectionString.ToString(); ;
            SqlConnection con = new SqlConnection(_constring);
            command.Connection = con;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                try
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        save = true;
                    }
                }
                catch (Exception)
                {
                    
                    con.Close();
                }
                
            }
            return save;

        }
    }
}