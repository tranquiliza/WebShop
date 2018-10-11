using System;
using System.Collections.Generic;
using System.Linq;

namespace WebShop.Models.Languages
{
    public class Label : Entity
    {
        public string Alias { get; private set; }

        public ICollection<LabelValue> LabelValues { get; private set; }

        private Label() { }

        public Label(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias)) throw new ArgumentException("Alias cannot be empty", nameof(alias));

            LabelValues = new List<LabelValue>();
            Alias = alias;
        }

        public void AddLabelValue(LabelValue labelValue)
        {
            if (LabelValues.Any(value => value.Language.Id == labelValue.Language.Id)) throw new InvalidOperationException("Cannot add two values for the same language");

            LabelValues.Add(labelValue);
        }
    }
}
