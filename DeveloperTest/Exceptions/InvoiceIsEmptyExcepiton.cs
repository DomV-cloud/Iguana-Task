namespace DeveloperTest.Exceptions
{
    public class InvoiceIsEmptyExcepiton : Exception
    {
        public InvoiceIsEmptyExcepiton() : base()
        {
        }
        public InvoiceIsEmptyExcepiton(string message) : base(message)
        {
        }
        public InvoiceIsEmptyExcepiton(string message, Exception e) : base(message, e)
        {
        }
    }
}
