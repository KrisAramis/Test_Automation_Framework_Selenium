using System.Net;
using RestSharp;
using WebApplication.API.Controllers;
using WebApplication.API.Modeles.ResponseModels;
using WebApplication.API.Modles.ResponseModels;

namespace WebApplication.API.Tests;
[TestFixture]

    public class BiblesTests
    {
        [Test]
        public void CheckAllBiblesResponseWithValidParams()
        {
            var response = new BiblesController(new CustomRestClient()).GetBibles<RestResponse>();
            Assert.That(response.response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Incorrect status code for GET /v1/bibles returned");
        }

        [Test]
        public void CheckWithoutAuthorization()
        {
            var response = new BiblesController(new CustomRestClient(), string.Empty).GetBibles<RestResponse>();
            Assert.That(response.response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized),"Incorrect Status code for for GET /v1/bibles if unauthorized");
        }

        [Test]
        public void CheckAllBiblesResponseReturnObject()
        {
           var response = new BiblesController(new CustomRestClient()).GetBibles<AllBiblesModel>();
           CollectionAssert.IsNotEmpty(response.Bibles.data, "Any bible should be returned for GET /v1/bibles");
        }
        
        [Test]
        public void CheckAudioBiblesResponse()
        {
            var response = new BiblesController(new CustomRestClient()).GetAudioBibles<RestResponse>();
            Assert.That(response.response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Incorrect status code returned for GET /audio-bibles");
        }

        [Test]
        public void CheckBooksOfFirstAudioBibleStatusCode()
        {
            var response = new BiblesController(new CustomRestClient()).GetAudioBibles<AudioBiblesModel>();
            CollectionAssert.IsNotEmpty(response.AudioBibles.data, "Any bible should be returned after");
            var audioBiblesFirstId = new BiblesController(new CustomRestClient()).GetAudioBibles<AudioBiblesModel>().AudioBibles.data.First().id;
            var responseAudioBibleBooksResponse = new BiblesController(new CustomRestClient()).GetAudioBooksOfBible<RestResponse>(audioBiblesFirstId);
            Assert.That(responseAudioBibleBooksResponse.response.StatusCode,Is.EqualTo(HttpStatusCode.OK), "Incorrect code returned for  GetAudioBooksOfBible /v1/audio-bibles/{0}/books");
        }
        
        [Test]
        public void CheckBooksOfFirstAudioBibleReturnsObjects()
        {
            var response = new BiblesController(new CustomRestClient()).GetAudioBibles<AudioBiblesModel>();
            CollectionAssert.IsNotEmpty(response.AudioBibles.data, "Any bible should be returned after sen");
            var audioBiblesFirstId = new BiblesController(new CustomRestClient()).GetAudioBibles<AudioBiblesModel>().AudioBibles.data.First().id;
            var responseAudioBibleBooksResponse = new BiblesController(new CustomRestClient()).GetAudioBooksOfBible<AudioBibleBooksModel>(audioBiblesFirstId);
            CollectionAssert.IsNotEmpty(responseAudioBibleBooksResponse.AudioBibleBooks.data,"Empty response for GetAudioBooksOfBible /v1/audio-bibles/{0}/books");
        }

        [Test]
        public void CheckAudioBiblesResponseWithoutAuthorization()
        {
            var response = new BiblesController(new CustomRestClient(), string.Empty).GetAudioBibles <RestResponse>();
            Assert.That(response.response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized), "Incorrect Status for for /audio-bibles if unauthorized");
        }
    }