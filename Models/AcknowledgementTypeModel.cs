using Malabanan_Portfolio.Logic.Enums;

namespace Malabanan_Portfolio.Models
{
    public class AcknowledgementTypeModel
    {
        public AcknowledgementTypes AcknowledgementType { get; set; }
        public string AcknowledgementName { get; set; } = string.Empty;

        public AcknowledgementTypeModel(AcknowledgementTypes acknowledgementType, string acknowledgementName)
        {
            AcknowledgementType = acknowledgementType;
            AcknowledgementName = acknowledgementName;
        }
    }
}
