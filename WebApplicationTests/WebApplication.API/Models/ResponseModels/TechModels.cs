namespace WebApplication.API.Modles.ResponseModels
{
    public class TechModels
    {
        public string id { get; set; }
        public string name { get; set; }
        public Tech data { get; set; }
    }

    public class Tech
        {
           public string color { get; set; }
            public string capacity { get; set; }
            public int capacity_GB { get; set; }
            public double price { get; set; }
            public string generation { get; set; }
            public int year { get; set; }
            public string CPU_model { get; set; }
            public string Hard_disk_size { get; set; }
            public string Strap_Colour { get; set; }
            public string Case_Size { get; set; }
            public string Color { get; set; }
            public string Description { get; set; }
            public string Capacity { get; set; }
            public double Screen_size { get; set; }
            public string Generation { get; set; }
            public string Price { get; set; }
        }
}

