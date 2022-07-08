using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList(productRepository.GetProducts());
        }
        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Update product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productRepository.GetProducts());
                source.Position = source.Count - 1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Update product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productRepository.GetProducts());
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList(productRepository.GetProducts());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }
        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }
        public void LoadProductList(IEnumerable<Product> orders)
        {
            //orders = ;
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }


        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> products = new List<Product>();
            try
            {
                switch (cboSearchBy.SelectedIndex)
                {
                    case 0:
                        products = productRepository.SearchProductBy("ProductId", txtSearch.Text);
                        break;
                    case 1:
                        products = productRepository.SearchProductBy("ProductName", txtSearch.Text);
                        break;
                    case 2:
                        products = productRepository.SearchProductBy("UnitPrice", txtSearch.Text);
                        break;
                    case 3:
                        products = productRepository.SearchProductBy("UnitsInStock", txtSearch.Text);
                        break;

                }
                LoadProductList(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search product");
            }
        }

        private void cboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSearchBy.SelectedIndex)
            {
                case 0:
                    lbValue.Text = "value";
                    break;
                case 1:
                    lbValue.Text = "value";
                    break;
                case 2:
                    lbValue.Text = "value MAXIMUM";
                    break;
                case 3:
                    lbValue.Text = "value MAXIMUM";
                    break;

            }
        }
    }
}
