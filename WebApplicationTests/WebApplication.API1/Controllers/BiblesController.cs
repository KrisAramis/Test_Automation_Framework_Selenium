using RestSharp;

namespace WebApplication.API.Controllers;

public class BiblesController:BaseController
{
    public BiblesController(CustomRestClient client, string apiKey="") : base(client, Service.Bibles, apiKey)
    {
        
    }

    public BiblesController(CustomRestClient client) : base(client, Service.Bibles, client._appConfig.ApiKey)
    {
        
    }

    private const string AllBiblesResource = "/v1/bibles";
    /// <summary>
    /// Gets list of Bibles from API
    /// </summary>
    /// <typeparam name="T"><see cref="AllBiblesModel"/typeparam>
    /// <returns></returns>
    
    private const string AudioBibleBooksResource = "/v1/audio-bibles/{0}/books";

    /// <summary>
    /// Gets list of books for AudioBible from API
    /// </summary>
    /// <typeparam name="T"><see cref="AudioBibleBooksModel"/typeparam>
    /// <returns> list of books for AudioBible</returns>
    /// 
    private const string AllAudioBiblesResource = "/v1/audio-bibles";
    /// <summary>
    /// Gets list of audio Bibles from API
    /// </summary>
    /// <typeparam name="T"><see cref="AudioBiblesModel"/typeparam>
    /// <returns> list of audio Bibles</returns>
    

    public (RestResponse response, T? Bibles) GetBibles<T>()
    {
        return Get<T>(AllBiblesResource);
    }

    public (RestResponse response, T? AudioBibles) GetAudioBibles<T>()
    {
        return Get<T>(AllAudioBiblesResource);
    }
    
   // public (RestResponse restResponse, T? )
    
    /*public (RestResponse Response, T AudioBibles) GetAudioBible<T>(string id)
    {
        return Get<T>(string.Format(SingleBibleResource, id));
    }*/
    
    public (RestResponse response, T? AudioBibleBooks) GetAudioBooksOfBible<T>(string id)
    {
        return Get<T>(String.Format(AudioBibleBooksResource, id));
    }
    
}