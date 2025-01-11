using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://dev.ontrak.onsite.com.au/dashboard");
Thread.Sleep(10000);

driver.Manage().Window.Maximize();
driver.FindElement(By.Id("Username")).SendKeys("ju");
driver.FindElement(By.Id("btn-login")).Click();
driver.FindElement(By.Id("Password")).SendKeys("ju");
driver.FindElement(By.Id("btn-login")).Click();

Thread.Sleep(10000);

//driver.FindElement(By.Id("connect-dashboard-v2")).Click();
driver.FindElement(By.CssSelector("#toolbar-outer-extended > div > div.dx-toolbar-after > div:nth-child(1)")).Click();

