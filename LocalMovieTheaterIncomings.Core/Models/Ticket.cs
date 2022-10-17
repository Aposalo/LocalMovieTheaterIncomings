namespace LocalMovieTheaterIncomings.Core.Models
{
    public partial class Ticket
    {
        public int Id { get; set; }
        
        public string MovieName { get; set; } = null!;
        
        public decimal? Saleprice { get; set; }
        
        public decimal? StudioCutPercentage { get; set; }
        
        public int? Quantity { get; set; }
        
        public decimal? Profit => (Quantity * Saleprice) - (StudioCutPercentage * (Quantity * Saleprice));

        public decimal? ProfitPerItem => Saleprice - (StudioCutPercentage * Saleprice);
    }
}
