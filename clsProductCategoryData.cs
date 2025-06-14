using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataLayer
{
    public class clsProductCategoryData
    { 
        public static bool GetProductCategoryByID(int categoryID,ref string categoryName)
        { bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductCategory where CategoryID = @categoryID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    categoryName = (string)reader["CategoryName"];
                    reader.Close();
                }

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in get product by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();

            }
            return isfound;

        }

        public static bool GetProductCategoryByName(ref int categoryID,string categoryName)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductCategory where CategoryName = @categoryname";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@categoryname", categoryName);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    categoryID = (int)reader["CategoryID"];
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in get product by name is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();

            }
            return isfound;

        }

        public static int AddnewProductCategory(string categoryname)
        { int categoryID = -1;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into ProductCategory (CategoryName) value (@categoryName); select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@categoryName", categoryname);
            try
            { connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    categoryID = ID;
                }

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new category is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return categoryID;
        }

        public static bool UpdateProductCategory(int categoryID,string categoryName)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update ProductCategory 
                             set CategoryName = @categoryName
                              where CategoryID = @categoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@categoryName", categoryName);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            try
            {
                connection.Open();
                rowsAffect = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in update category is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connection.Close();
            }
            return rowsAffect > 0;

        }

        public static DataTable GetAllCategory()
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductCategory";
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
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in get all category is " + ex.Message, EventLogEntryType.Error);


            }
            finally
            {
                connexion.Close();
            }
            return dt;

        }

        public static bool deleteCategory(int categoryID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete ProductCategory where CategoryID = @categoryID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in delete category is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }


    }
}
