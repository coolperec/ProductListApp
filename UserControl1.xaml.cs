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
using WpfAppLists;

namespace WpfAppLists
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            // Создаем коллекцию продуктов
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Ноутбук",
                    Description = "Высокопроизводительный ноутбук для работы и игр",
                    Manufacturer = "Dell",
                    Price = 85000,
                    Stock = 5,
                    ImagePath = "Images/laptop.png"
                },
                new Product
                {
                    Name = "Смартфон",
                    Description = "Смартфон с отличной камерой и большим экраном",
                    Manufacturer = "Samsung",
                    Price = 55000,
                    Stock = 8,
                    ImagePath = "Images/phone.png"
                },
                new Product
                {
                    Name = "Наушники",
                    Description = "Беспроводные наушники с шумоподавлением",
                    Manufacturer = "Sony",
                    Price = 12000,
                    Stock = 15,
                    ImagePath = "Images/headphones.png"
                }
            };

        }
        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Manufacturer { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string ImagePath { get; set; }
        }
    }
}
