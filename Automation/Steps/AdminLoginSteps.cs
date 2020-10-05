using Automation.Apis.Models;
using TechTalk.SpecFlow;

namespace Automation.Steps
{
    [Binding]
    public class AdminLoginSteps
    {
        private readonly AdminLoginDetails _adminLoginDetails;

        public AdminLoginSteps(AdminLoginDetails adminLoginDetails)
        {
            _adminLoginDetails = adminLoginDetails;
        }

        [Given(@"I have logged in as administrator '(.*)'")]
        public void GivenIHaveLoggedInAsAdministrator(string p0)
        {
            // need to store the username for later use 
            _adminLoginDetails.UserName = p0;
        }

        [When(@"I navigate to the user profile page")]
        public void WhenINavigateToTheUserProfilePage()
        {
            // test code
        }

        [Then(@"the correct username should be shown")]
        public void ThenTheCorrectUsernameShouldBeShown()
        {
            var p1 = _adminLoginDetails.UserName;
            //test code
        }

    }
}
