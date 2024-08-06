namespace FinanceLogs.Models
{
    public class Wants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int Price {get; set; }
        public bool CanBuy { get; set; }
    }
}
