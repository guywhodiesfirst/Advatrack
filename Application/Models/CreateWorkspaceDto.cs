namespace Application.Models;

public class CreateWorkspaceDto
{
    public string Name { get; set; } = "";
    public TimeOnly? ScheduledStartTime { get; set; }
    public TimeOnly? ScheduledEndTime { get; set; }
    public bool ForceStart { get; set; }
    public bool ForceEnd { get; set; }
}