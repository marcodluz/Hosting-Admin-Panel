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
    public partial class FormProduct : Form
    {
        private readonly FormProductInfo _parent;
        public string id, name, price, description, category;

        public FormProduct(FormProductInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblTitle.Text = "Update Product";
            btnSave.Text = "Update";
            txtName.Text = name;
            txtPrice.Text = price;
            txtDescription.Text = description;
            txtCategory.Text = category;
        }

        public void SaveInfo()
        {
            lblTitle.Text = "Add Product";
            btnSave.Text = "Save";
        }

        public void Clear()
        {
            txtName.Text = txtDescription.Text = txtPrice.Text = txtCategory.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product name is empty or smaller than 3 characters.");
                return;
            }
            if (txtDescription.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product description is empty or smaller than 3 characters.");
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product price is empty.");
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product category is empty.");
                return;
            }

            if(btnSave.Text == "Save")
            {
                Product pdt = new Product(txtName.Text.Trim(), txtDescription.Text.Trim(), txtPrice.Text.Trim(), txtCategory.Text.Trim());
                DBConnection.AddProduct(pdt);
                Clear();
            }

            if(btnSave.Text == "Update")
            {
                Product pdt = new Product(txtName.Text.Trim(), txtDescription.Text.Trim(), txtPrice.Text.Trim(), txtCategory.Text.Trim());
                DBConnection.UpdateProduct(pdt, id);
            }

            _parent.Display();
        }
    }
}
