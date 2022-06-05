﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
