using System;
using TechTalk.SpecFlow;

namespace SpringerTests
{
    [Binding]
    public class SearchTestSteps
    {
        [Given(@"I am a user")]
        public void GivenIAmAUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for the word")]
        public void WhenISearchForTheWord()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I receive search results with the word in the title")]
        public void ThenIReceiveSearchResultsWithTheWordInTheTitle()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
