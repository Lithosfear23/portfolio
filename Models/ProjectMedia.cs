using Malabanan_Portfolio.Logic.Enums;

namespace Malabanan_Portfolio.Models
{
    public class ProjectMedia
    {
        public int Key { get; set; }
        public string Source { get; set; } = string.Empty;
        public FileTypes Type { get; set; }
        public bool IsVideo { get; set; } = false;
        public bool Selected { get; set; } = false;

        public ProjectMedia (int key, string source, FileTypes type, bool isVideo = false, bool selected = false)
        {
            Key = key;
            Source = source;
            Type = type;
            IsVideo = isVideo; 
            Selected = selected;
        }
    }
}
