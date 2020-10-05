using Automation.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Utils.Hooks
{

    [Binding]
    internal static class ScenarioHooks
    {
        [BeforeScenario()]
        [Obsolete]
        internal static void BeforeHooks()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Api"))
            {
                BaseApiTests.SetBaseUriAndAuth();
            }
        }
    }
}
