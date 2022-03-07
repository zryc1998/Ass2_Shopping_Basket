using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ass2_Shopping_Basket.Models;
using PagedList;

namespace Ass2_Shopping_Basket.ViewModels
{
    public class BrandIndexViewModel
    {
        public IPagedList<Brand> Brands { get; set; }
    }
}