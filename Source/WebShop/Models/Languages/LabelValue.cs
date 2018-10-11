using System;
using WebShop.Contracts.Label;

namespace WebShop.Models.Languages
{
    public class LabelValue : Entity
    {
        public string Value { get; private set; }

        public Language Language { get; private set; }

        private LabelValue() { }

        public LabelValue(string value, Language language)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Value cannot be empty", nameof(value));

            Value = value;
            Language = language ?? throw new ArgumentNullException(nameof(language));
        }
    }
}
