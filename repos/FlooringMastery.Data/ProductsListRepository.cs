using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class ProductsListRepository
    {
        public List<Products> GetProductList()
        {
            List<Products> productList = new List<Products>();

            using (StreamReader sr = new StreamReader(@"C:\data\FlooringData\Products.txt"))
            {
                sr.ReadLine();
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Products product = new Products();

                    var columns = line.Split(',');

                    product.ProductType = columns[0];
                    product.CostPerSquareFoot = decimal.Parse(columns[1]);
                    product.LaborCostPerSquareFoot = decimal.Parse(columns[2]);

                    productList.Add(product);
                }
            }

            return productList;
        }
    }
}
