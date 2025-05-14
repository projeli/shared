using MassTransit;
using Projeli.Shared.Domain.Models.Files;

namespace Projeli.Shared.Infrastructure.Messaging.Events;

[EntityName("FileStore")]
public class FileStoreEvent
{
    public string FileName { get; set; } = null!;
    public string FileExtension { get; set; } = null!;
    public string MimeType { get; set; } = null!;
    public FileType FileType { get; set; } = null!;
    public string? ParentId { get; set; }
    public byte[] FileData { get; set; } = null!;
}