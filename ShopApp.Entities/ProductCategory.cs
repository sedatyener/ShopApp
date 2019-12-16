using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class ProductCategory
    {
        //coka cok iliski kurmak icin bir junktion tablo olusturuyoruz.
        //yani bir urun birden cok tabloya ait olabilir ve bir category birden cok urune sahip olabilir

        //public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
