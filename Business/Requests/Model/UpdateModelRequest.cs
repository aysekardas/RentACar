namespace Business.Requests.Model
{
    public class UpdateModelRequest
    {
        public int Id { get; set; }
        public int BrandId { get; set; }

        public int FuelId { get; set; }
        public int TranmissionId { get; set; }

        public decimal DailyPrice { get; set; }
        public string Name { get; set; }

        public short Year { get; set; }


    }
}