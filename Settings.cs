using System;
using System.IO;

namespace RobinhoodBot{
    public class settings{
        private string filepath{get; set;}

        public settings(string filepath){
            this.filepath = filepath;
        }

        public void readSettings(){
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}