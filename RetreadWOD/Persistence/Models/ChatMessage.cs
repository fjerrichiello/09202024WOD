using System.ComponentModel.DataAnnotations;

namespace RetreadWOD.Persistence.Models;

public class ChatMessage
{
    [Key]
    public int Id { get; set; }

    public string Message { get; set; } = string.Empty;
}