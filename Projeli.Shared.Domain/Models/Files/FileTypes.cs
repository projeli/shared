namespace Projeli.Shared.Domain.Models.Files;

public abstract class FileTypes
{
    public static readonly FileType ProjectLogo = new()
    {
        Id = "project-logo",
        Subdirectory = "projects",
        MimeTypes =
        [
            "image/jpeg",
            "image/png",
            "image/gif",
            "image/webp"
        ],
        MaxSize = 2 * 1024 * 1024, // 5 MB
        RequiresParentId = true,
    };
}