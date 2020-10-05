using Automation.Apis.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Foo.specs
{
    [Binding]
    public class AddUsersSteps
    {
        [Given(@"I have input the following users")]
        public void GivenIHaveInputTheFollowingUsers(Table table)
        {
            var users = table.CreateSet<NewUser>();
            NewUser[] a = users.ToArray();
            // Test code
        }

        [When(@"I choose add")]
        public void WhenIChooseAdd()
        {
            // Test code
        }

        [Then(@"the users should be added")]
        public void ThenTheUsersShouldBeAdded()
        {
            // Test code
        }
    }
}
