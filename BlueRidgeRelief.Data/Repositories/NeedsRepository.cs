using BlueRidgeRelief.Core.Entities;
using BlueRidgeRelief.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueRidgeRelief.Data.Repositories;

public class NeedsRepository : INeedsRepository
{
    private readonly ApplicationDbContext _context;

    public NeedsRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Need>> GetNeedsAsync()
    {
        return await _context.Needs.AsNoTracking().ToListAsync();
    }
    
    public async Task<Need?> GetNeedByIdAsync(int id)
    {
        return await _context.Needs.FindAsync(id);
    }
    
    public async Task<Need> CreateNeedAsync(Need need)
    {
        _context.Needs.Add(need);
        await _context.SaveChangesAsync();
        return need;
    }
    
    public async Task<Need> UpdateNeedAsync(Need need)
    {
        _context.Entry(need).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return need;
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByUserIdAsync(string userId)
    {
        return await _context.Needs.Where(n => n.IdentityUserId == userId).AsNoTracking().ToListAsync();
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByCategoryAsync(string category)
    {
        return await _context.Needs.Where(n => n.Category == category).AsNoTracking().ToListAsync();
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByUrgencyLevelAsync(string urgencyLevel)
    {
        return await _context.Needs.Where(n => n.UrgencyLevel == urgencyLevel).AsNoTracking().ToListAsync();
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByStatusAsync(string status)
    {
        return await _context.Needs.Where(n => n.Status == status).AsNoTracking().ToListAsync();
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByLocationAsync(string location)
    {
        return await _context.Needs.Where(n => n.LocationString == location).AsNoTracking().ToListAsync();
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByLocationAsync(double latitude, double longitude, double radius)
    {
        return await _context.Needs
            .Where(n => n.Latitude >= latitude - radius && n.Latitude <= latitude + radius)
            .Where(n => n.Longitude >= longitude - radius && n.Longitude <= longitude + radius)
            .AsNoTracking()
            .ToListAsync();
    }
    
    

}