namespace LocalMovieTheaterIncomings.Core.Models
{
    public partial class FoodItem
    {
        public int Id { get; set; }
        public string FoodName { get; set; } = null!;
        public decimal? Saleprice { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        
        public decimal? Profit
        {
            get
            {
                return (Saleprice * Quantity) - (UnitPrice * Quantity);
            }
        }
    }
}
