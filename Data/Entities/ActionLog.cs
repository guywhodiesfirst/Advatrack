using Data.Enums;

namespace Data.Entities;

public class ActionLog
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    
    public ActionType Type { get; set; }
    public DateTime TimeStamp { get; set; }
    
    public TrackingSession Session { get; set; } = null!;
}