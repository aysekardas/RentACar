namespace Business.Responses.User
{
    public class DeleteUserResponse
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}