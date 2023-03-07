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
    public partial class FormOrderInfo : Form
    {
        public FormOrderInfo()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            DBConnection.DisplayAndSearch("SELECT pc.category_name AS category, " +
                "p.product_name AS product, " +
                "SUM(oi.quantity * p.price) AS total_amount " +
                "FROM product_category pc " +
                "JOIN product p ON pc.category_id = p.category_id " +
                "JOIN order_item oi ON p.product_id = oi.product_id " +
                "JOIN order_details od ON oi.order_id = od.order_id " +
                "GROUP BY pc.category_name, p.product_name " +
                "ORDER BY pc.category_name ASC; ", dataGridViewOrders);
        }
    }
}
