namespace Malabanan_Portfolio.Models
{
    public class CertificateModel
    {
        public string CertificateName { get; set; } = string.Empty;
        public DateTime DateIssued { get; set; }
        public string Source { get; set; } = string.Empty;
        public bool HasSource { get; set; }

        public CertificateModel(string certificateName, DateTime dateIssued, string source, bool hasSource)
        {
            CertificateName = certificateName;
            DateIssued = dateIssued;
            Source = source;
            HasSource = hasSource;
        }
    }
}
