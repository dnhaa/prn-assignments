using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfo { get; set; }

    private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtOrderId.Text = OrderInfo.OrderId.ToString();
                txtMemberId.Text = OrderInfo.MemberId.ToString();
                txtOrderDate.Text = OrderInfo.OrderDate.ToString();
                txtRequiredDate.Text = OrderInfo.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtFreight.Text = OrderInfo.Freight.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = txtOrderDate.Value.Date,
                    RequiredDate = txtRequiredDate.Value.Date,
                    ShippedDate = txtShippedDate.Value.Date,
                    Freight = decimal.Parse(txtFreight.Text)
                };
                if (InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(order);
                }
                else
                {
                    OrderRepository.UpdateOrder(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new order" : "Update order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
