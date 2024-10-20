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
    
    public Task<IEnumerable<Need>> GetNeedsAsync()
    {
        return _needsRepository.GetNeedsAsync();
    }
    
    public Task<Need?> GetNeedByIdAsync(int id)
    {
        return _needsRepository.GetNeedByIdAsync(id);
    }
    
    public Task<Need> CreateNeedAsync(Need need)
    {
        return _needsRepository.CreateNeedAsync(need);
    }
    
    public Task<Need> UpdateNeedAsync(Need need)
    {
        return _needsRepository.UpdateNeedAsync(need);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByUserIdAsync(string userId)
    {
        return _needsRepository.GetNeedsByUserIdAsync(userId);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByCategoryAsync(string category)
    {
        return _needsRepository.GetNeedsByCategoryAsync(category);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByUrgencyLevelAsync(string urgencyLevel)
    {
        return _needsRepository.GetNeedsByUrgencyLevelAsync(urgencyLevel);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByStatusAsync(string status)
    {
        return _needsRepository.GetNeedsByStatusAsync(status);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByLocationAsync(string location)
    {
        return _needsRepository.GetNeedsByLocationAsync(location);
    }
    
    public Task<IEnumerable<Need>> GetNeedsByLocationAsync(double latitude, double longitude, double radius)
    {
        return _needsRepository.GetNeedsByLocationAsync(latitude, longitude, radius);
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