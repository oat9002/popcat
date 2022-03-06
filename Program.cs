using System;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace Pop.Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://popcat.click/");

                var cat = driver.FindElementByClassName("cat-img");

                for (var i = 0; i < 1000; i++)
                {
                    cat.Click();
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            driver.Close();
        }
    }
}
