namespace DeveloperTest.Exceptions
{
    public class ConnectionIsNotConfigured: Exception
    {
        public ConnectionIsNotConfigured() : base()
        {
        }
        public ConnectionIsNotConfigured(string message) : base(message)
        {
        }
        public ConnectionIsNotConfigured(string message, Exception e) : base(message, e)
        {
        }
    }
}
