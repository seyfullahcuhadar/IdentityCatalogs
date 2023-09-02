﻿using System.ComponentModel.DataAnnotations;

namespace IdentityCatalog.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted {  get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
