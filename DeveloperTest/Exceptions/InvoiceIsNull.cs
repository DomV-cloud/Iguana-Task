namespace DeveloperTest.Exceptions
{
    public class InvoiceIsNull : Exception
    {
        public InvoiceIsNull() : base()
        {
        }
        public InvoiceIsNull(string message) : base(message)
        {
        }
        public InvoiceIsNull(string message, Exception e) : base(message, e)
        {
        }
    }
}
