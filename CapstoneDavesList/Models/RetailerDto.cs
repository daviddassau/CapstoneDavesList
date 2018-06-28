using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneDavesList.Models
{
    public class RetailerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public string Details { get; set; }
        public int RetailerId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}