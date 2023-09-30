using Newtonsoft.Json;

namespace WebApplication.API.Models
{
    public class Tech
        {
            [JsonProperty("color")]
            public string color { get; set; }
            
            [JsonProperty("capacity")]
            public string capacity { get; set; }
            
            [JsonProperty("capacity_GB")]
            public int capacity_GB { get; set; }
            
            [JsonProperty("price")]
            public double price { get; set; }
            
           [JsonProperty("generation")]
            public string generation { get; set; }
            
            [JsonProperty("year")]
            public int year { get; set; }
            
            [JsonProperty("CPU_model")]
            public string CPU_model { get; set; }
            
           [JsonProperty("Hard_disk_size")]
            public string  Hard_disk_size{ get; set; }
            
            [JsonProperty("Strap_Colour")]
            public string Strap_Colour { get; set; }
            
           // [JsonProperty("Case_Size")]
            public string Case_Size { get; set; }
            
          //  [JsonProperty("Color")]
            //public string Color { get; set; }
            
           // [JsonProperty("Description")]
           // public string Description { get; set; }
            
            //[JsonProperty("Capacity")]
           // public string Capacity { get; set; }
            
          //  [JsonProperty("Screen_size")]
          //  public double Screen_size { get; set; }
            
          //  [JsonProperty("Generation")]
           // public string Generation { get; set; }
            
           [JsonProperty("Price")]
            public string Price { get; set; }
        }
}

