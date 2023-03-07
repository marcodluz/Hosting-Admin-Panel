using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Element011.Forms
{
    public partial class FormRevenueInfo : Form
    {
        public FormRevenueInfo()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            DBConnection.DisplayAndSearch("SELECT pc.category_name, SUM(oi.quantity * p.price) AS revenue " +
                "FROM order_item oi " +
                "JOIN product p ON p.product_id = oi.product_id " +
                "JOIN product_category pc ON pc.category_id = p.category_id " +
                "WHERE oi.order_id IN (" +
                "SELECT order_id FROM order_details " +
                "WHERE order_date >= DATE_SUB(CURDATE(), INTERVAL 3 MONTH)" +
                ") " +
                "GROUP BY pc.category_name; ", dataGridViewClients);
        }
    }
}
