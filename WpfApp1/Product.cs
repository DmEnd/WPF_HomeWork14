using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum ProductCategorys
    {
        Food,
        Appliances
    }
    public class Product
    {
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductImgPath { get; set; }
        public ProductCategorys ProductCategory { get; set; }

        public string ProductCategoryName
        {
            get
            {
                string str = ProductName;
                if (ProductCategory == ProductCategorys.Food)
                {
                    return "Еда";
                }
                else if (ProductCategory == ProductCategorys.Appliances)
                {
                    return "Бытовая техника";
                }
                else
                {
                    return "-";
                }
            }
        }
    }
}
