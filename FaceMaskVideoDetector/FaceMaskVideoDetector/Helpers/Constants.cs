namespace FaceMaskVideoDetector.Helpers
{
    public class Constants
    {
        public static readonly string SubscriptionKey = "";
        public static readonly string AccountId = "";
        public static readonly string Location = "trial";

        public static readonly string AuthBaseUrl = $"https://api.videoindexer.ai/Auth/{Location}/Accounts/";
        public static readonly string TokenService = "AccessToken?allowEdit=True";
        public static string VideoIndexerAccessToken = "";

        public static readonly string VideoIndexerBaseUrl = $"https://api.videoindexer.ai/{Location}/Accounts";

        public static readonly string UploadVideo = "Videos?privacy=Public&accessToken";
        public static readonly string NameParameter = "name";

        public static readonly string ListVideos = "Videos?accessToken";

        public static readonly string CustomVisionBaseUrl = "";
        public static readonly string CustomVisionKey = "";
        public static readonly string CustomVisionService = "";
    }
}
