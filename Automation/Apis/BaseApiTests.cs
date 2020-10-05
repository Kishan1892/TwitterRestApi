using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using static Automation.Utils.Settings.Settings;

namespace Automation.Apis
{
    public class BaseApiTests
    {
        public static RestClient Client;
        public static IRestRequest Request;
        public static IRestResponse Response;

        public static void SetBaseUriAndAuth()
        {
            Client = new RestClient(baseUrl)
            {
                Authenticator = AuthTwitter()
            };
        }

        private static OAuth1Authenticator AuthTwitter()
        {
            OAuth1Authenticator oAuth1Authenticator = OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            return oAuth1Authenticator;
        }

        public static void PostTweet(string message)
        {
            Request = new RestRequest("/update.json", Method.POST);
            Request.AddParameter("status", message, ParameterType.GetOrPost);
            GetResponse();
        }

        public static void GetResponseOfResource()
        {
            Request = new RestRequest
            {
                OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; }
            };
            GetResponse();
        }

        private static void GetResponse()
        {
            Response = Client.Execute(Request);
            Console.WriteLine(Response.Content);
        }

        public static void AssertTweetWasPosted(string tweet)
        {
            string test = Response.Content;
            Assert.True(test.Contains(tweet));
        }
    }
}
