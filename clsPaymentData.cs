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
    public class clsPaymentData
    {
        public static bool GetPaymentByID(int paymentID,ref int orderID,ref float Amount,ref string paymentMethod,ref DateTime TransactionDate)
        {
            bool IsFound = false;

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Payment where PaymentID = @paymentID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@paymentID", paymentID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    orderID = (int)reader["OrderID"];    
                    Amount = Convert.ToSingle(reader["Amount"]);
                    paymentMethod = (string)reader["PaymentMethod"];
                    TransactionDate = (DateTime)reader["TransactionDate"];

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

                EventLog.WriteEntry(sourceName, "the error in Get paymentID by ID is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            { 
            
                connexion.Close();
            }
            return IsFound;

        }


        public static bool GetPaymentByOrderID(int orderID, ref int paymentID, ref float Amount, ref string paymentMethod, ref DateTime TransactionDate)
        {
            bool IsFound = false;

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from Payment where OrderID = @OrderID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@OrderID",orderID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    paymentID= (int)reader["PaymentID"];
                    Amount = Convert.ToSingle(reader["Amount"]);
                    paymentMethod = (string)reader["PaymentMethod"];
                    TransactionDate = (DateTime)reader["TransactionDate"];

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

                EventLog.WriteEntry(sourceName, "the error in get payment by orderID is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }
            return IsFound;

        }


        public static DataTable GetAllPaymentForCustumor(int CustumorID)
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"SELECT Custumor.CustumorID, Custumor.Name, Custumor.Phone, Custumor.Address, Custumor.Username, [Order].OrderID, [Order].OrderDate, Payment.PaymentID, Payment.Amount, Payment.PaymentMethod
                 FROM     Custumor INNER JOIN
                  [Order] ON Custumor.CustumorID = [Order].CustumorID INNER JOIN
                  Payment ON [Order].OrderID = Payment.OrderID
				  where Custumor.CustumorID = @CustumorID";

            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@CustumorID", CustumorID);
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

                EventLog.WriteEntry(sourceName, "the error in get all payment is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return dt;

        }


        public static int AddNewPayment(int orderID,float amount,string paymentMethod,DateTime TransactionDate)
        {
            int paymentID = -1;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Insert into Payment (OrderID,Amount,PaymentMethod,TransactionDate) values (@orderID,@Amount,@paymentMethod,@TransactionDate); 
                               select scope_Identity();";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@Amount", amount);
            command.Parameters.AddWithValue("@paymentMethod", paymentMethod);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            try
            {
                connexion.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    paymentID = ID;
                }

            }
            catch(Exception ex)
            {
                string sourceName = "Store";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, "the error in add new payment is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }

            return paymentID;
        }

        public static bool UpdatePayment(int paymentID,int orderID,float amount,string paymentMethod,DateTime TransactionDate)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update Payment 
                             set OrderID = @orderID,
                                 Amount = @amount,
                                 PaymentMethod = @paymentMethod,
                                 TransactionDate = @transactionDate
                                  where PaymentID = @paymentID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@paymentMethod", paymentMethod);
            command.Parameters.AddWithValue("@transactionDate", TransactionDate);
            command.Parameters.AddWithValue("@paymentID", paymentID);
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

                EventLog.WriteEntry(sourceName, "the error in update payment is " + ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connexion.Close();
            }


            return rowsAffect > 0;


        }

        public static bool deletePayment(int paymentID)
        { int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete Payment where PaymentID = @paymentID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@paymentID", paymentID);
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

                EventLog.WriteEntry(sourceName, "the error in delete payment is " + ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connexion.Close();
            }

            return rowsAffect > 0;


        }



    }
}
