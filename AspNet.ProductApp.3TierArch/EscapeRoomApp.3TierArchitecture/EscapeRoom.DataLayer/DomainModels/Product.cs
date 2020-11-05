using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom.DataLayer.DomainModels
{
  public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
         // public Category Category { get; set; }
        public string Description { get; set; }
    }
}
