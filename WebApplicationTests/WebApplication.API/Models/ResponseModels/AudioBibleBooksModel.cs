namespace WebApplication.API.Modles.ResponseModels
{
    public class AudioBibleBooksModel
        {
            public AudioBibleBooks[] data { get; set; }
        }

        public class AudioBibleBooks
        {
            public string id { get; set; }
            public string bibleId { get; set; }
            public string abbreviation { get; set; }
            public string name { get; set; }
            public string nameLong { get; set; }
            public Chapters[] chapters { get; set; }
        }

        public class Chapters
        {
            public string id { get; set; }
            public string bibleId { get; set; }
            public string number { get; set; }
            public string bookId { get; set; }
            public string reference { get; set; }
        }
}