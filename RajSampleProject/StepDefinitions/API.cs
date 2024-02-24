using Newtonsoft.Json;
using RajSampleProject.Support;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

namespace RajSampleProject.StepDefinitions
{
    [Binding]
    public class httptest

    {
        HttpClient httpClient;
        HttpResponseMessage response;
        string responsebody;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        public httptest(ISpecFlowOutputHelper specFlowOutputHelper)

        {
            httpClient = new HttpClient();
            this._specFlowOutputHelper = specFlowOutputHelper;
        }

        [Given(@"Send out a get request url ""([^""]*)""")]
        public async Task GivenSendOutAGetRequestUrl(string url)
        {
          response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            responsebody = await response.Content.ReadAsStringAsync();
            _specFlowOutputHelper.WriteLine(responsebody);
            var desdata = JsonConvert.DeserializeObject<Datamodel>(responsebody);
            _specFlowOutputHelper.WriteLine("After deserialzation value is "+ desdata.page.ToString());
            foreach (var item in desdata.data) 
            {
                _specFlowOutputHelper.WriteLine(item.id.ToString());
                _specFlowOutputHelper.WriteLine(item.email.ToString());

            }

        }

        [Then(@"the response status code is '(.*)'")]
        public void ThenTheReponseStatusCodeIs(int statuscode)
        {
            var expected = (HttpStatusCode)statuscode;
            Assert.Equal(expected, response.StatusCode);
        }

        [Then(@"request should be a success")]
        public void ThenRequestShouldBeASuccess()
        {
            Assert.True(response.IsSuccessStatusCode);
            Debug.WriteLine(responsebody);
        }

        [Then(@"request should contain '([^']*)' this in the Body")]
        public void ThenRequestShouldContainThisInTheBody(string body)
        {
            Assert.Contains(body, responsebody);
        }

    }
}
