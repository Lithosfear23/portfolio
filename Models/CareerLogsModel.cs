namespace Malabanan_Portfolio.Models
{
    public class CareerLogsModel
    {
        public int Key { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public List<string> DescriptionParagraphs { get; set; } = new();
        public List<string> Achievements { get; set; } = new();
        public string Logo { get; set; } = string.Empty;
        public string Report { get; set; } = string.Empty;
        public bool HasReport { get; set; }

        public CareerLogsModel (int key, DateTime startDate, DateTime endDate, string company, string position,
            List<string> descriptionParagraphs, List<string> achievements, string logo, string report, bool hasReport)
        {
            Key = key;
            StartDate = startDate;
            EndDate = endDate;
            Company = company;
            Position = position;
            DescriptionParagraphs = descriptionParagraphs;
            Achievements = achievements;
            Logo = logo;
            Report = report;
            HasReport = hasReport;
        }
    }
}
