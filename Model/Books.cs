
using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Model
{
    public class Books
    {
        [Key]
        public int Book_id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Public_year { get; set; }

    }
}
