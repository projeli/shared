namespace Projeli.Shared.Domain.Models.Files;

public class FileType
{
    public string Id { get; set; } = null!;
    public string Subdirectory { get; set; } = null!;
    public List<string> MimeTypes { get; set; } = null!;
    public long MaxSize { get; set; }
    public bool RequiresParentId { get; set; }
}