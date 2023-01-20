namespace Testi
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
        NumberApp numberApp = new NumberApp();
        UserInterface ui = new UserInterface(numberApp);
        ui.Start();
        }
    }
}