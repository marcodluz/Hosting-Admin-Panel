using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Element011
{
    class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server=localhost;Database=hosting;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }

        public static void AddProduct(Product pdt)
        {
            string sql = "INSERT INTO `product` (`product_name`, `price`, `description`, `category_id`, `inventory_id`) " +
                         "VALUES (@ProductName, @ProductPrice, @ProductDescription, @ProductCategoryID, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = pdt.Name;
            cmd.Parameters.Add("@ProductPrice", MySqlDbType.VarChar).Value = pdt.Price;
            cmd.Parameters.Add("@ProductDescription", MySqlDbType.VarChar).Value = pdt.Description;
            cmd.Parameters.Add("@ProductCategoryID", MySqlDbType.Int32).Value = pdt.Category;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static void UpdateProduct(Product pdt, string id)
        {
            string sql = "UPDATE `product` " +
                         "SET `product_name` = @ProductName, `price` = @ProductPrice, `description` = @ProductDescription, `category_id` = @ProductCategoryID " +
                         "WHERE product_id = @ProductID";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = pdt.Name;
            cmd.Parameters.Add("@ProductPrice", MySqlDbType.VarChar).Value = pdt.Price;
            cmd.Parameters.Add("@ProductDescription", MySqlDbType.VarChar).Value = pdt.Description;
            cmd.Parameters.Add("@ProductCategoryID", MySqlDbType.VarChar).Value = pdt.Category;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static void DeleteProduct(string id)
        {
            string sql = "DELETE FROM product WHERE product_id = @ProductID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product not deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }
    }
}
