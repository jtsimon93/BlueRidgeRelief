using BlueRidgeRelief.Core.Entities;
using BlueRidgeRelief.Core.Interfaces;
namespace BlueRidgeRelief.Services;


public class CustomUserDetailsService : ICustomUserDetailsService
{
   private readonly ICustomUserDetailsRepository _customUserDetailsRepository;

   public CustomUserDetailsService (ICustomUserDetailsRepository customUserDetailsRepository)
   {
       _customUserDetailsRepository = customUserDetailsRepository;
   }
   
   public async Task<CustomUserDetails?> GetCustomUserDetailsByUserIdAsync(string userId)
   {
       return await _customUserDetailsRepository.GetCustomUserDetailsByUserIdAsync(userId);
   }
   
   public async Task<CustomUserDetails> CreateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
   {
       return await _customUserDetailsRepository.CreateCustomUserDetailsAsync(customUserDetails);
   }
   
   public async Task<CustomUserDetails> UpdateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
   {
       return await _customUserDetailsRepository.UpdateCustomUserDetailsAsync(customUserDetails);
   }
   
}