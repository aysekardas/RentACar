namespace Business.Requests.CorporateCustomer
{ 
    public class UpdateCorporateCustomerRequest
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public short TaxNo { get; set; }

    }
}