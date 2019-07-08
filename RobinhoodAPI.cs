using System;

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
            this.scope = scope;
            this.username = username;
        }

    
    }


}