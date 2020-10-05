using Automation.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Steps
{
    [Binding]
    public sealed class BaseApiScenariosSteps
    {
        [Given(@"I post a tweet of ""(.*)""")]
        public void GivenIPostATweetOf(string tweet)
        {
            BaseApiTests.PostTweet(tweet);
        }

        [When(@"I retrieve my information")]
        public void WhenIRetrieveMyInformation()
        {
            BaseApiTests.GetResponseOfResource();
        }

        [Then(@"the response in my message contains ""(.*)""")]
        public void ThenTheResponseInMyMessageContains(string message)
        {
            BaseApiTests.AssertTweetWasPosted(message);
        }


    }
}
