namespace ProductClientHub.Communication.Responses
{
    public class ResponseErrorMessagesJson(string message)
    {
        public List<string> Errors { get; private set; } = [message];
    }
}
