using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.Language
{
    public class Language : Entity
    {
        public string LanguageName { get; set; }
        public string Iso { get; set; }

        private Language() { }

        public Language(string languageName, string isoCode)
        {
            if (string.IsNullOrWhiteSpace(languageName))
                throw new ArgumentException("message", nameof(languageName));

            if (string.IsNullOrWhiteSpace(isoCode))
                throw new ArgumentException("message", nameof(isoCode));

            LanguageName = languageName;
        }
    }
}
