using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace ExternalLogins
{
    public partial class _Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginWith"] != null)
            {
                switch (Session["LoginWith"].ToString())
                {
                    case "google":
                        FetchUserSocialDetail("google");
                        break;
                    case "facebook":
                        FetchUserSocialDetail("facebook");
                        break;
                }
            }
        }

        protected void GoogleBtnClick(object sender, EventArgs e)
        {
            GetSocialCredentials("google");
        }
        protected void FacebookBtnClick(object sender, EventArgs e)
        {
            GetSocialCredentials("facebook");
        }
        private void GetSocialCredentials(String provider)
        {
            if (provider == "google")
            {
                string Googleurl = String.Format(ConfigurationManager.AppSettings["Googleurl"], ConfigurationManager.AppSettings["google_redirect_url"], ConfigurationManager.AppSettings["google_client_id"]);
                Session["LoginWith"] = provider;
                Response.Redirect(Googleurl);
            }
            else if (provider == "facebook")
            {
                string Facebookurl = string.Format(ConfigurationManager.AppSettings["Facebook_url"], ConfigurationManager.AppSettings["Facebook_AppId"], ConfigurationManager.AppSettings["Facebook_RedirectUrl"], ConfigurationManager.AppSettings["Facebook_scope"]);
                Session["LoginWith"] = provider;
                Response.Redirect(Facebookurl);
            }
        }

        private void FetchUserSocialDetail(String provider)
        {
            try
            {
                if (provider == "google")
                {
                    var url = Request.Url.Query;
                    if (!string.IsNullOrEmpty(url))
                    {
                        string queryString = url.ToString();
                        string[] words = queryString.Split('=');
                        string code = words[1];
                        if (!string.IsNullOrEmpty(code))
                        {
                            //string Parameters =  "code=" + code + "&client_id=" + ConfigurationManager.AppSettings["google_client_id"] + "&client_secret=" + ConfigurationManager.AppSettings["google_client_secret"] + "&redirect_uri=" + ConfigurationManager.AppSettings["google_redirect_url"] + "&grant_type=authorization_code";
                            string parameters = string.Format("code={0}&client_id={1}&client_secret={2}&redirect_uri={3}&grant_type=authorization_code",
                                code,
                                ConfigurationManager.AppSettings["google_client_id"],
                                ConfigurationManager.AppSettings["google_client_secret"],
                                ConfigurationManager.AppSettings["google_redirect_url"]);
                            string response = MakeWebRequest(ConfigurationManager.AppSettings["googleoAuthUrl"], "POST", "application/x-www-form-urlencoded", parameters);
                            GoogleToken tokenInfo = new JavaScriptSerializer().Deserialize<GoogleToken>(response);

                            if (tokenInfo != null)
                            {
                                if (!string.IsNullOrEmpty(tokenInfo.access_token))
                                {
                                    var googleInfo = MakeWebRequest(ConfigurationManager.AppSettings["googleoAccessUrl"] + tokenInfo.access_token, "GET");
                                    GoogleInfo profile = new JavaScriptSerializer().Deserialize<GoogleInfo>(googleInfo);
                                    txtResponse.Text = googleInfo;
                                }
                            }
                        }
                    }
                    Session.Remove("LoginWith");
                }
                else if (provider == "facebook")
                {
                    if (Request["code"] != null)
                    {
                        string url = string.Format(ConfigurationManager.AppSettings["FacebookOAuthurl"],
                            ConfigurationManager.AppSettings["Facebook_AppId"],
                            ConfigurationManager.AppSettings["Facebook_RedirectUrl"],
                            ConfigurationManager.AppSettings["Facebook_scope"],
                            Request["code"].ToString(),
                            ConfigurationManager.AppSettings["Facebook_AppSecret"]);

                        string tokenResponse = MakeWebRequest(url, "GET");
                        var tokenInfo = new JavaScriptSerializer().Deserialize<FacebookToken>(tokenResponse);
                        var facebookInfoJson = MakeWebRequest(ConfigurationManager.AppSettings["FacebookAccessUrl"] + tokenInfo.access_token, "GET");
                        FacebookInfo objUser = new JavaScriptSerializer().Deserialize<FacebookInfo>(facebookInfoJson);
                        txtResponse.Text = facebookInfoJson;
                    }
                }
                Session.Remove("LoginWith");
            }
            catch (Exception ex)
            {
                Response.Redirect("error.aspx");
            }
        }

        /// <summary>
        /// Calling 3rd party web apis. 
        /// </summary>
        /// <param name="destinationUrl"></param>
        /// <param name="methodName"></param>
        /// <param name="requestJSON"></param>
        /// <returns></returns>
        public string MakeWebRequest(string destinationUrl, string methodName, string contentType = "", string requestJSON = "")
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
                request.Method = methodName;
                if (methodName == "POST")
                {
                    byte[] bytes = System.Text.Encoding.ASCII.GetBytes(requestJSON);
                    request.ContentType = contentType;
                    request.ContentLength = bytes.Length;
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(bytes, 0, bytes.Length);
                    }
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }

                return null;
            }
            catch (WebException webEx)
            {
                return webEx.Message;
            }
        }
    }
}

public class GoogleToken
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
    public string id_token { get; set; }
    public string refresh_token { get; set; }
}
public class GoogleInfo
{
    public string id { get; set; }
    public string email { get; set; }
    public bool verified_email { get; set; }
    public string name { get; set; }
    public string given_name { get; set; }
    public string family_name { get; set; }
    public string picture { get; set; }
    public string locale { get; set; }
    public string gender { get; set; }
}
public class FacebookInfo
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string gender { get; set; }
    public string locale { get; set; }
    public string link { get; set; }
    public string id { get; set; }
    public string email { get; set; }
}

public class FacebookToken
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public int expires_in { get; set; }
}
