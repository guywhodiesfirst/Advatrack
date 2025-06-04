using Data;
using Data.Entities;

namespace Application;

public class TrackingService
{
    private readonly AdvatrackDbContext _dbContext;

    public async Task AddActionLog(ActionLog action)
    {
        await _dbContext.Actions.AddAsync(action);
        await _dbContext.SaveChangesAsync();
    }
}