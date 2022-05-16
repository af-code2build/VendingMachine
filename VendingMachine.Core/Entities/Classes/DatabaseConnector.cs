using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Core.Entities.Classes
{
    public static class DatabaseConnector
    {
        public static string connectionString = @"Data Source=.\Database\VendingMachine.db;Version=3";

        public static IEnumerable<Coin> LoadCoinReserves()
        {
            using IDbConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            var query = "select * from Coins";

            return connection.Query<Coin>(query, new DynamicParameters());
        }

        public static void UpdateCoinReserves(Dictionary<string, Coin> coinList)
        {
            using var connection = new SQLiteConnection(connectionString);

            connection.Open();

            using SQLiteCommand cmd = new SQLiteCommand(connection);

            foreach (var coin in coinList.Values)
            {
                cmd.CommandText = $"UPDATE Coins SET Quantity={coin.Quantity} WHERE ID={coin.Id}";
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateCoinQuantity(Coin coin)
        {
            using var connection = new SQLiteConnection(connectionString);

            connection.Open();

            using SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.CommandText = $"UPDATE Coins SET Quantity={coin.Quantity} WHERE ID={coin.Id}";
            cmd.ExecuteNonQuery();
        }

        public static List<Product> LoadProductList()
        {
            using IDbConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            var query = "select * from Products";

            return connection.Query<Product>(query, new DynamicParameters()).ToList();

        }

        public static void UpdateProductList(Product product)
        {
            using var connection = new SQLiteConnection(connectionString);

            connection.Open();

            using SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.CommandText = $"UPDATE Products SET Quantity={product.Quantity}, Price={product.Price:0.00} WHERE ID={product.Id}";
            cmd.ExecuteNonQuery();

        }

        public static void AddNewProduct(Product product)
        {
            using var connection = new SQLiteConnection(connectionString);

            connection.Open();

            using SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.CommandText = $"INSERT INTO Products(Name, Quantity, Price, Picture) VALUES('{product.Name}', {product.Quantity}, {product.Price}, '{product.Picture}')";
            cmd.ExecuteNonQuery();

        }

        public static bool CheckAdminPassword(string password)
        {
            using IDbConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            var query = "select * from KeyAccess";

            var result = connection.Query<KeyAccess>(query, new DynamicParameters()).FirstOrDefault().MasterKey;

            if (result == password)
            {
                return true;
            }

            return false;
        }
    }
}
