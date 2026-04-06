namespace BVUJobPortal.Models
{
    public class GoogleUserInfo
    {
        public string sub { get; set; }
        public string email { get; set; }
        public bool email_verified { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
    }
}