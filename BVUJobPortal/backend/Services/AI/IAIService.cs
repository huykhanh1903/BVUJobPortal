namespace BVUJobPortal.Services.AI
{
    public interface IAIService
    {
        Task<string> AskAsync(string message, int userId);
    }
}
