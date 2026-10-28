using System;
using System.Windows.Forms;

namespace MIP_Lab5
{
    public partial class AddExistingProduct : Form
    {
        public AddExistingProduct()
        {
            InitializeComponent();
        }

        private void AddExistingProduct_Load(object sender, EventArgs e)
        {
        }

        private void addQuantityButton_Click(object sender, EventArgs e)
        {
            int productId;

            if (!int.TryParse(productIdTextBox.Text, out productId))
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }

            if (quantityInput.Value <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than zero.");
                return;
            }

            using (StoreContext db = new StoreContext())
            {
                Product product = db.Products.Find(productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                product.Quantity += (int)quantityInput.Value;
                db.SaveChanges();
            }

            MessageBox.Show("Quantity updated successfully!");
            this.Close();
        }
    }
}
