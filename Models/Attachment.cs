using System;
using System.Collections.Generic;

namespace BackEnd_CSharp.Models;

public partial class Attachment
{
    public long AttachmentId { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public long NoteId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Note Note { get; set; } = null!;
}
