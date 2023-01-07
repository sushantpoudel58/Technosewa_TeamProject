using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnoSewa.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int book_value { get; set; }
        [ForeignKey("UserId")]
        public virtual registerModel User { get; set; }

    }
}
