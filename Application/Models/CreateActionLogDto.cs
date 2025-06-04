using Data.Enums;

namespace Application.Models;

public class CreateActionLogDto
{
    public Guid SessionId { get; set; }
    public ActionType Type { get; set; }
    public DateTime TimeStamp { get; set; }
}