using BlueRidgeRelief.Core.Entities;
using BlueRidgeRelief.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueRidgeRelief.Data.Repositories;

public class CustomUserDetailsRepository : ICustomUserDetailsRepository
{
    private readonly ApplicationDbContext _context;

    public CustomUserDetailsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CustomUserDetails?> GetCustomUserDetailsByUserIdAsync(string userId)
    {
        return await _context.CustomUserDetails
            .FirstOrDefaultAsync(cud => cud.IdentityUserId == userId);
    }

    public async Task<CustomUserDetails> CreateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
    {
        await _context.CustomUserDetails.AddAsync(customUserDetails);
        await _context.SaveChangesAsync();
        return customUserDetails;
    }

    public async Task<CustomUserDetails> UpdateCustomUserDetailsAsync(CustomUserDetails customUserDetails)
    {
        _context.CustomUserDetails.Update(customUserDetails);
        await _context.SaveChangesAsync();
        return customUserDetails;
    }
    
}