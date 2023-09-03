using DeveloperTest.Exceptions;
using DeveloperTest.Exceptions.ExceptionMessages;
using DeveloperTest.Models;

namespace DeveloperTest.Services
{
    public class ValidateService
    {
        public void ValidateInvoice<T>(T item)
        {
            if (item is null)
            {
                throw new InvoiceIsNull(Message.InvoiceIsNull);
            }
        }

        public void ValidateInvoices<T>(List<T> items)
        {
            if (items.Count == 0)
            {
                throw new InvoiceIsNull(Message.InvoiceIsNull);

            }
        }

    }
}
