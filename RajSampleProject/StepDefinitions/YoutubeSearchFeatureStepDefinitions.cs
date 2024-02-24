using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RajSampleProject.StepDefinitions
{
    [Binding]
    public class SearchFeatureStepDefinitions
    {
        
        //private readonly IWebDriver _driver;
        private IWebDriver driver;
        private readonly UiSearch _uiSearch; 

        [Given(@"Open the Browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter URL '([^']*)'")]
        public void WhenEnterURL(string URL)
        {
            driver.Url = URL;
            Thread.Sleep(5000);
        }

        [Then(@"Searh youtube")]
        public void ThenSearhYoutube()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[6]/div[1]/ytd-button-renderer[2]/yt-button-shape/button/div/span")).Click();

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Test");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            
           

        }

        [Then(@"I have searched google for '([^']*)'")]
        public void ThenIHaveSearchedGoogleFor(string Data)
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[3]/span/div/div/div/div[3]/div[1]/button[2]/div")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//*[@aria-label='Search']")).SendKeys(Data);
            driver.FindElement(By.XPath("//*[@aria-label='Search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);

            //Thread.Sleep(5000);
            _uiSearch.AcceptAll.Click();
            Thread.Sleep(5000);
            _uiSearch.GoogleSearchBox.Click();
            _uiSearch.GoogleSearchBox.SendKeys(Data);
            Thread.Sleep(5000);
            //driver.Quit();
        }

    }
}
