﻿using System;

namespace WebShop.Models.Languages
{
    public class Language : Entity
    {
        public string LanguageName { get; private set; }

        public string IsoCode { get; private set; }

        protected Language () { }

        public Language(string languageName, string isoCode)
        {
            if (string.IsNullOrWhiteSpace(languageName)) throw new ArgumentException("languageName must be given", nameof(languageName));
            if (string.IsNullOrWhiteSpace(isoCode)) throw new ArgumentException("isoCode must be given", nameof(isoCode));

            LanguageName = languageName;
            IsoCode = isoCode;
        }
    }
}
