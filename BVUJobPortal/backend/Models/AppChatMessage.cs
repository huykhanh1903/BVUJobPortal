namespace BVUJobPortal.Models
{
    public class AppChatMessage
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; } = "";
        public bool IsFromAI { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
