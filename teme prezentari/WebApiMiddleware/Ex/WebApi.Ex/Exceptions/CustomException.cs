namespace WebApi.Ex.Exceptions
{
    public class CustomException : Exception
    {
        public Details Details { get; set; }
        public CustomException(Details details) : base(details.Message)
        {
            Details = details;
        }
    }
}
