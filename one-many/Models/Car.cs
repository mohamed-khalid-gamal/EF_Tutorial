namespace one_many.Models
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string state { get; set; }
        public string Licencse { get; set; }
        public List<RecordSale> recordSales { get; set; }
    }
}
