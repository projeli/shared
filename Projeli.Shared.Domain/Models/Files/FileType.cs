namespace Projeli.Shared.Domain.Models.Files;

public class FileType
{
    public string Name { get; set; } = null!;
    public List<string> MimeTypes { get; set; } = null!;
    public long MaxSize { get; set; }
    public bool RequiresParentId { get; set; }
}