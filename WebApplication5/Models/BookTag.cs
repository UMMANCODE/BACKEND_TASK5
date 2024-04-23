using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models {
    public class BookTag {

        [Key, Column(Order = 0)]
        public int BookId { get; set; }

        [Key, Column(Order = 1)]
        public int TagId { get; set; }

        public Book Book { get; set; }
        public Tag Tag { get; set; }
    }
}
