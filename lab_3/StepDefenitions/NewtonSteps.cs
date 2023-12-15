using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace lab_3.StepDefenitions
{
    [Binding]
    internal class NewtonSteps : StepsBase
    {

        [Given(@"I have access to the Newton API")]
        public void GivenIHaveTheExpression()
        {
            client = new RestClient("https://newton.now.sh/api/v2/");
        }

        [When(@"I call the '(.*)' endpoint")]
        public void WhenICallTheEndpoint(string endpoint)
        {
            request = new RestRequest(endpoint);

            response = client.Execute(request, Method.Get);
        }

        [Then(@"the responce should contain operation:'(.*)',expression:'(.*)',result:'(.*)'")]
        public void ThenTheResultShouldBe(string operation, string expression,string result)
        {
            var newtonResponse = JObject.Parse(response.Content);
            expression = expression.Replace('/', '|');
            Assert.That((string)newtonResponse["expression"], Is.EqualTo(expression));
            Assert.That((string)newtonResponse["operation"], Is.EqualTo(operation));
            Assert.That((string)newtonResponse["result"], Is.EqualTo(result));
        }


    }
}
