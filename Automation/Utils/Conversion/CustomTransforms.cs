using Automation.Apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automation.Utils.Conversion
{
    [Binding]
    public class CustomTransforms
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgoTransform(int daysAgo)
        {
            return DateTime.Today.AddDays(-daysAgo);
        }

        [StepArgumentTransformation]
        public IEnumerable<NewUser> NewUsersTransform(Table table)
        {
            return table.CreateSet<NewUser>();
        }
    }
}
