namespace WebApplication5.Models {
    public class BookImage {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte CoverStatus { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
