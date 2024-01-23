namespace Business.Responses.Model
{
    public class UpdateModelResponse
    {
        public int BrandId { get; set; }

        public int FuelId { get; set; }
        public int TranmissionId { get; set; }

        public decimal DailyPrice { get; set; }
        public string Name { get; set; }

        public short Year { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}