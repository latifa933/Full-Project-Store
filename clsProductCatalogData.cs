using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StoreDataLayer
{
    public class clsProductCatalogData
    {
        public static bool GetProductInfoByID(int productID,ref string productName,ref string description,ref float Price,ref int QuantityInStock,ref int categoryID)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductCatalog where ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", productID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    productName = (string)reader["ProductName"];
                    description = (string)reader["Description"];
                    Price = Convert.ToSingle(reader["Price"]);
                    QuantityInStock = (int)reader["QuantityInStock"];
                    categoryID = (int)reader["CategoryID"];

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

                EventLog.WriteEntry(sourceName, "the error in Get Product by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return IsFound;

        }

        public static bool GetProductInfoByName(string productName, ref int productID, ref string description, ref float Price, ref int QuantityInStock, ref int categoryID)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductCatalog where ProductName = @name";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@name", productName);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    productID = (int)reader["ProductID"];
                    description = (string)reader["Description"];
                    Price = Convert.ToSingle(reader["Price"]);
                    QuantityInStock = (int)reader["QuantityInStock"];
                    categoryID = (int)reader["CategoryID"];

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in Get Product by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return IsFound;

        }

        public static DataTable GetAllProductByCategory(int categoryID)
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"SELECT ProductCatalog.ProductID, ProductCatalog.ProductName, ProductCatalog.Description,ProductCatalog.Price,ProductCategory.CategoryName, ProductImage.ImageURL as Image
                 FROM     ProductCatalog INNER JOIN
                  ProductCategory ON ProductCatalog.CategoryID = ProductCategory.CategoryID AND ProductCatalog.CategoryID = ProductCategory.CategoryID INNER JOIN
                  ProductImage ON ProductCatalog.ProductID = ProductImage.ProductID
                    where ProductCatalog.CategoryID = @categoryID";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@categoryID", categoryID);
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

                EventLog.WriteEntry(sourceName, "the error in Get all product by categID is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }
            return dt;

        }
        public static int AddNewProduct(string productName,string description,float price,int quantityInStock,int categoryID)
        {
            int productID = 0;

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into ProductCatalog (ProductName,Description,Price,QuantityInStock,CategoryID) values (@productName,@description,@price,@QuantityInStock,@categoryID); select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            try
            { connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    productID = ID;
                }


            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new product is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return productID;
           
        }
        public static bool UpdateProduct(int productID, string productName, string description, float price, int quantityInStock,int categoryID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update ProductCatalog
                             set ProductName = @productName,
                               Description = @description,
                               Price = @price,
                               QuantityInStock = @QuantityInStock,
                               CategoryID = @categoryID
                                where ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@productID", productID);
            
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

                EventLog.WriteEntry(sourceName, "the error in Update product is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }
        public static bool deleteProduct(int productID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete ProductCatalog where ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", productID);
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

                EventLog.WriteEntry(sourceName, "the error in delete product is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }
        public static bool IsProductExistByName(string productName)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select found=1 from ProductCatalog where ProductName = @productName";
            SqlCommand command = new SqlCommand(query, connexion);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;
                reader.Close();


            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in IsProductExist by name is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return isfound;



        }


    }
}
