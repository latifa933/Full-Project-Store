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
    public class clsReviewData
    {
        public static bool GetReviewByID(int reviewID,ref int ProductID,ref int CustumorID,ref string ReviewText,ref byte Rating,ref DateTime ReviewDate)
        {
            bool Isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Review where ReviewID = @reviewID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@reviewID", reviewID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Isfound = true;
                    ProductID = (int)reader["ProductID"];
                    CustumorID = (int)reader["CustumorID"];
                    ReviewText = (string)reader["ReviewText"];
                    Rating = (byte)reader["Rating"];
                    ReviewDate = (DateTime)reader["ReviewDate"];
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

                EventLog.WriteEntry(sourceName, "the error in get review by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return Isfound;

        }
        public static bool GetReviewByCustumorIDAndProductID(int custumorID,int productID,ref int reviewID,ref string ReviewText,ref byte Rating,ref DateTime ReviewDate)
        {
            bool Isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Review where CustumorID = @custumorID && ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@custumorID",custumorID);
            command.Parameters.AddWithValue("@productID", productID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Isfound = true;
                  
                    reviewID = (int)reader["ReviewID"];
                    ReviewText = (string)reader["ReviewText"];
                    Rating = (byte)reader["Rating"];
                    ReviewDate = (DateTime)reader["ReviewDate"];
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

                EventLog.WriteEntry(sourceName, "the error in get review by productID and custumorID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return Isfound;

        }
        public static int AddNewReview(int ProductID,int CustumorID,string ReviewText,byte Rating,DateTime ReviewDate)
        {
            int ReviewID = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into Review (ProductID,CustumorID,ReviewText,Rating,ReviewDate) values (@productID,@CustumorID,@ReviewText,@Rating,@ReviewDate);select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", ProductID);
            command.Parameters.AddWithValue("@CustumorID", CustumorID);
            command.Parameters.AddWithValue("@ReviewText", ReviewText);
            command.Parameters.AddWithValue("@Rating", Rating);
            command.Parameters.AddWithValue("@ReviewDate", ReviewDate);
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    ReviewID = ID;
                }

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new review is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }

            return ReviewID;
            
        }
        public static bool updateReview(int reviewID,int productID,int custumorID,string ReviewText,byte Rating,DateTime ReviewDate)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update Review 
                           set ProductID = @productID,
                           CustumorID = @custumorID,
                           ReviewText = @ReviewText,
                           Rating = @Rating,
                            ReviewDate = @reviewDate
                           where ReviewID = @reviewID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID",productID);
            command.Parameters.AddWithValue("@custumorID",custumorID);
            command.Parameters.AddWithValue("@ReviewText",ReviewText);
            command.Parameters.AddWithValue("@Rating",Rating);
            command.Parameters.AddWithValue("@reviewDate",ReviewDate);
            command.Parameters.AddWithValue("@reviewID",reviewID);
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

                EventLog.WriteEntry(sourceName, "the error in update review is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }
        public static bool DeleteReview(int reviewID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"delete Review where ReviewID = @reviewID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@reviewID", reviewID);
            try
            {   connexion.Open();
                rowsAffect = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in delete review is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }

            return rowsAffect > 0;
        }
        public static DataTable GetAllReview()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT Review.ReviewID, ProductCatalog.ProductName, ProductCatalog.Price, Custumor.Name, Custumor.Username, Review.ReviewText
                 FROM     Review INNER JOIN
                  ProductCatalog ON Review.ProductID = ProductCatalog.ProductID INNER JOIN
                  Custumor ON Review.CustumorID = Custumor.CustumorID";

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
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

                EventLog.WriteEntry(sourceName, "the error in get all review is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return dt;

        }

        public static DataTable GetAllReviewForProduct(int productID)
        {

            DataTable dt = new DataTable();
            string query = @"SELECT Review.ReviewID, Custumor.Name as Custumor, ProductCatalog.ProductName, Review.ReviewText, Review.Rating, Review.ReviewDate
                  FROM Review INNER JOIN
                  ProductCatalog ON Review.ProductID = ProductCatalog.ProductID INNER JOIN
                  Custumor ON Review.CustumorID = Custumor.CustumorID
				  where ProductCatalog.ProductID = @productID";

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@productID", productID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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

                EventLog.WriteEntry(sourceName, "the error in get all review for product is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return dt;

        }


    }
}
