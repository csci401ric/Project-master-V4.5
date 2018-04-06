/***********************************
 * ItemClass.cs
 * Created by The Dev Doods -Mike M.
***********************************/


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStopNBuy.SuperStopNBuyClasses
{
    public class ItemClass
    {
        //getter & setter
        public string itemName { get; set; }
        public int itemNumber { get; set; }
        public double itemPrice { get; set; }
        public int itemQuantity { get; set; }
        public string itemDesc { get; set; }
        public string itemCategory { get; set; }

        public DataTable Select()
        {
            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);
            DataTable itemDataTable = new DataTable();

            try
            {
                //SQL query to get items
                string getItemStatement = "SELECT * FROM product";

                //execute
                MySqlCommand getItemCommand = new MySqlCommand(getItemStatement, databaseConnection);

                MySqlDataAdapter adapt = new MySqlDataAdapter(getItemCommand);

                databaseConnection.Open();
                adapt.Fill(itemDataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return itemDataTable;
        }


        public DataTable SelectCategory(String category)
        {
            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);
            DataTable itemDataTable = new DataTable();

            try
            {
                //SQL query to get items
                string getItemStatement = "SELECT name, price, description FROM product WHERE category = '" + category + "'";

                //execute
                MySqlCommand getItemCommand = new MySqlCommand(getItemStatement, databaseConnection);

                MySqlDataAdapter adapt = new MySqlDataAdapter(getItemCommand);

                databaseConnection.Open();
                adapt.Fill(itemDataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return itemDataTable;
        }

        public DataTable SelectSearch(String search, bool isManager)
        {
            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);
            DataTable itemDataTable = new DataTable();

            try
            {
                //SQL query to get items
                string getItemStatement = "SELECT name, price, description FROM product WHERE name LIKE '%" + search + "%'";

                if (isManager == true)
                {
                    getItemStatement = "SELECT * FROM product WHERE name LIKE '%" + search + "%'";
                }

                //execute
                MySqlCommand getItemCommand = new MySqlCommand(getItemStatement, databaseConnection);

                MySqlDataAdapter adapt = new MySqlDataAdapter(getItemCommand);

                databaseConnection.Open();
                adapt.Fill(itemDataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return itemDataTable;
        }


        //insert data to database
        public bool InsertToDatabase(ItemClass insertItem)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                //SQL query to insert items
                string insertItemStatement = "INSERT INTO product (name, itemNumber, price, quantity, description, category) VALUES (@name, @itemNumber, @price, @quantity, @description, @category)";

                //execute
                MySqlCommand insertItemCommand = new MySqlCommand(insertItemStatement, databaseConnection);

                insertItemCommand.Parameters.AddWithValue("@name", insertItem.itemName);
                insertItemCommand.Parameters.AddWithValue("@itemNumber", insertItem.itemNumber);
                insertItemCommand.Parameters.AddWithValue("@price", insertItem.itemPrice);
                insertItemCommand.Parameters.AddWithValue("@quantity", insertItem.itemQuantity);
                insertItemCommand.Parameters.AddWithValue("@description", insertItem.itemDesc);
                insertItemCommand.Parameters.AddWithValue("@category", insertItem.itemCategory);

                databaseConnection.Open();
                int rows = insertItemCommand.ExecuteNonQuery();

                if(rows > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;
        }
        

        public bool UpdateDatabaseItem(ItemClass updateItem)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                string updateItemStatement = "UPDATE product SET name=@name, itemNumber=@itemNumber, price=@price, quantity=@quantity, description=@description, category=@category WHERE itemNumber=@itemNumber";
                //execute
                MySqlCommand updateItemCommand = new MySqlCommand(updateItemStatement, databaseConnection);
                updateItemCommand.Parameters.AddWithValue("@name", updateItem.itemName);
                updateItemCommand.Parameters.AddWithValue("@itemNumber", updateItem.itemNumber);
                updateItemCommand.Parameters.AddWithValue("@price", updateItem.itemPrice);
                updateItemCommand.Parameters.AddWithValue("@quantity", updateItem.itemQuantity);
                updateItemCommand.Parameters.AddWithValue("@description", updateItem.itemDesc);
                updateItemCommand.Parameters.AddWithValue("@category", updateItem.itemCategory);

                databaseConnection.Open();

                int rows = updateItemCommand.ExecuteNonQuery();
                if(rows > 0)
                {
                    isValid = true;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;
        }

        public bool DeleteDatabaseItem(ItemClass deleteItem)
        {
            bool isValid = false;

            //establish database connection
            MySqlConnection databaseConnection = new MySqlConnection(Global.ConnectionString);

            try
            {
                string deleteItemStatement = "DELETE FROM product WHERE itemNumber=@itemNumber";
                MySqlCommand deleteItemCommand = new MySqlCommand(deleteItemStatement, databaseConnection);
                deleteItemCommand.Parameters.AddWithValue("@itemNumber", deleteItem.itemNumber);
                databaseConnection.Open();

                int rows = deleteItemCommand.ExecuteNonQuery();
                if(rows > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return isValid;

        }
    }
}
