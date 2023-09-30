namespace WebApplication.API.Modeles.ResponseModels
{
    public class AudioBiblesModel
    {
        public AudioBiblesData[] data { get; set; }
    }

    public class AudioBiblesData
    {
        public string id { get; set; }
        public string dblId { get; set; }
        public string relatedDbl { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
         public string abbreviation { get; set; }
        public string abbreviationLocal { get; set; }
        public string description { get; set; }
        public string descriptionLocal { get; set; }
        public Language language { get; set; }
        public Countries[] countries { get; set; }
        public string type { get; set; }
        public string updatedAt { get; set; }
    }
}

