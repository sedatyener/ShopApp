﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        
        public int Id { get; set; }
        //This validations are desibled because Business Layer Validation tested
        //[Required]
        //[StringLength(60,MinimumLength =10,ErrorMessage ="Ürün ismi minimum 10 karakter ve maksimum 60 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Ürün açıklaması minimum 20 karakter ve maksimum 100 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}
