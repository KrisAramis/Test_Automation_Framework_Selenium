using System.Net;
using RestSharp;
using WebApplication.API.Controllers;
using WebApplication.API.Modles.ResponseModels;

namespace WebApplication.API.Tests;
[TestFixture]

public class TechTests
{
    [Test]
    public void CheckAllTechsResponseWithValidParams()
    {
        var response = new TechController(new CustomRestClient()).GetTechs<RestResponse>();
        Assert.That(response.response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Incorrect Status code for /objects returned");
    }
    
    [Test]
    public void CheckAllTechsResponseReturnObject()
    {
        var response = new TechController(new CustomRestClient()).GetTechs<List<TechModels>>();
        CollectionAssert.IsNotEmpty(response.Techs, "Incorrect response for /objects? returned");
    }
    [Test]
    public void CheckCorrectListofTechsReturned()
    {
        var responseAll = new TechController(new CustomRestClient()).GetTechs<List<TechModels>>();
        var firstId = responseAll.Techs[0].id;
        var secondId = responseAll.Techs[1].id;

        var responseSelected = new TechController(new CustomRestClient()).GetSelectedTechs<List<TechModels>>(firstId,secondId);
        double actualNumberOfTechs = responseSelected.Techs.Count();
        double expectedNumberOfTechs = 2;
        Assert.That(actualNumberOfTechs, Is.EqualTo(expectedNumberOfTechs), "Incorrect number of objects for /objects?id={0}&id={1} returned");
    }
}