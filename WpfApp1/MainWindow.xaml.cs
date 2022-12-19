using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Product> products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                ProductPrice = 100,
                ProductName = "Арбуз",
                ProductImgPath = "Data/Арбуз.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductPrice = 1000,
                ProductName = "Микроволновка",
                ProductImgPath = "Data/Микроволновка.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProductPrice = 80,
                ProductName = "Молоко",
                ProductImgPath = "Data/Молоко.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductPrice = 120,
                ProductName = "Арбуз",
                ProductImgPath = "Data/Дыня.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductPrice = 2500,
                ProductName = "Холодильник",
                ProductImgPath = "Data/Холодильник.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProductPrice = 2000,
                ProductName = "Плита",
                ProductImgPath = "Data/Плита.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            lstBox.ItemsSource=products;
            //string str=products.First().GetCategory();
        }
    }
}
