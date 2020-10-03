using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageCreateRequest
    {
        //public int ProductId { set; get; }
        public bool IsDefault { set; get; }
        public string Caption { set; get; }
        public int SortOrder { set; get; }
        public IFormFile ImageFile { get; set; }
    }
}
