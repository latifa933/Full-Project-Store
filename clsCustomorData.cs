using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataLayer
{
    public class clsCustomorData
    {
        public static bool GetCustumorByID(int CustumorID, ref string Name, ref string Email, ref string phone, ref string address, ref string username, ref string password)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Custumor where CustumorID = @CustumorID";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID", CustumorID);

            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["Name"];
                    Email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    username = (string)reader["Username"];
                    password = (string)reader["password"];
                    reader.Close();

                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connexion.Close();
            }
            return IsFound;
        }

        public static bool GetCustumorByUsernameAndPassword(string username, string password, ref int CustumorID, ref string Name, ref string Email, ref string phone, ref string address)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Custumor where Username = @username and password = @password";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["Name"];
                    Email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    CustumorID = (int)reader["CustumorID"];
                    reader.Close();

                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connexion.Close();
            }
            return IsFound;
        }

        public static int AddNewCustumor(string name, string email, string phone, string address, string username, string password)
        {
            int CustumorD = -1;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into Custumor (Name,Email,Phone,Address,Username,password)values (@Name,@Email,@Phone,@Address,@Username,@password);
                select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@Name", name);
            if (email != "")
                command.Parameters.AddWithValue("@Email", email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    CustumorD = ID;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return CustumorD;

        }

        public static bool UpdateCustumor(int? CustumorID,string name,string email,string phone,string address,string username,string password)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update Custumor
                            set Name = @name,
                             Email = @email,
                             Phone = @phone,
                             Address = @Adress,
                             Username = @username,
                             password = @password
                            Where CustumorID =@CustumorID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID", CustumorID);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@Adress", address);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                
                    
            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;
        }
    
        public static bool DeleteCustumor(int CustumorID)
        {   int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "Delete Custumor where CustumorID = @CustumorID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID", CustumorID);

            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();


            }
            catch(Exception ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }
    
        public static DataTable GetAllCustumor()
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select CustumorID,Name,Email,Phone,Address,Username from Custumor";
            SqlCommand command = new SqlCommand(query, connexion);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch(Exception  ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return dt;
        }

        public static bool IsCustumorExistByUsername(string username)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select found=1 from Custumor where Username = @Username";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@Username", username);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;
                reader.Close();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return isfound;
        }


    
    
    }



}