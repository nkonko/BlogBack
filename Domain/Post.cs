﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? Created_date { get; set; }
        public int Category_id { get; set; }
        public int User_id { get; set; }
    }
}
