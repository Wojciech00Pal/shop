﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.CoreBusiness
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        //public List<Products>? ProductList { get; set; }

        public DateTime Date { get; set; }

        public double Price { get; set; }

        public bool done { get; set; } = false;


    }
}
