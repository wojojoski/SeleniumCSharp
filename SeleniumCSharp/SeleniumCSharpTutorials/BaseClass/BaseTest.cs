using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        public IWebDriver driver2;

        [SetUp]
        public void Open()
        {
            //driver2 = new ChromeDriver();
            //driver2.Manage().Window.Maximize();
            //driver2.Url = "https://www.facebook.com/r.php";

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

        }

        [TearDown]
        public void Close()
        {
            //driver2.Quit();
            driver.Quit();
        }
    }
}
