namespace Malabanan_Portfolio.Models
{
    public class CertificateIssuerModel
    {
        public string Issuer { get; set; } = string.Empty;
        public List<CertificateModel> Certificates { get; set; } = new();

        public CertificateIssuerModel(string issuer, List<CertificateModel> certificates)
        {
            Issuer = issuer;
            Certificates = certificates;
        }
    }
}
