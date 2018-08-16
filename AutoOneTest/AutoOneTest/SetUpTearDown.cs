using static NSelene.Selene;
using OpenQA.Selenium.Chrome;
using NSelene;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoOneTest
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void InitDriver()
        {
            SetWebDriver(new ChromeDriver());
            GoToUrl(Properties.Default.baseUrl);
        }

        [OneTimeTearDown]
        public void DisposeDriver()
        {
            
            GetWebDriver().Quit();
        }
    }
}
