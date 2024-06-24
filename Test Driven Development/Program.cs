using MySqlConnector;
using System;

namespace Test_Driven_Development
{
    public class Program
    {
        //qR%8&!d1eTtY@qCa6D8TqDNd90&Y57xh
        static string connStr = "Server=ND-COMPSCI;User ID=tl_w3;Password=qR%8&!d1eTtY@qCa6D8TqDNd90&Y57xh;Database=w3schools_db";
        public static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Search products based on product ID");
                Console.WriteLine("2. Search suppliers based on supplier ID");
                Console.WriteLine("3. Search customers based on supplier ID");
                Console.WriteLine("0. Quit");
                string input = Console.ReadLine();
                if (new string[] { "0", "1", "2", "3" }.Contains(input))
                {
                    switch (input)
                    {
                        case "0":
                            running = false;
                            break;
                        case "1":
                            ProductMenu();
                            break;
                        case "2":
                            GetSupplier(ValidInt());
                            break;
                        case "3":
                            CustomerMenu();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static int ValidInt()
        {
            string input = "-";
            int output;
            while (!int.TryParse(input, out output))
            {
                Console.WriteLine("Enter an integer: ");
                input = Console.ReadLine();
            }
            return output;
        }
        public static void GetProduct(int productID)
        {
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT productName FROM products WHERE productID = @productID;", connection);
            command.Parameters.AddWithValue("@productID", productID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
            else
            {
                Console.WriteLine($"no product found with id {productID}");
            }
        }
        public static void GetSupplier(int supplierID)
        {            
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT supplierName FROM suppliers WHERE supplierID = @supplierID;", connection);
            command.Parameters.AddWithValue("@supplierID", supplierID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
            else
            {
                Console.WriteLine($"no supplier found with id {supplierID}");
            }
        }
        public static void ProductMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Searching products by product ID, Choose an option:");
                Console.WriteLine("1. Get product name");
                Console.WriteLine("2. Get category of product");
                Console.WriteLine("3. Get supplier of product");
                Console.WriteLine("0. Quit");
                string input = Console.ReadLine();
                if (new string[] { "0", "1", "2", "3" }.Contains(input))
                {
                    switch (input)
                    {
                        case "0":
                            running = false;
                            break;
                        case "1":
                            GetProduct(ValidInt());
                            break;
                        case "2":
                            GetCategoryOfProduct(ValidInt());
                            break;
                        case "3":
                            GetSupplierOfProduct(ValidInt());
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static void GetCategoryOfProduct(int productID)
        {
            string categoryName = "Category for product with ID 0 not found";
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT categoryName FROM products, categories WHERE productID = @productID " +
                "AND products.categoryID = categories.categoryID;", connection);
            command.Parameters.AddWithValue("@productID", productID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                categoryName = reader.GetString(0);
            }
            Console.WriteLine(categoryName);
        }
        public static void GetSupplierOfProduct(int productID)
        {
            string supplierName = "Supplier for product with ID 0 not found";
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT supplierName FROM products, suppliers WHERE productID = @productID " +
                "AND products.supplierID = suppliers.supplierID;", connection);
            command.Parameters.AddWithValue("@productID", productID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                supplierName = reader.GetString(0);
            }
            Console.WriteLine(supplierName);
        }
        public static void CustomerMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Searching customers by customer ID, Choose an option:");
                Console.WriteLine("1. Get customer name");
                Console.WriteLine("2. Get contact name (initals)");
                Console.WriteLine("3. Get address, city, postcode, country");
                Console.WriteLine("0. Quit");
                string input = Console.ReadLine();
                if (new string[] { "0", "1", "2", "3" }.Contains(input))
                {
                    switch (input)
                    {
                        case "0":
                            running = false;
                            break;
                        case "1":
                            GetCustomerName(ValidInt());
                            break;
                        case "2":
                            GetContactName(ValidInt());
                            break;
                        case "3":
                            GetFullCustomerAddress(ValidInt());
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static void GetCustomerName(int customerID)
        {
            string customerName = "Customer with ID 0 not found";
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT customerName FROM customers WHERE customerID = @customerID;", connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                customerName = reader.GetString(0);
            }
            Console.WriteLine(customerName);
        }
        public static void GetContactName(int customerID)
        {
            string contactName = "Contact for customer with ID 0 not found";
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT contactName FROM customers WHERE customerID = @customerID;", connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                contactName = reader.GetString(0);
                string[] splitName = contactName.Split(" ");
                contactName = $"{splitName[0][0]}.{splitName[1][0]}.";
            }
            Console.WriteLine(contactName);
        }
        public static void GetFullCustomerAddress(int customerID)
        {
            string FullCustomerAddress = "Address for customer with ID 0 not found";
            using var connection = new MySqlConnection(connStr);
            connection.Open();
            using var command = new MySqlCommand("SELECT Address, City, PostalCode, Country FROM customers WHERE customerID = @customerID;", connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                FullCustomerAddress = $"{reader.GetString(0)}, {reader.GetString(1)}, {reader.GetString(2)}, {reader.GetString(3)}";
            }
            Console.WriteLine(FullCustomerAddress);
        }
    }
}
