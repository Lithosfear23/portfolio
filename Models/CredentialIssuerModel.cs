namespace Malabanan_Portfolio.Models
{
    public class CredentialIssuerModel
    {
        public string Issuer { get; set; } = string.Empty;
        public List<CredentialModel> Credentials { get; set; } = new();

        public CredentialIssuerModel(string issuer, List<CredentialModel> credentials)
        {
            Issuer = issuer;
            Credentials = credentials;
        }
    }
}
