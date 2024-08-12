using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Pop.Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new EdgeDriver();

            if (driver == null)
            {
                return;
            }

            try
            {
                driver.Navigate().GoToUrl("https://popcat.click/");

                var cat = driver.FindElement(By.ClassName("cat-img"));

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
