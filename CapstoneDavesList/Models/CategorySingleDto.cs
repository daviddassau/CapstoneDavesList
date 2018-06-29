using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneDavesList.Models
{
    public class CategorySingleDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int RetailerId { get; set; }
        public string Name { get; set; }
    }
}