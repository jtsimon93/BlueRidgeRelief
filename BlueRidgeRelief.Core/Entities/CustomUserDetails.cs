using System.ComponentModel.DataAnnotations;

namespace BlueRidgeRelief.Core.Entities;

public class CustomUserDetails
{
    [Key]
    public int Id { get; set; }
    
    // Foreign key to the IdentityUser 
    [Required]
    public string? IdentityUserId { get; set; }
    
    [Required]
    public string? FirstName { get; set; }
    
    [Required]
    public string? LastName { get; set; }
    
    [Required]
    public string? Address { get; set; }
    
    [Required]
    public string? City { get; set; }
    
    [Required]
    public string? State { get; set; }
    
    [Required]
    public string? ZipCode { get; set; }
    
    [Required]
    public string? PhoneNumber { get; set; }
    
    [Required]
    public string? Email { get; set; }

    public string? VerificationMeans { get; set; }
    
    public string? VerificationNotes { get; set; }

}