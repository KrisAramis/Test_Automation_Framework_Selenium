using RestSharp;

namespace WebApplication.API.Controllers;

    public class TechController:BaseController
    {
        public TechController(CustomRestClient client) : base(client, Service.Tech)
        {
            
        }

        private const string AllObjectsResource = "/objects";
        
        /// <summary>
        /// Gets list of all Techs in API
        /// </summary>
        /// <typeparam name="T"><see cref="TechModels"/typeparam>
        /// <returns>list of all Techs</returns>
        /// 
        private const string SelectedTechsResource = "/objects?id={0}&id={1}";

        /// <summary>
        /// Gets list of selected Techs in API
        /// </summary>
        /// <typeparam name="T"><see cref="TechModels"/typeparam>
        /// <returns>list of selected Techs</returns>
    
        public (RestResponse response, T? Techs) GetTechs<T>()
        {
            return Get<T>(AllObjectsResource);
        }

        public (RestResponse response, T? Techs) GetSelectedTechs<T>(string id1, string id2)
        {
            return Get<T>(String.Format(SelectedTechsResource, id1, id2));
        }
    }