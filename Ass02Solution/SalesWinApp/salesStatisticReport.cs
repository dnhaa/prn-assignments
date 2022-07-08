using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;

namespace SalesWinApp
{
    public partial class salesStatisticReport : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public salesStatisticReport()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void salesStatisticReport_Load(object sender, EventArgs e)
        {

        }
        public void LoadOrderDetailList()
        {
            var orderDetails = orderDetailRepository.GetOrderDetailList();
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;
                /*if (orderDetails.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }
    }
}
