using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projeli.Shared.Domain.Models.Notifications;

[Index(nameof(UserId))]
[Index(nameof(IsRead))]
[Index(nameof(Timestamp))]
public class Notification
{
    [Key] public required Ulid Id { get; set; } = Ulid.NewUlid();

    [StringLength(32)] public required string UserId { get; set; }

    [Column(TypeName = "smallint")] public required NotificationType Type { get; set; }

    [Column(TypeName = "jsonb")] public required NotificationBody Body { get; set; }

    [Column(TypeName = "boolean")] public required bool IsRead { get; set; }

    [Column(TypeName = "timestamp with time zone")]
    public required DateTime Timestamp { get; set; } = DateTime.UtcNow;
}