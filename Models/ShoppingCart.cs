﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Art.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }


        public int Id { get; set; }

        public string ApplicationUserId { get; set; }



        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int ArtworkPortfolioId { get; set; }

        [NotMapped]
        [ForeignKey("ArtworkPortfolioId")]
        public virtual ArtworkPortfolio ArtworkPortfolio { get; set; }



        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to {1}")]
        public int Count { get; set; }
    }
}
