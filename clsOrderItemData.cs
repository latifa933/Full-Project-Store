using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataLayer
{
    public class clsOrderItemData
    {  
        public static bool GetItemByOrderAndProduct(int orderID,int productID,ref int quantity,ref float price)
        {
            bool isfound = false;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"select * from OrderItems where OrderID = @OrderID and ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@OrderID", orderID);
            command.Parameters.AddWithValue("@productID", productID);
            try
            {
                connexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    quantity = (int)reader["Quantity"];
                    price = Convert.ToSingle(reader["Price"]);
                    

                }
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


        public static DataTable GetAllOrderItemForOrder(int? orderID)
        {
            DataTable dt = new DataTable();
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "select * from OrderItems where OrderID = @OrderID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@OrderID", orderID);
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

            }
            finally
            {
                connexion.Close();
            }
            return dt;
        }

     public static bool AddNewOrderItem(int? orderID,int? productID,int? quantity,float? price)
        {
            int rowsAffect = 0;
            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "insert into OrderItems (OrderID,ProductID,Quantity,Price,TotalItemsPrice) Values(@orderID,@productID,@Quantity,@price,@TotalItemPrice)";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@TotalItemPrice", quantity * price);
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

        public static bool UpdateOrderItem(int? orderID,int? productID,int? quantity,float? price)
        {
            int rowsAffect = 0;

            SqlConnection connexion = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = @"Update OrderItems
                              set OrderID = @orderID,
                              ProductID = @productID,
                              Quantity = @quantity,
                              Price = @price,
                              TotalItemsPrice = @totalItemPrice
                              where OrderID = @orderID and ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@productID", productID);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@totalItemPrice", quantity * price);

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
        public static bool deleteOrderItem(int? orderID,int?productID)
        {
            int rowsaffect = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnexionString);
            string query = "delete OrderItems where OrderID = @orderID and ProductID = @productID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@productID", productID);
            try
            {
                connection.Open();
                rowsaffect = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return rowsaffect > 0;

        }

    }
}
