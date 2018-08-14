using System;

namespace WebShop.Models
{
    public class ProductInformation : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        //public string Language { get; private set; }

        private ProductInformation() { }

        public ProductInformation(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));

            //Language = "DefaultLanguage";
        }

        public ProductInformation(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));

            //Language = "DefaultLanguage";
        }

        //public ProductInformation(string name, string description, string language)
        //{
        //    Name = name ?? throw new ArgumentNullException(nameof(name));
        //    Description = description ?? throw new ArgumentNullException(nameof(description));
        //    Language = language ?? throw new ArgumentNullException(nameof(language));
        //}

        public void UpdateName(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void UpdateDescription(string description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
