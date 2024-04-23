namespace WebApplication5.Models {
    public class Book {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPercent { get; set; }
        public bool StockStatus { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<Tag> Tags { get; set; }
        public List<BookImage> BookImages { get; set; }
    }
}
