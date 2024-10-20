using System.ComponentModel.DataAnnotations;

namespace BlueRidgeRelief.DTOs;

public class NeedDto
{
    public int Id { get; set; }
    
    [Required]
    public string? IdentityUserId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? Title { get; set; }
    
    [Required]
    [MaxLength(2000)]
    public string? Description { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? Category { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? LocationString { get; set; }
    
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? UrgencyLevel { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? Status { get; set; }

    [Required] public bool IsActive { get; set; } = true;
    [Required] public bool IsDeleted { get; set; } = false;
    [Required] public bool IsFulfilled { get; set; } = false;

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? UpdatedAt { get; set; }
    
    public DateTime? FulfilledAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
    
    public string? FulfilledBy { get; set; } 
}