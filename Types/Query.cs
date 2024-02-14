namespace GraphQLFirstApp.Types
{
    public class Query
    {
        readonly List<Book> _books = new()
        {
            new Book("I love GrapgQL", new Author("Jhon")),
            new Book("GrapgQL is feature", new Author("Amol")),
            new Book("I love SOAP + Azure", new Author("Ram"))
        };

        public List<Book> GetBooks() => _books;
    }
    public record Book(string Title, Author Author);

    public record Author(string Name);

}
