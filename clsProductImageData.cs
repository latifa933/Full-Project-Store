using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataLayer
{
    public class clsProductImageData
    {
        public static bool GetProductImageByID(int imageID,ref string ImageUrl,ref int productID,ref byte imageOrder)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductImage where ImageID = @imageID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@imageID", imageID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    ImageUrl = (string)reader["ImageURL"];
                    productID = (int)reader["ProductID"];
                    imageOrder = (byte)reader["imageOrder"];

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

                EventLog.WriteEntry(sourceName, "the error in get product image by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return isfound;

        }
        public static bool GetProductImageByProductID(int productID,ref int imageID,ref string ImageUrl,byte imageOrder)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from ProductImage where ProductID = @productID and imageOrder = @imageorder";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@imageorder", imageOrder);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    ImageUrl = (string)reader["ImageURL"];
                    imageID = (int)reader["ImageID"];
                   

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

                EventLog.WriteEntry(sourceName, "the error in get product image by productID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return isfound;


        }
        public static int addNewImage(string ImageURL,int productID,byte imageOrder)
        {
            int imageID = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into ProductImage (ImageURL,ProductID,imageOrder) values (@imageURL,@productID,@imageOrder); select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@imageURL", ImageURL);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@imageOrder", imageOrder);
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    imageID = ID;
                }
            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new image is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }


            return imageID;
        }
        public static bool UpdateImage(int imageID,string ImageURL,int productID,byte imageOrder)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update ProductImage 
                             set ImageURL = @ImageURL,
                                ProductID = @productID,
                                imageOrder = @imageOrder
                                where ImageID = @imageID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@imageID", imageID);
            command.Parameters.AddWithValue("@ImageURL", ImageURL);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@imageOrder", imageOrder);

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

                EventLog.WriteEntry(sourceName, "the error in a Update image is " + ex.Message, EventLogEntryType.Error);


            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;


        }
        public static bool deleteImage(int imageID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete ProductImage where ImageID = @imageID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@imageID", imageID);
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

                EventLog.WriteEntry(sourceName, "the error in a Update image is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
           
            return rowsAffect > 0;

        }
        public static DataTable getAllImageforProduct(int productID)
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"select ImageURL
                            from ProductImage
                          where ProductID =@productID
                          order by imageOrder asc";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", productID);
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

                EventLog.WriteEntry(sourceName, "the error in get all image is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return dt;
        }


    }
}
