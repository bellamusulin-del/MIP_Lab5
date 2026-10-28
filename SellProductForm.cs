
using System;
using System.Windows.Forms;

namespace MIP_Lab5
{
    public partial class SellProductForm : Form
    {
        private int productId;

        public SellProductForm(int id)
        {
            InitializeComponent();
            productId = id;
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {
            using (StoreContext db = new StoreContext())
            {
                Product product = db.Products.Find(productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    this.Close();
                    return;
                }

                productNameLabel.Text = "Product: " + product.Name;
                availableQuantityLabel.Text =
                    "Available quantity: " + product.Quantity;
                expiryDateLabel.Text =
                    "Expiry date: " + product.ExpiryDate.ToShortDateString();
                descriptionLabel.Text =
                    "Description: " + product.Description;
                entryDateLabel.Text =
                    "Entry date: " + product.EntryDate.ToShortDateString();

                sellQuantityInput.Minimum = 1;
                sellQuantityInput.Maximum = Math.Max(1, product.Quantity);
                sellQuantityInput.Value = 1;

                sellButton.Enabled = product.Quantity > 0;
            }
        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            int quantityToSell = (int)sellQuantityInput.Value;

            using (StoreContext db = new StoreContext())
            {
                Product product = db.Products.Find(productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    this.Close();
                    return;
                }

                if (quantityToSell > product.Quantity)
                {
                    MessageBox.Show("Not enough products in stock.");
                    return;
                }

                product.Quantity = product.Quantity - quantityToSell;

                if (product.Quantity == 0)
                {
                    db.Products.Remove(product);
                }

                db.SaveChanges();
            }

            MessageBox.Show("Sale completed successfully!");
            this.Close();
        }

    }
}

