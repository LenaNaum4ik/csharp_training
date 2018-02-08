using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private new IWebDriver driver;
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.driver = new ChromeDriver();
            this.baseURL = "http://localhost";
        }

        public void GoToHomePage()
        {
           driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }
        public void GoToGroupsPage()
        {
         driver.FindElement(By.LinkText("groups")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
