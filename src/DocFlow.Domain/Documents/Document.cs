using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.Domain.Documents
{
    public sealed class Document
    {
        public DocumentId Id { get; }
        public string Title { get; private set; }
        public DocumentStatus Status { get; private set; }
        public DateTimeOffset CreatedAt { get; }

        public Document(DocumentId id, string title, DocumentStatus status, DateTimeOffset createdAt)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title is required property.");
            }
            Id = id;
            Title = title.Trim();
            Status = status;
            CreatedAt = createdAt;
        }
    }
}
