using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;


/*

**logout:
Request URL: https://api.robinhood.com/oauth2/revoke_token/
Request Method: POST
Status Code: 200 
Remote Address: 52.73.56.74:443
Referrer Policy: strict-origin-when-cross-origin

{client_id: "c82SH0WZOsabOXGP2sxqcj34FxkvfnWRZBKlBjFS", token: "long generated key"}
client_id: "c82SH0WZOsabOXGP2sxqcj34FxkvfnWRZBKlBjFS"
token: "long generated key"

**login
Request URL: https://api.robinhood.com/oauth2/token/
Request Method: POST
Status Code: 200 
Remote Address: 52.1.42.125:443
Referrer Policy: strict-origin-when-cross-origin

client_id:
device_token:
expires_in:
grant_type:
password:
scope:
username:

**watchlist
https://nummus.robinhood.com/watchlists/?name=Default

 */

namespace RobinhoodBot{
    public class RobinhoodAPI{

        //needed for login
        public string client_id {get; set;}
        public string device_token {get; set;}
        public string grant_type {get; set;}
        public string password {get; set;}
        public string scope {get; set;}
        public string username {get; set;}

        //acquired after login
        public string token_type {get; set;}
        public string mfa_code {get; set;}
        public string access_token {get; set;}
        public string refresh_token {get; set;}
    
        public RobinhoodAPI(string client_id, string device_token, string grant_type, string password, string username, string scope = "internal"){
            this.client_id = client_id;
            this.device_token = device_token;
            this.grant_type = grant_type;
            this.password = password;
            this.username = username;
            this.scope = scope;
        }

        public void login(){

            //just format settings.ini to json and add to body payload. 

            /*DataContractJsonSerializer dcjs = new DataContractJsonSerializer(new {
                client_id = client_id
            }); */

            //byte[] dataBytes = Encoding.UTF8.GetBytes(); Need to serialize Json Object for payload

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.robinhood.com/oauth2/token/");
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Origin", "https://robinhood.com");
            request.Headers.Add("Referer", "https://robinhood.com/");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36");
            request.Headers.Add("X-Robinhood-API-Version", "1.275.0");
            //request.ContentLength() dataBytes length goes here
            request.ContentType = "application/json";
            request.Method = "POST";

            //request.GetRequestStream
            


            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse()){
                using(Stream stream = response.GetResponseStream()){
                    using(StreamReader reader = new StreamReader(stream))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
                    
            }
                
        }
    }


}