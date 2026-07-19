namespace Malabanan_Portfolio.Models
{
    public class CredentialModel
    {
        public string CredentialName { get; set; } = string.Empty;
        public DateTime DateIssued { get; set; }
        public string Logo { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public bool HasSource { get; set; }

        public CredentialModel(string credentialName, DateTime dateIssued, string logo, string source, bool hasSource)
        {
            CredentialName = credentialName;
            DateIssued = dateIssued;
            Logo = logo;
            Source = source;
            HasSource = hasSource;
        }
    }
}
