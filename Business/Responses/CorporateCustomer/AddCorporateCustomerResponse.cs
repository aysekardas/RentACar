namespace Business.Responses.CorporateCustomer
{
    public class AddCorporateCustomerResponse
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public short TaxNo { get; set; }

        public DateTime CreateAt { get; set; }
    }
}