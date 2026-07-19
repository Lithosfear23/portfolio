namespace Malabanan_Portfolio.Models
{
    public class SkillBadgeIssuerModel
    {
        public string Issuer { get; set; } = string.Empty;
        public List<SkillBadgeModel> SkillBadges { get; set; } = new();

        public SkillBadgeIssuerModel(string issuer, List<SkillBadgeModel> certificates)
        {
            Issuer = issuer;
            SkillBadges = certificates;
        }
    }
}
