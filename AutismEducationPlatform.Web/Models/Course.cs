using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AutismEducationPlatform.Web.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public string? InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public ApplicationUser? Instructor { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Title { get; set; } = string.Empty;
        public string IconClass { get; set; } = string.Empty;
        public string BackgroundColor { get; set; } = string.Empty;
    }
} 