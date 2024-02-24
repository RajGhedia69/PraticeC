
using OpenQA.Selenium;


public class UiSearch
{
    private readonly IWebDriver _driver;
    public UiSearch(IWebDriver driver)
    {
        _driver = driver;
    }

    public IWebElement GoogleSearchBox => _driver.FindElement(By.XPath("//*[@aria-label='Search']"));

    public IWebElement AcceptAll => _driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[3]/span/div/div/div/div[3]/div[1]/button[2]/div"));

}
