using TechTalk.SpecFlow;

namespace RajSampleProject.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions

    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            throw new PendingStepException();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            throw new PendingStepException();
        }


    }

}

   
