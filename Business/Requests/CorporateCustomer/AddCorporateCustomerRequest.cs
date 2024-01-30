namespace Business.Requests.CorporateCustomer
{
    public class AddCorporateCustomerRequest
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public short TaxNo { get; set; }

    }
}