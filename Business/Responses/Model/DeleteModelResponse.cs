namespace Business.Responses.Model
{
    public class DeleteModelResponse
    {
        public DeleteModelResponse()
        {
            
        }


        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}