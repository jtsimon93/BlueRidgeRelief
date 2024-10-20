using BlueRidgeRelief.Core.Entities;
using BlueRidgeRelief.Core.Interfaces;

namespace BlueRidgeRelief.Services;

public class NeedsService : INeedsService
{
    private readonly INeedsRepository _needsRepository;
    
    public NeedsService(INeedsRepository needsRepository)
    {
        _needsRepository = needsRepository;
    }
    
    public async Task<IEnumerable<Need>> GetNeedsAsync()
    {
        return await _needsRepository.GetNeedsAsync();
    }
    
    public async Task<Need?> GetNeedByIdAsync(int id)
    {
        return await _needsRepository.GetNeedByIdAsync(id);
    }
    
    public async Task<Need> CreateNeedAsync(Need need)
    {
        return await _needsRepository.CreateNeedAsync(need);
    }
    
    public async Task<Need> UpdateNeedAsync(Need need)
    {
        return await _needsRepository.UpdateNeedAsync(need);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByUserIdAsync(string userId)
    {
        return await _needsRepository.GetNeedsByUserIdAsync(userId);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByCategoryAsync(string category)
    {
        return await _needsRepository.GetNeedsByCategoryAsync(category);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByUrgencyLevelAsync(string urgencyLevel)
    {
        return await _needsRepository.GetNeedsByUrgencyLevelAsync(urgencyLevel);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByStatusAsync(string status)
    {
        return await _needsRepository.GetNeedsByStatusAsync(status);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByLocationAsync(string location)
    {
        return await _needsRepository.GetNeedsByLocationAsync(location);
    }
    
    public async Task<IEnumerable<Need>> GetNeedsByLocationAsync(double latitude, double longitude, double radius)
    {
        return await _needsRepository.GetNeedsByLocationAsync(latitude, longitude, radius);
    }
    
    public async Task<bool> DeleteNeedAsync(int id)
    {
        // Find the need by ID
        var need = await _needsRepository.GetNeedByIdAsync(id);

        if (need == null)
        {
            return false;
        }

        need.IsDeleted = true;
        need.DeletedAt = DateTime.UtcNow;
        
        await _needsRepository.UpdateNeedAsync(need);
        
        return true;
    }
    
}