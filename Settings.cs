using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace RobinhoodBot{
    public class settings{
        private string filepath{get; set;}
        public Dictionary<string, string> settingsResult{get; set;}

        public settings(string filepath){
            this.filepath = filepath;
            settingsResult = new Dictionary<string, string>();
        }

        public void readSettings(){
            var lines = File.ReadAllLines(filepath);
            lines.Select(q => q.Trim().Split(":"))
                .Where(q => q.Length == 2)
                .ToList()
                .ForEach(q => settingsResult.Add(q[0], q[1]));
        }
    }
}