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
    public partial class FormProductInfo : Form
    {
        FormProduct form;

        public FormProductInfo()
        {
            InitializeComponent();
            form = new FormProduct(this);
        }

        public void Display()
        {
            DBConnection.DisplayAndSearch("SELECT product_id, product_name, price, description, category_id, inventory_id FROM product", dataGridViewProducts);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormProducts_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBConnection.DisplayAndSearch("SELECT product_id, product_name, price, description, category_id, inventory_id FROM product " +
                                          "WHERE product_name LIKE'%" + txtSearch.Text + "%'", dataGridViewProducts);
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                // Edit
                form.Clear();
                form.id = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.price = dataGridViewProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.description = dataGridViewProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.category = dataGridViewProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                // Delete
                if (MessageBox.Show("Are you sure you want to delete this product?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBConnection.DeleteProduct(dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
