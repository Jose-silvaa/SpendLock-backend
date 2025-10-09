using spendlock_backend.Models.Base;

namespace spendlock_backend.Models;

public enum NotificationType
{
    Info = 1,
    Warning = 2,
    Alert = 3,
    Success = 4
}

public class Notification : BaseEntity
{
    public User User {get; set;}
    public NotificationType Type {get; set;}
    public string Message {get; set;}
    public Boolean Read { get; set; }
}