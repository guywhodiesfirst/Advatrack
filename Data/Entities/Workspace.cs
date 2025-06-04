namespace Data.Entities;

public class Workspace
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public TimeOnly? ScheduledStartTime { get; set; }
    public TimeOnly? ScheduledEndTime { get; set; }
    public bool ForceStart { get; set; }
    public bool ForceEnd { get; set; }
    public List<TrackingSession> Sessions { get; set; } = [];
}