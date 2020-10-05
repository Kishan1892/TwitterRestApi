using System;
using TechTalk.SpecFlow;

namespace Foo.specs
{
    [Binding]
    public class CustomStepParamConversionSteps
    {
        [Given(@"I last logged in (.* days ago)")]
        public void GivenILastLoggedInDaysAgo(DateTime lastLogin)
        {
            // setup user login data to be lastLogin date
        }

        [When(@"I try to log in")]
        public void WhenITryToLogIn()
        {
            // test code
        }

        [Then(@"the new password wizard should start")]
        public void ThenTheNewPasswordWizardShouldStart()
        {
            // test code
        }
    }
}
