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
    public partial class FormReportInfo : Form
    {
        public FormReportInfo()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            Display(dateTimePicker1.Text);
        }

        public void Display(string year)
        {
            DBConnection.DisplayAndSearch("CALL sales_by_month(" + year + ");", dataGridViewReport1);
            DBConnection.DisplayAndSearch("CALL top_products(" + year + ");", dataGridViewReport2);
        }
    }
}
