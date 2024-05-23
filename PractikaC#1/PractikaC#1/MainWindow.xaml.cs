using System.Windows;
using PractikaC_1.Laba1DataSetTableAdapters;

namespace PractikaC_1
{
    public partial class MainWindow : Window
    {
        CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
        ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
        OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            CustomerDataGrid.ItemsSource = customersTableAdapter.GetData();
            ProductsDataGrid.ItemsSource = productsTableAdapter.GetData();
            OrdersDataGrid.ItemsSource = ordersTableAdapter.GetData();
        }
    }
}