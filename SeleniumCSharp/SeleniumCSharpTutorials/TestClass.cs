using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using OpenQA.Selenium.Support.UI;


namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestsClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebDriver driver2;
            driver2 = new ChromeDriver();
            driver2.Manage().Window.Maximize();
            driver2.Url = "https://www.facebook.com/r.php";

            IWebElement emailTextField = driver2.FindElement(By.XPath(".//*[@id='password_step_input']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownList = driver2.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            Thread.Sleep(1500);
            element.SelectByText("mar");
            Thread.Sleep(1500);
            element.SelectByValue("6");
            Thread.Sleep(1500);

            driver2.Quit();

        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(3000);
        }
    }
}