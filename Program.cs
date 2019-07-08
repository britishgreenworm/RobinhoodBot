using System;

namespace RobinhoodBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("read in settings.ini");
            settings s = new settings(AppContext.BaseDirectory + @"\settings.ini");
            s.readSettings();
            
            var rh = new RobinhoodAPI(
                s.settingsResult["client_id"], 
                s.settingsResult["device_token"],
                s.settingsResult["password"],
                s.settingsResult["scope"],
                s.settingsResult["username"]
            );

            Console.WriteLine("loading settings into robinhood wrapper...");
            Console.WriteLine("client_id: " + rh.client_id);
            Console.WriteLine("device_token: " + rh.device_token);
            Console.WriteLine("password: " + rh.password);
            Console.WriteLine("scope: " + rh.scope);
            Console.WriteLine("username: " + rh.username);
            Console.WriteLine("");
            Console.WriteLine("attempting to login...");
            rh.login();

        }
    }
}