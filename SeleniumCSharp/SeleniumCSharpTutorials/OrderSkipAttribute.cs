using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test,Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            //FIREFOX
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test,Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            //InternetExplorer
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}