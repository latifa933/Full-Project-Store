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
    public class clsShippingData
    {
        public static bool GetShippingByID(int shippingID,ref int orderID,ref string CarrierName,ref string TrackingNumber,ref byte ShippingStatus,ref DateTime Estimated,ref DateTime? Actual )
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Shipping where ShippingID = @shippingID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@shippingID", shippingID);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    orderID = (int)reader["OrderID"];
                    CarrierName = (string)reader["CarrierName"];
                    TrackingNumber = (string)reader["TrackingNumber"];
                    ShippingStatus = (byte)reader["ShippingStatus"];
                    Estimated = (DateTime)reader["EstimatedDeliveryDate"];
                    if (reader["ActualDeliveryDate"] != DBNull.Value)
                        Actual = (DateTime)reader["ActualDeliveryDate"];
                    else
                        Actual = null;
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

                EventLog.WriteEntry(sourceName, "the error in Get Shipping by ID is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return isfound;
        }
        public static bool GetShippingByOrderID(int orderID,ref int shippingID,ref string CarrierName,ref string TrackingNumber,ref byte ShippinStatus,ref DateTime EstimatdDelivryDate, ref DateTime? ActuaDelivryDate)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Shipping where OrderID = @orderID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    shippingID = (int)reader["ShippingID"];
                    CarrierName = (string)reader["CarrierName"];
                    TrackingNumber = (string)reader["TrackingNumber"];
                    ShippinStatus = (byte)reader["ShippingStatus"]; 
                    EstimatdDelivryDate = (DateTime)reader["EstimatedDeliveryDate"];
                    ActuaDelivryDate = (DateTime)reader["ActualDeliveryDate"];

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

                EventLog.WriteEntry(sourceName, "the error in Get Shipping by OrderID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
            return isfound;

        }
        public static int AddnewShipping(int orderID,string carrierName,string TrackingNumber,byte ShippingStatus,DateTime EstimatedDelivryDate,DateTime? ActualDelivryDate)
        {
            int shippingID = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into Shipping (OrderID,CarrierName,TrackingNumber,ShippingStatus,EstimatedDeliveryDate,
                     ActualDeliveryDate) values(@orderID,@carrierName,@TrackingNumber,@ShippingStatus,@EstimatedDelivryDate,@ActualDelivryDate);select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@carrierName", carrierName);
            command.Parameters.AddWithValue("@TrackingNumber", TrackingNumber);
            command.Parameters.AddWithValue("@ShippingStatus", ShippingStatus);
            command.Parameters.AddWithValue("@EstimatedDelivryDate", EstimatedDelivryDate);
            if(ActualDelivryDate != null)
            command.Parameters.AddWithValue("@ActualDelivryDate", ActualDelivryDate);
            else
            {
                command.Parameters.AddWithValue("@ActualDelivryDate", DBNull.Value);
            }
            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    shippingID = ID;
                }
            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in Add new Shipping is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }


            return shippingID;
        }
        public static bool updateShipping(int shippingID,int orderID,string carrierName,string TrackingNumber,byte ShippingStatus,DateTime EstimatedDelivryDate,DateTime? ActualDelivryDate)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update Shipping 
                             set OrderID = @orderID,
                             CarrierName = @cattrierName,
                             TrackingNumber = @TrackingNumber,
                             ShippingStatus = @ShippingStatus,
                             EstimatedDeliveryDate = @EstimatedDelivryDate,
                             ActualDeliveryDate = @ActualDelivryDate
                             where ShippingID = @shippingID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID",orderID);
            command.Parameters.AddWithValue("@cattrierName", carrierName);
            command.Parameters.AddWithValue("@TrackingNumber", TrackingNumber);
            command.Parameters.AddWithValue("@ShippingStatus", ShippingStatus);
            command.Parameters.AddWithValue("@EstimatedDelivryDate", EstimatedDelivryDate);
            command.Parameters.AddWithValue("@ActualDelivryDate", ActualDelivryDate);
            command.Parameters.AddWithValue("@shippingID", shippingID);
            try
            { connexion.Open();
                rowsAffect = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in update Shipping is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }
              
            return rowsAffect > 0;
        }
        public static bool deleteShipping(int shippingID)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete Shipping where ShippingID = @shippingID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@shippingID", shippingID);
            try
            {
                connexion.Open();
                rowsAffect = command.ExecuteNonQuery();

            }
            catch(Exception  ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in delete Shipping is " + ex.Message, EventLogEntryType.Error);


            }
            finally
            {
                connexion.Close();
            }


            return rowsAffect > 0;

        }
        public static DataTable GetAllShippings()
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from view_AllShipping";
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

                EventLog.WriteEntry(sourceName, "the error in get All Shipping is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }

            return dt;
        }

    }
}
