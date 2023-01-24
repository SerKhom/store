namespace Store.Memory
{
	public class BookRepository : IBookRepository
	{
		private readonly Book[] books = new[]
		{
			new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programing"),
			new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring"),
			new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programing Language")
		};

		public Book[] GetAllByIsbn( string isbn ) {
			return books.Where( book => book.Isbn == isbn.ToUpper() )
				.ToArray();
		}

		public Book[] GetAllByTitleOrAuthor( string query ) {
			return books.Where(book => book.Author.Contains( query )
									|| book.Title.Contains( query ) )
				.ToArray();
		}
	}
}