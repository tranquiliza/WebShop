using System;

namespace WebShop.Models.Organisations
{
    public class Organisation : Entity
    {
        public string OrganisationName { get; private set; }

        private Organisation() { }

        public Organisation(string organisationName)
        {
            if (string.IsNullOrWhiteSpace(organisationName)) throw new ArgumentException("The name of the organisation cannot be empty.", nameof(organisationName));

            OrganisationName = organisationName;
        }
    }
}
