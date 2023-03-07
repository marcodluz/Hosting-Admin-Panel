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
    public partial class FormTicketInfo : Form
    {
        public FormTicketInfo()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            DBConnection.DisplayAndSearch("SELECT tc.category_name, COUNT(*) " +
                "AS num_tickets, AVG(TIMESTAMPDIFF(HOUR, t.created_date, t.resolved_date)) AS avg_resolution_time " +
                "FROM ticket t " +
                "JOIN ticket_category tc ON tc.ticket_category_id = t.ticket_category_id " +
                "GROUP BY tc.category_name; ", dataGridViewTickets);
        }
    }
}
