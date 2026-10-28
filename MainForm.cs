using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIP_Lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (StoreContext db = new StoreContext())
            {
                db.Database.CreateIfNotExists();
            }

            LoadProducts();
        }

        // Load products from the database into the DataGridView
        private void LoadProducts()
        {
            using (StoreContext db = new StoreContext())
            {
                productsGrid.DataSource = null;
                productsGrid.DataSource = db.Products.ToList();
            }
        }
        private void SearchProducts()
        {
            string searchText = searchTextBox.Text.Trim();

            using (StoreContext db = new StoreContext())
            {
                productsGrid.DataSource = null;

                productsGrid.DataSource = db.Products
                    .Where(p => p.Name.Contains(searchText))
                    .ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        // Refresh button
        /*private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }*/ //1st attempt
        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        // Add Products menu item
        private void addProductsMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct form = new AddNewProduct();
            form.ShowDialog();

            LoadProducts();
        }

        // Add Products button, if you have one
        private void addProductsButton_Click(object sender, EventArgs e)
        {
            AddNewProduct form = new AddNewProduct();
            form.ShowDialog();

            LoadProducts();
        }

        private void existingProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExistingProduct form = new AddExistingProduct();
            form.ShowDialog();

            LoadProducts();

        }
        private void productsGrid_CellDoubleClick(
    object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int productId = Convert.ToInt32(
                productsGrid.Rows[e.RowIndex].Cells["Id"].Value);

            SellProductForm form = new SellProductForm(productId);
            form.ShowDialog();

            LoadProducts();
        }

        private async Task LoadProductsAsync()
        {
            var products = await Task.Run(() =>
            {
                using (StoreContext db = new StoreContext())
                {
                    return db.Products.ToList();
                }
            });

            Action updateGrid = () =>
            {
                productsGrid.DataSource = null;
                productsGrid.DataSource = products;
            };

            if (productsGrid.InvokeRequired)
            {
                productsGrid.Invoke(updateGrid);
            }
            else
            {
                updateGrid();
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();

            using (StoreContext db = new StoreContext())
            {
                var results = db.Products
                    .Where(p => p.Name.Contains(searchText))
                    .ToList();

                MessageBox.Show("Results found: " + results.Count);

                productsGrid.DataSource = null;

                BindingSource source = new BindingSource();
                source.DataSource = results;

                productsGrid.AutoGenerateColumns = true;
                productsGrid.DataSource = source;
            }
        }
    }
}