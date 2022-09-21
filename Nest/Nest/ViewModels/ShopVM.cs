using System;
using Nest.Models;

namespace Nest.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Tag> Tags { get; set; }


    }
}

