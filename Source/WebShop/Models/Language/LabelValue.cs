using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.Language
{
    public class LabelValue : Entity
    {
        public string Value { get; private set; }

        public Label Label { get; private set; }

        public Language Language { get; private set; }

        private LabelValue() { }

        public LabelValue(string value, Label label, Language language)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Value cannot be empty", nameof(value));

            Value = value;
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Language = language ?? throw new ArgumentNullException(nameof(language));
        }

        public string Alias
        {
            get
            {
                return Label.Alias;
            }
        }
    }
}
