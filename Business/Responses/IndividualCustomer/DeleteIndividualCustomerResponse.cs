namespace Business.Responses.IndividualCustomer
{
    public class DeleteIndividualCustomerResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
      
        public DateTime DeletedAt { get; set; }
    }
}