using System;

namespace RobinhoodBot
{
    class Program
    {
        static void Main(string[] args)
        {
            settings s = new settings(AppContext.BaseDirectory + @"\settings.ini");
            s.readSettings();
            Console.WriteLine(s.settingsResult["username"]);
        }
    }
}