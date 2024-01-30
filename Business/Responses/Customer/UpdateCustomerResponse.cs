namespace Business.Abstract
{
    public class UpdateCustomerResponse
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}