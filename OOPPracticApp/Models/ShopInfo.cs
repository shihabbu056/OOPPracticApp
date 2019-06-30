using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class ShopInfo
    {
        public ShopInfo()
        {
            ProductInfos = new List<ProductInfo>();
        }
        public string Name { get; set; }
        public string Addres { get; set; }
        private List<ProductInfo> ProductInfos;

        public string AddProductInfo(ProductInfo productInfo)
        {
            ProductInfos.Add(productInfo);
            foreach (ProductInfo productCheck in ProductInfos)
            {
                if (productCheck.ProductId == GetProductID(productId:ToString()))
                {
                    
                }
            }
            
        }

        public string GetProductID(string productId)
        {
            return productId;
        }

    }
}
