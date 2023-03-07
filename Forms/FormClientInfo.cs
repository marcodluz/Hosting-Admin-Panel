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
    public partial class FormClientInfo : Form
    {
        public FormClientInfo()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            DBConnection.DisplayAndSearch("SELECT c.first_name, c.last_name, c.email, c.phone, SUM(oi.quantity * p.price) AS total_spend " +
                "FROM order_item oi " +
                "JOIN product p ON p.product_id = oi.product_id " +
                "JOIN order_details o ON o.order_id = oi.order_id " +
                "JOIN client c ON c.client_id = o.client_id " +
                "WHERE o.order_date >= DATE_SUB(CURDATE(), INTERVAL 1 YEAR) " +
                "GROUP BY c.client_id " +
                "ORDER BY total_spend DESC " +
                "LIMIT 10; ", dataGridViewClientsTop);

            DBConnection.DisplayAndSearch("SELECT c.first_name, c.last_name, c.email, MAX(od.order_date) AS last_order_date " +
                "FROM client c " +
                "LEFT JOIN order_details od ON od.client_id = c.client_id " +
                "WHERE od.order_date < DATE_SUB(CURDATE(), INTERVAL 6 MONTH) OR od.order_date IS NULL " +
                "GROUP BY c.client_id", dataGridViewClientsOrders); 
        }
    }
}
