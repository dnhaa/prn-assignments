using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList(orderDetailRepository.GetOrderDetailList());
        }
        public void LoadOrderDetailList(IEnumerable<Object> orderDetails)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList(orderDetailRepository.SortSalesDescending());
            dgvOrderDetailList.Columns[5].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);
            try
            {
                LoadOrderDetailList(orderDetailRepository.FilterDate(startDate, endDate));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sales by Period");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            frmMembers.ShowDialog();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails();
            frmMemberDetails.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails();
            frmProductDetails.ShowDialog();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDatail = new frmOrderDetails();
            frmOrderDatail.ShowDialog();
        }
    }
}
