using System;
using System.Collections.Generic;

namespace BackEnd_CSharp.Models;

public partial class Note
{
    public long NoteId { get; set; }

    public Guid UserId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDone { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Attachment> Attachments { get; } = new List<Attachment>();
}
