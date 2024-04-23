using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.ViewModels {
    public class HomeViewModel {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Genre> Genres { get; set; }
        public HomeViewModel() { }
    }
}
