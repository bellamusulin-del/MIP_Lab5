using System;
using System.Windows.Forms;

namespace MIP_Lab5
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            using (StoreContext db = new StoreContext())
            {
                Product product = new Product();

                product.Name = nameTextBox.Text.Trim();
                product.Description = descriptionTextBox.Text.Trim();
                product.EntryDate = DateTime.Now;
                product.ExpiryDate = expiryDatePicker.Value;
                product.Quantity = (int)quantityInput.Value;

                db.Products.Add(product);
                db.SaveChanges();
            }

            MessageBox.Show("Product added successfully!");
            this.Close();
        }
    }
}