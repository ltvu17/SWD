﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWD_ICQS.Entities
{
    public class ConstructImages
    {
        // Completed entity.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ConstructId { get; set; }
        public string? ImageUrl { get; set; }

        // Relationship
        public Constructs? Construct { get; set; }
    }
}