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

                while (true)
                {
                    cat.Click();
                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                driver.Close();
            }
        }
    }
}
