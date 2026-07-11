namespace Malabanan_Portfolio.Models
{
    public class ProjectsModel
    {
        public DateTime Date { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string ProjectStatus { get; set; } = string.Empty;
        public bool SelectedProject { get; set; } = false;
    }
}
