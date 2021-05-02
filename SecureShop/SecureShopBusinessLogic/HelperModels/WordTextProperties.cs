using DocumentFormat.OpenXml.Wordprocessing;

namespace SecureShopBusinessLogic.HelperModels
{
    class WordTextProperties
    {
        public string Size { get; set; }
        public bool Bold { get; set; }
        public JustificationValues JustificationValues { get; set; }
    }
}
