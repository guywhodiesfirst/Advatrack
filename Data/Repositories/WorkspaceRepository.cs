using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class WorkspaceRepository(AdvatrackDbContext context) : IWorkspaceRepository
{
    private readonly AdvatrackDbContext _context = context;

    public async Task AddAsync(Workspace workspace)
    {
        await _context.Workspaces.AddAsync(workspace);
    }

    public async Task<Workspace?> GetByIdAsync(Guid id)
    {
        var workspace = await _context.Workspaces.FindAsync(id);
        return workspace;
    }

    public async Task<IEnumerable<Workspace>> GetAllAsync()
    {
        var workspaces = await _context.Workspaces.
            Include(w => w.Sessions)
            .ThenInclude(s => s.Actions)
            .ToListAsync();
        return workspaces;
    }

    public async Task<bool> UpdateAsync(Workspace entity)
    {
        var workspace = await _context.Workspaces.FindAsync(entity.Id);
        if (workspace == null)
            return false;
        
        workspace.Name = entity.Name;
        workspace.ForceStart = entity.ForceStart;
        workspace.ForceEnd = entity.ForceEnd;
        workspace.ScheduledStartTime = entity.ScheduledStartTime;
        workspace.ScheduledEndTime = entity.ScheduledEndTime;

        return true;
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        var workspace = await _context.Workspaces.FindAsync(id);
        if (workspace == null)
            return false;
        
        _context.Workspaces.Remove(workspace);
        return true;
    }
}