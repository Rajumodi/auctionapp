﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }
        [Required]
        public string? IdentityUserID { get; set; }
        [ForeignKey("IdentityUserID")]
        public IdentityUser? User { get; set; }

        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]

        public Listing? Listing { get; set; }
    }
}
