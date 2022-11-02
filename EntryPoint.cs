namespace AutoTestFramework
{
    class EntryPoint
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Url ="http://testing.todorvachev.com";

            menu.Selectors.Click();
        }
    }
}
