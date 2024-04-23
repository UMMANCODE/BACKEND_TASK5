namespace WebApplication5.Models {
    public class Tag {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
