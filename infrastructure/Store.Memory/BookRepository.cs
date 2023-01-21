namespace Store.Memory
{
	public class BookRepository : IBookRepository
	{
		private readonly Book[] books = new[]
		{
			new Book(1, "Art Of Programing"),
			new Book(2, "Refactoring"),
			new Book(3, "C Programing Language")
		};
		public Book[] GetByTitle( string titlePart ) {
			return books.Where(book => book.Title.Contains(titlePart))
				.ToArray();
		}
	}
}