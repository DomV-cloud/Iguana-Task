namespace DeveloperTest.Repository.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        /*
         * 
         get collection of unpaid invoices
         pay an invoice (changing status to paid)
         edit an invoice (PATCH request)
         
         */


        public List<T> GetAllInvoices();
        public T PayInvoice(int id);
        public T EditInvoice(int id);
    }
}
