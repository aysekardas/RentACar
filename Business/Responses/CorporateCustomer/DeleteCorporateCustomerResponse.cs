namespace Business.Responses.CorporateCustomer
{
    public class DeleteCorporateCustomerResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}