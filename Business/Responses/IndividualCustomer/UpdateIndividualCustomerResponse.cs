namespace Business.Responses.IndividualCustomer
{
    public class UpdateIndividualCustomerResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}