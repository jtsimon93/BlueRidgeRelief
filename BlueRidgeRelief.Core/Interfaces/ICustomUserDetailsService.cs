using BlueRidgeRelief.Core.Entities;

namespace BlueRidgeRelief.Core.Interfaces;

public interface ICustomUserDetailsService
{
    Task<CustomUserDetails?> GetCustomUserDetailsByUserIdAsync(string userId);
    Task<CustomUserDetails> CreateCustomUserDetailsAsync(CustomUserDetails customUserDetails);
    Task<CustomUserDetails> UpdateCustomUserDetailsAsync(CustomUserDetails customUserDetails);   
}