using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AdvatrackDbContext(DbContextOptions<AdvatrackDbContext> options) : DbContext(options)
{
    public DbSet<ActionLog> Actions { get; set; }
    public DbSet<TrackingSession> Sessions { get; set; }
    public DbSet<Workspace> Workspaces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionLog>()
            .HasOne(action => action.Session)
            .WithMany(session => session.Actions)
            .HasForeignKey(action => action.SessionId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<TrackingSession>()
            .HasOne(session => session.Workspace)
            .WithMany(workspace => workspace.Sessions)
            .HasForeignKey(session => session.WorkspaceId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}