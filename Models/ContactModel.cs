namespace Malabanan_Portfolio.Models
{
    public class ContactModel
    {
        public List<string> MainDescriptionParagraphs { get; set; } = new();
        public List<string> SubDescriptionParagraphs { get; set; } = new();
        public List<ContactChannelModel> ContactChannels { get; set; } = new();
        public string LocationText { get; set; } = string.Empty;
        public string OpenJobText { get; set; } = string.Empty;

        public ContactModel(List<string> mainDescriptionParagraphs, List<string> subDescriptionParagraphs,
            List<ContactChannelModel> contactChannels, string locationText, string openJobText)
        {
            MainDescriptionParagraphs = mainDescriptionParagraphs;
            SubDescriptionParagraphs = subDescriptionParagraphs;
            ContactChannels = contactChannels;
            LocationText = locationText;
            OpenJobText = openJobText;
        }
    }
}
