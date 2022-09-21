using System;
namespace Nest.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }


    }
}

