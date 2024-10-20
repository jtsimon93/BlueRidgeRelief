using BlueRidgeRelief.Core.Entities;

namespace BlueRidgeRelief.Core.Interfaces;

public interface INeedsService
{
    Task<IEnumerable<Need>> GetNeedsAsync();
    Task<IEnumerable<Need>> GetSortedNeedsAsync();
    Task<Need?> GetNeedByIdAsync(int id);
    Task<Need> CreateNeedAsync(Need need);
    Task<Need> UpdateNeedAsync(Need need);
    Task<IEnumerable<Need>> GetNeedsByUserIdAsync(string userId);
    Task<IEnumerable<Need>> GetNeedsByCategoryAsync(string category);
    Task<IEnumerable<Need>> GetNeedsByUrgencyLevelAsync(string urgencyLevel);
    Task<IEnumerable<Need>> GetNeedsByStatusAsync(string status);
    Task<IEnumerable<Need>> GetNeedsByLocationAsync(string location);
    Task<IEnumerable<Need>> GetNeedsByLocationAsync(double latitude, double longitude, double radius); 
}