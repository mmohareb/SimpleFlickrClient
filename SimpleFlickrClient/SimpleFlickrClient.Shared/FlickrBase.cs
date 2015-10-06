using FlickrNet;

namespace SimpleFlickrClient
{
    public static class FlickrBase
    {
        private static  Flickr _instance;
        private static Flickr _authInstance;
        private static Flickr _ignoreInstance;

        //protected readonly TestData Data = new TestData();

        private static Flickr GetInstance()
        {
            return new Flickr(Constants.Constants.apiKey, Constants.Constants.apiSecret);
        }

        private static Flickr GetAuthInstance()
        {
            return new Flickr(Constants.Constants.apiKey, Constants.Constants.apiKey)
            {
                //OAuthAccessToken = Data.AccessToken,
                //OAuthAccessTokenSecret = Data.AccessTokenSecret
            };
        }

        public static Flickr Instance
        {
            get { return _instance ?? (_instance = GetInstance()); }
        }

        public static Flickr AuthInstance
        {
            get { return _authInstance ?? (_authInstance = GetAuthInstance()); }
        }

        public static Flickr IgnoreInstance
        {
            get { return _ignoreInstance ?? (_ignoreInstance = GetAuthInstance()); }
        }

        public static bool InstanceUsed
        {
            get { return _instance != null; }
        }

        public static bool AuthInstanceUsed
        {
            get { return _authInstance != null; }
        }
    }
}
