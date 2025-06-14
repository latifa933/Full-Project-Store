
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StoreDataLayer
{
    public class clsOrderData
    {
        public static bool GetOrderByID(int orderID,ref int CustumorID,ref DateTime OrderDate,ref float TotalAmount,ref byte Status)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "SELECT TOP (1000) [OrderID],[CustumorID] ,[OrderDate],[TotalAmount],[status] FROM [Store].[dbo].[Order] where OrderID = @orderID";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);

            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CustumorID = (int)reader["CustumorID"];
                    OrderDate = (DateTime)reader["OrderDate"];
                    TotalAmount = Convert.ToSingle(reader["TotalAmount"]);
                    Status = (byte)reader["status"];
                    
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

                EventLog.WriteEntry(sourceName, "the error in Get order by ID is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }
            return IsFound;

        }
        
        public static bool GetOrderByCustumorID(int custumorID,ref int orderID,ref DateTime orderdate,ref float TotalAmount,ref byte status)
        {
            bool IsFound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Order where CustumorID = @custumorID";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@custumorID",custumorID);

            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    orderID = (int)reader["OrderID"];
                    orderdate = (DateTime)reader["OrderDate"];
                    TotalAmount = Convert.ToSingle(reader["TotalAmount"]);
                    status = (byte)reader["status"];

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

        public static int AddNewOrder(int custumorID,DateTime orderDate,float totalAmount,byte status)
        {
            int orderID = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"INSERT INTO [dbo].[Order]
           ([CustumorID]
           ,[OrderDate]
           ,[TotalAmount]
           ,[status]) values (@CustumorID,@OrderDate,@TotalAmount,@Status);
                select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID",custumorID);
            command.Parameters.AddWithValue("@OrderDate",orderDate);
            command.Parameters.AddWithValue("@TotalAmount",totalAmount);
            command.Parameters.AddWithValue("@Status",status);
            
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    orderID = ID;
                }


            }
            catch (Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new order is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return orderID;
        }

        public static bool UpdateOrder(int orderID,int custumorID,DateTime orderDate,float totalAmount,byte Status)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"
                            UPDATE [dbo].[Order]
                            SET [CustumorID] = @CustumorID
                          ,[OrderDate] = @OrderDate
                          ,[TotalAmount] = @TotalAmount
                          ,[status] = @status
                           WHERE OrderID = @orderID";
                            
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID",custumorID );
            command.Parameters.AddWithValue("@OrderDate",orderDate);
            command.Parameters.AddWithValue("@TotalAmount",totalAmount);
            command.Parameters.AddWithValue("@status",Status);
            command.Parameters.AddWithValue("@orderID",orderID);
           

            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in update order by ID is " + ex.Message, EventLogEntryType.Error);


            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;

        }

        public static bool DeleteOrder(int orderID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "DELETE FROM [dbo].[Order] WHERE OrderID = @OrderID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@OrderID",orderID);

            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return rowsAffect > 0;
        }

        public static int GetOrderForCustumorID(int CustumorID)
        {
            int orderID = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select OrderID from Order where CustumorID = @CustumorID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID",CustumorID);
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    orderID = ID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connexion.Close();
            }
            return orderID;

        }

        public static bool UpdateStatus(int orderID,byte NewStatus)
        {
            int rowsAffect = 0;
            string query = @"Update Order
                            set status = @newStatus
                             where OrderID = @orderID";
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@newStatus", NewStatus);
            command.Parameters.AddWithValue("@orderID", orderID);
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

                EventLog.WriteEntry(sourceName, "the error in Update status is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return rowsAffect > 0;
        }


        public static DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"SELECT [Order].OrderID, [Order].CustumorID, Custumor.Name, Custumor.Email, Custumor.Phone, Custumor.Address, Custumor.Username, [Order].OrderDate, [Order].TotalAmount, [Order].status
                  FROM     [Order] INNER JOIN
                  Custumor ON [Order].CustumorID = Custumor.CustumorID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
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

                EventLog.WriteEntry(sourceName, "the error in Get all order is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connection.Close();
            }

            return dt;


        }

    }
}
