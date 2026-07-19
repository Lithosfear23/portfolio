using Malabanan_Portfolio.Logic.Enums;

namespace Malabanan_Portfolio.Models
{
    public class ContactChannelModel
    {
        public string ChannelName { get; set; } = string.Empty;
        public string ChannelLink { get; set; } = string.Empty;
        public SVGTypes SVGType { get; set; }

        public ContactChannelModel(string channelName, string channelLink, SVGTypes sVGType)
        {
            ChannelName = channelName;
            ChannelLink = channelLink;
            SVGType = sVGType;
        }
    }
}
