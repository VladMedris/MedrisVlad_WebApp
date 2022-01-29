namespace MedrisVlad_WebApp.Models
{
    public class Library
    {
        public int ID { get; set; }

        public string? LibraryName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
