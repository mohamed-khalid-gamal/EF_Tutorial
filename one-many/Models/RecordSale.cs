namespace one_many.Models
{
    class RecordSale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string carLicense { get; set; }
        public string carState { get; set; }
        public Car car { get; set; }
    }
}
