namespace Business.Responses.CorporateCustomer
{
    public class GetCorporateCustomerByIdResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public string CompanyName { get; set; }
        public short TaxNo { get; set; }
    }
}