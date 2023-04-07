namespace MultiplePublisher.Common.DTOs
{
    public class RequestBase
    {
        string Token { get; set; }
        string IpAddress { get; set; }

        public RequestBase ()
        {
            Token = string.Empty;
            IpAddress = string.Empty;
        }
    }
}