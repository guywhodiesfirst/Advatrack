using Data.Enums;

namespace Data.Entities;

public class TrackingSession
{
    public Guid Id { get; set; }
    public Guid WorkspaceId { get; set; }
    public SessionStatus Status { get; set; }
    public Workspace Workspace { get; set; } = null!;
    public List<ActionLog> Actions { get; set; } = [];
}