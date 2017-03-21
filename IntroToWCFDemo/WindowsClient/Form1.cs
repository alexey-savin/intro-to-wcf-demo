using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.InventoryService;
using WindowsClient.ProductService;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private InventoryServiceClient _proxyInventory = null;
        private ProductServiceClient _proxyProduct = null;

        private Inventory _inventory = null;
        private Product _product = null;
        private decimal _inStockValue = 0M;
        private decimal _onOrderValue = 0M;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _proxyInventory = new InventoryServiceClient("WSHttpBinding_IInventoryService"); // name of the endpoint in the app.config file
            _proxyProduct = new ProductServiceClient("WSHttpBinding_IProductService");
        }

        private void buttonGetInStock_Click(object sender, EventArgs e)
        {
            labelInStock.Text = $"{_proxyInventory.GetInventory(Convert.ToInt32(textBoxProductId.Text)).UnitsInStock} units are in stock";
        }

        private void buttonGetProduct_Click(object sender, EventArgs e)
        {
            _product = new Product();

            try
            {
                _product = _proxyProduct.GetProduct(Convert.ToInt32(textBoxProductId.Text));
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }

            labelProductName.Text = _product.ProductName;
            labelUnitPrice.Text = _product.UnitPrice.ToString("C");
            //textBoxInStock.Text = _product.UnitsInStock.ToString();
            //labelInStock.Text = _product.UnitsInStock.ToString();
            //_inStockValue = _product.UnitPrice * Convert.ToDecimal(_product.UnitsInStock);
            //labelInStockValue.Text = _inStockValue.ToString("C");
            //textBoxOnOrder.Text = _product.UnitsOnOrder.ToString();
            //_onOrderValue = _product.UnitPrice * Convert.ToDecimal(_product.UnitsOnOrder);
            //labelOnOrderValue.Text = _onOrderValue.ToString("C");
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            _inventory.UnitsInStock = Convert.ToInt16(textBoxInStock.Text);
            _inventory.UnitsOnOrder = Convert.ToInt16(textBoxOnOrder.Text);

            if (_proxyInventory.UpdateInventory(_inventory))
            {
                MessageBox.Show("Your changes were saved");

                _inStockValue = _product.UnitPrice * Convert.ToDecimal(_inventory.UnitsInStock);
                labelInStockValue.Text = _inStockValue.ToString("C");
                _onOrderValue = _product.UnitPrice * Convert.ToDecimal(_inventory.UnitsOnOrder);
                labelOnOrderValue.Text = _onOrderValue.ToString("C");
            }
            else
            {
                MessageBox.Show("Your changes were not saved");
            }
        }
    }
}
