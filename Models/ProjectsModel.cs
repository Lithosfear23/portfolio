namespace Malabanan_Portfolio.Models
{
    public class ProjectsModel
    {
        public DateTime Date { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public List<string> TechStack { get; set; } = new();
        public string ProjectStatus { get; set; } = string.Empty;
        public List<ProjectMedia> Medias { get; set; } = new();
        public string Description { get; set; } = string.Empty;
        public List<string> FeaturesParagraph { get; set; } = new();
        public List<string> FeaturesList { get; set; } = new();
        public string Credits { get; set; } = string.Empty;
    }
}
