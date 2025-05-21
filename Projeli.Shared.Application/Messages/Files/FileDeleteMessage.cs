using MassTransit;
using Projeli.Shared.Domain.Models.Files;

namespace Projeli.Shared.Application.Messages.Files;

[EntityName("FileDelete")]
public class FileDeleteMessage
{
    public string FilePath { get; set; } = null!;
    public FileType FileType { get; set; } = null!;
    public string? ParentId { get; set; }
    public string UserId { get; set; } = null!;
}