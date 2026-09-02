using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.Domain.Documents
{
    public sealed record DocumentNumber
    {
        public string Value { get; }
        public DocumentNumber(string value)
        {
            Value = value;
        }
        public static DocumentNumber Create(string value)
        {
            if (string.IsNullOrEmpty(value)) { throw new ArgumentNullException("DocumentNumber is empty"); }
            string normalizedValue = value.Trim();
            if (normalizedValue.Length < 3 || normalizedValue.Length > 30) { throw new ArgumentException("DocumentNumber's length must be between 2 and 30 characters"); }
            return new DocumentNumber(normalizedValue);
        }
        public override string ToString() => Value;
    }
}
