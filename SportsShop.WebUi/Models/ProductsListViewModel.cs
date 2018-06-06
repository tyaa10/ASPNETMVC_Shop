using SportsShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsShop.WebUi.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}