namespace Malabanan_Portfolio.Models
{
    public class SkillBadgeModel
    {
        public string SkillBadgeName { get; set; } = string.Empty;
        public DateTime DateIssued { get; set; }
        public string Source { get; set; } = string.Empty;
        public bool HasSource { get; set; }

        public SkillBadgeModel(string skillBadgeName, DateTime dateIssued, string source, bool hasSource)
        {
            SkillBadgeName = skillBadgeName;
            DateIssued = dateIssued;
            Source = source;
            HasSource = hasSource;
        }
    }
}
