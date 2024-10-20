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
   
   public Task<CustomUserDetails?> GetCustomUserDetailsByUserIdAsync(string userId)
   {
       return _customUserDetailsRepository.GetCustomUserDetailsByUserIdAsync(userId);
   }
   
   public Task<CustomUserDetails> CreateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
   {
       return _customUserDetailsRepository.CreateCustomUserDetailsAsync(customUserDetails);
   }
   
   public Task<CustomUserDetails> UpdateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
   {
       return _customUserDetailsRepository.UpdateCustomUserDetailsAsync(customUserDetails);
   }
   
}