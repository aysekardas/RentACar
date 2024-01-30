namespace Business.Abstract
{
    public class DeleteCustomerResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}